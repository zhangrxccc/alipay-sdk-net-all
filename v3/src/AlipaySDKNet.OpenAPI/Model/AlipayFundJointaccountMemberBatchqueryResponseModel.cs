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
    /// AlipayFundJointaccountMemberBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountMemberBatchqueryResponseModel")]
    public partial class AlipayFundJointaccountMemberBatchqueryResponseModel : IEquatable<AlipayFundJointaccountMemberBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountMemberBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="accountId">共同账户ID.</param>
        /// <param name="memberList">员工列表.</param>
        /// <param name="pageNum">当前页数，使用游标方式查询时，没有该字段.</param>
        /// <param name="pageSize">当前记录数.</param>
        /// <param name="totalCount">总条数.</param>
        /// <param name="totalPageCount">总页数.</param>
        public AlipayFundJointaccountMemberBatchqueryResponseModel(string accountId = default(string), List<JointAccountMemberDTO> memberList = default(List<JointAccountMemberDTO>), string pageNum = default(string), string pageSize = default(string), string totalCount = default(string), string totalPageCount = default(string))
        {
            this.AccountId = accountId;
            this.MemberList = memberList;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
            this.TotalPageCount = totalPageCount;
        }

        /// <summary>
        /// 共同账户ID
        /// </summary>
        /// <value>共同账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 员工列表
        /// </summary>
        /// <value>员工列表</value>
        [DataMember(Name = "member_list", EmitDefaultValue = false)]
        public List<JointAccountMemberDTO> MemberList { get; set; }

        /// <summary>
        /// 当前页数，使用游标方式查询时，没有该字段
        /// </summary>
        /// <value>当前页数，使用游标方式查询时，没有该字段</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public string PageNum { get; set; }

        /// <summary>
        /// 当前记录数
        /// </summary>
        /// <value>当前记录数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        /// <value>总条数</value>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        /// <value>总页数</value>
        [DataMember(Name = "total_page_count", EmitDefaultValue = false)]
        public string TotalPageCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountMemberBatchqueryResponseModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  MemberList: ").Append(MemberList).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  TotalPageCount: ").Append(TotalPageCount).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountMemberBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountMemberBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountMemberBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountMemberBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.MemberList == input.MemberList ||
                    this.MemberList != null &&
                    input.MemberList != null &&
                    this.MemberList.SequenceEqual(input.MemberList)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    (this.PageNum != null &&
                    this.PageNum.Equals(input.PageNum))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.TotalPageCount == input.TotalPageCount ||
                    (this.TotalPageCount != null &&
                    this.TotalPageCount.Equals(input.TotalPageCount))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.MemberList != null)
                {
                    hashCode = (hashCode * 59) + this.MemberList.GetHashCode();
                }
                if (this.PageNum != null)
                {
                    hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                if (this.TotalCount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
                }
                if (this.TotalPageCount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPageCount.GetHashCode();
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
