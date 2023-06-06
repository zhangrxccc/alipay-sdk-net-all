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
    /// OpenAppOperatorVo
    /// </summary>
    [DataContract(Name = "OpenAppOperatorVo")]
    public partial class OpenAppOperatorVo : IEquatable<OpenAppOperatorVo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAppOperatorVo" /> class.
        /// </summary>
        /// <param name="logonId">登录账号.</param>
        /// <param name="nickName">昵称.</param>
        /// <param name="portrait">用户头像.</param>
        /// <param name="role">角色.</param>
        /// <param name="status">状态.</param>
        /// <param name="userId">用户Id.</param>
        public OpenAppOperatorVo(string logonId = default(string), string nickName = default(string), string portrait = default(string), string role = default(string), string status = default(string), string userId = default(string))
        {
            this.LogonId = logonId;
            this.NickName = nickName;
            this.Portrait = portrait;
            this.Role = role;
            this.Status = status;
            this.UserId = userId;
        }

        /// <summary>
        /// 登录账号
        /// </summary>
        /// <value>登录账号</value>
        [DataMember(Name = "logon_id", EmitDefaultValue = false)]
        public string LogonId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        /// <value>昵称</value>
        [DataMember(Name = "nick_name", EmitDefaultValue = false)]
        public string NickName { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        /// <value>用户头像</value>
        [DataMember(Name = "portrait", EmitDefaultValue = false)]
        public string Portrait { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        /// <value>角色</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        /// <value>状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        /// <value>用户Id</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenAppOperatorVo {\n");
            sb.Append("  LogonId: ").Append(LogonId).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
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
            return this.Equals(input as OpenAppOperatorVo);
        }

        /// <summary>
        /// Returns true if OpenAppOperatorVo instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenAppOperatorVo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenAppOperatorVo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                if (this.LogonId != null)
                {
                    hashCode = (hashCode * 59) + this.LogonId.GetHashCode();
                }
                if (this.NickName != null)
                {
                    hashCode = (hashCode * 59) + this.NickName.GetHashCode();
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
