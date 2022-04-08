if(($null -eq $TestName) -or ($TestName -contains 'Get-AzFrontDoorCdnRoute'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzFrontDoorCdnRoute.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzFrontDoorCdnRoute' {
    It 'List' {
        $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)
        try
        {
            Write-Host -ForegroundColor Green "Create test group $($ResourceGroupName)"
            New-AzResourceGroup -Name $ResourceGroupName -Location $env.location

            $frontDoorCdnProfileName = 'fdp-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnProfileName : $($frontDoorCdnProfileName)"

            $profileSku = "Standard_AzureFrontDoor";
            New-AzFrontDoorCdnProfile -SkuName $profileSku -Name $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global

            $endpointName = 'end-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnEndpointName : $($endpointName)"
            $endpoint = New-AzFrontDoorCdnEndpoint -EndpointName $endpointName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global

            $originGroupName = 'org' + (RandomString -allChars $false -len 6);
            $originGroup = New-AzFrontDoorCdnOriginGroup -OriginGroupName $originGroupName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName `
            -LoadBalancingSettingSampleSize 5 `
            -LoadBalancingSettingSuccessfulSamplesRequired 4 `
            -LoadBalancingSettingAdditionalLatencyInMillisecond 200 `
            -HealthProbeSettingProbeIntervalInSecond 1 `
            -HealthProbeSettingProbePath "/" `
            -HealthProbeSettingProbeProtocol $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol]::Https) `
            -HealthProbeSettingProbeRequestType $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType]::Get) `

            Get-AzFrontDoorCdnOriginGroup -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -OriginGroupName $originGroupName

            $hostName = "en.wikipedia.org";
            $originName = 'ori' + (RandomString -allChars $false -len 6);
            New-AzFrontDoorCdnOrigin -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -OriginGroupName $originGroupName `
            -OriginName $originName -OriginHostHeader $hostName -HostName $hostName `
            -HttpPort 80 -HttpsPort 443 -Priority 1 -Weight 1000

            $rulesetName = 'rs' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use rulesetName : $($rulesetName)"
            $ruleSet = New-AzFrontDoorCdnRuleSet -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Name $rulesetName
            $uriConditon = New-AzCdnDeliveryRuleRequestUriConditionObject -Name "RequestUri" -ParameterOperator "Any"
            $conditions = @(
                $uriConditon
            );
            $overrideAction = New-AzFrontDoorCdnRuleRouteConfigurationOverrideActionObject -Name "RouteConfigurationOverride" `
            -CacheConfigurationQueryStringCachingBehavior "IgnoreSpecifiedQueryStrings" `
            -CacheConfigurationQueryParameter "a=test" `
            -CacheConfigurationIsCompressionEnabled "Enabled" `
            -CacheConfigurationCacheBehavior "HonorOrigin"
            $actions = @($overrideAction);
            
            $ruleName = 'r' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use ruleName : $($ruleName)"
            New-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName `
            -Action $actions -Condition $conditions

            $ruleSetResoure = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReference]::new()
            $ruleSetResoure.Id = $ruleSet.Id

            $routeName = 'route' + (RandomString -allChars $false -len 6);
            New-AzFrontDoorCdnRoute -Name $routeName -EndpointName $endpointName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName `
            -OriginGroupId $originGroup.Id -RuleSet @($ruleSetResoure) -PatternsToMatch "/*" -LinkToDefaultDomain "Enabled" -EnabledState "Enabled"
        
            $routes = Get-AzFrontDoorCdnRoute -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -EndpointName $endpointName
            $routes.Count | Should -Be 1
        } Finally
        {
            Remove-AzResourceGroup -Name $ResourceGroupName -NoWait
        }
    }

    It 'Get' {
        $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)
        try
        {
            Write-Host -ForegroundColor Green "Create test group $($ResourceGroupName)"
            New-AzResourceGroup -Name $ResourceGroupName -Location $env.location

            $frontDoorCdnProfileName = 'fdp-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnProfileName : $($frontDoorCdnProfileName)"

            $profileSku = "Standard_AzureFrontDoor";
            New-AzFrontDoorCdnProfile -SkuName $profileSku -Name $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global

            $endpointName = 'end-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnEndpointName : $($endpointName)"
            $endpoint = New-AzFrontDoorCdnEndpoint -EndpointName $endpointName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global

            $originGroupName = 'org' + (RandomString -allChars $false -len 6);
            $originGroup = New-AzFrontDoorCdnOriginGroup -OriginGroupName $originGroupName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName `
            -LoadBalancingSettingSampleSize 5 `
            -LoadBalancingSettingSuccessfulSamplesRequired 4 `
            -LoadBalancingSettingAdditionalLatencyInMillisecond 200 `
            -HealthProbeSettingProbeIntervalInSecond 1 `
            -HealthProbeSettingProbePath "/" `
            -HealthProbeSettingProbeProtocol $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol]::Https) `
            -HealthProbeSettingProbeRequestType $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType]::Get) `

            Get-AzFrontDoorCdnOriginGroup -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -OriginGroupName $originGroupName

            $hostName = "en.wikipedia.org";
            $originName = 'ori' + (RandomString -allChars $false -len 6);
            New-AzFrontDoorCdnOrigin -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -OriginGroupName $originGroupName `
            -OriginName $originName -OriginHostHeader $hostName -HostName $hostName `
            -HttpPort 80 -HttpsPort 443 -Priority 1 -Weight 1000

            $rulesetName = 'rs' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use rulesetName : $($rulesetName)"
            $ruleSet = New-AzFrontDoorCdnRuleSet -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Name $rulesetName
            $uriConditon = New-AzCdnDeliveryRuleRequestUriConditionObject -Name "RequestUri" -ParameterOperator "Any"
            $conditions = @(
                $uriConditon
            );
            $overrideAction = New-AzFrontDoorCdnRuleRouteConfigurationOverrideActionObject -Name "RouteConfigurationOverride" `
            -CacheConfigurationQueryStringCachingBehavior "IgnoreSpecifiedQueryStrings" `
            -CacheConfigurationQueryParameter "a=test" `
            -CacheConfigurationIsCompressionEnabled "Enabled" `
            -CacheConfigurationCacheBehavior "HonorOrigin"
            $actions = @($overrideAction);
            
            $ruleName = 'r' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use ruleName : $($ruleName)"
            New-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName `
            -Action $actions -Condition $conditions

            $ruleSetResoure = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReference]::new()
            $ruleSetResoure.Id = $ruleSet.Id

            $routeName = 'route' + (RandomString -allChars $false -len 6);
            New-AzFrontDoorCdnRoute -Name $routeName -EndpointName $endpointName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName `
            -OriginGroupId $originGroup.Id -RuleSet @($ruleSetResoure) -PatternsToMatch "/*" -LinkToDefaultDomain "Enabled" -EnabledState "Enabled"
        
            $route = Get-AzFrontDoorCdnRoute -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -EndpointName $endpointName -Name $routeName
            $route.Name | Should -Be $routeName
        } Finally
        {
            Remove-AzResourceGroup -Name $ResourceGroupName -NoWait
        }
    }

    It 'GetViaIdentity' {
        $PSDefaultParameterValues['Disabled'] = $true
        $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)
        try
        {
            Write-Host -ForegroundColor Green "Create test group $($ResourceGroupName)"
            New-AzResourceGroup -Name $ResourceGroupName -Location $env.location

            $frontDoorCdnProfileName = 'fdp-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnProfileName : $($frontDoorCdnProfileName)"

            $profileSku = "Standard_AzureFrontDoor";
            New-AzFrontDoorCdnProfile -SkuName $profileSku -Name $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global

            $endpointName = 'end-' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use frontDoorCdnEndpointName : $($endpointName)"
            $endpoint = New-AzFrontDoorCdnEndpoint -EndpointName $endpointName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global

            $originGroupName = 'org' + (RandomString -allChars $false -len 6);
            $originGroup = New-AzFrontDoorCdnOriginGroup -OriginGroupName $originGroupName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName `
            -LoadBalancingSettingSampleSize 5 `
            -LoadBalancingSettingSuccessfulSamplesRequired 4 `
            -LoadBalancingSettingAdditionalLatencyInMillisecond 200 `
            -HealthProbeSettingProbeIntervalInSecond 1 `
            -HealthProbeSettingProbePath "/" `
            -HealthProbeSettingProbeProtocol $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProbeProtocol]::Https) `
            -HealthProbeSettingProbeRequestType $([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HealthProbeRequestType]::Get) `

            Get-AzFrontDoorCdnOriginGroup -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -OriginGroupName $originGroupName

            $hostName = "en.wikipedia.org";
            $originName = 'ori' + (RandomString -allChars $false -len 6);
            New-AzFrontDoorCdnOrigin -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -OriginGroupName $originGroupName `
            -OriginName $originName -OriginHostHeader $hostName -HostName $hostName `
            -HttpPort 80 -HttpsPort 443 -Priority 1 -Weight 1000

            $rulesetName = 'rs' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use rulesetName : $($rulesetName)"
            $ruleSet = New-AzFrontDoorCdnRuleSet -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Name $rulesetName
            $uriConditon = New-AzCdnDeliveryRuleRequestUriConditionObject -Name "RequestUri" -ParameterOperator "Any"
            $conditions = @(
                $uriConditon
            );
            $overrideAction = New-AzFrontDoorCdnRuleRouteConfigurationOverrideActionObject -Name "RouteConfigurationOverride" `
            -CacheConfigurationQueryStringCachingBehavior "IgnoreSpecifiedQueryStrings" `
            -CacheConfigurationQueryParameter "a=test" `
            -CacheConfigurationIsCompressionEnabled "Enabled" `
            -CacheConfigurationCacheBehavior "HonorOrigin"
            $actions = @($overrideAction);
            
            $ruleName = 'r' + (RandomString -allChars $false -len 6);
            Write-Host -ForegroundColor Green "Use ruleName : $($ruleName)"
            New-AzFrontDoorCdnRule -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -RuleSetName $rulesetName -Name $ruleName `
            -Action $actions -Condition $conditions

            $ruleSetResoure = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReference]::new()
            $ruleSetResoure.Id = $ruleSet.Id

            $routeName = 'route' + (RandomString -allChars $false -len 6);
            New-AzFrontDoorCdnRoute -Name $routeName -EndpointName $endpointName -ProfileName $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName `
            -OriginGroupId $originGroup.Id -RuleSet @($ruleSetResoure) -PatternsToMatch "/*" -LinkToDefaultDomain "Enabled" -EnabledState "Enabled"
        
            $route = Get-AzFrontDoorCdnRoute -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName -EndpointName $endpointName -Name $routeName | Get-AzFrontDoorCdnRoute
            $route.Name | Should -Be $routeName
        } Finally
        {
            Remove-AzResourceGroup -Name $ResourceGroupName -NoWait
        }
    }
}
