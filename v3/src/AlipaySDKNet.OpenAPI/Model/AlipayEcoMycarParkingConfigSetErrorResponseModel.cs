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
    /// AlipayEcoMycarParkingConfigSetErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingConfigSetErrorResponseModel")]
    public partial class AlipayEcoMycarParkingConfigSetErrorResponseModel : IEquatable<AlipayEcoMycarParkingConfigSetErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum MERCHANTNAMEISEMPTY for value: MERCHANT_NAME_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "MERCHANT_NAME_IS_EMPTY")]
            MERCHANTNAMEISEMPTY = 1,

            /// <summary>
            /// Enum MERCHANTPHONEISEMPTY for value: MERCHANT_PHONE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "MERCHANT_PHONE_IS_EMPTY")]
            MERCHANTPHONEISEMPTY = 2,

            /// <summary>
            /// Enum ACCOUNTNOISEMPTY for value: ACCOUNT_NO_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "ACCOUNT_NO_IS_EMPTY")]
            ACCOUNTNOISEMPTY = 3,

            /// <summary>
            /// Enum INTERFACETYPEISEMPTY for value: INTERFACE_TYPE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "INTERFACE_TYPE_IS_EMPTY")]
            INTERFACETYPEISEMPTY = 4,

            /// <summary>
            /// Enum INTERFACETYPEISILLEGAL for value: INTERFACE_TYPE_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "INTERFACE_TYPE_IS_ILLEGAL")]
            INTERFACETYPEISILLEGAL = 5,

            /// <summary>
            /// Enum INTERFACEURLISEMPTY for value: INTERFACE_URL_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "INTERFACE_URL_IS_EMPTY")]
            INTERFACEURLISEMPTY = 6,

            /// <summary>
            /// Enum INTERFACEURLISILLEGAL for value: INTERFACE_URL_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "INTERFACE_URL_IS_ILLEGAL")]
            INTERFACEURLISILLEGAL = 7,

            /// <summary>
            /// Enum SERVICENAMEISEMPTY for value: SERVICE_NAME_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SERVICE_NAME_IS_EMPTY")]
            SERVICENAMEISEMPTY = 8,

            /// <summary>
            /// Enum SERVICENAMEISILLEGAL for value: SERVICE_NAME_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SERVICE_NAME_IS_ILLEGAL")]
            SERVICENAMEISILLEGAL = 9,

            /// <summary>
            /// Enum INTERFACELISTISEMPTY for value: INTERFACE_LIST_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "INTERFACE_LIST_IS_EMPTY")]
            INTERFACELISTISEMPTY = 10,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 11,

            /// <summary>
            /// Enum MERCHANTLOGOFORMATERROR for value: MERCHANT_LOGO_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "MERCHANT_LOGO_FORMAT_ERROR")]
            MERCHANTLOGOFORMATERROR = 12,

            /// <summary>
            /// Enum MERCHANTLOGOISILLEGAL for value: MERCHANT_LOGO_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MERCHANT_LOGO_IS_ILLEGAL")]
            MERCHANTLOGOISILLEGAL = 13,

            /// <summary>
            /// Enum MERCHANTLOGOUPLOADERROR for value: MERCHANT_LOGO_UPLOAD_ERROR
            /// </summary>
            [EnumMember(Value = "MERCHANT_LOGO_UPLOAD_ERROR")]
            MERCHANTLOGOUPLOADERROR = 14,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 15

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingConfigSetErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayEcoMycarParkingConfigSetErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingConfigSetErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayEcoMycarParkingConfigSetErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayEcoMycarParkingConfigSetErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayEcoMycarParkingConfigSetErrorResponseModel {\n");
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
            return this.Equals(input as AlipayEcoMycarParkingConfigSetErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingConfigSetErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingConfigSetErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingConfigSetErrorResponseModel input)
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
