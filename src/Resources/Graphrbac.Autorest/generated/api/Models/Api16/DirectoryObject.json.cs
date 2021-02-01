namespace Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Extensions;

    /// <summary>Represents an Azure Active Directory object.</summary>
    public partial class DirectoryObject
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject into a new instance of <see cref="DirectoryObject" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject instance to deserialize from.</param>
        /// <param name="exclusions"></param>
        internal DirectoryObject(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json, global::System.Collections.Generic.HashSet<string> exclusions = null)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.JsonSerializable.FromJson( json, ((Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.JsonSerializable.DeserializeDictionary(()=>new global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object>()),exclusions );
            {_deletionTimestamp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString>("deletionTimestamp"), out var __jsonDeletionTimestamp) ? global::System.DateTime.TryParse((string)__jsonDeletionTimestamp, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonDeletionTimestampValue) ? __jsonDeletionTimestampValue : DeletionTimestamp : DeletionTimestamp;}
            {_objectId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString>("objectId"), out var __jsonObjectId) ? (string)__jsonObjectId : (string)ObjectId;}
            {_objectType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString>("objectType"), out var __jsonObjectType) ? (string)__jsonObjectType : (string)ObjectType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IDirectoryObject.
        /// Note: the Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IDirectoryObject interface is polymorphic, and the precise
        /// model class that will get deserialized is determined at runtime based on the payload.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IDirectoryObject.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AD.Models.Api16.IDirectoryObject FromJson(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode node)
        {
            if (!(node is Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject json))
            {
                return null;
            }
            // Polymorphic type -- select the appropriate constructor using the discriminator

            switch ( json.StringProperty("objectType") )
            {
                case "AppRoleAssignment":
                {
                    return new AppRoleAssignment(json);
                }
                case "Group":
                {
                    return new AdGroup(json);
                }
                case "ServicePrincipal":
                {
                    return new ServicePrincipal(json);
                }
                case "User":
                {
                    return new User(json);
                }
                case "Application":
                {
                    return new Application(json);
                }
            }
            return new DirectoryObject(json, new global::System.Collections.Generic.HashSet<string>(){ @"deletionTimestamp",@"objectId",@"objectType" });
        }

        /// <summary>
        /// Serializes this instance of <see cref="DirectoryObject" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DirectoryObject" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode" />.
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
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._deletionTimestamp ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString(this._deletionTimestamp?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "deletionTimestamp" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._objectId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString(this._objectId.ToString()) : null, "objectId" ,container.Add );
            }
            AddIf( null != (((object)this._objectType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AD.Runtime.Json.JsonString(this._objectType.ToString()) : null, "objectType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}