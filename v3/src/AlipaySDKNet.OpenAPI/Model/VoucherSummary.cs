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
    /// VoucherSummary
    /// </summary>
    [DataContract(Name = "VoucherSummary")]
    public partial class VoucherSummary : IEquatable<VoucherSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherSummary" /> class.
        /// </summary>
        /// <param name="publishCount">券已发放数量。.</param>
        /// <param name="usedCount">券已核销数量。.</param>
        public VoucherSummary(int publishCount = default(int), int usedCount = default(int))
        {
            this.PublishCount = publishCount;
            this.UsedCount = usedCount;
        }

        /// <summary>
        /// 券已发放数量。
        /// </summary>
        /// <value>券已发放数量。</value>
        [DataMember(Name = "publish_count", EmitDefaultValue = false)]
        public int PublishCount { get; set; }

        /// <summary>
        /// 券已核销数量。
        /// </summary>
        /// <value>券已核销数量。</value>
        [DataMember(Name = "used_count", EmitDefaultValue = false)]
        public int UsedCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherSummary {\n");
            sb.Append("  PublishCount: ").Append(PublishCount).Append("\n");
            sb.Append("  UsedCount: ").Append(UsedCount).Append("\n");
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
            return this.Equals(input as VoucherSummary);
        }

        /// <summary>
        /// Returns true if VoucherSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PublishCount == input.PublishCount ||
                    this.PublishCount.Equals(input.PublishCount)
                ) && 
                (
                    this.UsedCount == input.UsedCount ||
                    this.UsedCount.Equals(input.UsedCount)
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
                hashCode = (hashCode * 59) + this.PublishCount.GetHashCode();
                hashCode = (hashCode * 59) + this.UsedCount.GetHashCode();
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
