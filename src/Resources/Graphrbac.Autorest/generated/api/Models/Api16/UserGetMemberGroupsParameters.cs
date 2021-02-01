namespace Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Extensions;

    /// <summary>Request parameters for GetMemberGroups API call.</summary>
    public partial class UserGetMemberGroupsParameters :
        Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IUserGetMemberGroupsParameters,
        Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IUserGetMemberGroupsParametersInternal
    {

        /// <summary>Backing field for <see cref="SecurityEnabledOnly" /> property.</summary>
        private bool _securityEnabledOnly;

        /// <summary>
        /// If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AD.Origin(Microsoft.Azure.PowerShell.Cmdlets.AD.PropertyOrigin.Owned)]
        public bool SecurityEnabledOnly { get => this._securityEnabledOnly; set => this._securityEnabledOnly = value; }

        /// <summary>Creates an new <see cref="UserGetMemberGroupsParameters" /> instance.</summary>
        public UserGetMemberGroupsParameters()
        {

        }
    }
    /// Request parameters for GetMemberGroups API call.
    public partial interface IUserGetMemberGroupsParameters :
        Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.",
        SerializedName = @"securityEnabledOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool SecurityEnabledOnly { get; set; }

    }
    /// Request parameters for GetMemberGroups API call.
    internal partial interface IUserGetMemberGroupsParametersInternal

    {
        /// <summary>
        /// If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.
        /// </summary>
        bool SecurityEnabledOnly { get; set; }

    }
}