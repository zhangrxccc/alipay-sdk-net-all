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
    /// AlipayOpenAppMiniTemplatemessageSendErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppMiniTemplatemessageSendErrorResponseModel")]
    public partial class AlipayOpenAppMiniTemplatemessageSendErrorResponseModel : IEquatable<AlipayOpenAppMiniTemplatemessageSendErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum FORMIDSENDLIMIT for value: FORM_ID_SEND_LIMIT
            /// </summary>
            [EnumMember(Value = "FORM_ID_SEND_LIMIT")]
            FORMIDSENDLIMIT = 1,

            /// <summary>
            /// Enum TEMPLATEILLEGAL for value: TEMPLATE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "TEMPLATE_ILLEGAL")]
            TEMPLATEILLEGAL = 2,

            /// <summary>
            /// Enum MESSAGETEMPLATEKEYWORDILLEGAL for value: MESSAGE_TEMPLATE_KEYWORD_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MESSAGE_TEMPLATE_KEYWORD_ILLEGAL")]
            MESSAGETEMPLATEKEYWORDILLEGAL = 3,

            /// <summary>
            /// Enum USERTEMPLATEILLEGAL for value: USER_TEMPLATE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "USER_TEMPLATE_ILLEGAL")]
            USERTEMPLATEILLEGAL = 4,

            /// <summary>
            /// Enum USERTEMPLATELACKKEYWORD for value: USER_TEMPLATE_LACK_KEYWORD
            /// </summary>
            [EnumMember(Value = "USER_TEMPLATE_LACK_KEYWORD")]
            USERTEMPLATELACKKEYWORD = 5,

            /// <summary>
            /// Enum FORMIDINVALID for value: FORM_ID_INVALID
            /// </summary>
            [EnumMember(Value = "FORM_ID_INVALID")]
            FORMIDINVALID = 6,

            /// <summary>
            /// Enum FORMIDNOTMATCHAPPID for value: FORM_ID_NOT_MATCH_APPID
            /// </summary>
            [EnumMember(Value = "FORM_ID_NOT_MATCH_APPID")]
            FORMIDNOTMATCHAPPID = 7,

            /// <summary>
            /// Enum FORMIDOVERTIME for value: FORM_ID_OVER_TIME
            /// </summary>
            [EnumMember(Value = "FORM_ID_OVER_TIME")]
            FORMIDOVERTIME = 8,

            /// <summary>
            /// Enum USERKEYWORDLENGTHERROR for value: USER_KEYWORD_LENGTH_ERROR
            /// </summary>
            [EnumMember(Value = "USER_KEYWORD_LENGTH_ERROR")]
            USERKEYWORDLENGTHERROR = 9,

            /// <summary>
            /// Enum PAGEOVERLIMIT for value: PAGE_OVER_LIMIT
            /// </summary>
            [EnumMember(Value = "PAGE_OVER_LIMIT")]
            PAGEOVERLIMIT = 10,

            /// <summary>
            /// Enum TRADENONOTMATCHUSERID for value: TRADE_NO_NOT_MATCH_USERID
            /// </summary>
            [EnumMember(Value = "TRADE_NO_NOT_MATCH_USERID")]
            TRADENONOTMATCHUSERID = 11,

            /// <summary>
            /// Enum QUERYCONSUMERREQEUSTERROR for value: QUERY_CONSUMER_REQEUST_ERROR
            /// </summary>
            [EnumMember(Value = "QUERY_CONSUMER_REQEUST_ERROR")]
            QUERYCONSUMERREQEUSTERROR = 12,

            /// <summary>
            /// Enum BIZCONTENTFORMATERROR for value: BIZ_CONTENT_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_CONTENT_FORMAT_ERROR")]
            BIZCONTENTFORMATERROR = 13,

            /// <summary>
            /// Enum DATACONTENTFORMATERROR for value: DATA_CONTENT_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "DATA_CONTENT_FORMAT_ERROR")]
            DATACONTENTFORMATERROR = 14,

            /// <summary>
            /// Enum DATASENSITIVE for value: DATA_SENSITIVE
            /// </summary>
            [EnumMember(Value = "DATA_SENSITIVE")]
            DATASENSITIVE = 15,

            /// <summary>
            /// Enum USERIDINVALID for value: USER_ID_INVALID
            /// </summary>
            [EnumMember(Value = "USER_ID_INVALID")]
            USERIDINVALID = 16,

            /// <summary>
            /// Enum NOBINDPUBLICAPP for value: NO_BIND_PUBLIC_APP
            /// </summary>
            [EnumMember(Value = "NO_BIND_PUBLIC_APP")]
            NOBINDPUBLICAPP = 17,

            /// <summary>
            /// Enum MESSAGESENDAUTHERROR for value: MESSAGE_SEND_AUTH_ERROR
            /// </summary>
            [EnumMember(Value = "MESSAGE_SEND_AUTH_ERROR")]
            MESSAGESENDAUTHERROR = 18,

            /// <summary>
            /// Enum USERTEMPLATESTATUSILLEGAL for value: USER_TEMPLATE_STATUS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "USER_TEMPLATE_STATUS_ILLEGAL")]
            USERTEMPLATESTATUSILLEGAL = 19,

            /// <summary>
            /// Enum APPTYPEERROR for value: APP_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "APP_TYPE_ERROR")]
            APPTYPEERROR = 20,

            /// <summary>
            /// Enum MSGSENDERROR for value: MSG_SEND_ERROR
            /// </summary>
            [EnumMember(Value = "MSG_SEND_ERROR")]
            MSGSENDERROR = 21,

            /// <summary>
            /// Enum ILLEGALARGUMENTPARAMS for value: ILLEGAL_ARGUMENT_PARAMS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_ARGUMENT_PARAMS")]
            ILLEGALARGUMENTPARAMS = 22,

            /// <summary>
            /// Enum NORECENTVISITRECORD for value: NO_RECENT_VISIT_RECORD
            /// </summary>
            [EnumMember(Value = "NO_RECENT_VISIT_RECORD")]
            NORECENTVISITRECORD = 23,

            /// <summary>
            /// Enum MSGSINGLESDOVER for value: MSG_SINGLE_SD_OVER
            /// </summary>
            [EnumMember(Value = "MSG_SINGLE_SD_OVER")]
            MSGSINGLESDOVER = 24,

            /// <summary>
            /// Enum NOPLACEORDERRECORD for value: NO_PLACE_ORDER_RECORD
            /// </summary>
            [EnumMember(Value = "NO_PLACE_ORDER_RECORD")]
            NOPLACEORDERRECORD = 25,

            /// <summary>
            /// Enum MSGUNSUBSCRIBED for value: MSG_UNSUBSCRIBED
            /// </summary>
            [EnumMember(Value = "MSG_UNSUBSCRIBED")]
            MSGUNSUBSCRIBED = 26,

            /// <summary>
            /// Enum MSGCONTENTNOTINTERESTED for value: MSG_CONTENT_NOT_INTERESTED
            /// </summary>
            [EnumMember(Value = "MSG_CONTENT_NOT_INTERESTED")]
            MSGCONTENTNOTINTERESTED = 27,

            /// <summary>
            /// Enum MSGREJECTED for value: MSG_REJECTED
            /// </summary>
            [EnumMember(Value = "MSG_REJECTED")]
            MSGREJECTED = 28,

            /// <summary>
            /// Enum MSGTEMPLATEIDVALID for value: MSG_TEMPLATE_ID_VALID
            /// </summary>
            [EnumMember(Value = "MSG_TEMPLATE_ID_VALID")]
            MSGTEMPLATEIDVALID = 29,

            /// <summary>
            /// Enum DATAISEMPTY for value: DATA_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "DATA_IS_EMPTY")]
            DATAISEMPTY = 30,

            /// <summary>
            /// Enum MSGUNAUTHORIZED for value: MSG_UNAUTHORIZED
            /// </summary>
            [EnumMember(Value = "MSG_UNAUTHORIZED")]
            MSGUNAUTHORIZED = 31,

            /// <summary>
            /// Enum APPNOAVAIABLE for value: APP_NO_AVAIABLE
            /// </summary>
            [EnumMember(Value = "APP_NO_AVAIABLE")]
            APPNOAVAIABLE = 32

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppMiniTemplatemessageSendErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenAppMiniTemplatemessageSendErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppMiniTemplatemessageSendErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenAppMiniTemplatemessageSendErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenAppMiniTemplatemessageSendErrorResponseModel and cannot be null");
            // }
            this.Message = message;
            this.Links = links;
        }

        /// <summary>
        /// 解决方案链接
        /// </summary>
        /// <value>解决方案链接</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public string Links { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>错误描述</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAppMiniTemplatemessageSendErrorResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlipayOpenAppMiniTemplatemessageSendErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppMiniTemplatemessageSendErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppMiniTemplatemessageSendErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppMiniTemplatemessageSendErrorResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
