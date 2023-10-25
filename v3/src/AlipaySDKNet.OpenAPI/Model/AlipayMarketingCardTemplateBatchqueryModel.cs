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
    /// AlipayMarketingCardTemplateBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardTemplateBatchqueryModel")]
    public partial class AlipayMarketingCardTemplateBatchqueryModel : IEquatable<AlipayMarketingCardTemplateBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardTemplateBatchqueryModel" /> class.
        /// </summary>
        /// <param name="pageNo">查询起始页码，第一页为 1。.</param>
        /// <param name="pageSize">每页数据大小，默认 20条，最大支持20条。.</param>
        public AlipayMarketingCardTemplateBatchqueryModel(int pageNo = default(int), int pageSize = default(int))
        {
            this.PageNo = pageNo;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// 查询起始页码，第一页为 1。
        /// </summary>
        /// <value>查询起始页码，第一页为 1。</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public int PageNo { get; set; }

        /// <summary>
        /// 每页数据大小，默认 20条，最大支持20条。
        /// </summary>
        /// <value>每页数据大小，默认 20条，最大支持20条。</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardTemplateBatchqueryModel {\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardTemplateBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardTemplateBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardTemplateBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardTemplateBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageNo == input.PageNo ||
                    this.PageNo.Equals(input.PageNo)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                hashCode = (hashCode * 59) + this.PageNo.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
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
