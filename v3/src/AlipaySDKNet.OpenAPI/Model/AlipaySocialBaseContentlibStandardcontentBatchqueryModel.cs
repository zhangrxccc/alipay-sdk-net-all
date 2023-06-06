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
    /// AlipaySocialBaseContentlibStandardcontentBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipaySocialBaseContentlibStandardcontentBatchqueryModel")]
    public partial class AlipaySocialBaseContentlibStandardcontentBatchqueryModel : IEquatable<AlipaySocialBaseContentlibStandardcontentBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySocialBaseContentlibStandardcontentBatchqueryModel" /> class.
        /// </summary>
        /// <param name="needDetail">指示是否返回内容详情,  默认为false false: 仅返回内容ID列表 true:返回 content_details.</param>
        /// <param name="pageNum">当页分页,默认为1.</param>
        /// <param name="pageSize">分页记录数，最大20,默认20.</param>
        /// <param name="publicId">生活号+号ID，只有MCN机构为达人号ID查询内容才需要传入.</param>
        /// <param name="status">内容状态，默认查询所有状态 0-审核中  1-发布成功  2-审核不通过  3-己删除.</param>
        public AlipaySocialBaseContentlibStandardcontentBatchqueryModel(bool needDetail = default(bool), int pageNum = default(int), int pageSize = default(int), string publicId = default(string), string status = default(string))
        {
            this.NeedDetail = needDetail;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.PublicId = publicId;
            this.Status = status;
        }

        /// <summary>
        /// 指示是否返回内容详情,  默认为false false: 仅返回内容ID列表 true:返回 content_details
        /// </summary>
        /// <value>指示是否返回内容详情,  默认为false false: 仅返回内容ID列表 true:返回 content_details</value>
        [DataMember(Name = "need_detail", EmitDefaultValue = true)]
        public bool NeedDetail { get; set; }

        /// <summary>
        /// 当页分页,默认为1
        /// </summary>
        /// <value>当页分页,默认为1</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 分页记录数，最大20,默认20
        /// </summary>
        /// <value>分页记录数，最大20,默认20</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 生活号+号ID，只有MCN机构为达人号ID查询内容才需要传入
        /// </summary>
        /// <value>生活号+号ID，只有MCN机构为达人号ID查询内容才需要传入</value>
        [DataMember(Name = "public_id", EmitDefaultValue = false)]
        public string PublicId { get; set; }

        /// <summary>
        /// 内容状态，默认查询所有状态 0-审核中  1-发布成功  2-审核不通过  3-己删除
        /// </summary>
        /// <value>内容状态，默认查询所有状态 0-审核中  1-发布成功  2-审核不通过  3-己删除</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipaySocialBaseContentlibStandardcontentBatchqueryModel {\n");
            sb.Append("  NeedDetail: ").Append(NeedDetail).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipaySocialBaseContentlibStandardcontentBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipaySocialBaseContentlibStandardcontentBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipaySocialBaseContentlibStandardcontentBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipaySocialBaseContentlibStandardcontentBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NeedDetail == input.NeedDetail ||
                    this.NeedDetail.Equals(input.NeedDetail)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.PublicId == input.PublicId ||
                    (this.PublicId != null &&
                    this.PublicId.Equals(input.PublicId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                hashCode = (hashCode * 59) + this.NeedDetail.GetHashCode();
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.PublicId != null)
                {
                    hashCode = (hashCode * 59) + this.PublicId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
