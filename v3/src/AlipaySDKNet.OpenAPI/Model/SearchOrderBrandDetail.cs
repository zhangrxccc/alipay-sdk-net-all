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
    /// SearchOrderBrandDetail
    /// </summary>
    [DataContract(Name = "SearchOrderBrandDetail")]
    public partial class SearchOrderBrandDetail : IEquatable<SearchOrderBrandDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOrderBrandDetail" /> class.
        /// </summary>
        /// <param name="brandDetail">brandDetail.</param>
        /// <param name="key">工单详情key值.</param>
        public SearchOrderBrandDetail(BrandDetail brandDetail = default(BrandDetail), string key = default(string))
        {
            this.BrandDetail = brandDetail;
            this.Key = key;
        }

        /// <summary>
        /// Gets or Sets BrandDetail
        /// </summary>
        [DataMember(Name = "brand_detail", EmitDefaultValue = false)]
        public BrandDetail BrandDetail { get; set; }

        /// <summary>
        /// 工单详情key值
        /// </summary>
        /// <value>工单详情key值</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchOrderBrandDetail {\n");
            sb.Append("  BrandDetail: ").Append(BrandDetail).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as SearchOrderBrandDetail);
        }

        /// <summary>
        /// Returns true if SearchOrderBrandDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchOrderBrandDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchOrderBrandDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BrandDetail == input.BrandDetail ||
                    (this.BrandDetail != null &&
                    this.BrandDetail.Equals(input.BrandDetail))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.BrandDetail != null)
                {
                    hashCode = (hashCode * 59) + this.BrandDetail.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
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
