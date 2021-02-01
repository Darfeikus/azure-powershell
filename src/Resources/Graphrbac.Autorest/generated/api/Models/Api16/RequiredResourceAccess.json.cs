namespace Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Extensions;

    /// <summary>
    /// Specifies the set of OAuth 2.0 permission scopes and app roles under the specified resource that an application requires
    /// access to. The specified OAuth 2.0 permission scopes may be requested by client applications (through the requiredResourceAccess
    /// collection) when calling a resource application. The requiredResourceAccess property of the Application entity is a collection
    /// of RequiredResourceAccess.
    /// </summary>
    public partial class RequiredResourceAccess
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IRequiredResourceAccess.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IRequiredResourceAccess.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IRequiredResourceAccess FromJson(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json ? new RequiredResourceAccess(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject into a new instance of <see cref="RequiredResourceAccess" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject instance to deserialize from.</param>
        /// <param name="exclusions"></param>
        internal RequiredResourceAccess(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json, global::System.Collections.Generic.HashSet<string> exclusions = null)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.JsonSerializable.FromJson( json, ((Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.JsonSerializable.DeserializeDictionary(()=>new global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object>()),exclusions );
            {_resourceAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray>("resourceAccess"), out var __jsonResourceAccess) ? If( __jsonResourceAccess as Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IResourceAccess[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IResourceAccess) (Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.ResourceAccess.FromJson(__u) )) ))() : null : ResourceAccess;}
            {_resourceAppId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString>("resourceAppId"), out var __jsonResourceAppId) ? (string)__jsonResourceAppId : (string)ResourceAppId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RequiredResourceAccess" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RequiredResourceAccess" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
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
            Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.JsonSerializable.ToJson( ((Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, container);
            if (null != this._resourceAccess)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.XNodeArray();
                foreach( var __x in this._resourceAccess )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("resourceAccess",__w);
            }
            AddIf( null != (((object)this._resourceAppId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString(this._resourceAppId.ToString()) : null, "resourceAppId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}