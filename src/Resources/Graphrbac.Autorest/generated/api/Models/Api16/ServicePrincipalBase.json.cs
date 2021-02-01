namespace Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Extensions;

    /// <summary>
    /// Active Directory service principal common properties shared among GET, POST and PATCH
    /// </summary>
    public partial class ServicePrincipalBase
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IServicePrincipalBase.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IServicePrincipalBase.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IServicePrincipalBase FromJson(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json ? new ServicePrincipalBase(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject into a new instance of <see cref="ServicePrincipalBase" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ServicePrincipalBase(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_accountEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonBoolean>("accountEnabled"), out var __jsonAccountEnabled) ? (bool?)__jsonAccountEnabled : AccountEnabled;}
            {_appRoleAssignmentRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonBoolean>("appRoleAssignmentRequired"), out var __jsonAppRoleAssignmentRequired) ? (bool?)__jsonAppRoleAssignmentRequired : AppRoleAssignmentRequired;}
            {_keyCredentials = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray>("keyCredentials"), out var __jsonKeyCredentials) ? If( __jsonKeyCredentials as Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IKeyCredential[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IKeyCredential) (Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.KeyCredential.FromJson(__u) )) ))() : null : KeyCredentials;}
            {_passwordCredentials = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray>("passwordCredentials"), out var __jsonPasswordCredentials) ? If( __jsonPasswordCredentials as Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IPasswordCredential[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IPasswordCredential) (Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.PasswordCredential.FromJson(__p) )) ))() : null : PasswordCredentials;}
            {_servicePrincipalType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString>("servicePrincipalType"), out var __jsonServicePrincipalType) ? (string)__jsonServicePrincipalType : (string)ServicePrincipalType;}
            {_tag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray>("tags"), out var __jsonTags) ? If( __jsonTags as Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : Tag;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ServicePrincipalBase" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ServicePrincipalBase" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._accountEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonBoolean((bool)this._accountEnabled) : null, "accountEnabled" ,container.Add );
            AddIf( null != this._appRoleAssignmentRequired ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonBoolean((bool)this._appRoleAssignmentRequired) : null, "appRoleAssignmentRequired" ,container.Add );
            if (null != this._keyCredentials)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.XNodeArray();
                foreach( var __x in this._keyCredentials )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("keyCredentials",__w);
            }
            if (null != this._passwordCredentials)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.XNodeArray();
                foreach( var __s in this._passwordCredentials )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("passwordCredentials",__r);
            }
            AddIf( null != (((object)this._servicePrincipalType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString(this._servicePrincipalType.ToString()) : null, "servicePrincipalType" ,container.Add );
            if (null != this._tag)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.XNodeArray();
                foreach( var __n in this._tag )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("tags",__m);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}