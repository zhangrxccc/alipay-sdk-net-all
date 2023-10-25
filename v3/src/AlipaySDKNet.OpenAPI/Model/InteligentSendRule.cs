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
    /// InteligentSendRule
    /// </summary>
    [DataContract(Name = "InteligentSendRule")]
    public partial class InteligentSendRule : IEquatable<InteligentSendRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentSendRule" /> class.
        /// </summary>
        /// <param name="allowRepeatSend">是否允许重复发奖：  true代表允许，false代表不允许  默认不设置，表明用户领取券后如果没有核销则不允许再次领取券  如果设置为true，表明如果用户领取券后没有核销，还可以继续领取该券.</param>
        /// <param name="minCost">发券最低消费金额，单位元  活动类型为消费送且不是消费送礼包时设置  多营销工具之间不允许设置重复值.</param>
        /// <param name="sendBudget">券的预算数量（仅对口令送随机抽奖有效，即当活动类型为GUESS_SEND，且营销工具PromoTool的个数大于1时，此字段必填，其余情况此字段必为空）.</param>
        /// <param name="sendNum">发券数目  最少发1张券，最多发5张券.</param>
        public InteligentSendRule(string allowRepeatSend = default(string), string minCost = default(string), string sendBudget = default(string), string sendNum = default(string))
        {
            this.AllowRepeatSend = allowRepeatSend;
            this.MinCost = minCost;
            this.SendBudget = sendBudget;
            this.SendNum = sendNum;
        }

        /// <summary>
        /// 是否允许重复发奖：  true代表允许，false代表不允许  默认不设置，表明用户领取券后如果没有核销则不允许再次领取券  如果设置为true，表明如果用户领取券后没有核销，还可以继续领取该券
        /// </summary>
        /// <value>是否允许重复发奖：  true代表允许，false代表不允许  默认不设置，表明用户领取券后如果没有核销则不允许再次领取券  如果设置为true，表明如果用户领取券后没有核销，还可以继续领取该券</value>
        [DataMember(Name = "allow_repeat_send", EmitDefaultValue = false)]
        public string AllowRepeatSend { get; set; }

        /// <summary>
        /// 发券最低消费金额，单位元  活动类型为消费送且不是消费送礼包时设置  多营销工具之间不允许设置重复值
        /// </summary>
        /// <value>发券最低消费金额，单位元  活动类型为消费送且不是消费送礼包时设置  多营销工具之间不允许设置重复值</value>
        [DataMember(Name = "min_cost", EmitDefaultValue = false)]
        public string MinCost { get; set; }

        /// <summary>
        /// 券的预算数量（仅对口令送随机抽奖有效，即当活动类型为GUESS_SEND，且营销工具PromoTool的个数大于1时，此字段必填，其余情况此字段必为空）
        /// </summary>
        /// <value>券的预算数量（仅对口令送随机抽奖有效，即当活动类型为GUESS_SEND，且营销工具PromoTool的个数大于1时，此字段必填，其余情况此字段必为空）</value>
        [DataMember(Name = "send_budget", EmitDefaultValue = false)]
        public string SendBudget { get; set; }

        /// <summary>
        /// 发券数目  最少发1张券，最多发5张券
        /// </summary>
        /// <value>发券数目  最少发1张券，最多发5张券</value>
        [DataMember(Name = "send_num", EmitDefaultValue = false)]
        public string SendNum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentSendRule {\n");
            sb.Append("  AllowRepeatSend: ").Append(AllowRepeatSend).Append("\n");
            sb.Append("  MinCost: ").Append(MinCost).Append("\n");
            sb.Append("  SendBudget: ").Append(SendBudget).Append("\n");
            sb.Append("  SendNum: ").Append(SendNum).Append("\n");
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
            return this.Equals(input as InteligentSendRule);
        }

        /// <summary>
        /// Returns true if InteligentSendRule instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentSendRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentSendRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowRepeatSend == input.AllowRepeatSend ||
                    (this.AllowRepeatSend != null &&
                    this.AllowRepeatSend.Equals(input.AllowRepeatSend))
                ) && 
                (
                    this.MinCost == input.MinCost ||
                    (this.MinCost != null &&
                    this.MinCost.Equals(input.MinCost))
                ) && 
                (
                    this.SendBudget == input.SendBudget ||
                    (this.SendBudget != null &&
                    this.SendBudget.Equals(input.SendBudget))
                ) && 
                (
                    this.SendNum == input.SendNum ||
                    (this.SendNum != null &&
                    this.SendNum.Equals(input.SendNum))
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
                if (this.AllowRepeatSend != null)
                {
                    hashCode = (hashCode * 59) + this.AllowRepeatSend.GetHashCode();
                }
                if (this.MinCost != null)
                {
                    hashCode = (hashCode * 59) + this.MinCost.GetHashCode();
                }
                if (this.SendBudget != null)
                {
                    hashCode = (hashCode * 59) + this.SendBudget.GetHashCode();
                }
                if (this.SendNum != null)
                {
                    hashCode = (hashCode * 59) + this.SendNum.GetHashCode();
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
