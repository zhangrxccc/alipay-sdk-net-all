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
    /// ChatMessage
    /// </summary>
    [DataContract(Name = "ChatMessage")]
    public partial class ChatMessage : IEquatable<ChatMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="messageContent">消息内容.</param>
        /// <param name="messageType">消息内容类型,默认TEXT,包括: TEXT(文本消息),IMAGE(图片消息),FILE(文件消息).</param>
        /// <param name="sendTime">消息发送时间，按照ISO8601标准表示，比如：2018-12-24T15:38:17.824+08:00.</param>
        /// <param name="userName">发送者名称.</param>
        /// <param name="userType">发送者类型: VISITOR(访客) ,AGENT(在线客服) ,SYSTEM(系统).</param>
        public ChatMessage(string messageContent = default(string), string messageType = default(string), string sendTime = default(string), string userName = default(string), string userType = default(string))
        {
            this.MessageContent = messageContent;
            this.MessageType = messageType;
            this.SendTime = sendTime;
            this.UserName = userName;
            this.UserType = userType;
        }

        /// <summary>
        /// 消息内容
        /// </summary>
        /// <value>消息内容</value>
        [DataMember(Name = "message_content", EmitDefaultValue = false)]
        public string MessageContent { get; set; }

        /// <summary>
        /// 消息内容类型,默认TEXT,包括: TEXT(文本消息),IMAGE(图片消息),FILE(文件消息)
        /// </summary>
        /// <value>消息内容类型,默认TEXT,包括: TEXT(文本消息),IMAGE(图片消息),FILE(文件消息)</value>
        [DataMember(Name = "message_type", EmitDefaultValue = false)]
        public string MessageType { get; set; }

        /// <summary>
        /// 消息发送时间，按照ISO8601标准表示，比如：2018-12-24T15:38:17.824+08:00
        /// </summary>
        /// <value>消息发送时间，按照ISO8601标准表示，比如：2018-12-24T15:38:17.824+08:00</value>
        [DataMember(Name = "send_time", EmitDefaultValue = false)]
        public string SendTime { get; set; }

        /// <summary>
        /// 发送者名称
        /// </summary>
        /// <value>发送者名称</value>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// 发送者类型: VISITOR(访客) ,AGENT(在线客服) ,SYSTEM(系统)
        /// </summary>
        /// <value>发送者类型: VISITOR(访客) ,AGENT(在线客服) ,SYSTEM(系统)</value>
        [DataMember(Name = "user_type", EmitDefaultValue = false)]
        public string UserType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChatMessage {\n");
            sb.Append("  MessageContent: ").Append(MessageContent).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  SendTime: ").Append(SendTime).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
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
            return this.Equals(input as ChatMessage);
        }

        /// <summary>
        /// Returns true if ChatMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ChatMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MessageContent == input.MessageContent ||
                    (this.MessageContent != null &&
                    this.MessageContent.Equals(input.MessageContent))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.SendTime == input.SendTime ||
                    (this.SendTime != null &&
                    this.SendTime.Equals(input.SendTime))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.UserType == input.UserType ||
                    (this.UserType != null &&
                    this.UserType.Equals(input.UserType))
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
                if (this.MessageContent != null)
                {
                    hashCode = (hashCode * 59) + this.MessageContent.GetHashCode();
                }
                if (this.MessageType != null)
                {
                    hashCode = (hashCode * 59) + this.MessageType.GetHashCode();
                }
                if (this.SendTime != null)
                {
                    hashCode = (hashCode * 59) + this.SendTime.GetHashCode();
                }
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                if (this.UserType != null)
                {
                    hashCode = (hashCode * 59) + this.UserType.GetHashCode();
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
