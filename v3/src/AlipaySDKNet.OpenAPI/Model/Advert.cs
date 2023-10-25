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
    /// Advert
    /// </summary>
    [DataContract(Name = "Advert")]
    public partial class Advert : IEquatable<Advert>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Advert" /> class.
        /// </summary>
        /// <param name="advertGroup">广告组标识.</param>
        /// <param name="advertId">广告位id.</param>
        /// <param name="advertItems">广告位轮播内容列表.</param>
        /// <param name="groupId">投放人群分组id.</param>
        /// <param name="mobileClientType">手机客户端类型，iphone、android、wp,空为不区分机型.</param>
        public Advert(string advertGroup = default(string), string advertId = default(string), List<AdvertItem> advertItems = default(List<AdvertItem>), string groupId = default(string), string mobileClientType = default(string))
        {
            this.AdvertGroup = advertGroup;
            this.AdvertId = advertId;
            this.AdvertItems = advertItems;
            this.GroupId = groupId;
            this.MobileClientType = mobileClientType;
        }

        /// <summary>
        /// 广告组标识
        /// </summary>
        /// <value>广告组标识</value>
        [DataMember(Name = "advert_group", EmitDefaultValue = false)]
        public string AdvertGroup { get; set; }

        /// <summary>
        /// 广告位id
        /// </summary>
        /// <value>广告位id</value>
        [DataMember(Name = "advert_id", EmitDefaultValue = false)]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表
        /// </summary>
        /// <value>广告位轮播内容列表</value>
        [DataMember(Name = "advert_items", EmitDefaultValue = false)]
        public List<AdvertItem> AdvertItems { get; set; }

        /// <summary>
        /// 投放人群分组id
        /// </summary>
        /// <value>投放人群分组id</value>
        [DataMember(Name = "group_id", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// 手机客户端类型，iphone、android、wp,空为不区分机型
        /// </summary>
        /// <value>手机客户端类型，iphone、android、wp,空为不区分机型</value>
        [DataMember(Name = "mobile_client_type", EmitDefaultValue = false)]
        public string MobileClientType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Advert {\n");
            sb.Append("  AdvertGroup: ").Append(AdvertGroup).Append("\n");
            sb.Append("  AdvertId: ").Append(AdvertId).Append("\n");
            sb.Append("  AdvertItems: ").Append(AdvertItems).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  MobileClientType: ").Append(MobileClientType).Append("\n");
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
            return this.Equals(input as Advert);
        }

        /// <summary>
        /// Returns true if Advert instances are equal
        /// </summary>
        /// <param name="input">Instance of Advert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Advert input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdvertGroup == input.AdvertGroup ||
                    (this.AdvertGroup != null &&
                    this.AdvertGroup.Equals(input.AdvertGroup))
                ) && 
                (
                    this.AdvertId == input.AdvertId ||
                    (this.AdvertId != null &&
                    this.AdvertId.Equals(input.AdvertId))
                ) && 
                (
                    this.AdvertItems == input.AdvertItems ||
                    this.AdvertItems != null &&
                    input.AdvertItems != null &&
                    this.AdvertItems.SequenceEqual(input.AdvertItems)
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.MobileClientType == input.MobileClientType ||
                    (this.MobileClientType != null &&
                    this.MobileClientType.Equals(input.MobileClientType))
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
                if (this.AdvertGroup != null)
                {
                    hashCode = (hashCode * 59) + this.AdvertGroup.GetHashCode();
                }
                if (this.AdvertId != null)
                {
                    hashCode = (hashCode * 59) + this.AdvertId.GetHashCode();
                }
                if (this.AdvertItems != null)
                {
                    hashCode = (hashCode * 59) + this.AdvertItems.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.MobileClientType != null)
                {
                    hashCode = (hashCode * 59) + this.MobileClientType.GetHashCode();
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
