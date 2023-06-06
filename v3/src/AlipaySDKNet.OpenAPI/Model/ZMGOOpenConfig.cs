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
    /// ZMGOOpenConfig
    /// </summary>
    [DataContract(Name = "ZMGOOpenConfig")]
    public partial class ZMGOOpenConfig : IEquatable<ZMGOOpenConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZMGOOpenConfig" /> class.
        /// </summary>
        /// <param name="applyButtonDesc">开通页按钮文案描述;传入内容后开通页点击开通按钮展示文案会使用该字段传入内容.</param>
        /// <param name="appointDate">固定到期时间或每月的第几日。 （1）当period_mode为APPOINT_DATE时，取值固定日期，如\&quot;2022-06-01 00:00:00\&quot;，表示协议在6月1号0点到期; （2）当period_mode为FIX_DATE，取值\&quot;3\&quot;，表示协议在period_time个月后的3号到期。.</param>
        /// <param name="cardColorScheme">芝麻GO卡颜色。 C_BLACK(\&quot;C_BLACK\&quot;, \&quot;黑色\&quot;), C_RED(\&quot;C_RED\&quot;, \&quot;红色\&quot;), C_GREEN(\&quot;C_GREEN\&quot;, \&quot;绿色\&quot;), C_LIGHT_BLUE(\&quot;C_LIGHT_BLUE\&quot;, \&quot;浅蓝色\&quot;), C_BLUE(\&quot;C_BLUE\&quot;, \&quot;蓝色\&quot;), C_ORANGE(\&quot;C_ORANGE\&quot;,\&quot;橙色\&quot;), C_PURPLE(\&quot;C_PURPLE\&quot;, \&quot;紫色\&quot;);.</param>
        /// <param name="customOpenTipList">未完成任务规则详情.</param>
        /// <param name="customOpenTips">规则详情.</param>
        /// <param name="freezeAmount">担保金额额度.</param>
        /// <param name="minSignInterval">用户签约间隔时间.</param>
        /// <param name="periodMode">芝麻GO义务到期的计算方式。包括： RELATIVE_DATE(\&quot;RELATIVE_DATE\&quot;, \&quot;相对日期\&quot;), ABSOLATE_DATE(\&quot;ABSOLATE_DATE\&quot;, \&quot;绝对日期(当日开始计算)\&quot;), ABSOLUTE_PLUS_1_DATE(\&quot;ABSOLUTE_PLUS_1_DATE\&quot;, \&quot;绝对日期(次日开始计算)\&quot;), FIX_DATE(\&quot;FIX_DATE\&quot;, \&quot;固定日期\&quot;), APPOINT_DATE(\&quot;APPOINT_DATE\&quot;, \&quot;指定日期\&quot;),.</param>
        /// <param name="periodTime">周期时长 当period_mode为RELATIVE_DATE、ABSOLATE_DATE、ABSOLUTE_PLUS_1_DATE、FIX_DATE时必填.</param>
        /// <param name="showSignSuccessPage">是否展示签约完成页.</param>
        /// <param name="signAgainSchema">用户签约商户活动到期.</param>
        /// <param name="signSuccessTaskButtonDesc">签约完成页任务按钮描述，当展示签约完成页&#x3D;true的时候 改内容必填.</param>
        /// <param name="supportExpireDeferral">是否支持延期特权.</param>
        public ZMGOOpenConfig(string applyButtonDesc = default(string), string appointDate = default(string), string cardColorScheme = default(string), string customOpenTipList = default(string), string customOpenTips = default(string), string freezeAmount = default(string), string minSignInterval = default(string), string periodMode = default(string), string periodTime = default(string), bool showSignSuccessPage = default(bool), string signAgainSchema = default(string), string signSuccessTaskButtonDesc = default(string), bool supportExpireDeferral = default(bool))
        {
            this.ApplyButtonDesc = applyButtonDesc;
            this.AppointDate = appointDate;
            this.CardColorScheme = cardColorScheme;
            this.CustomOpenTipList = customOpenTipList;
            this.CustomOpenTips = customOpenTips;
            this.FreezeAmount = freezeAmount;
            this.MinSignInterval = minSignInterval;
            this.PeriodMode = periodMode;
            this.PeriodTime = periodTime;
            this.ShowSignSuccessPage = showSignSuccessPage;
            this.SignAgainSchema = signAgainSchema;
            this.SignSuccessTaskButtonDesc = signSuccessTaskButtonDesc;
            this.SupportExpireDeferral = supportExpireDeferral;
        }

        /// <summary>
        /// 开通页按钮文案描述;传入内容后开通页点击开通按钮展示文案会使用该字段传入内容
        /// </summary>
        /// <value>开通页按钮文案描述;传入内容后开通页点击开通按钮展示文案会使用该字段传入内容</value>
        [DataMember(Name = "apply_button_desc", EmitDefaultValue = false)]
        public string ApplyButtonDesc { get; set; }

        /// <summary>
        /// 固定到期时间或每月的第几日。 （1）当period_mode为APPOINT_DATE时，取值固定日期，如\&quot;2022-06-01 00:00:00\&quot;，表示协议在6月1号0点到期; （2）当period_mode为FIX_DATE，取值\&quot;3\&quot;，表示协议在period_time个月后的3号到期。
        /// </summary>
        /// <value>固定到期时间或每月的第几日。 （1）当period_mode为APPOINT_DATE时，取值固定日期，如\&quot;2022-06-01 00:00:00\&quot;，表示协议在6月1号0点到期; （2）当period_mode为FIX_DATE，取值\&quot;3\&quot;，表示协议在period_time个月后的3号到期。</value>
        [DataMember(Name = "appoint_date", EmitDefaultValue = false)]
        public string AppointDate { get; set; }

        /// <summary>
        /// 芝麻GO卡颜色。 C_BLACK(\&quot;C_BLACK\&quot;, \&quot;黑色\&quot;), C_RED(\&quot;C_RED\&quot;, \&quot;红色\&quot;), C_GREEN(\&quot;C_GREEN\&quot;, \&quot;绿色\&quot;), C_LIGHT_BLUE(\&quot;C_LIGHT_BLUE\&quot;, \&quot;浅蓝色\&quot;), C_BLUE(\&quot;C_BLUE\&quot;, \&quot;蓝色\&quot;), C_ORANGE(\&quot;C_ORANGE\&quot;,\&quot;橙色\&quot;), C_PURPLE(\&quot;C_PURPLE\&quot;, \&quot;紫色\&quot;);
        /// </summary>
        /// <value>芝麻GO卡颜色。 C_BLACK(\&quot;C_BLACK\&quot;, \&quot;黑色\&quot;), C_RED(\&quot;C_RED\&quot;, \&quot;红色\&quot;), C_GREEN(\&quot;C_GREEN\&quot;, \&quot;绿色\&quot;), C_LIGHT_BLUE(\&quot;C_LIGHT_BLUE\&quot;, \&quot;浅蓝色\&quot;), C_BLUE(\&quot;C_BLUE\&quot;, \&quot;蓝色\&quot;), C_ORANGE(\&quot;C_ORANGE\&quot;,\&quot;橙色\&quot;), C_PURPLE(\&quot;C_PURPLE\&quot;, \&quot;紫色\&quot;);</value>
        [DataMember(Name = "card_color_scheme", EmitDefaultValue = false)]
        public string CardColorScheme { get; set; }

        /// <summary>
        /// 未完成任务规则详情
        /// </summary>
        /// <value>未完成任务规则详情</value>
        [DataMember(Name = "custom_open_tip_list", EmitDefaultValue = false)]
        public string CustomOpenTipList { get; set; }

        /// <summary>
        /// 规则详情
        /// </summary>
        /// <value>规则详情</value>
        [DataMember(Name = "custom_open_tips", EmitDefaultValue = false)]
        public string CustomOpenTips { get; set; }

        /// <summary>
        /// 担保金额额度
        /// </summary>
        /// <value>担保金额额度</value>
        [DataMember(Name = "freeze_amount", EmitDefaultValue = false)]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 用户签约间隔时间
        /// </summary>
        /// <value>用户签约间隔时间</value>
        [DataMember(Name = "min_sign_interval", EmitDefaultValue = false)]
        public string MinSignInterval { get; set; }

        /// <summary>
        /// 芝麻GO义务到期的计算方式。包括： RELATIVE_DATE(\&quot;RELATIVE_DATE\&quot;, \&quot;相对日期\&quot;), ABSOLATE_DATE(\&quot;ABSOLATE_DATE\&quot;, \&quot;绝对日期(当日开始计算)\&quot;), ABSOLUTE_PLUS_1_DATE(\&quot;ABSOLUTE_PLUS_1_DATE\&quot;, \&quot;绝对日期(次日开始计算)\&quot;), FIX_DATE(\&quot;FIX_DATE\&quot;, \&quot;固定日期\&quot;), APPOINT_DATE(\&quot;APPOINT_DATE\&quot;, \&quot;指定日期\&quot;),
        /// </summary>
        /// <value>芝麻GO义务到期的计算方式。包括： RELATIVE_DATE(\&quot;RELATIVE_DATE\&quot;, \&quot;相对日期\&quot;), ABSOLATE_DATE(\&quot;ABSOLATE_DATE\&quot;, \&quot;绝对日期(当日开始计算)\&quot;), ABSOLUTE_PLUS_1_DATE(\&quot;ABSOLUTE_PLUS_1_DATE\&quot;, \&quot;绝对日期(次日开始计算)\&quot;), FIX_DATE(\&quot;FIX_DATE\&quot;, \&quot;固定日期\&quot;), APPOINT_DATE(\&quot;APPOINT_DATE\&quot;, \&quot;指定日期\&quot;),</value>
        [DataMember(Name = "period_mode", EmitDefaultValue = false)]
        public string PeriodMode { get; set; }

        /// <summary>
        /// 周期时长 当period_mode为RELATIVE_DATE、ABSOLATE_DATE、ABSOLUTE_PLUS_1_DATE、FIX_DATE时必填
        /// </summary>
        /// <value>周期时长 当period_mode为RELATIVE_DATE、ABSOLATE_DATE、ABSOLUTE_PLUS_1_DATE、FIX_DATE时必填</value>
        [DataMember(Name = "period_time", EmitDefaultValue = false)]
        public string PeriodTime { get; set; }

        /// <summary>
        /// 是否展示签约完成页
        /// </summary>
        /// <value>是否展示签约完成页</value>
        [DataMember(Name = "show_sign_success_page", EmitDefaultValue = true)]
        public bool ShowSignSuccessPage { get; set; }

        /// <summary>
        /// 用户签约商户活动到期
        /// </summary>
        /// <value>用户签约商户活动到期</value>
        [DataMember(Name = "sign_again_schema", EmitDefaultValue = false)]
        public string SignAgainSchema { get; set; }

        /// <summary>
        /// 签约完成页任务按钮描述，当展示签约完成页&#x3D;true的时候 改内容必填
        /// </summary>
        /// <value>签约完成页任务按钮描述，当展示签约完成页&#x3D;true的时候 改内容必填</value>
        [DataMember(Name = "sign_success_task_button_desc", EmitDefaultValue = false)]
        public string SignSuccessTaskButtonDesc { get; set; }

        /// <summary>
        /// 是否支持延期特权
        /// </summary>
        /// <value>是否支持延期特权</value>
        [DataMember(Name = "support_expire_deferral", EmitDefaultValue = true)]
        public bool SupportExpireDeferral { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZMGOOpenConfig {\n");
            sb.Append("  ApplyButtonDesc: ").Append(ApplyButtonDesc).Append("\n");
            sb.Append("  AppointDate: ").Append(AppointDate).Append("\n");
            sb.Append("  CardColorScheme: ").Append(CardColorScheme).Append("\n");
            sb.Append("  CustomOpenTipList: ").Append(CustomOpenTipList).Append("\n");
            sb.Append("  CustomOpenTips: ").Append(CustomOpenTips).Append("\n");
            sb.Append("  FreezeAmount: ").Append(FreezeAmount).Append("\n");
            sb.Append("  MinSignInterval: ").Append(MinSignInterval).Append("\n");
            sb.Append("  PeriodMode: ").Append(PeriodMode).Append("\n");
            sb.Append("  PeriodTime: ").Append(PeriodTime).Append("\n");
            sb.Append("  ShowSignSuccessPage: ").Append(ShowSignSuccessPage).Append("\n");
            sb.Append("  SignAgainSchema: ").Append(SignAgainSchema).Append("\n");
            sb.Append("  SignSuccessTaskButtonDesc: ").Append(SignSuccessTaskButtonDesc).Append("\n");
            sb.Append("  SupportExpireDeferral: ").Append(SupportExpireDeferral).Append("\n");
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
            return this.Equals(input as ZMGOOpenConfig);
        }

        /// <summary>
        /// Returns true if ZMGOOpenConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ZMGOOpenConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZMGOOpenConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyButtonDesc == input.ApplyButtonDesc ||
                    (this.ApplyButtonDesc != null &&
                    this.ApplyButtonDesc.Equals(input.ApplyButtonDesc))
                ) && 
                (
                    this.AppointDate == input.AppointDate ||
                    (this.AppointDate != null &&
                    this.AppointDate.Equals(input.AppointDate))
                ) && 
                (
                    this.CardColorScheme == input.CardColorScheme ||
                    (this.CardColorScheme != null &&
                    this.CardColorScheme.Equals(input.CardColorScheme))
                ) && 
                (
                    this.CustomOpenTipList == input.CustomOpenTipList ||
                    (this.CustomOpenTipList != null &&
                    this.CustomOpenTipList.Equals(input.CustomOpenTipList))
                ) && 
                (
                    this.CustomOpenTips == input.CustomOpenTips ||
                    (this.CustomOpenTips != null &&
                    this.CustomOpenTips.Equals(input.CustomOpenTips))
                ) && 
                (
                    this.FreezeAmount == input.FreezeAmount ||
                    (this.FreezeAmount != null &&
                    this.FreezeAmount.Equals(input.FreezeAmount))
                ) && 
                (
                    this.MinSignInterval == input.MinSignInterval ||
                    (this.MinSignInterval != null &&
                    this.MinSignInterval.Equals(input.MinSignInterval))
                ) && 
                (
                    this.PeriodMode == input.PeriodMode ||
                    (this.PeriodMode != null &&
                    this.PeriodMode.Equals(input.PeriodMode))
                ) && 
                (
                    this.PeriodTime == input.PeriodTime ||
                    (this.PeriodTime != null &&
                    this.PeriodTime.Equals(input.PeriodTime))
                ) && 
                (
                    this.ShowSignSuccessPage == input.ShowSignSuccessPage ||
                    this.ShowSignSuccessPage.Equals(input.ShowSignSuccessPage)
                ) && 
                (
                    this.SignAgainSchema == input.SignAgainSchema ||
                    (this.SignAgainSchema != null &&
                    this.SignAgainSchema.Equals(input.SignAgainSchema))
                ) && 
                (
                    this.SignSuccessTaskButtonDesc == input.SignSuccessTaskButtonDesc ||
                    (this.SignSuccessTaskButtonDesc != null &&
                    this.SignSuccessTaskButtonDesc.Equals(input.SignSuccessTaskButtonDesc))
                ) && 
                (
                    this.SupportExpireDeferral == input.SupportExpireDeferral ||
                    this.SupportExpireDeferral.Equals(input.SupportExpireDeferral)
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
                if (this.ApplyButtonDesc != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyButtonDesc.GetHashCode();
                }
                if (this.AppointDate != null)
                {
                    hashCode = (hashCode * 59) + this.AppointDate.GetHashCode();
                }
                if (this.CardColorScheme != null)
                {
                    hashCode = (hashCode * 59) + this.CardColorScheme.GetHashCode();
                }
                if (this.CustomOpenTipList != null)
                {
                    hashCode = (hashCode * 59) + this.CustomOpenTipList.GetHashCode();
                }
                if (this.CustomOpenTips != null)
                {
                    hashCode = (hashCode * 59) + this.CustomOpenTips.GetHashCode();
                }
                if (this.FreezeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FreezeAmount.GetHashCode();
                }
                if (this.MinSignInterval != null)
                {
                    hashCode = (hashCode * 59) + this.MinSignInterval.GetHashCode();
                }
                if (this.PeriodMode != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodMode.GetHashCode();
                }
                if (this.PeriodTime != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowSignSuccessPage.GetHashCode();
                if (this.SignAgainSchema != null)
                {
                    hashCode = (hashCode * 59) + this.SignAgainSchema.GetHashCode();
                }
                if (this.SignSuccessTaskButtonDesc != null)
                {
                    hashCode = (hashCode * 59) + this.SignSuccessTaskButtonDesc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SupportExpireDeferral.GetHashCode();
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
