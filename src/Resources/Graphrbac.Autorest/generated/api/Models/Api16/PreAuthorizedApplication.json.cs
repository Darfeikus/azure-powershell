namespace Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Extensions;

    /// <summary>Contains information about pre authorized client application.</summary>
    public partial class PreAuthorizedApplication
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IPreAuthorizedApplication.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IPreAuthorizedApplication.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IPreAuthorizedApplication FromJson(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json ? new PreAuthorizedApplication(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject into a new instance of <see cref="PreAuthorizedApplication" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PreAuthorizedApplication(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_appId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString>("appId"), out var __jsonAppId) ? (string)__jsonAppId : (string)AppId;}
            {_permission = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray>("permissions"), out var __jsonPermissions) ? If( __jsonPermissions as Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IPreAuthorizedApplicationPermission[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IPreAuthorizedApplicationPermission) (Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.PreAuthorizedApplicationPermission.FromJson(__u) )) ))() : null : Permission;}
            {_extension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray>("extensions"), out var __jsonExtensions) ? If( __jsonExtensions as Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IPreAuthorizedApplicationExtension[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IPreAuthorizedApplicationExtension) (Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.PreAuthorizedApplicationExtension.FromJson(__p) )) ))() : null : Extension;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PreAuthorizedApplication" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PreAuthorizedApplication" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._appId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString(this._appId.ToString()) : null, "appId" ,container.Add );
            if (null != this._permission)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.XNodeArray();
                foreach( var __x in this._permission )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("permissions",__w);
            }
            if (null != this._extension)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.XNodeArray();
                foreach( var __s in this._extension )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("extensions",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}