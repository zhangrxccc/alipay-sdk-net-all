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
    /// AlipayEcoMycarParkingOrderSyncErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingOrderSyncErrorResponseModel")]
    public partial class AlipayEcoMycarParkingOrderSyncErrorResponseModel : IEquatable<AlipayEcoMycarParkingOrderSyncErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum BIZERROR for value: BIZ_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_ERROR")]
            BIZERROR = 1,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 2,

            /// <summary>
            /// Enum PARKINGUSERIDISEMPTY for value: PARKING_USER_ID_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_USER_ID_IS_EMPTY")]
            PARKINGUSERIDISEMPTY = 3,

            /// <summary>
            /// Enum PARKINGUSERIDFORMATERROR for value: PARKING_USER_ID_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "PARKING_USER_ID_FORMAT_ERROR")]
            PARKINGUSERIDFORMATERROR = 4,

            /// <summary>
            /// Enum PARKINGOUTORDERNOISEMPTY for value: PARKING_OUT_ORDER_NO_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_OUT_ORDER_NO_IS_EMPTY")]
            PARKINGOUTORDERNOISEMPTY = 5,

            /// <summary>
            /// Enum PARKINGORDERSTATUSISEMPTY for value: PARKING_ORDER_STATUS_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_ORDER_STATUS_IS_EMPTY")]
            PARKINGORDERSTATUSISEMPTY = 6,

            /// <summary>
            /// Enum PARKINGORDERTIMEISEMPTY for value: PARKING_ORDER_TIME_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_ORDER_TIME_IS_EMPTY")]
            PARKINGORDERTIMEISEMPTY = 7,

            /// <summary>
            /// Enum PARKINGORDERTIMEFORMATERROR for value: PARKING_ORDER_TIME_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "PARKING_ORDER_TIME_FORMAT_ERROR")]
            PARKINGORDERTIMEFORMATERROR = 8,

            /// <summary>
            /// Enum PARKINGORDERNOISEMPTY for value: PARKING_ORDER_NO_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_ORDER_NO_IS_EMPTY")]
            PARKINGORDERNOISEMPTY = 9,

            /// <summary>
            /// Enum PARKINGPAYTIMEISEMPTY for value: PARKING_PAY_TIME_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_PAY_TIME_IS_EMPTY")]
            PARKINGPAYTIMEISEMPTY = 10,

            /// <summary>
            /// Enum PARKINGPAYTIMEFORMATERROR for value: PARKING_PAY_TIME_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "PARKING_PAY_TIME_FORMAT_ERROR")]
            PARKINGPAYTIMEFORMATERROR = 11,

            /// <summary>
            /// Enum PARKINGPAYTYPEISEMPTY for value: PARKING_PAY_TYPE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_PAY_TYPE_IS_EMPTY")]
            PARKINGPAYTYPEISEMPTY = 12,

            /// <summary>
            /// Enum PARKINGPAYTYPEILLEGAL for value: PARKING_PAY_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PARKING_PAY_TYPE_ILLEGAL")]
            PARKINGPAYTYPEILLEGAL = 13,

            /// <summary>
            /// Enum PARKINGPAYMONEYISEMPTY for value: PARKING_PAY_MONEY_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_PAY_MONEY_IS_EMPTY")]
            PARKINGPAYMONEYISEMPTY = 14,

            /// <summary>
            /// Enum PARKINGPAYMONEYILLEGAL for value: PARKING_PAY_MONEY_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PARKING_PAY_MONEY_ILLEGAL")]
            PARKINGPAYMONEYILLEGAL = 15,

            /// <summary>
            /// Enum PARKINGINTIMEISEMPTY for value: PARKING_IN_TIME_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_IN_TIME_IS_EMPTY")]
            PARKINGINTIMEISEMPTY = 16,

            /// <summary>
            /// Enum PARKINGINTIMEFORMATERROR for value: PARKING_IN_TIME_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "PARKING_IN_TIME_FORMAT_ERROR")]
            PARKINGINTIMEFORMATERROR = 17,

            /// <summary>
            /// Enum PARKINGINDURATIONISEMPTY for value: PARKING_IN_DURATION_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_IN_DURATION_IS_EMPTY")]
            PARKINGINDURATIONISEMPTY = 18,

            /// <summary>
            /// Enum PARKINGCARNUMBERISEMPTY for value: PARKING_CAR_NUMBER_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_CAR_NUMBER_IS_EMPTY")]
            PARKINGCARNUMBERISEMPTY = 19,

            /// <summary>
            /// Enum PARKINGCARNUMBERFORMATERROR for value: PARKING_CAR_NUMBER_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "PARKING_CAR_NUMBER_FORMAT_ERROR")]
            PARKINGCARNUMBERFORMATERROR = 20,

            /// <summary>
            /// Enum PARKINGNAMELENGTHTOOLONG for value: PARKING_NAME_LENGTH_TOO_LONG
            /// </summary>
            [EnumMember(Value = "PARKING_NAME_LENGTH_TOO_LONG")]
            PARKINGNAMELENGTHTOOLONG = 21,

            /// <summary>
            /// Enum PARKINGIDISEMPTY for value: PARKING_ID_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_ID_IS_EMPTY")]
            PARKINGIDISEMPTY = 22,

            /// <summary>
            /// Enum PARKINGLOTNOTEXIST for value: PARKING_LOT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "PARKING_LOT_NOT_EXIST")]
            PARKINGLOTNOTEXIST = 23,

            /// <summary>
            /// Enum ISVAPPIDILLEGAL for value: ISV_APP_ID_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ISV_APP_ID_ILLEGAL")]
            ISVAPPIDILLEGAL = 24,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 25,

            /// <summary>
            /// Enum PARKINGORDERSTATUSILLEGAL for value: PARKING_ORDER_STATUS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PARKING_ORDER_STATUS_ILLEGAL")]
            PARKINGORDERSTATUSILLEGAL = 26,

            /// <summary>
            /// Enum PARKINGDEDUCTORDERHASSYNCED for value: PARKING_DEDUCT_ORDER_HAS_SYNCED
            /// </summary>
            [EnumMember(Value = "PARKING_DEDUCT_ORDER_HAS_SYNCED")]
            PARKINGDEDUCTORDERHASSYNCED = 27,

            /// <summary>
            /// Enum NOPERMISSIONERROR for value: NO_PERMISSION_ERROR
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION_ERROR")]
            NOPERMISSIONERROR = 28

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingOrderSyncErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayEcoMycarParkingOrderSyncErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingOrderSyncErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayEcoMycarParkingOrderSyncErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayEcoMycarParkingOrderSyncErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayEcoMycarParkingOrderSyncErrorResponseModel {\n");
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
            return this.Equals(input as AlipayEcoMycarParkingOrderSyncErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingOrderSyncErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingOrderSyncErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingOrderSyncErrorResponseModel input)
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
