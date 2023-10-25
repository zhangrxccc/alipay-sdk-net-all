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
    /// IndirectFinancialOrgInfo
    /// </summary>
    [DataContract(Name = "IndirectFinancialOrgInfo")]
    public partial class IndirectFinancialOrgInfo : IEquatable<IndirectFinancialOrgInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndirectFinancialOrgInfo" /> class.
        /// </summary>
        /// <param name="financialOrgCertImg">金融机构许可证图片，最多五张（使用图片上传接口）.</param>
        /// <param name="financialOrgType">银行业(BANK)、支付机构(PAYMENT)、保险业(INSURANCE)、交易及结算类金融机构(SETTLE)、OTHER(OTHER).</param>
        public IndirectFinancialOrgInfo(List<string> financialOrgCertImg = default(List<string>), string financialOrgType = default(string))
        {
            this.FinancialOrgCertImg = financialOrgCertImg;
            this.FinancialOrgType = financialOrgType;
        }

        /// <summary>
        /// 金融机构许可证图片，最多五张（使用图片上传接口）
        /// </summary>
        /// <value>金融机构许可证图片，最多五张（使用图片上传接口）</value>
        [DataMember(Name = "financial_org_cert_img", EmitDefaultValue = false)]
        public List<string> FinancialOrgCertImg { get; set; }

        /// <summary>
        /// 银行业(BANK)、支付机构(PAYMENT)、保险业(INSURANCE)、交易及结算类金融机构(SETTLE)、OTHER(OTHER)
        /// </summary>
        /// <value>银行业(BANK)、支付机构(PAYMENT)、保险业(INSURANCE)、交易及结算类金融机构(SETTLE)、OTHER(OTHER)</value>
        [DataMember(Name = "financial_org_type", EmitDefaultValue = false)]
        public string FinancialOrgType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndirectFinancialOrgInfo {\n");
            sb.Append("  FinancialOrgCertImg: ").Append(FinancialOrgCertImg).Append("\n");
            sb.Append("  FinancialOrgType: ").Append(FinancialOrgType).Append("\n");
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
            return this.Equals(input as IndirectFinancialOrgInfo);
        }

        /// <summary>
        /// Returns true if IndirectFinancialOrgInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IndirectFinancialOrgInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndirectFinancialOrgInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FinancialOrgCertImg == input.FinancialOrgCertImg ||
                    this.FinancialOrgCertImg != null &&
                    input.FinancialOrgCertImg != null &&
                    this.FinancialOrgCertImg.SequenceEqual(input.FinancialOrgCertImg)
                ) && 
                (
                    this.FinancialOrgType == input.FinancialOrgType ||
                    (this.FinancialOrgType != null &&
                    this.FinancialOrgType.Equals(input.FinancialOrgType))
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
                if (this.FinancialOrgCertImg != null)
                {
                    hashCode = (hashCode * 59) + this.FinancialOrgCertImg.GetHashCode();
                }
                if (this.FinancialOrgType != null)
                {
                    hashCode = (hashCode * 59) + this.FinancialOrgType.GetHashCode();
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
