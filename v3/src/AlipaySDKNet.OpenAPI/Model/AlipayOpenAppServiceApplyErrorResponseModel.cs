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
    /// AlipayOpenAppServiceApplyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppServiceApplyErrorResponseModel")]
    public partial class AlipayOpenAppServiceApplyErrorResponseModel : IEquatable<AlipayOpenAppServiceApplyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum XMLFORMATERROR for value: XML_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "XML_FORMAT_ERROR")]
            XMLFORMATERROR = 1,

            /// <summary>
            /// Enum ATTRMISSID for value: ATTR_MISS_ID
            /// </summary>
            [EnumMember(Value = "ATTR_MISS_ID")]
            ATTRMISSID = 2,

            /// <summary>
            /// Enum ATTRMISSTYPE for value: ATTR_MISS_TYPE
            /// </summary>
            [EnumMember(Value = "ATTR_MISS_TYPE")]
            ATTRMISSTYPE = 3,

            /// <summary>
            /// Enum ATTRTYPEERROR for value: ATTR_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "ATTR_TYPE_ERROR")]
            ATTRTYPEERROR = 4,

            /// <summary>
            /// Enum ATTRVALUEERROR for value: ATTR_VALUE_ERROR
            /// </summary>
            [EnumMember(Value = "ATTR_VALUE_ERROR")]
            ATTRVALUEERROR = 5,

            /// <summary>
            /// Enum ATTRVALUETYPEERROR for value: ATTR_VALUETYPE_ERROR
            /// </summary>
            [EnumMember(Value = "ATTR_VALUETYPE_ERROR")]
            ATTRVALUETYPEERROR = 6,

            /// <summary>
            /// Enum ATTRRULENAMEERROR for value: ATTR_RULE_NAME_ERROR
            /// </summary>
            [EnumMember(Value = "ATTR_RULE_NAME_ERROR")]
            ATTRRULENAMEERROR = 7,

            /// <summary>
            /// Enum ATTRRULEVALUEERROR for value: ATTR_RULE_VALUE_ERROR
            /// </summary>
            [EnumMember(Value = "ATTR_RULE_VALUE_ERROR")]
            ATTRRULEVALUEERROR = 8,

            /// <summary>
            /// Enum ATTRRULETYPEERROR for value: ATTR_RULE_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "ATTR_RULE_TYPE_ERROR")]
            ATTRRULETYPEERROR = 9,

            /// <summary>
            /// Enum OPTIONNAMEERROR for value: OPTION_NAME_ERROR
            /// </summary>
            [EnumMember(Value = "OPTION_NAME_ERROR")]
            OPTIONNAMEERROR = 10,

            /// <summary>
            /// Enum OPTIONVALUEERROR for value: OPTION_VALUE_ERROR
            /// </summary>
            [EnumMember(Value = "OPTION_VALUE_ERROR")]
            OPTIONVALUEERROR = 11,

            /// <summary>
            /// Enum ADDRESSORCITYCODEERROR for value: ADDRESS_OR_CITYCODE_ERROR
            /// </summary>
            [EnumMember(Value = "ADDRESS_OR_CITYCODE_ERROR")]
            ADDRESSORCITYCODEERROR = 12,

            /// <summary>
            /// Enum SHOPIDISERROR for value: SHOP_ID_IS_ERROR
            /// </summary>
            [EnumMember(Value = "SHOP_ID_IS_ERROR")]
            SHOPIDISERROR = 13,

            /// <summary>
            /// Enum ATTRNOTMATCHSERVICESCHEMA for value: ATTR_NOT_MATCH_SERVICE_SCHEMA
            /// </summary>
            [EnumMember(Value = "ATTR_NOT_MATCH_SERVICE_SCHEMA")]
            ATTRNOTMATCHSERVICESCHEMA = 14,

            /// <summary>
            /// Enum MINIAPPNOTONLINE for value: MINI_APP_NOT_ONLINE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NOT_ONLINE")]
            MINIAPPNOTONLINE = 15,

            /// <summary>
            /// Enum SERVICEURLREPEATERROR for value: SERVICE_URL_REPEAT_ERROR
            /// </summary>
            [EnumMember(Value = "SERVICE_URL_REPEAT_ERROR")]
            SERVICEURLREPEATERROR = 16,

            /// <summary>
            /// Enum SERVICENAMEREPEATERROR for value: SERVICE_NAME_REPEAT_ERROR
            /// </summary>
            [EnumMember(Value = "SERVICE_NAME_REPEAT_ERROR")]
            SERVICENAMEREPEATERROR = 17,

            /// <summary>
            /// Enum PERMISSIONCHECKERROR for value: PERMISSION_CHECK_ERROR
            /// </summary>
            [EnumMember(Value = "PERMISSION_CHECK_ERROR")]
            PERMISSIONCHECKERROR = 18,

            /// <summary>
            /// Enum SERVICENULL for value: SERVICE_NULL
            /// </summary>
            [EnumMember(Value = "SERVICE_NULL")]
            SERVICENULL = 19,

            /// <summary>
            /// Enum SERVICEISINVALID for value: SERVICE_IS_INVALID
            /// </summary>
            [EnumMember(Value = "SERVICE_IS_INVALID")]
            SERVICEISINVALID = 20,

            /// <summary>
            /// Enum SERVICEURLERROR for value: SERVICE_URL_ERROR
            /// </summary>
            [EnumMember(Value = "SERVICE_URL_ERROR")]
            SERVICEURLERROR = 21,

            /// <summary>
            /// Enum ATTRRULECHECKERROR for value: ATTR_RULE_CHECK_ERROR
            /// </summary>
            [EnumMember(Value = "ATTR_RULE_CHECK_ERROR")]
            ATTRRULECHECKERROR = 22,

            /// <summary>
            /// Enum BIZERROR for value: BIZ_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_ERROR")]
            BIZERROR = 23,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 24,

            /// <summary>
            /// Enum AREACODEERROR for value: AREA_CODE_ERROR
            /// </summary>
            [EnumMember(Value = "AREA_CODE_ERROR")]
            AREACODEERROR = 25,

            /// <summary>
            /// Enum IDEMPOTENTCONFLICTED for value: IDEMPOTENT_CONFLICTED
            /// </summary>
            [EnumMember(Value = "IDEMPOTENT_CONFLICTED")]
            IDEMPOTENTCONFLICTED = 26,

            /// <summary>
            /// Enum SERVICEAPPIDNOTINURL for value: SERVICE_APPID_NOT_IN_URL
            /// </summary>
            [EnumMember(Value = "SERVICE_APPID_NOT_IN_URL")]
            SERVICEAPPIDNOTINURL = 27,

            /// <summary>
            /// Enum SERVICENOTEXIST for value: SERVICE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SERVICE_NOT_EXIST")]
            SERVICENOTEXIST = 28,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 29

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppServiceApplyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenAppServiceApplyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppServiceApplyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenAppServiceApplyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenAppServiceApplyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenAppServiceApplyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenAppServiceApplyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppServiceApplyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppServiceApplyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppServiceApplyErrorResponseModel input)
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
