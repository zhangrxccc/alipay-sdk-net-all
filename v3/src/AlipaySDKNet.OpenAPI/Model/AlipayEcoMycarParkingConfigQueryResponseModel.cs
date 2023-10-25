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
    /// AlipayEcoMycarParkingConfigQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingConfigQueryResponseModel")]
    public partial class AlipayEcoMycarParkingConfigQueryResponseModel : IEquatable<AlipayEcoMycarParkingConfigQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingConfigQueryResponseModel" /> class.
        /// </summary>
        /// <param name="accountNo">签约支付宝账号，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)传入的参数值.</param>
        /// <param name="interfaceInfoList">interfaceInfoList.</param>
        /// <param name="merchantLogo">商户在停车平台首页露出的LOGO链接地址，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)调用自动生成该链接.</param>
        /// <param name="merchantName">商户简称，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)传入的参数值.</param>
        /// <param name="merchantServicePhone">商户客服电话，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)传入的参数值.</param>
        public AlipayEcoMycarParkingConfigQueryResponseModel(string accountNo = default(string), InterfaceInfoList interfaceInfoList = default(InterfaceInfoList), string merchantLogo = default(string), string merchantName = default(string), string merchantServicePhone = default(string))
        {
            this.AccountNo = accountNo;
            this.InterfaceInfoList = interfaceInfoList;
            this.MerchantLogo = merchantLogo;
            this.MerchantName = merchantName;
            this.MerchantServicePhone = merchantServicePhone;
        }

        /// <summary>
        /// 签约支付宝账号，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)传入的参数值
        /// </summary>
        /// <value>签约支付宝账号，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)传入的参数值</value>
        [DataMember(Name = "account_no", EmitDefaultValue = false)]
        public string AccountNo { get; set; }

        /// <summary>
        /// Gets or Sets InterfaceInfoList
        /// </summary>
        [DataMember(Name = "interface_info_list", EmitDefaultValue = false)]
        public InterfaceInfoList InterfaceInfoList { get; set; }

        /// <summary>
        /// 商户在停车平台首页露出的LOGO链接地址，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)调用自动生成该链接
        /// </summary>
        /// <value>商户在停车平台首页露出的LOGO链接地址，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)调用自动生成该链接</value>
        [DataMember(Name = "merchant_logo", EmitDefaultValue = false)]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户简称，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)传入的参数值
        /// </summary>
        /// <value>商户简称，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)传入的参数值</value>
        [DataMember(Name = "merchant_name", EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户客服电话，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)传入的参数值
        /// </summary>
        /// <value>商户客服电话，开发者通过ISV系统配置信息注册接口(alipay.eco.mycar.parking.config.set)传入的参数值</value>
        [DataMember(Name = "merchant_service_phone", EmitDefaultValue = false)]
        public string MerchantServicePhone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingConfigQueryResponseModel {\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  InterfaceInfoList: ").Append(InterfaceInfoList).Append("\n");
            sb.Append("  MerchantLogo: ").Append(MerchantLogo).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  MerchantServicePhone: ").Append(MerchantServicePhone).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingConfigQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingConfigQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingConfigQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingConfigQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountNo == input.AccountNo ||
                    (this.AccountNo != null &&
                    this.AccountNo.Equals(input.AccountNo))
                ) && 
                (
                    this.InterfaceInfoList == input.InterfaceInfoList ||
                    (this.InterfaceInfoList != null &&
                    this.InterfaceInfoList.Equals(input.InterfaceInfoList))
                ) && 
                (
                    this.MerchantLogo == input.MerchantLogo ||
                    (this.MerchantLogo != null &&
                    this.MerchantLogo.Equals(input.MerchantLogo))
                ) && 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) && 
                (
                    this.MerchantServicePhone == input.MerchantServicePhone ||
                    (this.MerchantServicePhone != null &&
                    this.MerchantServicePhone.Equals(input.MerchantServicePhone))
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
                if (this.AccountNo != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNo.GetHashCode();
                }
                if (this.InterfaceInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.InterfaceInfoList.GetHashCode();
                }
                if (this.MerchantLogo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantLogo.GetHashCode();
                }
                if (this.MerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantName.GetHashCode();
                }
                if (this.MerchantServicePhone != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantServicePhone.GetHashCode();
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
