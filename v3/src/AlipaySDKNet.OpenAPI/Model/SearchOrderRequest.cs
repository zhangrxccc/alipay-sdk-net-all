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
    /// SearchOrderRequest
    /// </summary>
    [DataContract(Name = "SearchOrderRequest")]
    public partial class SearchOrderRequest : IEquatable<SearchOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOrderRequest" /> class.
        /// </summary>
        /// <param name="applyId">申请单id.</param>
        /// <param name="applyType">申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达.</param>
        /// <param name="brandTemplateId">品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四.</param>
        /// <param name="serviceCode">服务code.</param>
        /// <param name="specCode">服务的类型默认使用小程序 SP_MINI_APP 小程序 SP_PUBLIC_APP 生活号.</param>
        public SearchOrderRequest(string applyId = default(string), string applyType = default(string), string brandTemplateId = default(string), string serviceCode = default(string), string specCode = default(string))
        {
            this.ApplyId = applyId;
            this.ApplyType = applyType;
            this.BrandTemplateId = brandTemplateId;
            this.ServiceCode = serviceCode;
            this.SpecCode = specCode;
        }

        /// <summary>
        /// 申请单id
        /// </summary>
        /// <value>申请单id</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        /// <value>申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达</value>
        [DataMember(Name = "apply_type", EmitDefaultValue = false)]
        public string ApplyType { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        /// <value>品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四</value>
        [DataMember(Name = "brand_template_id", EmitDefaultValue = false)]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        /// <value>服务code</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务的类型默认使用小程序 SP_MINI_APP 小程序 SP_PUBLIC_APP 生活号
        /// </summary>
        /// <value>服务的类型默认使用小程序 SP_MINI_APP 小程序 SP_PUBLIC_APP 生活号</value>
        [DataMember(Name = "spec_code", EmitDefaultValue = false)]
        public string SpecCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchOrderRequest {\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  ApplyType: ").Append(ApplyType).Append("\n");
            sb.Append("  BrandTemplateId: ").Append(BrandTemplateId).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  SpecCode: ").Append(SpecCode).Append("\n");
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
            return this.Equals(input as SearchOrderRequest);
        }

        /// <summary>
        /// Returns true if SearchOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchOrderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyId == input.ApplyId ||
                    (this.ApplyId != null &&
                    this.ApplyId.Equals(input.ApplyId))
                ) && 
                (
                    this.ApplyType == input.ApplyType ||
                    (this.ApplyType != null &&
                    this.ApplyType.Equals(input.ApplyType))
                ) && 
                (
                    this.BrandTemplateId == input.BrandTemplateId ||
                    (this.BrandTemplateId != null &&
                    this.BrandTemplateId.Equals(input.BrandTemplateId))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
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
                if (this.ApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyId.GetHashCode();
                }
                if (this.ApplyType != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyType.GetHashCode();
                }
                if (this.BrandTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.BrandTemplateId.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.SpecCode != null)
                {
                    hashCode = (hashCode * 59) + this.SpecCode.GetHashCode();
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
