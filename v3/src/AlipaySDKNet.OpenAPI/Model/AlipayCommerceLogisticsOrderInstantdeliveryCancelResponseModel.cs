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
    /// AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel")]
    public partial class AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel : IEquatable<AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel" /> class.
        /// </summary>
        /// <param name="cancelFee">取消金额.</param>
        public AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel(string cancelFee = default(string))
        {
            this.CancelFee = cancelFee;
        }

        /// <summary>
        /// 取消金额
        /// </summary>
        /// <value>取消金额</value>
        [DataMember(Name = "cancel_fee", EmitDefaultValue = false)]
        public string CancelFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel {\n");
            sb.Append("  CancelFee: ").Append(CancelFee).Append("\n");
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
            return this.Equals(input as AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceLogisticsOrderInstantdeliveryCancelResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CancelFee == input.CancelFee ||
                    (this.CancelFee != null &&
                    this.CancelFee.Equals(input.CancelFee))
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
                if (this.CancelFee != null)
                {
                    hashCode = (hashCode * 59) + this.CancelFee.GetHashCode();
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
