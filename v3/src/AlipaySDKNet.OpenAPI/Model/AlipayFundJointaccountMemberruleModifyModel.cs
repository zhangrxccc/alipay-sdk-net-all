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
    /// AlipayFundJointaccountMemberruleModifyModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountMemberruleModifyModel")]
    public partial class AlipayFundJointaccountMemberruleModifyModel : IEquatable<AlipayFundJointaccountMemberruleModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountMemberruleModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">账户ID.</param>
        /// <param name="agreementNo">授权协议号.</param>
        /// <param name="bizScene">业务场景.</param>
        /// <param name="memberList">memberList.</param>
        /// <param name="productCode">产品码.</param>
        public AlipayFundJointaccountMemberruleModifyModel(string accountId = default(string), string agreementNo = default(string), string bizScene = default(string), JointAccountMemberList memberList = default(JointAccountMemberList), string productCode = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.BizScene = bizScene;
            this.MemberList = memberList;
            this.ProductCode = productCode;
        }

        /// <summary>
        /// 账户ID
        /// </summary>
        /// <value>账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权协议号
        /// </summary>
        /// <value>授权协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        /// <value>业务场景</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// Gets or Sets MemberList
        /// </summary>
        [DataMember(Name = "member_list", EmitDefaultValue = false)]
        public JointAccountMemberList MemberList { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        /// <value>产品码</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountMemberruleModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  BizScene: ").Append(BizScene).Append("\n");
            sb.Append("  MemberList: ").Append(MemberList).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountMemberruleModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountMemberruleModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountMemberruleModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountMemberruleModifyModel input)
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
                    this.MemberList == input.MemberList ||
                    (this.MemberList != null &&
                    this.MemberList.Equals(input.MemberList))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
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
                if (this.MemberList != null)
                {
                    hashCode = (hashCode * 59) + this.MemberList.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
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
