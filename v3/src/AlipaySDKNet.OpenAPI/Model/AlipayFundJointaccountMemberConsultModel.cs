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
    /// AlipayFundJointaccountMemberConsultModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountMemberConsultModel")]
    public partial class AlipayFundJointaccountMemberConsultModel : IEquatable<AlipayFundJointaccountMemberConsultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountMemberConsultModel" /> class.
        /// </summary>
        /// <param name="accountId">企业ID.</param>
        /// <param name="agreementNo">协议号.</param>
        /// <param name="businessParams">扩展参数，如需使用请联系支付宝开放同学.</param>
        /// <param name="openIdList">要检查的员工openId.</param>
        /// <param name="userIdList">要检查的员工ID.</param>
        public AlipayFundJointaccountMemberConsultModel(string accountId = default(string), string agreementNo = default(string), string businessParams = default(string), List<string> openIdList = default(List<string>), List<string> userIdList = default(List<string>))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.BusinessParams = businessParams;
            this.OpenIdList = openIdList;
            this.UserIdList = userIdList;
        }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 协议号
        /// </summary>
        /// <value>协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 扩展参数，如需使用请联系支付宝开放同学
        /// </summary>
        /// <value>扩展参数，如需使用请联系支付宝开放同学</value>
        [DataMember(Name = "business_params", EmitDefaultValue = false)]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 要检查的员工openId
        /// </summary>
        /// <value>要检查的员工openId</value>
        [DataMember(Name = "open_id_list", EmitDefaultValue = false)]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// 要检查的员工ID
        /// </summary>
        /// <value>要检查的员工ID</value>
        [DataMember(Name = "user_id_list", EmitDefaultValue = false)]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountMemberConsultModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  BusinessParams: ").Append(BusinessParams).Append("\n");
            sb.Append("  OpenIdList: ").Append(OpenIdList).Append("\n");
            sb.Append("  UserIdList: ").Append(UserIdList).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountMemberConsultModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountMemberConsultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountMemberConsultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountMemberConsultModel input)
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
                    this.BusinessParams == input.BusinessParams ||
                    (this.BusinessParams != null &&
                    this.BusinessParams.Equals(input.BusinessParams))
                ) && 
                (
                    this.OpenIdList == input.OpenIdList ||
                    this.OpenIdList != null &&
                    input.OpenIdList != null &&
                    this.OpenIdList.SequenceEqual(input.OpenIdList)
                ) && 
                (
                    this.UserIdList == input.UserIdList ||
                    this.UserIdList != null &&
                    input.UserIdList != null &&
                    this.UserIdList.SequenceEqual(input.UserIdList)
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
                if (this.BusinessParams != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessParams.GetHashCode();
                }
                if (this.OpenIdList != null)
                {
                    hashCode = (hashCode * 59) + this.OpenIdList.GetHashCode();
                }
                if (this.UserIdList != null)
                {
                    hashCode = (hashCode * 59) + this.UserIdList.GetHashCode();
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
