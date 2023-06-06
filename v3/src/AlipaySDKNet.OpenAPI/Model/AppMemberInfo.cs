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
    /// AppMemberInfo
    /// </summary>
    [DataContract(Name = "AppMemberInfo")]
    public partial class AppMemberInfo : IEquatable<AppMemberInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppMemberInfo" /> class.
        /// </summary>
        /// <param name="gmtInvite">邀请时间.</param>
        /// <param name="gmtJoin">加入时间.</param>
        /// <param name="logonId">支付宝登录账号.</param>
        /// <param name="nickName">昵称.</param>
        /// <param name="openId">支付宝用户openId.</param>
        /// <param name="portrait">头像地址.</param>
        /// <param name="role">角色类型.</param>
        /// <param name="status">成员的状态，VALID-有效，UNCONFIRMED-未确认，TIMEOUT-已经失效，REFUSED-用户拒绝.</param>
        /// <param name="userId">支付宝用户id.</param>
        public AppMemberInfo(string gmtInvite = default(string), string gmtJoin = default(string), string logonId = default(string), string nickName = default(string), string openId = default(string), string portrait = default(string), string role = default(string), string status = default(string), string userId = default(string))
        {
            this.GmtInvite = gmtInvite;
            this.GmtJoin = gmtJoin;
            this.LogonId = logonId;
            this.NickName = nickName;
            this.OpenId = openId;
            this.Portrait = portrait;
            this.Role = role;
            this.Status = status;
            this.UserId = userId;
        }

        /// <summary>
        /// 邀请时间
        /// </summary>
        /// <value>邀请时间</value>
        [DataMember(Name = "gmt_invite", EmitDefaultValue = false)]
        public string GmtInvite { get; set; }

        /// <summary>
        /// 加入时间
        /// </summary>
        /// <value>加入时间</value>
        [DataMember(Name = "gmt_join", EmitDefaultValue = false)]
        public string GmtJoin { get; set; }

        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        /// <value>支付宝登录账号</value>
        [DataMember(Name = "logon_id", EmitDefaultValue = false)]
        public string LogonId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        /// <value>昵称</value>
        [DataMember(Name = "nick_name", EmitDefaultValue = false)]
        public string NickName { get; set; }

        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        /// <value>支付宝用户openId</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        /// <value>头像地址</value>
        [DataMember(Name = "portrait", EmitDefaultValue = false)]
        public string Portrait { get; set; }

        /// <summary>
        /// 角色类型
        /// </summary>
        /// <value>角色类型</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// 成员的状态，VALID-有效，UNCONFIRMED-未确认，TIMEOUT-已经失效，REFUSED-用户拒绝
        /// </summary>
        /// <value>成员的状态，VALID-有效，UNCONFIRMED-未确认，TIMEOUT-已经失效，REFUSED-用户拒绝</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        /// <value>支付宝用户id</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppMemberInfo {\n");
            sb.Append("  GmtInvite: ").Append(GmtInvite).Append("\n");
            sb.Append("  GmtJoin: ").Append(GmtJoin).Append("\n");
            sb.Append("  LogonId: ").Append(LogonId).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  Portrait: ").Append(Portrait).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as AppMemberInfo);
        }

        /// <summary>
        /// Returns true if AppMemberInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AppMemberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppMemberInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GmtInvite == input.GmtInvite ||
                    (this.GmtInvite != null &&
                    this.GmtInvite.Equals(input.GmtInvite))
                ) && 
                (
                    this.GmtJoin == input.GmtJoin ||
                    (this.GmtJoin != null &&
                    this.GmtJoin.Equals(input.GmtJoin))
                ) && 
                (
                    this.LogonId == input.LogonId ||
                    (this.LogonId != null &&
                    this.LogonId.Equals(input.LogonId))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.Portrait == input.Portrait ||
                    (this.Portrait != null &&
                    this.Portrait.Equals(input.Portrait))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.GmtInvite != null)
                {
                    hashCode = (hashCode * 59) + this.GmtInvite.GetHashCode();
                }
                if (this.GmtJoin != null)
                {
                    hashCode = (hashCode * 59) + this.GmtJoin.GetHashCode();
                }
                if (this.LogonId != null)
                {
                    hashCode = (hashCode * 59) + this.LogonId.GetHashCode();
                }
                if (this.NickName != null)
                {
                    hashCode = (hashCode * 59) + this.NickName.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.Portrait != null)
                {
                    hashCode = (hashCode * 59) + this.Portrait.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
