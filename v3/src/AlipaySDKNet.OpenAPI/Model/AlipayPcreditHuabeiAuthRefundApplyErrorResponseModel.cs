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
    /// AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel")]
    public partial class AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel : IEquatable<AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 1,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 2,

            /// <summary>
            /// Enum AGREEMENTNOTEXIST for value: AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "AGREEMENT_NOT_EXIST")]
            AGREEMENTNOTEXIST = 3,

            /// <summary>
            /// Enum REFUNDAMOUNTCHECKERROR for value: REFUND_AMOUNT_CHECK_ERROR
            /// </summary>
            [EnumMember(Value = "REFUND_AMOUNT_CHECK_ERROR")]
            REFUNDAMOUNTCHECKERROR = 4,

            /// <summary>
            /// Enum REQUESTPARAMILLEGAL for value: REQUEST_PARAM_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REQUEST_PARAM_ILLEGAL")]
            REQUESTPARAMILLEGAL = 5,

            /// <summary>
            /// Enum REQUESTACCESSILLEGAL for value: REQUEST_ACCESS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REQUEST_ACCESS_ILLEGAL")]
            REQUESTACCESSILLEGAL = 6,

            /// <summary>
            /// Enum REFUNDPARAMISERROR for value: REFUND_PARAM_IS_ERROR
            /// </summary>
            [EnumMember(Value = "REFUND_PARAM_IS_ERROR")]
            REFUNDPARAMISERROR = 7,

            /// <summary>
            /// Enum REFUNDAGREEMENTSTATUSNOTSUPPORT for value: REFUND_AGREEMENT_STATUS_NOT_SUPPORT
            /// </summary>
            [EnumMember(Value = "REFUND_AGREEMENT_STATUS_NOT_SUPPORT")]
            REFUNDAGREEMENTSTATUSNOTSUPPORT = 8,

            /// <summary>
            /// Enum AUTHOPTORDERNOTEXIST for value: AUTH_OPT_ORDER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "AUTH_OPT_ORDER_NOT_EXIST")]
            AUTHOPTORDERNOTEXIST = 9,

            /// <summary>
            /// Enum REFUNDOPTORDERNOTUNIQUE for value: REFUND_OPT_ORDER_NOT_UNIQUE
            /// </summary>
            [EnumMember(Value = "REFUND_OPT_ORDER_NOT_UNIQUE")]
            REFUNDOPTORDERNOTUNIQUE = 10,

            /// <summary>
            /// Enum REFUNDOPTORDERNOTEXIST for value: REFUND_OPT_ORDER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "REFUND_OPT_ORDER_NOT_EXIST")]
            REFUNDOPTORDERNOTEXIST = 11,

            /// <summary>
            /// Enum REFUNDTRADENONOTEXIST for value: REFUND_TRADE_NO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "REFUND_TRADE_NO_NOT_EXIST")]
            REFUNDTRADENONOTEXIST = 12,

            /// <summary>
            /// Enum REFUNDREQUESTNOIDEMPOTENTFAIL for value: REFUND_REQUEST_NO_IDEMPOTENT_FAIL
            /// </summary>
            [EnumMember(Value = "REFUND_REQUEST_NO_IDEMPOTENT_FAIL")]
            REFUNDREQUESTNOIDEMPOTENTFAIL = 13,

            /// <summary>
            /// Enum REFUNDAGREEMENTANDUSERNOTMATCH for value: REFUND_AGREEMENT_AND_USER_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "REFUND_AGREEMENT_AND_USER_NOT_MATCH")]
            REFUNDAGREEMENTANDUSERNOTMATCH = 14,

            /// <summary>
            /// Enum REFUNDAMOUNTISILLEGAL for value: REFUND_AMOUNT_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REFUND_AMOUNT_IS_ILLEGAL")]
            REFUNDAMOUNTISILLEGAL = 15,

            /// <summary>
            /// Enum REFUNDPAYAMOUNTISEMPTY for value: REFUND_PAY_AMOUNT_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "REFUND_PAY_AMOUNT_IS_EMPTY")]
            REFUNDPAYAMOUNTISEMPTY = 16,

            /// <summary>
            /// Enum REFUNDAMOUNTISZERO for value: REFUND_AMOUNT_IS_ZERO
            /// </summary>
            [EnumMember(Value = "REFUND_AMOUNT_IS_ZERO")]
            REFUNDAMOUNTISZERO = 17,

            /// <summary>
            /// Enum REFUNDTRADENOANDAUTHOPTNOTMATCH for value: REFUND_TRADE_NO_AND_AUTH_OPT_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "REFUND_TRADE_NO_AND_AUTH_OPT_NOT_MATCH")]
            REFUNDTRADENOANDAUTHOPTNOTMATCH = 18,

            /// <summary>
            /// Enum REFUNDPARAMOPTORDERANDTRADENOALLEMPTY for value: REFUND_PARAM_OPT_ORDER_AND_TRADE_NO_ALL_EMPTY
            /// </summary>
            [EnumMember(Value = "REFUND_PARAM_OPT_ORDER_AND_TRADE_NO_ALL_EMPTY")]
            REFUNDPARAMOPTORDERANDTRADENOALLEMPTY = 19,

            /// <summary>
            /// Enum REFUNDAGREEMENTANDPARTNERNOTMATCH for value: REFUND_AGREEMENT_AND_PARTNER_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "REFUND_AGREEMENT_AND_PARTNER_NOT_MATCH")]
            REFUNDAGREEMENTANDPARTNERNOTMATCH = 20,

            /// <summary>
            /// Enum REFUNDLASTTIMESUCCESS for value: REFUND_LAST_TIME_SUCCESS
            /// </summary>
            [EnumMember(Value = "REFUND_LAST_TIME_SUCCESS")]
            REFUNDLASTTIMESUCCESS = 21,

            /// <summary>
            /// Enum REFUNDLASTTIMEFAIL for value: REFUND_LAST_TIME_FAIL
            /// </summary>
            [EnumMember(Value = "REFUND_LAST_TIME_FAIL")]
            REFUNDLASTTIMEFAIL = 22,

            /// <summary>
            /// Enum REFUNDLASTTIMEINIT for value: REFUND_LAST_TIME_INIT
            /// </summary>
            [EnumMember(Value = "REFUND_LAST_TIME_INIT")]
            REFUNDLASTTIMEINIT = 23,

            /// <summary>
            /// Enum REFUNDAGREEMENTNOTEXIST for value: REFUND_AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "REFUND_AGREEMENT_NOT_EXIST")]
            REFUNDAGREEMENTNOTEXIST = 24,

            /// <summary>
            /// Enum UNITRADEPRODEXECUTEERROR for value: UNITRADEPROD_EXECUTE_ERROR
            /// </summary>
            [EnumMember(Value = "UNITRADEPROD_EXECUTE_ERROR")]
            UNITRADEPRODEXECUTEERROR = 25,

            /// <summary>
            /// Enum TRADEHASCLOSE for value: TRADE_HAS_CLOSE
            /// </summary>
            [EnumMember(Value = "TRADE_HAS_CLOSE")]
            TRADEHASCLOSE = 26,

            /// <summary>
            /// Enum SELLERBALANCENOTENOUGH for value: SELLER_BALANCE_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "SELLER_BALANCE_NOT_ENOUGH")]
            SELLERBALANCENOTENOUGH = 27,

            /// <summary>
            /// Enum REFUNDAMTNOTEQUALTOTAL for value: REFUND_AMT_NOT_EQUAL_TOTAL
            /// </summary>
            [EnumMember(Value = "REFUND_AMT_NOT_EQUAL_TOTAL")]
            REFUNDAMTNOTEQUALTOTAL = 28,

            /// <summary>
            /// Enum TRADENOTEXIST for value: TRADE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "TRADE_NOT_EXIST")]
            TRADENOTEXIST = 29,

            /// <summary>
            /// Enum TRADEHASFINISHED for value: TRADE_HAS_FINISHED
            /// </summary>
            [EnumMember(Value = "TRADE_HAS_FINISHED")]
            TRADEHASFINISHED = 30,

            /// <summary>
            /// Enum REASONTRADEREFUNDFEEERR for value: REASON_TRADE_REFUND_FEE_ERR
            /// </summary>
            [EnumMember(Value = "REASON_TRADE_REFUND_FEE_ERR")]
            REASONTRADEREFUNDFEEERR = 31,

            /// <summary>
            /// Enum TRADENOTALLOWREFUND for value: TRADE_NOT_ALLOW_REFUND
            /// </summary>
            [EnumMember(Value = "TRADE_NOT_ALLOW_REFUND")]
            TRADENOTALLOWREFUND = 32,

            /// <summary>
            /// Enum REFUNDFEEERROR for value: REFUND_FEE_ERROR
            /// </summary>
            [EnumMember(Value = "REFUND_FEE_ERROR")]
            REFUNDFEEERROR = 33,

            /// <summary>
            /// Enum REASONTRADEBEENFREEZEN for value: REASON_TRADE_BEEN_FREEZEN
            /// </summary>
            [EnumMember(Value = "REASON_TRADE_BEEN_FREEZEN")]
            REASONTRADEBEENFREEZEN = 34,

            /// <summary>
            /// Enum TRADESTATUSERROR for value: TRADE_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "TRADE_STATUS_ERROR")]
            TRADESTATUSERROR = 35,

            /// <summary>
            /// Enum PARAMERROR for value: PARAM_ERROR
            /// </summary>
            [EnumMember(Value = "PARAM_ERROR")]
            PARAMERROR = 36,

            /// <summary>
            /// Enum REFUNDLASTTIMEACCEPT for value: REFUND_LAST_TIME_ACCEPT
            /// </summary>
            [EnumMember(Value = "REFUND_LAST_TIME_ACCEPT")]
            REFUNDLASTTIMEACCEPT = 37,

            /// <summary>
            /// Enum REFUNDPAYAMOUNTISZERO for value: REFUND_PAY_AMOUNT_IS_ZERO
            /// </summary>
            [EnumMember(Value = "REFUND_PAY_AMOUNT_IS_ZERO")]
            REFUNDPAYAMOUNTISZERO = 38

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayPcreditHuabeiAuthRefundApplyErrorResponseModel input)
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
