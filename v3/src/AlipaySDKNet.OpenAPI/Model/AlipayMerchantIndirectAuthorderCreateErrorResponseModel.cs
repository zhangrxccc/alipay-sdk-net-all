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
    /// AlipayMerchantIndirectAuthorderCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantIndirectAuthorderCreateErrorResponseModel")]
    public partial class AlipayMerchantIndirectAuthorderCreateErrorResponseModel : IEquatable<AlipayMerchantIndirectAuthorderCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum AUTHIDENTITYTYPEILLEGAL for value: AUTH_IDENTITY_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "AUTH_IDENTITY_TYPE_ILLEGAL")]
            AUTHIDENTITYTYPEILLEGAL = 1,

            /// <summary>
            /// Enum AUTHORDERCREATEFAILED for value: AUTH_ORDER_CREATE_FAILED
            /// </summary>
            [EnumMember(Value = "AUTH_ORDER_CREATE_FAILED")]
            AUTHORDERCREATEFAILED = 2,

            /// <summary>
            /// Enum AUTHORDERISVHASRISK for value: AUTH_ORDER_ISV_HAS_RISK
            /// </summary>
            [EnumMember(Value = "AUTH_ORDER_ISV_HAS_RISK")]
            AUTHORDERISVHASRISK = 3,

            /// <summary>
            /// Enum DEPENDFAILURE for value: DEPEND_FAILURE
            /// </summary>
            [EnumMember(Value = "DEPEND_FAILURE")]
            DEPENDFAILURE = 4,

            /// <summary>
            /// Enum CREATEORDERINFOFAIL for value: CREATE_ORDER_INFO_FAIL
            /// </summary>
            [EnumMember(Value = "CREATE_ORDER_INFO_FAIL")]
            CREATEORDERINFOFAIL = 5,

            /// <summary>
            /// Enum SERVICEUNAVAILABLE for value: SERVICE_UNAVAILABLE
            /// </summary>
            [EnumMember(Value = "SERVICE_UNAVAILABLE")]
            SERVICEUNAVAILABLE = 6,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 7,

            /// <summary>
            /// Enum LEGALPERSONNAMENOTEQUAL for value: LEGAL_PERSON_NAME_NOT_EQUAL
            /// </summary>
            [EnumMember(Value = "LEGAL_PERSON_NAME_NOT_EQUAL")]
            LEGALPERSONNAMENOTEQUAL = 8,

            /// <summary>
            /// Enum BIZCERTILLEGALCERTNO for value: BIZ_CERT_ILLEGAL_CERT_NO
            /// </summary>
            [EnumMember(Value = "BIZ_CERT_ILLEGAL_CERT_NO")]
            BIZCERTILLEGALCERTNO = 9

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIndirectAuthorderCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayMerchantIndirectAuthorderCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIndirectAuthorderCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayMerchantIndirectAuthorderCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayMerchantIndirectAuthorderCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayMerchantIndirectAuthorderCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayMerchantIndirectAuthorderCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantIndirectAuthorderCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantIndirectAuthorderCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantIndirectAuthorderCreateErrorResponseModel input)
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
