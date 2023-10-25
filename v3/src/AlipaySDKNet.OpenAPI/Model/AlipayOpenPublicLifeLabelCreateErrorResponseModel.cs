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
    /// AlipayOpenPublicLifeLabelCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicLifeLabelCreateErrorResponseModel")]
    public partial class AlipayOpenPublicLifeLabelCreateErrorResponseModel : IEquatable<AlipayOpenPublicLifeLabelCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum ILLEGALBIZPARAMS for value: ILLEGAL_BIZ_PARAMS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_BIZ_PARAMS")]
            ILLEGALBIZPARAMS = 1,

            /// <summary>
            /// Enum ADDLABELNAMEISEMPTY for value: ADD_LABEL_NAME_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "ADD_LABEL_NAME_IS_EMPTY")]
            ADDLABELNAMEISEMPTY = 2,

            /// <summary>
            /// Enum LABELNAMEHASSPACE for value: LABEL_NAME_HAS_SPACE
            /// </summary>
            [EnumMember(Value = "LABEL_NAME_HAS_SPACE")]
            LABELNAMEHASSPACE = 3,

            /// <summary>
            /// Enum LABELNAMEHASCOMMA for value: LABEL_NAME_HAS_COMMA
            /// </summary>
            [EnumMember(Value = "LABEL_NAME_HAS_COMMA")]
            LABELNAMEHASCOMMA = 4,

            /// <summary>
            /// Enum LABELNAMETOOLONG for value: LABEL_NAME_TOO_LONG
            /// </summary>
            [EnumMember(Value = "LABEL_NAME_TOO_LONG")]
            LABELNAMETOOLONG = 5,

            /// <summary>
            /// Enum DATATYPEINVALID for value: DATA_TYPE_INVALID
            /// </summary>
            [EnumMember(Value = "DATA_TYPE_INVALID")]
            DATATYPEINVALID = 6,

            /// <summary>
            /// Enum LABELNAMEALREADYEXISTS for value: LABEL_NAME_ALREADY_EXISTS
            /// </summary>
            [EnumMember(Value = "LABEL_NAME_ALREADY_EXISTS")]
            LABELNAMEALREADYEXISTS = 7,

            /// <summary>
            /// Enum LABELCOUNTLIMIT for value: LABEL_COUNT_LIMIT
            /// </summary>
            [EnumMember(Value = "LABEL_COUNT_LIMIT")]
            LABELCOUNTLIMIT = 8,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 9,

            /// <summary>
            /// Enum APPNOAVAIABLE for value: APP_NO_AVAIABLE
            /// </summary>
            [EnumMember(Value = "APP_NO_AVAIABLE")]
            APPNOAVAIABLE = 10

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicLifeLabelCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicLifeLabelCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicLifeLabelCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicLifeLabelCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicLifeLabelCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicLifeLabelCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicLifeLabelCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicLifeLabelCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicLifeLabelCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicLifeLabelCreateErrorResponseModel input)
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
