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
    /// AlipayOpenMiniAppdeployBydeployversionQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniAppdeployBydeployversionQueryResponseModel")]
    public partial class AlipayOpenMiniAppdeployBydeployversionQueryResponseModel : IEquatable<AlipayOpenMiniAppdeployBydeployversionQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniAppdeployBydeployversionQueryResponseModel" /> class.
        /// </summary>
        /// <param name="deploys">小程序发布信息.</param>
        public AlipayOpenMiniAppdeployBydeployversionQueryResponseModel(List<MiniAppDeployResponse> deploys = default(List<MiniAppDeployResponse>))
        {
            this.Deploys = deploys;
        }

        /// <summary>
        /// 小程序发布信息
        /// </summary>
        /// <value>小程序发布信息</value>
        [DataMember(Name = "deploys", EmitDefaultValue = false)]
        public List<MiniAppDeployResponse> Deploys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniAppdeployBydeployversionQueryResponseModel {\n");
            sb.Append("  Deploys: ").Append(Deploys).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniAppdeployBydeployversionQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniAppdeployBydeployversionQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniAppdeployBydeployversionQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniAppdeployBydeployversionQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Deploys == input.Deploys ||
                    this.Deploys != null &&
                    input.Deploys != null &&
                    this.Deploys.SequenceEqual(input.Deploys)
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
                if (this.Deploys != null)
                {
                    hashCode = (hashCode * 59) + this.Deploys.GetHashCode();
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
