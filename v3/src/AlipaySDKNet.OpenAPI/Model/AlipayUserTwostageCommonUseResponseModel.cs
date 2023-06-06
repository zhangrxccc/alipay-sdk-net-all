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
    /// AlipayUserTwostageCommonUseResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserTwostageCommonUseResponseModel")]
    public partial class AlipayUserTwostageCommonUseResponseModel : IEquatable<AlipayUserTwostageCommonUseResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserTwostageCommonUseResponseModel" /> class.
        /// </summary>
        /// <param name="openId">open_id.</param>
        /// <param name="userId">支付宝用户userId信息，因为用户已经在客户端给商户的小程序授权了，并且商户要通过userId信息挂接优惠券信息，所以可以无需脱敏返回给商户。.</param>
        /// <param name="userIdentityInfo">userIdentityInfo.</param>
        public AlipayUserTwostageCommonUseResponseModel(string openId = default(string), string userId = default(string), UserIdentityInfo userIdentityInfo = default(UserIdentityInfo))
        {
            this.OpenId = openId;
            this.UserId = userId;
            this.UserIdentityInfo = userIdentityInfo;
        }

        /// <summary>
        /// open_id
        /// </summary>
        /// <value>open_id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户userId信息，因为用户已经在客户端给商户的小程序授权了，并且商户要通过userId信息挂接优惠券信息，所以可以无需脱敏返回给商户。
        /// </summary>
        /// <value>支付宝用户userId信息，因为用户已经在客户端给商户的小程序授权了，并且商户要通过userId信息挂接优惠券信息，所以可以无需脱敏返回给商户。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserIdentityInfo
        /// </summary>
        [DataMember(Name = "user_identity_info", EmitDefaultValue = false)]
        public UserIdentityInfo UserIdentityInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserTwostageCommonUseResponseModel {\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserIdentityInfo: ").Append(UserIdentityInfo).Append("\n");
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
            return this.Equals(input as AlipayUserTwostageCommonUseResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserTwostageCommonUseResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserTwostageCommonUseResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserTwostageCommonUseResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserIdentityInfo == input.UserIdentityInfo ||
                    (this.UserIdentityInfo != null &&
                    this.UserIdentityInfo.Equals(input.UserIdentityInfo))
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
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.UserIdentityInfo != null)
                {
                    hashCode = (hashCode * 59) + this.UserIdentityInfo.GetHashCode();
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
