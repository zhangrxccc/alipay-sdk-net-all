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
    /// AccountQuotaDetail
    /// </summary>
    [DataContract(Name = "AccountQuotaDetail")]
    public partial class AccountQuotaDetail : IEquatable<AccountQuotaDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountQuotaDetail" /> class.
        /// </summary>
        /// <param name="quotaAmount">周期内的额度上限.</param>
        /// <param name="quotaDimension">额度周期，有限枚举.</param>
        /// <param name="role">角色.</param>
        public AccountQuotaDetail(int quotaAmount = default(int), string quotaDimension = default(string), string role = default(string))
        {
            this.QuotaAmount = quotaAmount;
            this.QuotaDimension = quotaDimension;
            this.Role = role;
        }

        /// <summary>
        /// 周期内的额度上限
        /// </summary>
        /// <value>周期内的额度上限</value>
        [DataMember(Name = "quota_amount", EmitDefaultValue = false)]
        public int QuotaAmount { get; set; }

        /// <summary>
        /// 额度周期，有限枚举
        /// </summary>
        /// <value>额度周期，有限枚举</value>
        [DataMember(Name = "quota_dimension", EmitDefaultValue = false)]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        /// <value>角色</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountQuotaDetail {\n");
            sb.Append("  QuotaAmount: ").Append(QuotaAmount).Append("\n");
            sb.Append("  QuotaDimension: ").Append(QuotaDimension).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as AccountQuotaDetail);
        }

        /// <summary>
        /// Returns true if AccountQuotaDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountQuotaDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountQuotaDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuotaAmount == input.QuotaAmount ||
                    this.QuotaAmount.Equals(input.QuotaAmount)
                ) && 
                (
                    this.QuotaDimension == input.QuotaDimension ||
                    (this.QuotaDimension != null &&
                    this.QuotaDimension.Equals(input.QuotaDimension))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                hashCode = (hashCode * 59) + this.QuotaAmount.GetHashCode();
                if (this.QuotaDimension != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaDimension.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
