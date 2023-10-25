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
    /// SettleExtraParams
    /// </summary>
    [DataContract(Name = "SettleExtraParams")]
    public partial class SettleExtraParams : IEquatable<SettleExtraParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettleExtraParams" /> class.
        /// </summary>
        /// <param name="quitType">quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT.</param>
        /// <param name="scenePayLinkInfo">商链通权益抵扣信息,  当前只有运营商使用,  未使用权益抵扣忽略该字段  fundRuleList为对应的出资信息，目前该列表不支持多对象，长度限制为1。其中fundAgreementNo为本笔交易实际出资的协议，由(商链通二方通用版本接入文档)2.3.2获取，fundAmount为该出资协议出资的金额。  bizScene和subBizScene为(商链通二方通用版本接入文档)2.1.3中支付宝侧分配的信息。  bizMode&#x3D;MERCHANT_ORDER为固定值。.</param>
        /// <param name="settleAdjustReason">action_type选择PAY_TO_ZERO时必填， \&quot;SERVICE_CANCELED\&quot;:\&quot;服务已取消\&quot;, \&quot;OTHER_CHANNEL_PERFORMANCE\&quot;:\&quot;户已通过其他方式履约\&quot;.</param>
        public SettleExtraParams(string quitType = default(string), string scenePayLinkInfo = default(string), string settleAdjustReason = default(string))
        {
            this.QuitType = quitType;
            this.ScenePayLinkInfo = scenePayLinkInfo;
            this.SettleAdjustReason = settleAdjustReason;
        }

        /// <summary>
        /// quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT
        /// </summary>
        /// <value>quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT</value>
        [DataMember(Name = "quit_type", EmitDefaultValue = false)]
        public string QuitType { get; set; }

        /// <summary>
        /// 商链通权益抵扣信息,  当前只有运营商使用,  未使用权益抵扣忽略该字段  fundRuleList为对应的出资信息，目前该列表不支持多对象，长度限制为1。其中fundAgreementNo为本笔交易实际出资的协议，由(商链通二方通用版本接入文档)2.3.2获取，fundAmount为该出资协议出资的金额。  bizScene和subBizScene为(商链通二方通用版本接入文档)2.1.3中支付宝侧分配的信息。  bizMode&#x3D;MERCHANT_ORDER为固定值。
        /// </summary>
        /// <value>商链通权益抵扣信息,  当前只有运营商使用,  未使用权益抵扣忽略该字段  fundRuleList为对应的出资信息，目前该列表不支持多对象，长度限制为1。其中fundAgreementNo为本笔交易实际出资的协议，由(商链通二方通用版本接入文档)2.3.2获取，fundAmount为该出资协议出资的金额。  bizScene和subBizScene为(商链通二方通用版本接入文档)2.1.3中支付宝侧分配的信息。  bizMode&#x3D;MERCHANT_ORDER为固定值。</value>
        [DataMember(Name = "scene_pay_link_info", EmitDefaultValue = false)]
        public string ScenePayLinkInfo { get; set; }

        /// <summary>
        /// action_type选择PAY_TO_ZERO时必填， \&quot;SERVICE_CANCELED\&quot;:\&quot;服务已取消\&quot;, \&quot;OTHER_CHANNEL_PERFORMANCE\&quot;:\&quot;户已通过其他方式履约\&quot;
        /// </summary>
        /// <value>action_type选择PAY_TO_ZERO时必填， \&quot;SERVICE_CANCELED\&quot;:\&quot;服务已取消\&quot;, \&quot;OTHER_CHANNEL_PERFORMANCE\&quot;:\&quot;户已通过其他方式履约\&quot;</value>
        [DataMember(Name = "settle_adjust_reason", EmitDefaultValue = false)]
        public string SettleAdjustReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettleExtraParams {\n");
            sb.Append("  QuitType: ").Append(QuitType).Append("\n");
            sb.Append("  ScenePayLinkInfo: ").Append(ScenePayLinkInfo).Append("\n");
            sb.Append("  SettleAdjustReason: ").Append(SettleAdjustReason).Append("\n");
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
            return this.Equals(input as SettleExtraParams);
        }

        /// <summary>
        /// Returns true if SettleExtraParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SettleExtraParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettleExtraParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuitType == input.QuitType ||
                    (this.QuitType != null &&
                    this.QuitType.Equals(input.QuitType))
                ) && 
                (
                    this.ScenePayLinkInfo == input.ScenePayLinkInfo ||
                    (this.ScenePayLinkInfo != null &&
                    this.ScenePayLinkInfo.Equals(input.ScenePayLinkInfo))
                ) && 
                (
                    this.SettleAdjustReason == input.SettleAdjustReason ||
                    (this.SettleAdjustReason != null &&
                    this.SettleAdjustReason.Equals(input.SettleAdjustReason))
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
                if (this.QuitType != null)
                {
                    hashCode = (hashCode * 59) + this.QuitType.GetHashCode();
                }
                if (this.ScenePayLinkInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ScenePayLinkInfo.GetHashCode();
                }
                if (this.SettleAdjustReason != null)
                {
                    hashCode = (hashCode * 59) + this.SettleAdjustReason.GetHashCode();
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
