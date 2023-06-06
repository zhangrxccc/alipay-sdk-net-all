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
    /// MemberStatusRespDTO
    /// </summary>
    [DataContract(Name = "MemberStatusRespDTO")]
    public partial class MemberStatusRespDTO : IEquatable<MemberStatusRespDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberStatusRespDTO" /> class.
        /// </summary>
        /// <param name="openId">用户支付宝会员openid.</param>
        /// <param name="status">员工当前状态： 邀请中（PROCESSING）、正常（NORMAL）、不在企业中（OUT）.</param>
        /// <param name="userId">用户支付宝2088会员号.</param>
        public MemberStatusRespDTO(string openId = default(string), string status = default(string), string userId = default(string))
        {
            this.OpenId = openId;
            this.Status = status;
            this.UserId = userId;
        }

        /// <summary>
        /// 用户支付宝会员openid
        /// </summary>
        /// <value>用户支付宝会员openid</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 员工当前状态： 邀请中（PROCESSING）、正常（NORMAL）、不在企业中（OUT）
        /// </summary>
        /// <value>员工当前状态： 邀请中（PROCESSING）、正常（NORMAL）、不在企业中（OUT）</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 用户支付宝2088会员号
        /// </summary>
        /// <value>用户支付宝2088会员号</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MemberStatusRespDTO {\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as MemberStatusRespDTO);
        }

        /// <summary>
        /// Returns true if MemberStatusRespDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberStatusRespDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberStatusRespDTO input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
