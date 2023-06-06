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
    /// UserRiskPrediction
    /// </summary>
    [DataContract(Name = "UserRiskPrediction")]
    public partial class UserRiskPrediction : IEquatable<UserRiskPrediction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRiskPrediction" /> class.
        /// </summary>
        /// <param name="phoneRecycleRiskLeve">用户绑定手机号被二次放号风险等级。 NO_RESULT：手机号风险未入库 NO_RISK：用户绑定手机无二次放号风险，高置信度 LOW_RISK：用户绑定手机二次放号风险较小，商户自行决策是否相信。 HIGH_RISK：用户绑定手机已被放号，高置信度.</param>
        /// <param name="refusedPaymentRiskLevel">用户拒付风险等级。 NO_SIGN：商户未签约。 NO_RESULT：未查询到账户信息。 LOW_RISK：用户拒付风险为低；处理建议：用户可以先享受服务，再进行支付。 MEDIUM_RISK：用户拒付风险为中；处理建议：根据业务场景客户自行判断提供或者不提供。 HIGH_RISK：用户拒付风险为高；处理建议：不建议先提供给用户服务。.</param>
        public UserRiskPrediction(string phoneRecycleRiskLeve = default(string), string refusedPaymentRiskLevel = default(string))
        {
            this.PhoneRecycleRiskLeve = phoneRecycleRiskLeve;
            this.RefusedPaymentRiskLevel = refusedPaymentRiskLevel;
        }

        /// <summary>
        /// 用户绑定手机号被二次放号风险等级。 NO_RESULT：手机号风险未入库 NO_RISK：用户绑定手机无二次放号风险，高置信度 LOW_RISK：用户绑定手机二次放号风险较小，商户自行决策是否相信。 HIGH_RISK：用户绑定手机已被放号，高置信度
        /// </summary>
        /// <value>用户绑定手机号被二次放号风险等级。 NO_RESULT：手机号风险未入库 NO_RISK：用户绑定手机无二次放号风险，高置信度 LOW_RISK：用户绑定手机二次放号风险较小，商户自行决策是否相信。 HIGH_RISK：用户绑定手机已被放号，高置信度</value>
        [DataMember(Name = "phone_recycle_risk_leve", EmitDefaultValue = false)]
        public string PhoneRecycleRiskLeve { get; set; }

        /// <summary>
        /// 用户拒付风险等级。 NO_SIGN：商户未签约。 NO_RESULT：未查询到账户信息。 LOW_RISK：用户拒付风险为低；处理建议：用户可以先享受服务，再进行支付。 MEDIUM_RISK：用户拒付风险为中；处理建议：根据业务场景客户自行判断提供或者不提供。 HIGH_RISK：用户拒付风险为高；处理建议：不建议先提供给用户服务。
        /// </summary>
        /// <value>用户拒付风险等级。 NO_SIGN：商户未签约。 NO_RESULT：未查询到账户信息。 LOW_RISK：用户拒付风险为低；处理建议：用户可以先享受服务，再进行支付。 MEDIUM_RISK：用户拒付风险为中；处理建议：根据业务场景客户自行判断提供或者不提供。 HIGH_RISK：用户拒付风险为高；处理建议：不建议先提供给用户服务。</value>
        [DataMember(Name = "refused_payment_risk_level", EmitDefaultValue = false)]
        public string RefusedPaymentRiskLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserRiskPrediction {\n");
            sb.Append("  PhoneRecycleRiskLeve: ").Append(PhoneRecycleRiskLeve).Append("\n");
            sb.Append("  RefusedPaymentRiskLevel: ").Append(RefusedPaymentRiskLevel).Append("\n");
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
            return this.Equals(input as UserRiskPrediction);
        }

        /// <summary>
        /// Returns true if UserRiskPrediction instances are equal
        /// </summary>
        /// <param name="input">Instance of UserRiskPrediction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRiskPrediction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PhoneRecycleRiskLeve == input.PhoneRecycleRiskLeve ||
                    (this.PhoneRecycleRiskLeve != null &&
                    this.PhoneRecycleRiskLeve.Equals(input.PhoneRecycleRiskLeve))
                ) && 
                (
                    this.RefusedPaymentRiskLevel == input.RefusedPaymentRiskLevel ||
                    (this.RefusedPaymentRiskLevel != null &&
                    this.RefusedPaymentRiskLevel.Equals(input.RefusedPaymentRiskLevel))
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
                if (this.PhoneRecycleRiskLeve != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneRecycleRiskLeve.GetHashCode();
                }
                if (this.RefusedPaymentRiskLevel != null)
                {
                    hashCode = (hashCode * 59) + this.RefusedPaymentRiskLevel.GetHashCode();
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
