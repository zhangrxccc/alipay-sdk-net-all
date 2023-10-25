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
    /// AlipayFundAgreementQuotaQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundAgreementQuotaQueryResponseModel")]
    public partial class AlipayFundAgreementQuotaQueryResponseModel : IEquatable<AlipayFundAgreementQuotaQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAgreementQuotaQueryResponseModel" /> class.
        /// </summary>
        /// <param name="quotaQueryResponseList">单个协议的额度查询结果.</param>
        public AlipayFundAgreementQuotaQueryResponseModel(List<QuotaQueryResponse> quotaQueryResponseList = default(List<QuotaQueryResponse>))
        {
            this.QuotaQueryResponseList = quotaQueryResponseList;
        }

        /// <summary>
        /// 单个协议的额度查询结果
        /// </summary>
        /// <value>单个协议的额度查询结果</value>
        [DataMember(Name = "quota_query_response_list", EmitDefaultValue = false)]
        public List<QuotaQueryResponse> QuotaQueryResponseList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAgreementQuotaQueryResponseModel {\n");
            sb.Append("  QuotaQueryResponseList: ").Append(QuotaQueryResponseList).Append("\n");
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
            return this.Equals(input as AlipayFundAgreementQuotaQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAgreementQuotaQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAgreementQuotaQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAgreementQuotaQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuotaQueryResponseList == input.QuotaQueryResponseList ||
                    this.QuotaQueryResponseList != null &&
                    input.QuotaQueryResponseList != null &&
                    this.QuotaQueryResponseList.SequenceEqual(input.QuotaQueryResponseList)
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
                if (this.QuotaQueryResponseList != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaQueryResponseList.GetHashCode();
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
