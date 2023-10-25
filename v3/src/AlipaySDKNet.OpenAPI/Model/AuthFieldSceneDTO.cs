/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-25
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// AuthFieldSceneDTO
    /// </summary>
    [DataContract(Name = "AuthFieldSceneDTO")]
    public partial class AuthFieldSceneDTO : IEquatable<AuthFieldSceneDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthFieldSceneDTO" /> class.
        /// </summary>
        /// <param name="sceneCode">场景CODE.</param>
        /// <param name="sceneDesc">场景code描述.</param>
        public AuthFieldSceneDTO(string sceneCode = default(string), string sceneDesc = default(string))
        {
            this.SceneCode = sceneCode;
            this.SceneDesc = sceneDesc;
        }

        /// <summary>
        /// 场景CODE
        /// </summary>
        /// <value>场景CODE</value>
        [DataMember(Name = "scene_code", EmitDefaultValue = false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景code描述
        /// </summary>
        /// <value>场景code描述</value>
        [DataMember(Name = "scene_desc", EmitDefaultValue = false)]
        public string SceneDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthFieldSceneDTO {\n");
            sb.Append("  SceneCode: ").Append(SceneCode).Append("\n");
            sb.Append("  SceneDesc: ").Append(SceneDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthFieldSceneDTO);
        }

        /// <summary>
        /// Returns true if AuthFieldSceneDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthFieldSceneDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthFieldSceneDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SceneCode == input.SceneCode ||
                    (this.SceneCode != null &&
                    this.SceneCode.Equals(input.SceneCode))
                ) && 
                (
                    this.SceneDesc == input.SceneDesc ||
                    (this.SceneDesc != null &&
                    this.SceneDesc.Equals(input.SceneDesc))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SceneCode != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCode.GetHashCode();
                }
                if (this.SceneDesc != null)
                {
                    hashCode = (hashCode * 59) + this.SceneDesc.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
