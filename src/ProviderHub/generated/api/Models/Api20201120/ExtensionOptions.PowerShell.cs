namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120
{
    using Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ExtensionOptionsTypeConverter))]
    public partial class ExtensionOptions
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.ExtensionOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptions" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptions DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExtensionOptions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.ExtensionOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptions" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptions DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExtensionOptions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.ExtensionOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExtensionOptions(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptionsInternal)this).Request = (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType[]) content.GetValueForProperty("Request",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptionsInternal)this).Request, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptionsInternal)this).Response = (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType[]) content.GetValueForProperty("Response",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptionsInternal)this).Response, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType.CreateFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.ExtensionOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExtensionOptions(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptionsInternal)this).Request = (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType[]) content.GetValueForProperty("Request",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptionsInternal)this).Request, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptionsInternal)this).Response = (Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType[]) content.GetValueForProperty("Response",((Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptionsInternal)this).Response, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType>(__y, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.ExtensionOptionType.CreateFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExtensionOptions" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Models.Api20201120.IExtensionOptions FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ExtensionOptionsTypeConverter))]
    public partial interface IExtensionOptions

    {

    }
}