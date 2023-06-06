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
    /// AntMerchantExpandShopModifyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandShopModifyErrorResponseModel")]
    public partial class AntMerchantExpandShopModifyErrorResponseModel : IEquatable<AntMerchantExpandShopModifyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum NOTALLOWEDSETTLE for value: NOT_ALLOWED_SETTLE
            /// </summary>
            [EnumMember(Value = "NOT_ALLOWED_SETTLE")]
            NOTALLOWEDSETTLE = 1,

            /// <summary>
            /// Enum SHOPCATEGORYISILLEGAL for value: SHOP_CATEGORY_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_CATEGORY_IS_ILLEGAL")]
            SHOPCATEGORYISILLEGAL = 2,

            /// <summary>
            /// Enum ISVNOTEXIST for value: ISV_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ISV_NOT_EXIST")]
            ISVNOTEXIST = 3,

            /// <summary>
            /// Enum SHOPACCOUNTNOISILLEGAL for value: SHOP_ACCOUNT_NO_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_ACCOUNT_NO_IS_ILLEGAL")]
            SHOPACCOUNTNOISILLEGAL = 4,

            /// <summary>
            /// Enum INDUSTRYQUALIFICATIONISEMPTY for value: INDUSTRY_QUALIFICATION_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "INDUSTRY_QUALIFICATION_IS_EMPTY")]
            INDUSTRYQUALIFICATIONISEMPTY = 5,

            /// <summary>
            /// Enum SETTLEDOUTDOORIMAGEEMPTY for value: SETTLED_OUTDOORIMAGE_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_OUTDOORIMAGE_EMPTY")]
            SETTLEDOUTDOORIMAGEEMPTY = 6,

            /// <summary>
            /// Enum SETTLEDBIZADDRESSILLEGAL for value: SETTLED_BIZ_ADDRESS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_BIZ_ADDRESS_ILLEGAL")]
            SETTLEDBIZADDRESSILLEGAL = 7,

            /// <summary>
            /// Enum SHOPCATEGORYISEMPTY for value: SHOP_CATEGORY_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SHOP_CATEGORY_IS_EMPTY")]
            SHOPCATEGORYISEMPTY = 8,

            /// <summary>
            /// Enum CONTACTWAYVALUENULL for value: CONTACT_WAY_VALUE_NULL
            /// </summary>
            [EnumMember(Value = "CONTACT_WAY_VALUE_NULL")]
            CONTACTWAYVALUENULL = 9,

            /// <summary>
            /// Enum ADDRESSPROVINCECODEILLEGAL for value: ADDRESS_PROVINCE_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_PROVINCE_CODE_ILLEGAL")]
            ADDRESSPROVINCECODEILLEGAL = 10,

            /// <summary>
            /// Enum ADDRESSCITYCODEILLEGAL for value: ADDRESS_CITY_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_CITY_CODE_ILLEGAL")]
            ADDRESSCITYCODEILLEGAL = 11,

            /// <summary>
            /// Enum ADDRESSDISTRICTCODEILLEGAL for value: ADDRESS_DISTRICT_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_DISTRICT_CODE_ILLEGAL")]
            ADDRESSDISTRICTCODEILLEGAL = 12,

            /// <summary>
            /// Enum GONGANCHECKFAIL for value: GONGAN_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "GONGAN_CHECK_FAIL")]
            GONGANCHECKFAIL = 13,

            /// <summary>
            /// Enum GONGSHANGCHECKFAIL for value: GONGSHANG_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "GONGSHANG_CHECK_FAIL")]
            GONGSHANGCHECKFAIL = 14,

            /// <summary>
            /// Enum MERCHANTINPUTARGUMENTILLEGAL for value: MERCHANT_INPUT_ARGUMENT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MERCHANT_INPUT_ARGUMENT_ILLEGAL")]
            MERCHANTINPUTARGUMENTILLEGAL = 15,

            /// <summary>
            /// Enum CONTACTPERSONNAMENULL for value: CONTACT_PERSON_NAME_NULL
            /// </summary>
            [EnumMember(Value = "CONTACT_PERSON_NAME_NULL")]
            CONTACTPERSONNAMENULL = 16,

            /// <summary>
            /// Enum USERILLEGAL for value: USER_ILLEGAL
            /// </summary>
            [EnumMember(Value = "USER_ILLEGAL")]
            USERILLEGAL = 17,

            /// <summary>
            /// Enum BRANDILLEGAL for value: BRAND_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BRAND_ILLEGAL")]
            BRANDILLEGAL = 18,

            /// <summary>
            /// Enum PROFILEKEYILLEGAL for value: PROFILE_KEY_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PROFILE_KEY_ILLEGAL")]
            PROFILEKEYILLEGAL = 19,

            /// <summary>
            /// Enum MERARGUMENTNULL for value: MER_ARGUMENT_NULL
            /// </summary>
            [EnumMember(Value = "MER_ARGUMENT_NULL")]
            MERARGUMENTNULL = 20,

            /// <summary>
            /// Enum IPROLEIDDONOTCHANGE for value: IP_ROLE_ID_DO_NOT_CHANGE
            /// </summary>
            [EnumMember(Value = "IP_ROLE_ID_DO_NOT_CHANGE")]
            IPROLEIDDONOTCHANGE = 21,

            /// <summary>
            /// Enum SHOPNOTEXIST for value: SHOP_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_NOT_EXIST")]
            SHOPNOTEXIST = 22,

            /// <summary>
            /// Enum RELATIONNOTEXIST for value: RELATION_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "RELATION_NOT_EXIST")]
            RELATIONNOTEXIST = 23,

            /// <summary>
            /// Enum SHOPALREADYEXIST for value: SHOP_ALREADY_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_ALREADY_EXIST")]
            SHOPALREADYEXIST = 24,

            /// <summary>
            /// Enum SETTLEDBANKCARDNOISEMPTY for value: SETTLED_BANKCARD_NO_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_BANKCARD_NO_IS_EMPTY")]
            SETTLEDBANKCARDNOISEMPTY = 25,

            /// <summary>
            /// Enum SETTLEDACCOUNTHOLDERNAMEEMPTY for value: SETTLED_ACCOUNTHOLDERNAME_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_ACCOUNTHOLDERNAME_EMPTY")]
            SETTLEDACCOUNTHOLDERNAMEEMPTY = 26,

            /// <summary>
            /// Enum SETTLEDACCOUNTBRANCHNAMEEMPTY for value: SETTLED_ACCOUNTBRANCHNAME_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_ACCOUNTBRANCHNAME_EMPTY")]
            SETTLEDACCOUNTBRANCHNAMEEMPTY = 27,

            /// <summary>
            /// Enum SETTLEDACCOUNTINSTNAMEEMPTY for value: SETTLED_ACCOUNTINSTNAME_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_ACCOUNTINSTNAME_EMPTY")]
            SETTLEDACCOUNTINSTNAMEEMPTY = 28,

            /// <summary>
            /// Enum SETTLEDUSAGETYPEISEMPTY for value: SETTLED_USAGETYPE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_USAGETYPE_IS_EMPTY")]
            SETTLEDUSAGETYPEISEMPTY = 29,

            /// <summary>
            /// Enum BANKBRANCHNAMEILLEGAL for value: BANK_BRANCH_NAME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_BRANCH_NAME_ILLEGAL")]
            BANKBRANCHNAMEILLEGAL = 30,

            /// <summary>
            /// Enum SETTLEDUSAGETYPEILLEGAL for value: SETTLED_USAGETYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_USAGETYPE_ILLEGAL")]
            SETTLEDUSAGETYPEILLEGAL = 31,

            /// <summary>
            /// Enum SETTLEDCARDACCOUNTINSTIDEMPTY for value: SETTLED_CARD_ACCOUNTINSTID_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_ACCOUNTINSTID_EMPTY")]
            SETTLEDCARDACCOUNTINSTIDEMPTY = 32,

            /// <summary>
            /// Enum SETTLEDCARDACCOUNTTYPEEMPTY for value: SETTLED_CARD_ACCOUNTTYPE_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_ACCOUNTTYPE_EMPTY")]
            SETTLEDCARDACCOUNTTYPEEMPTY = 33,

            /// <summary>
            /// Enum BANKACCOUNTINSTIDILLEGAL for value: BANK_ACCOUNTINSTID_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_ACCOUNTINSTID_ILLEGAL")]
            BANKACCOUNTINSTIDILLEGAL = 34,

            /// <summary>
            /// Enum SETTLEDCARDACCOUNTTYPEILLEGAL for value: SETTLED_CARD_ACCOUNTTYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_ACCOUNTTYPE_ILLEGAL")]
            SETTLEDCARDACCOUNTTYPEILLEGAL = 35,

            /// <summary>
            /// Enum BANKACCOUNTINSTNAMEILLEGAL for value: BANK_ACCOUNTINSTNAME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_ACCOUNTINSTNAME_ILLEGAL")]
            BANKACCOUNTINSTNAMEILLEGAL = 36,

            /// <summary>
            /// Enum SETTLEDALIPAYACCOUNTNOTEXIST for value: SETTLED_ALIPAYACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SETTLED_ALIPAYACCOUNT_NOT_EXIST")]
            SETTLEDALIPAYACCOUNTNOTEXIST = 37,

            /// <summary>
            /// Enum GONGSHANGLICENSEILLEGAL for value: GONGSHANG_LICENSE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "GONGSHANG_LICENSE_ILLEGAL")]
            GONGSHANGLICENSEILLEGAL = 38,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 39,

            /// <summary>
            /// Enum SHOPTYPEILLEGAL for value: SHOP_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_TYPE_ILLEGAL")]
            SHOPTYPEILLEGAL = 40,

            /// <summary>
            /// Enum LOCATIONCHECKFAIL for value: LOCATION_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "LOCATION_CHECK_FAIL")]
            LOCATIONCHECKFAIL = 41,

            /// <summary>
            /// Enum ATTACHMENTCHECKFAIL for value: ATTACHMENT_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "ATTACHMENT_CHECK_FAIL")]
            ATTACHMENTCHECKFAIL = 42,

            /// <summary>
            /// Enum BUSINESSTIMEILLEGAL for value: BUSINESS_TIME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BUSINESS_TIME_ILLEGAL")]
            BUSINESSTIMEILLEGAL = 43,

            /// <summary>
            /// Enum SHOPAUDITREJECT for value: SHOP_AUDIT_REJECT
            /// </summary>
            [EnumMember(Value = "SHOP_AUDIT_REJECT")]
            SHOPAUDITREJECT = 44,

            /// <summary>
            /// Enum ATTACHMENTURLNULL for value: ATTACHMENT_URL_NULL
            /// </summary>
            [EnumMember(Value = "ATTACHMENT_URL_NULL")]
            ATTACHMENTURLNULL = 45,

            /// <summary>
            /// Enum SHOPCODEALREADYEXIST for value: SHOP_CODE_ALREADY_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_CODE_ALREADY_EXIST")]
            SHOPCODEALREADYEXIST = 46,

            /// <summary>
            /// Enum MERARGUMENTILLEGAL for value: MER_ARGUMENT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MER_ARGUMENT_ILLEGAL")]
            MERARGUMENTILLEGAL = 47

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopModifyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AntMerchantExpandShopModifyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopModifyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AntMerchantExpandShopModifyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AntMerchantExpandShopModifyErrorResponseModel and cannot be null");
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
            sb.Append("class AntMerchantExpandShopModifyErrorResponseModel {\n");
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
            return this.Equals(input as AntMerchantExpandShopModifyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandShopModifyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandShopModifyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandShopModifyErrorResponseModel input)
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
