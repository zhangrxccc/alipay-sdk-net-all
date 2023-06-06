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
    /// AlipayOpenSpIsvSignauthCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpIsvSignauthCreateErrorResponseModel")]
    public partial class AlipayOpenSpIsvSignauthCreateErrorResponseModel : IEquatable<AlipayOpenSpIsvSignauthCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum ILLEGALPARAMS for value: ILLEGAL_PARAMS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_PARAMS")]
            ILLEGALPARAMS = 1,

            /// <summary>
            /// Enum SIGNAUTHMERCHANTNOTEXIST for value: SIGNAUTH_MERCHANT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SIGNAUTH_MERCHANT_NOT_EXIST")]
            SIGNAUTHMERCHANTNOTEXIST = 2,

            /// <summary>
            /// Enum SIGNAUTHISVNOTEXIST for value: SIGNAUTH_ISV_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SIGNAUTH_ISV_NOT_EXIST")]
            SIGNAUTHISVNOTEXIST = 3,

            /// <summary>
            /// Enum SIGNORDERNOTEXSIT for value: SIGNORDER_NOT_EXSIT
            /// </summary>
            [EnumMember(Value = "SIGNORDER_NOT_EXSIT")]
            SIGNORDERNOTEXSIT = 4,

            /// <summary>
            /// Enum SIGNORDERABNORMAL for value: SIGNORDER_ABNORMAL
            /// </summary>
            [EnumMember(Value = "SIGNORDER_ABNORMAL")]
            SIGNORDERABNORMAL = 5,

            /// <summary>
            /// Enum SIGNORDERISVNOTMATCH for value: SIGNORDER_ISV_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "SIGNORDER_ISV_NOT_MATCH")]
            SIGNORDERISVNOTMATCH = 6,

            /// <summary>
            /// Enum SIGNORDERMERCHANTNOTMATCH for value: SIGNORDER_MERCHANT_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "SIGNORDER_MERCHANT_NOT_MATCH")]
            SIGNORDERMERCHANTNOTMATCH = 7,

            /// <summary>
            /// Enum ISVAUTHSCENENOTEXIST for value: ISVAUTH_SCENE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ISVAUTH_SCENE_NOT_EXIST")]
            ISVAUTHSCENENOTEXIST = 8,

            /// <summary>
            /// Enum ISVAUTHSCENEPERMISSIONNOTMATCH for value: ISVAUTH_SCENE_PERMISSION_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "ISVAUTH_SCENE_PERMISSION_NOT_MATCH")]
            ISVAUTHSCENEPERMISSIONNOTMATCH = 9,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 10,

            /// <summary>
            /// Enum SIGNORDERBINDED for value: SIGNORDER_BINDED
            /// </summary>
            [EnumMember(Value = "SIGNORDER_BINDED")]
            SIGNORDERBINDED = 11,

            /// <summary>
            /// Enum APPLYORDERNOTEXIST for value: APPLY_ORDER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APPLY_ORDER_NOT_EXIST")]
            APPLYORDERNOTEXIST = 12,

            /// <summary>
            /// Enum SPDISCARD for value: SP_DISCARD
            /// </summary>
            [EnumMember(Value = "SP_DISCARD")]
            SPDISCARD = 13,

            /// <summary>
            /// Enum ILLEGALISVUSER for value: ILLEGAL_ISV_USER
            /// </summary>
            [EnumMember(Value = "ILLEGAL_ISV_USER")]
            ILLEGALISVUSER = 14,

            /// <summary>
            /// Enum SPPAUSEORDELETE for value: SP_PAUSE_OR_DELETE
            /// </summary>
            [EnumMember(Value = "SP_PAUSE_OR_DELETE")]
            SPPAUSEORDELETE = 15,

            /// <summary>
            /// Enum NOTICEMERCHANTFAIL for value: NOTICE_MERCHANT_FAIL
            /// </summary>
            [EnumMember(Value = "NOTICE_MERCHANT_FAIL")]
            NOTICEMERCHANTFAIL = 16

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpIsvSignauthCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenSpIsvSignauthCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpIsvSignauthCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenSpIsvSignauthCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenSpIsvSignauthCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenSpIsvSignauthCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenSpIsvSignauthCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpIsvSignauthCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpIsvSignauthCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpIsvSignauthCreateErrorResponseModel input)
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
