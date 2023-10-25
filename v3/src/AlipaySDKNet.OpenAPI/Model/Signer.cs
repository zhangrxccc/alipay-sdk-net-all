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
    /// Signer
    /// </summary>
    [DataContract(Name = "Signer")]
    public partial class Signer : IEquatable<Signer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        /// <param name="email">邮箱.</param>
        /// <param name="idNumber">证件号.</param>
        /// <param name="idType">证件类型,详见个人证件类型说明（http://open.esign.cn/docs/xy/%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3/%E9%99%84%E5%BD%95/%E4%B8%AA%E4%BA%BA%E8%AF%81%E4%BB%B6%E7%B1%BB%E5%9E%8B.html），默认CRED_PSN_CH_IDCARD (证件号不为空，则必填).</param>
        /// <param name="mobile">手机号.</param>
        /// <param name="name">姓名.</param>
        /// <param name="userId">支付宝userId.</param>
        public Signer(string email = default(string), string idNumber = default(string), string idType = default(string), string mobile = default(string), string name = default(string), string userId = default(string))
        {
            this.Email = email;
            this.IdNumber = idNumber;
            this.IdType = idType;
            this.Mobile = mobile;
            this.Name = name;
            this.UserId = userId;
        }

        /// <summary>
        /// 邮箱
        /// </summary>
        /// <value>邮箱</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        /// <value>证件号</value>
        [DataMember(Name = "id_number", EmitDefaultValue = false)]
        public string IdNumber { get; set; }

        /// <summary>
        /// 证件类型,详见个人证件类型说明（http://open.esign.cn/docs/xy/%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3/%E9%99%84%E5%BD%95/%E4%B8%AA%E4%BA%BA%E8%AF%81%E4%BB%B6%E7%B1%BB%E5%9E%8B.html），默认CRED_PSN_CH_IDCARD (证件号不为空，则必填)
        /// </summary>
        /// <value>证件类型,详见个人证件类型说明（http://open.esign.cn/docs/xy/%E6%8E%A5%E5%8F%A3%E6%96%87%E6%A1%A3/%E9%99%84%E5%BD%95/%E4%B8%AA%E4%BA%BA%E8%AF%81%E4%BB%B6%E7%B1%BB%E5%9E%8B.html），默认CRED_PSN_CH_IDCARD (证件号不为空，则必填)</value>
        [DataMember(Name = "id_type", EmitDefaultValue = false)]
        public string IdType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value>手机号</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        /// <value>姓名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        /// <value>支付宝userId</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Signer {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Signer);
        }

        /// <summary>
        /// Returns true if Signer instances are equal
        /// </summary>
        /// <param name="input">Instance of Signer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.IdType == input.IdType ||
                    (this.IdType != null &&
                    this.IdType.Equals(input.IdType))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.IdNumber != null)
                {
                    hashCode = (hashCode * 59) + this.IdNumber.GetHashCode();
                }
                if (this.IdType != null)
                {
                    hashCode = (hashCode * 59) + this.IdType.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
