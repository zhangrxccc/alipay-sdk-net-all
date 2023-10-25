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
    /// AlipayOpenAuthTokenAppModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAuthTokenAppModel")]
    public partial class AlipayOpenAuthTokenAppModel : IEquatable<AlipayOpenAuthTokenAppModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAuthTokenAppModel" /> class.
        /// </summary>
        /// <param name="code">应用授权码，传入应用授权后得到的  app_auth_code。 说明： grant_type 为 authorization_code 时，本参数必填； grant_type 为 refresh_token 时不填。.</param>
        /// <param name="grantType">授权方式。支持： authorization_code：使用应用授权码换取应用授权令牌app_auth_token。 refresh_token：使用app_refresh_token刷新获取新授权令牌。 .</param>
        /// <param name="refreshToken">刷新令牌，上次换取访问令牌时得到。本参数在 grant_type 为 authorization_code 时不填；为 refresh_token 时必填，且该值来源于此接口的返回值 app_refresh_token（即至少需要通过 grant_type&#x3D;authorization_code 调用此接口一次才能获取）。.</param>
        public AlipayOpenAuthTokenAppModel(string code = default(string), string grantType = default(string), string refreshToken = default(string))
        {
            this.Code = code;
            this.GrantType = grantType;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// 应用授权码，传入应用授权后得到的  app_auth_code。 说明： grant_type 为 authorization_code 时，本参数必填； grant_type 为 refresh_token 时不填。
        /// </summary>
        /// <value>应用授权码，传入应用授权后得到的  app_auth_code。 说明： grant_type 为 authorization_code 时，本参数必填； grant_type 为 refresh_token 时不填。</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 授权方式。支持： authorization_code：使用应用授权码换取应用授权令牌app_auth_token。 refresh_token：使用app_refresh_token刷新获取新授权令牌。 
        /// </summary>
        /// <value>授权方式。支持： authorization_code：使用应用授权码换取应用授权令牌app_auth_token。 refresh_token：使用app_refresh_token刷新获取新授权令牌。 </value>
        [DataMember(Name = "grant_type", EmitDefaultValue = false)]
        public string GrantType { get; set; }

        /// <summary>
        /// 刷新令牌，上次换取访问令牌时得到。本参数在 grant_type 为 authorization_code 时不填；为 refresh_token 时必填，且该值来源于此接口的返回值 app_refresh_token（即至少需要通过 grant_type&#x3D;authorization_code 调用此接口一次才能获取）。
        /// </summary>
        /// <value>刷新令牌，上次换取访问令牌时得到。本参数在 grant_type 为 authorization_code 时不填；为 refresh_token 时必填，且该值来源于此接口的返回值 app_refresh_token（即至少需要通过 grant_type&#x3D;authorization_code 调用此接口一次才能获取）。</value>
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAuthTokenAppModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
            return this.Equals(input as AlipayOpenAuthTokenAppModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAuthTokenAppModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAuthTokenAppModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAuthTokenAppModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.GrantType == input.GrantType ||
                    (this.GrantType != null &&
                    this.GrantType.Equals(input.GrantType))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.GrantType != null)
                {
                    hashCode = (hashCode * 59) + this.GrantType.GetHashCode();
                }
                if (this.RefreshToken != null)
                {
                    hashCode = (hashCode * 59) + this.RefreshToken.GetHashCode();
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
