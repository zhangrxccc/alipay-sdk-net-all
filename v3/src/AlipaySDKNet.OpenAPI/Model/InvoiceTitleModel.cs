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
    /// InvoiceTitleModel
    /// </summary>
    [DataContract(Name = "InvoiceTitleModel")]
    public partial class InvoiceTitleModel : IEquatable<InvoiceTitleModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceTitleModel" /> class.
        /// </summary>
        /// <param name="isDefault">是否为用户设置默认抬头  字段值包括两种情况：  false（非默认）  true（默认抬头）.</param>
        /// <param name="logonId">支付宝用户登录名.</param>
        /// <param name="openBankAccount">银行账号.</param>
        /// <param name="openBankName">开户银行.</param>
        /// <param name="openId">支付宝用户id.</param>
        /// <param name="taxRegisterNo">纳税人识别号.</param>
        /// <param name="telePhoneNo">用户私人手机号.</param>
        /// <param name="titleName">抬头名称.</param>
        /// <param name="titleType">抬头类型  字段值有两种情况抬:  PERSONAL（个人）   CORPORATION（单位）.</param>
        /// <param name="userAddress">地址.</param>
        /// <param name="userEmail">邮箱.</param>
        /// <param name="userId">支付宝用户id.</param>
        /// <param name="userMobile">电话号码.</param>
        public InvoiceTitleModel(bool isDefault = default(bool), string logonId = default(string), string openBankAccount = default(string), string openBankName = default(string), string openId = default(string), string taxRegisterNo = default(string), string telePhoneNo = default(string), string titleName = default(string), string titleType = default(string), string userAddress = default(string), string userEmail = default(string), string userId = default(string), string userMobile = default(string))
        {
            this.IsDefault = isDefault;
            this.LogonId = logonId;
            this.OpenBankAccount = openBankAccount;
            this.OpenBankName = openBankName;
            this.OpenId = openId;
            this.TaxRegisterNo = taxRegisterNo;
            this.TelePhoneNo = telePhoneNo;
            this.TitleName = titleName;
            this.TitleType = titleType;
            this.UserAddress = userAddress;
            this.UserEmail = userEmail;
            this.UserId = userId;
            this.UserMobile = userMobile;
        }

        /// <summary>
        /// 是否为用户设置默认抬头  字段值包括两种情况：  false（非默认）  true（默认抬头）
        /// </summary>
        /// <value>是否为用户设置默认抬头  字段值包括两种情况：  false（非默认）  true（默认抬头）</value>
        [DataMember(Name = "is_default", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 支付宝用户登录名
        /// </summary>
        /// <value>支付宝用户登录名</value>
        [DataMember(Name = "logon_id", EmitDefaultValue = false)]
        public string LogonId { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        /// <value>银行账号</value>
        [DataMember(Name = "open_bank_account", EmitDefaultValue = false)]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        /// <value>开户银行</value>
        [DataMember(Name = "open_bank_name", EmitDefaultValue = false)]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        /// <value>支付宝用户id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        /// <value>纳税人识别号</value>
        [DataMember(Name = "tax_register_no", EmitDefaultValue = false)]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 用户私人手机号
        /// </summary>
        /// <value>用户私人手机号</value>
        [DataMember(Name = "tele_phone_no", EmitDefaultValue = false)]
        public string TelePhoneNo { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        /// <value>抬头名称</value>
        [DataMember(Name = "title_name", EmitDefaultValue = false)]
        public string TitleName { get; set; }

        /// <summary>
        /// 抬头类型  字段值有两种情况抬:  PERSONAL（个人）   CORPORATION（单位）
        /// </summary>
        /// <value>抬头类型  字段值有两种情况抬:  PERSONAL（个人）   CORPORATION（单位）</value>
        [DataMember(Name = "title_type", EmitDefaultValue = false)]
        public string TitleType { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        /// <value>地址</value>
        [DataMember(Name = "user_address", EmitDefaultValue = false)]
        public string UserAddress { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        /// <value>邮箱</value>
        [DataMember(Name = "user_email", EmitDefaultValue = false)]
        public string UserEmail { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        /// <value>支付宝用户id</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        /// <value>电话号码</value>
        [DataMember(Name = "user_mobile", EmitDefaultValue = false)]
        public string UserMobile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceTitleModel {\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  LogonId: ").Append(LogonId).Append("\n");
            sb.Append("  OpenBankAccount: ").Append(OpenBankAccount).Append("\n");
            sb.Append("  OpenBankName: ").Append(OpenBankName).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  TaxRegisterNo: ").Append(TaxRegisterNo).Append("\n");
            sb.Append("  TelePhoneNo: ").Append(TelePhoneNo).Append("\n");
            sb.Append("  TitleName: ").Append(TitleName).Append("\n");
            sb.Append("  TitleType: ").Append(TitleType).Append("\n");
            sb.Append("  UserAddress: ").Append(UserAddress).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserMobile: ").Append(UserMobile).Append("\n");
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
            return this.Equals(input as InvoiceTitleModel);
        }

        /// <summary>
        /// Returns true if InvoiceTitleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceTitleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceTitleModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.LogonId == input.LogonId ||
                    (this.LogonId != null &&
                    this.LogonId.Equals(input.LogonId))
                ) && 
                (
                    this.OpenBankAccount == input.OpenBankAccount ||
                    (this.OpenBankAccount != null &&
                    this.OpenBankAccount.Equals(input.OpenBankAccount))
                ) && 
                (
                    this.OpenBankName == input.OpenBankName ||
                    (this.OpenBankName != null &&
                    this.OpenBankName.Equals(input.OpenBankName))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.TaxRegisterNo == input.TaxRegisterNo ||
                    (this.TaxRegisterNo != null &&
                    this.TaxRegisterNo.Equals(input.TaxRegisterNo))
                ) && 
                (
                    this.TelePhoneNo == input.TelePhoneNo ||
                    (this.TelePhoneNo != null &&
                    this.TelePhoneNo.Equals(input.TelePhoneNo))
                ) && 
                (
                    this.TitleName == input.TitleName ||
                    (this.TitleName != null &&
                    this.TitleName.Equals(input.TitleName))
                ) && 
                (
                    this.TitleType == input.TitleType ||
                    (this.TitleType != null &&
                    this.TitleType.Equals(input.TitleType))
                ) && 
                (
                    this.UserAddress == input.UserAddress ||
                    (this.UserAddress != null &&
                    this.UserAddress.Equals(input.UserAddress))
                ) && 
                (
                    this.UserEmail == input.UserEmail ||
                    (this.UserEmail != null &&
                    this.UserEmail.Equals(input.UserEmail))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserMobile == input.UserMobile ||
                    (this.UserMobile != null &&
                    this.UserMobile.Equals(input.UserMobile))
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
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                if (this.LogonId != null)
                {
                    hashCode = (hashCode * 59) + this.LogonId.GetHashCode();
                }
                if (this.OpenBankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.OpenBankAccount.GetHashCode();
                }
                if (this.OpenBankName != null)
                {
                    hashCode = (hashCode * 59) + this.OpenBankName.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.TaxRegisterNo != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRegisterNo.GetHashCode();
                }
                if (this.TelePhoneNo != null)
                {
                    hashCode = (hashCode * 59) + this.TelePhoneNo.GetHashCode();
                }
                if (this.TitleName != null)
                {
                    hashCode = (hashCode * 59) + this.TitleName.GetHashCode();
                }
                if (this.TitleType != null)
                {
                    hashCode = (hashCode * 59) + this.TitleType.GetHashCode();
                }
                if (this.UserAddress != null)
                {
                    hashCode = (hashCode * 59) + this.UserAddress.GetHashCode();
                }
                if (this.UserEmail != null)
                {
                    hashCode = (hashCode * 59) + this.UserEmail.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.UserMobile != null)
                {
                    hashCode = (hashCode * 59) + this.UserMobile.GetHashCode();
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
