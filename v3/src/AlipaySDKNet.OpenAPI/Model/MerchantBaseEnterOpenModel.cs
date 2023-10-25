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
    /// MerchantBaseEnterOpenModel
    /// </summary>
    [DataContract(Name = "MerchantBaseEnterOpenModel")]
    public partial class MerchantBaseEnterOpenModel : IEquatable<MerchantBaseEnterOpenModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantBaseEnterOpenModel" /> class.
        /// </summary>
        /// <param name="loginId">登陆账号.</param>
        /// <param name="logoInfo">商户logo文件流信息，该字段为文件流经base64编码后得到的字符串。.</param>
        /// <param name="mName">商户品牌全称。.</param>
        /// <param name="mShortName">商户品牌简称.</param>
        public MerchantBaseEnterOpenModel(string loginId = default(string), string logoInfo = default(string), string mName = default(string), string mShortName = default(string))
        {
            this.LoginId = loginId;
            this.LogoInfo = logoInfo;
            this.MName = mName;
            this.MShortName = mShortName;
        }

        /// <summary>
        /// 登陆账号
        /// </summary>
        /// <value>登陆账号</value>
        [DataMember(Name = "login_id", EmitDefaultValue = false)]
        public string LoginId { get; set; }

        /// <summary>
        /// 商户logo文件流信息，该字段为文件流经base64编码后得到的字符串。
        /// </summary>
        /// <value>商户logo文件流信息，该字段为文件流经base64编码后得到的字符串。</value>
        [DataMember(Name = "logo_info", EmitDefaultValue = false)]
        public string LogoInfo { get; set; }

        /// <summary>
        /// 商户品牌全称。
        /// </summary>
        /// <value>商户品牌全称。</value>
        [DataMember(Name = "m_name", EmitDefaultValue = false)]
        public string MName { get; set; }

        /// <summary>
        /// 商户品牌简称
        /// </summary>
        /// <value>商户品牌简称</value>
        [DataMember(Name = "m_short_name", EmitDefaultValue = false)]
        public string MShortName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantBaseEnterOpenModel {\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  LogoInfo: ").Append(LogoInfo).Append("\n");
            sb.Append("  MName: ").Append(MName).Append("\n");
            sb.Append("  MShortName: ").Append(MShortName).Append("\n");
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
            return this.Equals(input as MerchantBaseEnterOpenModel);
        }

        /// <summary>
        /// Returns true if MerchantBaseEnterOpenModel instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantBaseEnterOpenModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantBaseEnterOpenModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LoginId == input.LoginId ||
                    (this.LoginId != null &&
                    this.LoginId.Equals(input.LoginId))
                ) && 
                (
                    this.LogoInfo == input.LogoInfo ||
                    (this.LogoInfo != null &&
                    this.LogoInfo.Equals(input.LogoInfo))
                ) && 
                (
                    this.MName == input.MName ||
                    (this.MName != null &&
                    this.MName.Equals(input.MName))
                ) && 
                (
                    this.MShortName == input.MShortName ||
                    (this.MShortName != null &&
                    this.MShortName.Equals(input.MShortName))
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
                if (this.LoginId != null)
                {
                    hashCode = (hashCode * 59) + this.LoginId.GetHashCode();
                }
                if (this.LogoInfo != null)
                {
                    hashCode = (hashCode * 59) + this.LogoInfo.GetHashCode();
                }
                if (this.MName != null)
                {
                    hashCode = (hashCode * 59) + this.MName.GetHashCode();
                }
                if (this.MShortName != null)
                {
                    hashCode = (hashCode * 59) + this.MShortName.GetHashCode();
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
