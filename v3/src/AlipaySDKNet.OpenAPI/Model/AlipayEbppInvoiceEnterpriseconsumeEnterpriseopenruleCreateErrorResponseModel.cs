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
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel")]
    public partial class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel : IEquatable<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum PARAMETERILLEGAL for value: PARAMETER_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PARAMETER_ILLEGAL")]
            PARAMETERILLEGAL = 1,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 2,

            /// <summary>
            /// Enum PERMISSIONDENIED for value: PERMISSION_DENIED
            /// </summary>
            [EnumMember(Value = "PERMISSION_DENIED")]
            PERMISSIONDENIED = 3,

            /// <summary>
            /// Enum ENTERPRISETITLENOTEXISTS for value: ENTERPRISE_TITLE_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "ENTERPRISE_TITLE_NOT_EXISTS")]
            ENTERPRISETITLENOTEXISTS = 4,

            /// <summary>
            /// Enum INVOICERULENAMEEXIST for value: INVOICE_RULE_NAME_EXIST
            /// </summary>
            [EnumMember(Value = "INVOICE_RULE_NAME_EXIST")]
            INVOICERULENAMEEXIST = 5,

            /// <summary>
            /// Enum INVOICERULENAMETOOLONG for value: INVOICE_RULE_NAME_TOO_LONG
            /// </summary>
            [EnumMember(Value = "INVOICE_RULE_NAME_TOO_LONG")]
            INVOICERULENAMETOOLONG = 6,

            /// <summary>
            /// Enum INVOICERULENAMEILLEGAL for value: INVOICE_RULE_NAME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "INVOICE_RULE_NAME_ILLEGAL")]
            INVOICERULENAMEILLEGAL = 7,

            /// <summary>
            /// Enum BILLMONTHDAYILLEGAL for value: BILL_MONTH_DAY_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BILL_MONTH_DAY_ILLEGAL")]
            BILLMONTHDAYILLEGAL = 8,

            /// <summary>
            /// Enum BIZERROR for value: BIZ_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_ERROR")]
            BIZERROR = 9,

            /// <summary>
            /// Enum REMOTESERVICEERROR for value: REMOTE_SERVICE_ERROR
            /// </summary>
            [EnumMember(Value = "REMOTE_SERVICE_ERROR")]
            REMOTESERVICEERROR = 10

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateErrorResponseModel input)
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
