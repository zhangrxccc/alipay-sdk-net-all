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
    /// AlipayOpenPublicGroupCrowdQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicGroupCrowdQueryResponseModel")]
    public partial class AlipayOpenPublicGroupCrowdQueryResponseModel : IEquatable<AlipayOpenPublicGroupCrowdQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicGroupCrowdQueryResponseModel" /> class.
        /// </summary>
        /// <param name="count">分组圈出的人群数量.</param>
        public AlipayOpenPublicGroupCrowdQueryResponseModel(string count = default(string))
        {
            this.Count = count;
        }

        /// <summary>
        /// 分组圈出的人群数量
        /// </summary>
        /// <value>分组圈出的人群数量</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public string Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicGroupCrowdQueryResponseModel {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicGroupCrowdQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicGroupCrowdQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicGroupCrowdQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicGroupCrowdQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Count != null)
                {
                    hashCode = (hashCode * 59) + this.Count.GetHashCode();
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
