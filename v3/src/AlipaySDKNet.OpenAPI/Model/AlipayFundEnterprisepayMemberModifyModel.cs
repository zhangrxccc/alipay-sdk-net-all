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
    /// AlipayFundEnterprisepayMemberModifyModel
    /// </summary>
    [DataContract(Name = "AlipayFundEnterprisepayMemberModifyModel")]
    public partial class AlipayFundEnterprisepayMemberModifyModel : IEquatable<AlipayFundEnterprisepayMemberModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayMemberModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">企业签约账户ID.</param>
        /// <param name="agreementNo">平台和企业的三方授权协议号.</param>
        /// <param name="bizScene">场景码，联系支付宝分配.</param>
        /// <param name="fundExtInfo">fundExtInfo.</param>
        /// <param name="groupIdList">员工当前关联的群组ID，支持多个.</param>
        /// <param name="openId">蚂蚁统一会员openId.</param>
        /// <param name="operationTypeList">更新操作类型：多个时逗号分隔 GROUP-群组信息 FUND-出资信息 字段不传时，默认全量更新.</param>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY.</param>
        /// <param name="userId">蚂蚁统一会员ID.</param>
        public AlipayFundEnterprisepayMemberModifyModel(string accountId = default(string), string agreementNo = default(string), string bizScene = default(string), FundExtInfo fundExtInfo = default(FundExtInfo), List<string> groupIdList = default(List<string>), string openId = default(string), List<string> operationTypeList = default(List<string>), string productCode = default(string), string userId = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.BizScene = bizScene;
            this.FundExtInfo = fundExtInfo;
            this.GroupIdList = groupIdList;
            this.OpenId = openId;
            this.OperationTypeList = operationTypeList;
            this.ProductCode = productCode;
            this.UserId = userId;
        }

        /// <summary>
        /// 企业签约账户ID
        /// </summary>
        /// <value>企业签约账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 平台和企业的三方授权协议号
        /// </summary>
        /// <value>平台和企业的三方授权协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码，联系支付宝分配
        /// </summary>
        /// <value>场景码，联系支付宝分配</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// Gets or Sets FundExtInfo
        /// </summary>
        [DataMember(Name = "fund_ext_info", EmitDefaultValue = false)]
        public FundExtInfo FundExtInfo { get; set; }

        /// <summary>
        /// 员工当前关联的群组ID，支持多个
        /// </summary>
        /// <value>员工当前关联的群组ID，支持多个</value>
        [DataMember(Name = "group_id_list", EmitDefaultValue = false)]
        public List<string> GroupIdList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员openId
        /// </summary>
        /// <value>蚂蚁统一会员openId</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 更新操作类型：多个时逗号分隔 GROUP-群组信息 FUND-出资信息 字段不传时，默认全量更新
        /// </summary>
        /// <value>更新操作类型：多个时逗号分隔 GROUP-群组信息 FUND-出资信息 字段不传时，默认全量更新</value>
        [DataMember(Name = "operation_type_list", EmitDefaultValue = false)]
        public List<string> OperationTypeList { get; set; }

        /// <summary>
        /// 产品码，默认值 ENTERPRISE_PAY
        /// </summary>
        /// <value>产品码，默认值 ENTERPRISE_PAY</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        /// <value>蚂蚁统一会员ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundEnterprisepayMemberModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  BizScene: ").Append(BizScene).Append("\n");
            sb.Append("  FundExtInfo: ").Append(FundExtInfo).Append("\n");
            sb.Append("  GroupIdList: ").Append(GroupIdList).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OperationTypeList: ").Append(OperationTypeList).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayFundEnterprisepayMemberModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayFundEnterprisepayMemberModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundEnterprisepayMemberModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundEnterprisepayMemberModifyModel input)
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
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.BizScene == input.BizScene ||
                    (this.BizScene != null &&
                    this.BizScene.Equals(input.BizScene))
                ) && 
                (
                    this.FundExtInfo == input.FundExtInfo ||
                    (this.FundExtInfo != null &&
                    this.FundExtInfo.Equals(input.FundExtInfo))
                ) && 
                (
                    this.GroupIdList == input.GroupIdList ||
                    this.GroupIdList != null &&
                    input.GroupIdList != null &&
                    this.GroupIdList.SequenceEqual(input.GroupIdList)
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OperationTypeList == input.OperationTypeList ||
                    this.OperationTypeList != null &&
                    input.OperationTypeList != null &&
                    this.OperationTypeList.SequenceEqual(input.OperationTypeList)
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.BizScene != null)
                {
                    hashCode = (hashCode * 59) + this.BizScene.GetHashCode();
                }
                if (this.FundExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.FundExtInfo.GetHashCode();
                }
                if (this.GroupIdList != null)
                {
                    hashCode = (hashCode * 59) + this.GroupIdList.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OperationTypeList != null)
                {
                    hashCode = (hashCode * 59) + this.OperationTypeList.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
