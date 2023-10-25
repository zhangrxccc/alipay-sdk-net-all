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
    /// PaidOuterCardCycleSellConfDTO
    /// </summary>
    [DataContract(Name = "PaidOuterCardCycleSellConfDTO")]
    public partial class PaidOuterCardCycleSellConfDTO : IEquatable<PaidOuterCardCycleSellConfDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaidOuterCardCycleSellConfDTO" /> class.
        /// </summary>
        /// <param name="cycleSellingUrl">用户开通连续购买地址.</param>
        /// <param name="cycleType">周期购买类型。.</param>
        /// <param name="supportCycleSell">是否支持用户连续购买.</param>
        public PaidOuterCardCycleSellConfDTO(string cycleSellingUrl = default(string), List<string> cycleType = default(List<string>), bool supportCycleSell = default(bool))
        {
            this.CycleSellingUrl = cycleSellingUrl;
            this.CycleType = cycleType;
            this.SupportCycleSell = supportCycleSell;
        }

        /// <summary>
        /// 用户开通连续购买地址
        /// </summary>
        /// <value>用户开通连续购买地址</value>
        [DataMember(Name = "cycle_selling_url", EmitDefaultValue = false)]
        public string CycleSellingUrl { get; set; }

        /// <summary>
        /// 周期购买类型。
        /// </summary>
        /// <value>周期购买类型。</value>
        [DataMember(Name = "cycle_type", EmitDefaultValue = false)]
        public List<string> CycleType { get; set; }

        /// <summary>
        /// 是否支持用户连续购买
        /// </summary>
        /// <value>是否支持用户连续购买</value>
        [DataMember(Name = "support_cycle_sell", EmitDefaultValue = true)]
        public bool SupportCycleSell { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaidOuterCardCycleSellConfDTO {\n");
            sb.Append("  CycleSellingUrl: ").Append(CycleSellingUrl).Append("\n");
            sb.Append("  CycleType: ").Append(CycleType).Append("\n");
            sb.Append("  SupportCycleSell: ").Append(SupportCycleSell).Append("\n");
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
            return this.Equals(input as PaidOuterCardCycleSellConfDTO);
        }

        /// <summary>
        /// Returns true if PaidOuterCardCycleSellConfDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PaidOuterCardCycleSellConfDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaidOuterCardCycleSellConfDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CycleSellingUrl == input.CycleSellingUrl ||
                    (this.CycleSellingUrl != null &&
                    this.CycleSellingUrl.Equals(input.CycleSellingUrl))
                ) && 
                (
                    this.CycleType == input.CycleType ||
                    this.CycleType != null &&
                    input.CycleType != null &&
                    this.CycleType.SequenceEqual(input.CycleType)
                ) && 
                (
                    this.SupportCycleSell == input.SupportCycleSell ||
                    this.SupportCycleSell.Equals(input.SupportCycleSell)
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
                if (this.CycleSellingUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CycleSellingUrl.GetHashCode();
                }
                if (this.CycleType != null)
                {
                    hashCode = (hashCode * 59) + this.CycleType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SupportCycleSell.GetHashCode();
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
