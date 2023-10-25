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
    /// AlipayOpenPublicAccountResetErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicAccountResetErrorResponseModel")]
    public partial class AlipayOpenPublicAccountResetErrorResponseModel : IEquatable<AlipayOpenPublicAccountResetErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum MENUKEYNOTEXIST for value: MENUKEY_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MENUKEY_NOT_EXIST")]
            MENUKEYNOTEXIST = 1,

            /// <summary>
            /// Enum OPENIDISILLEGAL for value: OPEN_ID_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "OPEN_ID_IS_ILLEGAL")]
            OPENIDISILLEGAL = 2,

            /// <summary>
            /// Enum BINDACCOUNTFORMATERROR for value: BIND_ACCOUNT_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "BIND_ACCOUNT_FORMAT_ERROR")]
            BINDACCOUNTFORMATERROR = 3,

            /// <summary>
            /// Enum APPINFOILLEGAL for value: APP_INFO_ILLEGAL
            /// </summary>
            [EnumMember(Value = "APP_INFO_ILLEGAL")]
            APPINFOILLEGAL = 4,

            /// <summary>
            /// Enum AGREEMENTIDNULL for value: AGREEMENT_ID_NULL
            /// </summary>
            [EnumMember(Value = "AGREEMENT_ID_NULL")]
            AGREEMENTIDNULL = 5,

            /// <summary>
            /// Enum FROMUSERIDNULL for value: FROM_USER_ID_NULL
            /// </summary>
            [EnumMember(Value = "FROM_USER_ID_NULL")]
            FROMUSERIDNULL = 6,

            /// <summary>
            /// Enum FORBITREMOVEBINDACCOUNT for value: FORBIT_REMOVE_BIND_ACCOUNT
            /// </summary>
            [EnumMember(Value = "FORBIT_REMOVE_BIND_ACCOUNT")]
            FORBITREMOVEBINDACCOUNT = 7,

            /// <summary>
            /// Enum REMOVEBINDACCOUNTFAIL for value: REMOVE_BIND_ACCOUNT_FAIL
            /// </summary>
            [EnumMember(Value = "REMOVE_BIND_ACCOUNT_FAIL")]
            REMOVEBINDACCOUNTFAIL = 8,

            /// <summary>
            /// Enum DELETETHIRDACCOUNTFAIL for value: DELETE_THIRD_ACCOUNT_FAIL
            /// </summary>
            [EnumMember(Value = "DELETE_THIRD_ACCOUNT_FAIL")]
            DELETETHIRDACCOUNTFAIL = 9,

            /// <summary>
            /// Enum FORBITREMOVEOTHERUSERBINDAC for value: FORBIT_REMOVE_OTHER_USER_BIND_AC
            /// </summary>
            [EnumMember(Value = "FORBIT_REMOVE_OTHER_USER_BIND_AC")]
            FORBITREMOVEOTHERUSERBINDAC = 10,

            /// <summary>
            /// Enum SAVETHIRDACCOUNTFAIL for value: SAVE_THIRD_ACCOUNT_FAIL
            /// </summary>
            [EnumMember(Value = "SAVE_THIRD_ACCOUNT_FAIL")]
            SAVETHIRDACCOUNTFAIL = 11,

            /// <summary>
            /// Enum ADDBINDACCOUNTFAIL for value: ADD_BIND_ACCOUNT_FAIL
            /// </summary>
            [EnumMember(Value = "ADD_BIND_ACCOUNT_FAIL")]
            ADDBINDACCOUNTFAIL = 12,

            /// <summary>
            /// Enum BINDACCOUNTNONULL for value: BIND_ACCOUNT_NO_NULL
            /// </summary>
            [EnumMember(Value = "BIND_ACCOUNT_NO_NULL")]
            BINDACCOUNTNONULL = 13,

            /// <summary>
            /// Enum DISPLAYNAMEISNULL for value: DISPLAY_NAME_IS_NULL
            /// </summary>
            [EnumMember(Value = "DISPLAY_NAME_IS_NULL")]
            DISPLAYNAMEISNULL = 14,

            /// <summary>
            /// Enum DISPLAYNAMEEXCEEDLENGTH for value: DISPLAY_NAME_EXCEED_LENGTH
            /// </summary>
            [EnumMember(Value = "DISPLAY_NAME_EXCEED_LENGTH")]
            DISPLAYNAMEEXCEEDLENGTH = 15,

            /// <summary>
            /// Enum REALNAMEEXCEEDLENGTH for value: REAL_NAME_EXCEED_LENGTH
            /// </summary>
            [EnumMember(Value = "REAL_NAME_EXCEED_LENGTH")]
            REALNAMEEXCEEDLENGTH = 16,

            /// <summary>
            /// Enum EXCEEDTHIRDACCOUNTLIMIT for value: EXCEED_THIRD_ACCOUNT_LIMIT
            /// </summary>
            [EnumMember(Value = "EXCEED_THIRD_ACCOUNT_LIMIT")]
            EXCEEDTHIRDACCOUNTLIMIT = 17,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 18

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicAccountResetErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicAccountResetErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicAccountResetErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicAccountResetErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicAccountResetErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicAccountResetErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicAccountResetErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicAccountResetErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicAccountResetErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicAccountResetErrorResponseModel input)
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
