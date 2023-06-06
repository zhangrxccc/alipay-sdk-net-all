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
    /// CashCampaignInfo
    /// </summary>
    [DataContract(Name = "CashCampaignInfo")]
    public partial class CashCampaignInfo : IEquatable<CashCampaignInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashCampaignInfo" /> class.
        /// </summary>
        /// <param name="campStatus">活动状态.</param>
        /// <param name="couponName">现金红包名称.</param>
        /// <param name="crowdNo">现金红包活动号.</param>
        /// <param name="originCrowdNo">原始活动号,商户进行问题排查时提供.</param>
        public CashCampaignInfo(string campStatus = default(string), string couponName = default(string), string crowdNo = default(string), string originCrowdNo = default(string))
        {
            this.CampStatus = campStatus;
            this.CouponName = couponName;
            this.CrowdNo = crowdNo;
            this.OriginCrowdNo = originCrowdNo;
        }

        /// <summary>
        /// 活动状态
        /// </summary>
        /// <value>活动状态</value>
        [DataMember(Name = "camp_status", EmitDefaultValue = false)]
        public string CampStatus { get; set; }

        /// <summary>
        /// 现金红包名称
        /// </summary>
        /// <value>现金红包名称</value>
        [DataMember(Name = "coupon_name", EmitDefaultValue = false)]
        public string CouponName { get; set; }

        /// <summary>
        /// 现金红包活动号
        /// </summary>
        /// <value>现金红包活动号</value>
        [DataMember(Name = "crowd_no", EmitDefaultValue = false)]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 原始活动号,商户进行问题排查时提供
        /// </summary>
        /// <value>原始活动号,商户进行问题排查时提供</value>
        [DataMember(Name = "origin_crowd_no", EmitDefaultValue = false)]
        public string OriginCrowdNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CashCampaignInfo {\n");
            sb.Append("  CampStatus: ").Append(CampStatus).Append("\n");
            sb.Append("  CouponName: ").Append(CouponName).Append("\n");
            sb.Append("  CrowdNo: ").Append(CrowdNo).Append("\n");
            sb.Append("  OriginCrowdNo: ").Append(OriginCrowdNo).Append("\n");
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
            return this.Equals(input as CashCampaignInfo);
        }

        /// <summary>
        /// Returns true if CashCampaignInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CashCampaignInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashCampaignInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampStatus == input.CampStatus ||
                    (this.CampStatus != null &&
                    this.CampStatus.Equals(input.CampStatus))
                ) && 
                (
                    this.CouponName == input.CouponName ||
                    (this.CouponName != null &&
                    this.CouponName.Equals(input.CouponName))
                ) && 
                (
                    this.CrowdNo == input.CrowdNo ||
                    (this.CrowdNo != null &&
                    this.CrowdNo.Equals(input.CrowdNo))
                ) && 
                (
                    this.OriginCrowdNo == input.OriginCrowdNo ||
                    (this.OriginCrowdNo != null &&
                    this.OriginCrowdNo.Equals(input.OriginCrowdNo))
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
                if (this.CampStatus != null)
                {
                    hashCode = (hashCode * 59) + this.CampStatus.GetHashCode();
                }
                if (this.CouponName != null)
                {
                    hashCode = (hashCode * 59) + this.CouponName.GetHashCode();
                }
                if (this.CrowdNo != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdNo.GetHashCode();
                }
                if (this.OriginCrowdNo != null)
                {
                    hashCode = (hashCode * 59) + this.OriginCrowdNo.GetHashCode();
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
