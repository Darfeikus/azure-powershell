function RandomString([bool]$allChars, [int32]$len) {
    if ($allChars) {
        return -join ((33..126) | Get-Random -Count $len | % {[char]$_})
    } else {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | % {[char]$_})
    }
}
$env = @{}
if ($UsePreviousConfigForRecord) {
    $previousEnv = Get-Content (Join-Path $PSScriptRoot 'env.json') | ConvertFrom-Json
    $previousEnv.psobject.properties | Foreach-Object { $env[$_.Name] = $_.Value }
}
# Add script method called AddWithCache to $env, when useCache is set true, it will try to get the value from the $env first.
# example: $val = $env.AddWithCache('key', $val, $true)
$env | Add-Member -Type ScriptMethod -Value { param( [string]$key, [object]$val, [bool]$useCache) if ($this.Contains($key) -and $useCache) { return $this[$key] } else { $this[$key] = $val; return $val } } -Name 'AddWithCache'
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    $env.SubscriptionId = (Get-AzContext).Subscription.Id
    $env.Tenant = (Get-AzContext).Tenant.Id
    # For any resources you created for test, you should add it to $env here.
    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    set-content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)

    Import-Module Az.Compute

    $env.vmname = "testpwshellvm"
    $env.vmssname = "testpwshellvmss"
    $env.rgname = "testpwshellcompute"
    $user = "Foo12";
    $password = RandomString -allChars $True -len 13 
    $securePassword = ConvertTo-SecureString $password -AsPlainText -Force;
    $cred = New-Object System.Management.Automation.PSCredential ($user, $securePassword);
    New-AzResourceGroup -Name $env.rgname -Location "eastus"

    #New-AzVM -ResourceGroupName $env.rgname -Location "eastus" -Name $env.vmname -Credential $cred
    #New-AzVmss -ResourceGroupName $env.rgname -VMScaleSetName $env.vmssname -ImageName 'Win2016Datacenter' -Credential $cred -InstanceCount 2
}
function cleanupEnv() {
    $env.rgname = "testpwshellcompute"
    #Remove-AzResourceGroup -Name $env.rgname
}