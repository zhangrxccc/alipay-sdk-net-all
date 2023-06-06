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
    /// AlipayUserAlipaypointSendResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserAlipaypointSendResponseModel")]
    public partial class AlipayUserAlipaypointSendResponseModel : IEquatable<AlipayUserAlipaypointSendResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAlipaypointSendResponseModel" /> class.
        /// </summary>
        /// <param name="recordId">发放记录号。.</param>
        /// <param name="transactionId">对账中心关联订单，一般场景无需关注.</param>
        public AlipayUserAlipaypointSendResponseModel(string recordId = default(string), string transactionId = default(string))
        {
            this.RecordId = recordId;
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// 发放记录号。
        /// </summary>
        /// <value>发放记录号。</value>
        [DataMember(Name = "record_id", EmitDefaultValue = false)]
        public string RecordId { get; set; }

        /// <summary>
        /// 对账中心关联订单，一般场景无需关注
        /// </summary>
        /// <value>对账中心关联订单，一般场景无需关注</value>
        [DataMember(Name = "transaction_id", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserAlipaypointSendResponseModel {\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as AlipayUserAlipaypointSendResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAlipaypointSendResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAlipaypointSendResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAlipaypointSendResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RecordId == input.RecordId ||
                    (this.RecordId != null &&
                    this.RecordId.Equals(input.RecordId))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.RecordId != null)
                {
                    hashCode = (hashCode * 59) + this.RecordId.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
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
