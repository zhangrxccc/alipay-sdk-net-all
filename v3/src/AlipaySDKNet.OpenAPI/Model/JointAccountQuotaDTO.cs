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
    /// JointAccountQuotaDTO
    /// </summary>
    [DataContract(Name = "JointAccountQuotaDTO")]
    public partial class JointAccountQuotaDTO : IEquatable<JointAccountQuotaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JointAccountQuotaDTO" /> class.
        /// </summary>
        /// <param name="customBeginDate">自定义周期起始日期，精确到分钟，yyyy-MM-dd HH:mm.</param>
        /// <param name="customEndDate">自定义周期结束日期，精确到分钟，yyyy-MM-dd HH:mm.</param>
        /// <param name="quotaDimension">额度维度 单笔上限：ONCE 日：DAY 月：MONTH 季度：QUARTER 年：YEAR 终身：LIFETIME 一次性使用额度：ONLYONE.</param>
        /// <param name="quotaTotal">协议额度.</param>
        public JointAccountQuotaDTO(string customBeginDate = default(string), string customEndDate = default(string), string quotaDimension = default(string), string quotaTotal = default(string))
        {
            this.CustomBeginDate = customBeginDate;
            this.CustomEndDate = customEndDate;
            this.QuotaDimension = quotaDimension;
            this.QuotaTotal = quotaTotal;
        }

        /// <summary>
        /// 自定义周期起始日期，精确到分钟，yyyy-MM-dd HH:mm
        /// </summary>
        /// <value>自定义周期起始日期，精确到分钟，yyyy-MM-dd HH:mm</value>
        [DataMember(Name = "custom_begin_date", EmitDefaultValue = false)]
        public string CustomBeginDate { get; set; }

        /// <summary>
        /// 自定义周期结束日期，精确到分钟，yyyy-MM-dd HH:mm
        /// </summary>
        /// <value>自定义周期结束日期，精确到分钟，yyyy-MM-dd HH:mm</value>
        [DataMember(Name = "custom_end_date", EmitDefaultValue = false)]
        public string CustomEndDate { get; set; }

        /// <summary>
        /// 额度维度 单笔上限：ONCE 日：DAY 月：MONTH 季度：QUARTER 年：YEAR 终身：LIFETIME 一次性使用额度：ONLYONE
        /// </summary>
        /// <value>额度维度 单笔上限：ONCE 日：DAY 月：MONTH 季度：QUARTER 年：YEAR 终身：LIFETIME 一次性使用额度：ONLYONE</value>
        [DataMember(Name = "quota_dimension", EmitDefaultValue = false)]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// 协议额度
        /// </summary>
        /// <value>协议额度</value>
        [DataMember(Name = "quota_total", EmitDefaultValue = false)]
        public string QuotaTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JointAccountQuotaDTO {\n");
            sb.Append("  CustomBeginDate: ").Append(CustomBeginDate).Append("\n");
            sb.Append("  CustomEndDate: ").Append(CustomEndDate).Append("\n");
            sb.Append("  QuotaDimension: ").Append(QuotaDimension).Append("\n");
            sb.Append("  QuotaTotal: ").Append(QuotaTotal).Append("\n");
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
            return this.Equals(input as JointAccountQuotaDTO);
        }

        /// <summary>
        /// Returns true if JointAccountQuotaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of JointAccountQuotaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JointAccountQuotaDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomBeginDate == input.CustomBeginDate ||
                    (this.CustomBeginDate != null &&
                    this.CustomBeginDate.Equals(input.CustomBeginDate))
                ) && 
                (
                    this.CustomEndDate == input.CustomEndDate ||
                    (this.CustomEndDate != null &&
                    this.CustomEndDate.Equals(input.CustomEndDate))
                ) && 
                (
                    this.QuotaDimension == input.QuotaDimension ||
                    (this.QuotaDimension != null &&
                    this.QuotaDimension.Equals(input.QuotaDimension))
                ) && 
                (
                    this.QuotaTotal == input.QuotaTotal ||
                    (this.QuotaTotal != null &&
                    this.QuotaTotal.Equals(input.QuotaTotal))
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
                if (this.CustomBeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.CustomBeginDate.GetHashCode();
                }
                if (this.CustomEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.CustomEndDate.GetHashCode();
                }
                if (this.QuotaDimension != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaDimension.GetHashCode();
                }
                if (this.QuotaTotal != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaTotal.GetHashCode();
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
