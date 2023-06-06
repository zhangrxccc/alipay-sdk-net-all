/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-06-06
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
    /// AlipayMarketingCardDeleteResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardDeleteResponseModel")]
    public partial class AlipayMarketingCardDeleteResponseModel : IEquatable<AlipayMarketingCardDeleteResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardDeleteResponseModel" /> class.
        /// </summary>
        /// <param name="bizSerialNo">支付宝端删卡业务流水号.</param>
        public AlipayMarketingCardDeleteResponseModel(string bizSerialNo = default(string))
        {
            this.BizSerialNo = bizSerialNo;
        }

        /// <summary>
        /// 支付宝端删卡业务流水号
        /// </summary>
        /// <value>支付宝端删卡业务流水号</value>
        [DataMember(Name = "biz_serial_no", EmitDefaultValue = false)]
        public string BizSerialNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardDeleteResponseModel {\n");
            sb.Append("  BizSerialNo: ").Append(BizSerialNo).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardDeleteResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardDeleteResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardDeleteResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardDeleteResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizSerialNo == input.BizSerialNo ||
                    (this.BizSerialNo != null &&
                    this.BizSerialNo.Equals(input.BizSerialNo))
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
                if (this.BizSerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizSerialNo.GetHashCode();
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
