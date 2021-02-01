namespace Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Extensions;

    /// <summary>Request parameters for creating a new application.</summary>
    public partial class ApplicationCreateParameters
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject into a new instance of <see cref="ApplicationCreateParameters" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ApplicationCreateParameters(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __applicationBase = new Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.ApplicationBase(json);
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_identifierUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray>("identifierUris"), out var __jsonIdentifierUris) ? If( __jsonIdentifierUris as Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : IdentifierUri;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IApplicationCreateParameters.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IApplicationCreateParameters.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IApplicationCreateParameters FromJson(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json ? new ApplicationCreateParameters(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ApplicationCreateParameters" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ApplicationCreateParameters" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __applicationBase?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            if (null != this._identifierUri)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.XNodeArray();
                foreach( var __x in this._identifierUri )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("identifierUris",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}