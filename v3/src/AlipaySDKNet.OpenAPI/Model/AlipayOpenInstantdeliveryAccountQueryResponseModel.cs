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
    /// AlipayOpenInstantdeliveryAccountQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenInstantdeliveryAccountQueryResponseModel")]
    public partial class AlipayOpenInstantdeliveryAccountQueryResponseModel : IEquatable<AlipayOpenInstantdeliveryAccountQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenInstantdeliveryAccountQueryResponseModel" /> class.
        /// </summary>
        /// <param name="balance">账户余额.</param>
        /// <param name="businessLicense">企业营业执照图片正反面.</param>
        /// <param name="businessScope">经营范围.</param>
        /// <param name="creditCode">统一社会信用代码.</param>
        /// <param name="email">联系人邮箱.</param>
        /// <param name="enterpriseAddress">企业地址.</param>
        /// <param name="enterpriseCity">企业所在地，市编码.</param>
        /// <param name="enterpriseDistrict">企业所在地，区编码.</param>
        /// <param name="enterpriseName">企业全称.</param>
        /// <param name="enterpriseProvince">企业所在地，省编码.</param>
        /// <param name="enterpriseType">企业类型.</param>
        /// <param name="logisticsAccountStatus">在配送公司的账户状态信息.</param>
        /// <param name="phone">联系人手机号.</param>
        public AlipayOpenInstantdeliveryAccountQueryResponseModel(string balance = default(string), string businessLicense = default(string), string businessScope = default(string), string creditCode = default(string), string email = default(string), string enterpriseAddress = default(string), string enterpriseCity = default(string), string enterpriseDistrict = default(string), string enterpriseName = default(string), string enterpriseProvince = default(string), string enterpriseType = default(string), List<LogisticsAccountStatusDTO> logisticsAccountStatus = default(List<LogisticsAccountStatusDTO>), string phone = default(string))
        {
            this.Balance = balance;
            this.BusinessLicense = businessLicense;
            this.BusinessScope = businessScope;
            this.CreditCode = creditCode;
            this.Email = email;
            this.EnterpriseAddress = enterpriseAddress;
            this.EnterpriseCity = enterpriseCity;
            this.EnterpriseDistrict = enterpriseDistrict;
            this.EnterpriseName = enterpriseName;
            this.EnterpriseProvince = enterpriseProvince;
            this.EnterpriseType = enterpriseType;
            this.LogisticsAccountStatus = logisticsAccountStatus;
            this.Phone = phone;
        }

        /// <summary>
        /// 账户余额
        /// </summary>
        /// <value>账户余额</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public string Balance { get; set; }

        /// <summary>
        /// 企业营业执照图片正反面
        /// </summary>
        /// <value>企业营业执照图片正反面</value>
        [DataMember(Name = "business_license", EmitDefaultValue = false)]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        /// <value>经营范围</value>
        [DataMember(Name = "business_scope", EmitDefaultValue = false)]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        /// <value>统一社会信用代码</value>
        [DataMember(Name = "credit_code", EmitDefaultValue = false)]
        public string CreditCode { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        /// <value>联系人邮箱</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        /// <value>企业地址</value>
        [DataMember(Name = "enterprise_address", EmitDefaultValue = false)]
        public string EnterpriseAddress { get; set; }

        /// <summary>
        /// 企业所在地，市编码
        /// </summary>
        /// <value>企业所在地，市编码</value>
        [DataMember(Name = "enterprise_city", EmitDefaultValue = false)]
        public string EnterpriseCity { get; set; }

        /// <summary>
        /// 企业所在地，区编码
        /// </summary>
        /// <value>企业所在地，区编码</value>
        [DataMember(Name = "enterprise_district", EmitDefaultValue = false)]
        public string EnterpriseDistrict { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        /// <value>企业全称</value>
        [DataMember(Name = "enterprise_name", EmitDefaultValue = false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 企业所在地，省编码
        /// </summary>
        /// <value>企业所在地，省编码</value>
        [DataMember(Name = "enterprise_province", EmitDefaultValue = false)]
        public string EnterpriseProvince { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        /// <value>企业类型</value>
        [DataMember(Name = "enterprise_type", EmitDefaultValue = false)]
        public string EnterpriseType { get; set; }

        /// <summary>
        /// 在配送公司的账户状态信息
        /// </summary>
        /// <value>在配送公司的账户状态信息</value>
        [DataMember(Name = "logistics_account_status", EmitDefaultValue = false)]
        public List<LogisticsAccountStatusDTO> LogisticsAccountStatus { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        /// <value>联系人手机号</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenInstantdeliveryAccountQueryResponseModel {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  BusinessLicense: ").Append(BusinessLicense).Append("\n");
            sb.Append("  BusinessScope: ").Append(BusinessScope).Append("\n");
            sb.Append("  CreditCode: ").Append(CreditCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EnterpriseAddress: ").Append(EnterpriseAddress).Append("\n");
            sb.Append("  EnterpriseCity: ").Append(EnterpriseCity).Append("\n");
            sb.Append("  EnterpriseDistrict: ").Append(EnterpriseDistrict).Append("\n");
            sb.Append("  EnterpriseName: ").Append(EnterpriseName).Append("\n");
            sb.Append("  EnterpriseProvince: ").Append(EnterpriseProvince).Append("\n");
            sb.Append("  EnterpriseType: ").Append(EnterpriseType).Append("\n");
            sb.Append("  LogisticsAccountStatus: ").Append(LogisticsAccountStatus).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(input as AlipayOpenInstantdeliveryAccountQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenInstantdeliveryAccountQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenInstantdeliveryAccountQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenInstantdeliveryAccountQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.BusinessLicense == input.BusinessLicense ||
                    (this.BusinessLicense != null &&
                    this.BusinessLicense.Equals(input.BusinessLicense))
                ) && 
                (
                    this.BusinessScope == input.BusinessScope ||
                    (this.BusinessScope != null &&
                    this.BusinessScope.Equals(input.BusinessScope))
                ) && 
                (
                    this.CreditCode == input.CreditCode ||
                    (this.CreditCode != null &&
                    this.CreditCode.Equals(input.CreditCode))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EnterpriseAddress == input.EnterpriseAddress ||
                    (this.EnterpriseAddress != null &&
                    this.EnterpriseAddress.Equals(input.EnterpriseAddress))
                ) && 
                (
                    this.EnterpriseCity == input.EnterpriseCity ||
                    (this.EnterpriseCity != null &&
                    this.EnterpriseCity.Equals(input.EnterpriseCity))
                ) && 
                (
                    this.EnterpriseDistrict == input.EnterpriseDistrict ||
                    (this.EnterpriseDistrict != null &&
                    this.EnterpriseDistrict.Equals(input.EnterpriseDistrict))
                ) && 
                (
                    this.EnterpriseName == input.EnterpriseName ||
                    (this.EnterpriseName != null &&
                    this.EnterpriseName.Equals(input.EnterpriseName))
                ) && 
                (
                    this.EnterpriseProvince == input.EnterpriseProvince ||
                    (this.EnterpriseProvince != null &&
                    this.EnterpriseProvince.Equals(input.EnterpriseProvince))
                ) && 
                (
                    this.EnterpriseType == input.EnterpriseType ||
                    (this.EnterpriseType != null &&
                    this.EnterpriseType.Equals(input.EnterpriseType))
                ) && 
                (
                    this.LogisticsAccountStatus == input.LogisticsAccountStatus ||
                    this.LogisticsAccountStatus != null &&
                    input.LogisticsAccountStatus != null &&
                    this.LogisticsAccountStatus.SequenceEqual(input.LogisticsAccountStatus)
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                if (this.BusinessLicense != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicense.GetHashCode();
                }
                if (this.BusinessScope != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessScope.GetHashCode();
                }
                if (this.CreditCode != null)
                {
                    hashCode = (hashCode * 59) + this.CreditCode.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.EnterpriseAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseAddress.GetHashCode();
                }
                if (this.EnterpriseCity != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseCity.GetHashCode();
                }
                if (this.EnterpriseDistrict != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseDistrict.GetHashCode();
                }
                if (this.EnterpriseName != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseName.GetHashCode();
                }
                if (this.EnterpriseProvince != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseProvince.GetHashCode();
                }
                if (this.EnterpriseType != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseType.GetHashCode();
                }
                if (this.LogisticsAccountStatus != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsAccountStatus.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
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
