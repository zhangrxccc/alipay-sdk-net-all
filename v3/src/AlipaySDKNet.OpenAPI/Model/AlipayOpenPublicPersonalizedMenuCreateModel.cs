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
    /// AlipayOpenPublicPersonalizedMenuCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicPersonalizedMenuCreateModel")]
    public partial class AlipayOpenPublicPersonalizedMenuCreateModel : IEquatable<AlipayOpenPublicPersonalizedMenuCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicPersonalizedMenuCreateModel" /> class.
        /// </summary>
        /// <param name="button">一级菜单列表。说明： * 如果是文本菜单，最多有4个一级菜单，若开发者在后台打开了\&quot;咨询反馈\&quot;的开关，则只能有3个一级菜单。 * 如果是 ICON 菜单信息，最多有80个一级菜单(忽略二级菜单)。.</param>
        /// <param name="groupId">人群分组id。分组创建及管理接入详情参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/fw/api/106931\&quot;&gt;分组管理&lt;/a&gt;。 注意：group_id 与 label_rule（标签规则）不能同时为空。.</param>
        /// <param name="labelRule">标签规则，目前限定只能传入1条，在个性化菜单创建成功后，满足该标签规则的用户进入生活号首页，将看到该套菜单。生成标签及打标详情参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/fw/api/106877\&quot;&gt;标签管理&lt;/a&gt;。 注意：group_id（人群分组id） 与 label_rule 不能同时为空。.</param>
        /// <param name="mobileClientType">手机客户端类型，枚举支持： *iphone； *android； *wp； 说明：不填为不区分机型。.</param>
        /// <param name="type">菜单类型，不填时默认为 text（文本型菜单）。枚举值如下： * text：文本型菜单。 * icon：表示 icon 型菜单，当传值为\&quot;icon\&quot;时，菜单节点的icon字段必传。.</param>
        public AlipayOpenPublicPersonalizedMenuCreateModel(List<ButtonObject> button = default(List<ButtonObject>), string groupId = default(string), List<LabelRule> labelRule = default(List<LabelRule>), string mobileClientType = default(string), string type = default(string))
        {
            this.Button = button;
            this.GroupId = groupId;
            this.LabelRule = labelRule;
            this.MobileClientType = mobileClientType;
            this.Type = type;
        }

        /// <summary>
        /// 一级菜单列表。说明： * 如果是文本菜单，最多有4个一级菜单，若开发者在后台打开了\&quot;咨询反馈\&quot;的开关，则只能有3个一级菜单。 * 如果是 ICON 菜单信息，最多有80个一级菜单(忽略二级菜单)。
        /// </summary>
        /// <value>一级菜单列表。说明： * 如果是文本菜单，最多有4个一级菜单，若开发者在后台打开了\&quot;咨询反馈\&quot;的开关，则只能有3个一级菜单。 * 如果是 ICON 菜单信息，最多有80个一级菜单(忽略二级菜单)。</value>
        [DataMember(Name = "button", EmitDefaultValue = false)]
        public List<ButtonObject> Button { get; set; }

        /// <summary>
        /// 人群分组id。分组创建及管理接入详情参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/fw/api/106931\&quot;&gt;分组管理&lt;/a&gt;。 注意：group_id 与 label_rule（标签规则）不能同时为空。
        /// </summary>
        /// <value>人群分组id。分组创建及管理接入详情参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/fw/api/106931\&quot;&gt;分组管理&lt;/a&gt;。 注意：group_id 与 label_rule（标签规则）不能同时为空。</value>
        [DataMember(Name = "group_id", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// 标签规则，目前限定只能传入1条，在个性化菜单创建成功后，满足该标签规则的用户进入生活号首页，将看到该套菜单。生成标签及打标详情参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/fw/api/106877\&quot;&gt;标签管理&lt;/a&gt;。 注意：group_id（人群分组id） 与 label_rule 不能同时为空。
        /// </summary>
        /// <value>标签规则，目前限定只能传入1条，在个性化菜单创建成功后，满足该标签规则的用户进入生活号首页，将看到该套菜单。生成标签及打标详情参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/fw/api/106877\&quot;&gt;标签管理&lt;/a&gt;。 注意：group_id（人群分组id） 与 label_rule 不能同时为空。</value>
        [DataMember(Name = "label_rule", EmitDefaultValue = false)]
        public List<LabelRule> LabelRule { get; set; }

        /// <summary>
        /// 手机客户端类型，枚举支持： *iphone； *android； *wp； 说明：不填为不区分机型。
        /// </summary>
        /// <value>手机客户端类型，枚举支持： *iphone； *android； *wp； 说明：不填为不区分机型。</value>
        [DataMember(Name = "mobile_client_type", EmitDefaultValue = false)]
        public string MobileClientType { get; set; }

        /// <summary>
        /// 菜单类型，不填时默认为 text（文本型菜单）。枚举值如下： * text：文本型菜单。 * icon：表示 icon 型菜单，当传值为\&quot;icon\&quot;时，菜单节点的icon字段必传。
        /// </summary>
        /// <value>菜单类型，不填时默认为 text（文本型菜单）。枚举值如下： * text：文本型菜单。 * icon：表示 icon 型菜单，当传值为\&quot;icon\&quot;时，菜单节点的icon字段必传。</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicPersonalizedMenuCreateModel {\n");
            sb.Append("  Button: ").Append(Button).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  LabelRule: ").Append(LabelRule).Append("\n");
            sb.Append("  MobileClientType: ").Append(MobileClientType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicPersonalizedMenuCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicPersonalizedMenuCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicPersonalizedMenuCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicPersonalizedMenuCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Button == input.Button ||
                    this.Button != null &&
                    input.Button != null &&
                    this.Button.SequenceEqual(input.Button)
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.LabelRule == input.LabelRule ||
                    this.LabelRule != null &&
                    input.LabelRule != null &&
                    this.LabelRule.SequenceEqual(input.LabelRule)
                ) && 
                (
                    this.MobileClientType == input.MobileClientType ||
                    (this.MobileClientType != null &&
                    this.MobileClientType.Equals(input.MobileClientType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Button != null)
                {
                    hashCode = (hashCode * 59) + this.Button.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.LabelRule != null)
                {
                    hashCode = (hashCode * 59) + this.LabelRule.GetHashCode();
                }
                if (this.MobileClientType != null)
                {
                    hashCode = (hashCode * 59) + this.MobileClientType.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
