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
    /// AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel")]
    public partial class AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel : IEquatable<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="billList">返回账单列表.</param>
        /// <param name="bizScene">业务场景.</param>
        /// <param name="enterpriseId">企业ID，和接口入参一致.</param>
        /// <param name="hasNextPage">是否有下一页.</param>
        /// <param name="pageNum">当期页数.</param>
        /// <param name="pageSize">当期页记录数.</param>
        public AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel(List<JointAccountBillDetail> billList = default(List<JointAccountBillDetail>), string bizScene = default(string), string enterpriseId = default(string), bool hasNextPage = default(bool), string pageNum = default(string), string pageSize = default(string))
        {
            this.BillList = billList;
            this.BizScene = bizScene;
            this.EnterpriseId = enterpriseId;
            this.HasNextPage = hasNextPage;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// 返回账单列表
        /// </summary>
        /// <value>返回账单列表</value>
        [DataMember(Name = "bill_list", EmitDefaultValue = false)]
        public List<JointAccountBillDetail> BillList { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        /// <value>业务场景</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// 企业ID，和接口入参一致
        /// </summary>
        /// <value>企业ID，和接口入参一致</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        /// <value>是否有下一页</value>
        [DataMember(Name = "has_next_page", EmitDefaultValue = true)]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 当期页数
        /// </summary>
        /// <value>当期页数</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public string PageNum { get; set; }

        /// <summary>
        /// 当期页记录数
        /// </summary>
        /// <value>当期页记录数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel {\n");
            sb.Append("  BillList: ").Append(BillList).Append("\n");
            sb.Append("  BizScene: ").Append(BizScene).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  HasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillList == input.BillList ||
                    this.BillList != null &&
                    input.BillList != null &&
                    this.BillList.SequenceEqual(input.BillList)
                ) && 
                (
                    this.BizScene == input.BizScene ||
                    (this.BizScene != null &&
                    this.BizScene.Equals(input.BizScene))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.HasNextPage == input.HasNextPage ||
                    this.HasNextPage.Equals(input.HasNextPage)
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
                if (this.BillList != null)
                {
                    hashCode = (hashCode * 59) + this.BillList.GetHashCode();
                }
                if (this.BizScene != null)
                {
                    hashCode = (hashCode * 59) + this.BizScene.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasNextPage.GetHashCode();
                if (this.PageNum != null)
                {
                    hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
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
