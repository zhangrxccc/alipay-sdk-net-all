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
    /// AlipayOpenMiniInnerappPluginservicePublishModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerappPluginservicePublishModel")]
    public partial class AlipayOpenMiniInnerappPluginservicePublishModel : IEquatable<AlipayOpenMiniInnerappPluginservicePublishModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerappPluginservicePublishModel" /> class.
        /// </summary>
        /// <param name="abilityTypeList">功能类型，目前支持的有：1039支付, 1040会员, 1041基础, 1056资金, 1058信用, 1111口碑, 330120安全, 360101营销.</param>
        /// <param name="appLogo">服务发布logo.</param>
        /// <param name="appOrigin">业务来源.</param>
        /// <param name="description">服务描述.</param>
        /// <param name="detailForClient">移动端详情，用于能力中心展示.</param>
        /// <param name="detailForPc">pc端详情，用于能力中心展示.</param>
        /// <param name="miniAppId">插件id.</param>
        /// <param name="sellCrowd">可订购人群，1003个人, 1004企业，-1无限制.</param>
        /// <param name="showType">发布后是否展示，01展示（默认）、02隐藏.</param>
        /// <param name="title">服务标题.</param>
        /// <param name="visitUrlForPc">pc端url地址，不需要则为空.</param>
        public AlipayOpenMiniInnerappPluginservicePublishModel(List<string> abilityTypeList = default(List<string>), string appLogo = default(string), string appOrigin = default(string), string description = default(string), string detailForClient = default(string), string detailForPc = default(string), string miniAppId = default(string), string sellCrowd = default(string), string showType = default(string), string title = default(string), string visitUrlForPc = default(string))
        {
            this.AbilityTypeList = abilityTypeList;
            this.AppLogo = appLogo;
            this.AppOrigin = appOrigin;
            this.Description = description;
            this.DetailForClient = detailForClient;
            this.DetailForPc = detailForPc;
            this.MiniAppId = miniAppId;
            this.SellCrowd = sellCrowd;
            this.ShowType = showType;
            this.Title = title;
            this.VisitUrlForPc = visitUrlForPc;
        }

        /// <summary>
        /// 功能类型，目前支持的有：1039支付, 1040会员, 1041基础, 1056资金, 1058信用, 1111口碑, 330120安全, 360101营销
        /// </summary>
        /// <value>功能类型，目前支持的有：1039支付, 1040会员, 1041基础, 1056资金, 1058信用, 1111口碑, 330120安全, 360101营销</value>
        [DataMember(Name = "ability_type_list", EmitDefaultValue = false)]
        public List<string> AbilityTypeList { get; set; }

        /// <summary>
        /// 服务发布logo
        /// </summary>
        /// <value>服务发布logo</value>
        [DataMember(Name = "app_logo", EmitDefaultValue = false)]
        public string AppLogo { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        /// <value>业务来源</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        /// <value>服务描述</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 移动端详情，用于能力中心展示
        /// </summary>
        /// <value>移动端详情，用于能力中心展示</value>
        [DataMember(Name = "detail_for_client", EmitDefaultValue = false)]
        public string DetailForClient { get; set; }

        /// <summary>
        /// pc端详情，用于能力中心展示
        /// </summary>
        /// <value>pc端详情，用于能力中心展示</value>
        [DataMember(Name = "detail_for_pc", EmitDefaultValue = false)]
        public string DetailForPc { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        /// <value>插件id</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 可订购人群，1003个人, 1004企业，-1无限制
        /// </summary>
        /// <value>可订购人群，1003个人, 1004企业，-1无限制</value>
        [DataMember(Name = "sell_crowd", EmitDefaultValue = false)]
        public string SellCrowd { get; set; }

        /// <summary>
        /// 发布后是否展示，01展示（默认）、02隐藏
        /// </summary>
        /// <value>发布后是否展示，01展示（默认）、02隐藏</value>
        [DataMember(Name = "show_type", EmitDefaultValue = false)]
        public string ShowType { get; set; }

        /// <summary>
        /// 服务标题
        /// </summary>
        /// <value>服务标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// pc端url地址，不需要则为空
        /// </summary>
        /// <value>pc端url地址，不需要则为空</value>
        [DataMember(Name = "visit_url_for_pc", EmitDefaultValue = false)]
        public string VisitUrlForPc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerappPluginservicePublishModel {\n");
            sb.Append("  AbilityTypeList: ").Append(AbilityTypeList).Append("\n");
            sb.Append("  AppLogo: ").Append(AppLogo).Append("\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DetailForClient: ").Append(DetailForClient).Append("\n");
            sb.Append("  DetailForPc: ").Append(DetailForPc).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  SellCrowd: ").Append(SellCrowd).Append("\n");
            sb.Append("  ShowType: ").Append(ShowType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  VisitUrlForPc: ").Append(VisitUrlForPc).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerappPluginservicePublishModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerappPluginservicePublishModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerappPluginservicePublishModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerappPluginservicePublishModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AbilityTypeList == input.AbilityTypeList ||
                    this.AbilityTypeList != null &&
                    input.AbilityTypeList != null &&
                    this.AbilityTypeList.SequenceEqual(input.AbilityTypeList)
                ) && 
                (
                    this.AppLogo == input.AppLogo ||
                    (this.AppLogo != null &&
                    this.AppLogo.Equals(input.AppLogo))
                ) && 
                (
                    this.AppOrigin == input.AppOrigin ||
                    (this.AppOrigin != null &&
                    this.AppOrigin.Equals(input.AppOrigin))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DetailForClient == input.DetailForClient ||
                    (this.DetailForClient != null &&
                    this.DetailForClient.Equals(input.DetailForClient))
                ) && 
                (
                    this.DetailForPc == input.DetailForPc ||
                    (this.DetailForPc != null &&
                    this.DetailForPc.Equals(input.DetailForPc))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.SellCrowd == input.SellCrowd ||
                    (this.SellCrowd != null &&
                    this.SellCrowd.Equals(input.SellCrowd))
                ) && 
                (
                    this.ShowType == input.ShowType ||
                    (this.ShowType != null &&
                    this.ShowType.Equals(input.ShowType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.VisitUrlForPc == input.VisitUrlForPc ||
                    (this.VisitUrlForPc != null &&
                    this.VisitUrlForPc.Equals(input.VisitUrlForPc))
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
                if (this.AbilityTypeList != null)
                {
                    hashCode = (hashCode * 59) + this.AbilityTypeList.GetHashCode();
                }
                if (this.AppLogo != null)
                {
                    hashCode = (hashCode * 59) + this.AppLogo.GetHashCode();
                }
                if (this.AppOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.AppOrigin.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DetailForClient != null)
                {
                    hashCode = (hashCode * 59) + this.DetailForClient.GetHashCode();
                }
                if (this.DetailForPc != null)
                {
                    hashCode = (hashCode * 59) + this.DetailForPc.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.SellCrowd != null)
                {
                    hashCode = (hashCode * 59) + this.SellCrowd.GetHashCode();
                }
                if (this.ShowType != null)
                {
                    hashCode = (hashCode * 59) + this.ShowType.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.VisitUrlForPc != null)
                {
                    hashCode = (hashCode * 59) + this.VisitUrlForPc.GetHashCode();
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
