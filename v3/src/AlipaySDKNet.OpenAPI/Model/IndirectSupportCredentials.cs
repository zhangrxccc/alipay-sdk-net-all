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
    /// IndirectSupportCredentials
    /// </summary>
    [DataContract(Name = "IndirectSupportCredentials")]
    public partial class IndirectSupportCredentials : IEquatable<IndirectSupportCredentials>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndirectSupportCredentials" /> class.
        /// </summary>
        /// <param name="city">门店城市.</param>
        /// <param name="cityCode">门店市行政区号（数字）.</param>
        /// <param name="district">门店街道.</param>
        /// <param name="districtCode">门店街道区号（数字）.</param>
        /// <param name="merchantType">小微商户经营类型，枚举值：门店场所（STORE）、流动经营（STALL）.</param>
        /// <param name="province">门店省份.</param>
        /// <param name="provinceCode">门店省行政区号（数字.</param>
        /// <param name="storeAddress">门店场所填写门店详细地址，流动经营类型填“无”.</param>
        /// <param name="storeDoorImg">门店门头照信息或摊位照（使用图片上传接口）.</param>
        /// <param name="storeInnerImg">门店店内照片或者摊位照侧面（使用图片上传接口）.</param>
        /// <param name="storeName">门店名称.</param>
        public IndirectSupportCredentials(string city = default(string), string cityCode = default(string), string district = default(string), string districtCode = default(string), string merchantType = default(string), string province = default(string), string provinceCode = default(string), string storeAddress = default(string), string storeDoorImg = default(string), string storeInnerImg = default(string), string storeName = default(string))
        {
            this.City = city;
            this.CityCode = cityCode;
            this.District = district;
            this.DistrictCode = districtCode;
            this.MerchantType = merchantType;
            this.Province = province;
            this.ProvinceCode = provinceCode;
            this.StoreAddress = storeAddress;
            this.StoreDoorImg = storeDoorImg;
            this.StoreInnerImg = storeInnerImg;
            this.StoreName = storeName;
        }

        /// <summary>
        /// 门店城市
        /// </summary>
        /// <value>门店城市</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// 门店市行政区号（数字）
        /// </summary>
        /// <value>门店市行政区号（数字）</value>
        [DataMember(Name = "city_code", EmitDefaultValue = false)]
        public string CityCode { get; set; }

        /// <summary>
        /// 门店街道
        /// </summary>
        /// <value>门店街道</value>
        [DataMember(Name = "district", EmitDefaultValue = false)]
        public string District { get; set; }

        /// <summary>
        /// 门店街道区号（数字）
        /// </summary>
        /// <value>门店街道区号（数字）</value>
        [DataMember(Name = "district_code", EmitDefaultValue = false)]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 小微商户经营类型，枚举值：门店场所（STORE）、流动经营（STALL）
        /// </summary>
        /// <value>小微商户经营类型，枚举值：门店场所（STORE）、流动经营（STALL）</value>
        [DataMember(Name = "merchant_type", EmitDefaultValue = false)]
        public string MerchantType { get; set; }

        /// <summary>
        /// 门店省份
        /// </summary>
        /// <value>门店省份</value>
        [DataMember(Name = "province", EmitDefaultValue = false)]
        public string Province { get; set; }

        /// <summary>
        /// 门店省行政区号（数字
        /// </summary>
        /// <value>门店省行政区号（数字</value>
        [DataMember(Name = "province_code", EmitDefaultValue = false)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门店场所填写门店详细地址，流动经营类型填“无”
        /// </summary>
        /// <value>门店场所填写门店详细地址，流动经营类型填“无”</value>
        [DataMember(Name = "store_address", EmitDefaultValue = false)]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 门店门头照信息或摊位照（使用图片上传接口）
        /// </summary>
        /// <value>门店门头照信息或摊位照（使用图片上传接口）</value>
        [DataMember(Name = "store_door_img", EmitDefaultValue = false)]
        public string StoreDoorImg { get; set; }

        /// <summary>
        /// 门店店内照片或者摊位照侧面（使用图片上传接口）
        /// </summary>
        /// <value>门店店内照片或者摊位照侧面（使用图片上传接口）</value>
        [DataMember(Name = "store_inner_img", EmitDefaultValue = false)]
        public string StoreInnerImg { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        /// <value>门店名称</value>
        [DataMember(Name = "store_name", EmitDefaultValue = false)]
        public string StoreName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndirectSupportCredentials {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CityCode: ").Append(CityCode).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  DistrictCode: ").Append(DistrictCode).Append("\n");
            sb.Append("  MerchantType: ").Append(MerchantType).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  ProvinceCode: ").Append(ProvinceCode).Append("\n");
            sb.Append("  StoreAddress: ").Append(StoreAddress).Append("\n");
            sb.Append("  StoreDoorImg: ").Append(StoreDoorImg).Append("\n");
            sb.Append("  StoreInnerImg: ").Append(StoreInnerImg).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
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
            return this.Equals(input as IndirectSupportCredentials);
        }

        /// <summary>
        /// Returns true if IndirectSupportCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of IndirectSupportCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndirectSupportCredentials input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CityCode == input.CityCode ||
                    (this.CityCode != null &&
                    this.CityCode.Equals(input.CityCode))
                ) && 
                (
                    this.District == input.District ||
                    (this.District != null &&
                    this.District.Equals(input.District))
                ) && 
                (
                    this.DistrictCode == input.DistrictCode ||
                    (this.DistrictCode != null &&
                    this.DistrictCode.Equals(input.DistrictCode))
                ) && 
                (
                    this.MerchantType == input.MerchantType ||
                    (this.MerchantType != null &&
                    this.MerchantType.Equals(input.MerchantType))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.ProvinceCode == input.ProvinceCode ||
                    (this.ProvinceCode != null &&
                    this.ProvinceCode.Equals(input.ProvinceCode))
                ) && 
                (
                    this.StoreAddress == input.StoreAddress ||
                    (this.StoreAddress != null &&
                    this.StoreAddress.Equals(input.StoreAddress))
                ) && 
                (
                    this.StoreDoorImg == input.StoreDoorImg ||
                    (this.StoreDoorImg != null &&
                    this.StoreDoorImg.Equals(input.StoreDoorImg))
                ) && 
                (
                    this.StoreInnerImg == input.StoreInnerImg ||
                    (this.StoreInnerImg != null &&
                    this.StoreInnerImg.Equals(input.StoreInnerImg))
                ) && 
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.CityCode != null)
                {
                    hashCode = (hashCode * 59) + this.CityCode.GetHashCode();
                }
                if (this.District != null)
                {
                    hashCode = (hashCode * 59) + this.District.GetHashCode();
                }
                if (this.DistrictCode != null)
                {
                    hashCode = (hashCode * 59) + this.DistrictCode.GetHashCode();
                }
                if (this.MerchantType != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantType.GetHashCode();
                }
                if (this.Province != null)
                {
                    hashCode = (hashCode * 59) + this.Province.GetHashCode();
                }
                if (this.ProvinceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceCode.GetHashCode();
                }
                if (this.StoreAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StoreAddress.GetHashCode();
                }
                if (this.StoreDoorImg != null)
                {
                    hashCode = (hashCode * 59) + this.StoreDoorImg.GetHashCode();
                }
                if (this.StoreInnerImg != null)
                {
                    hashCode = (hashCode * 59) + this.StoreInnerImg.GetHashCode();
                }
                if (this.StoreName != null)
                {
                    hashCode = (hashCode * 59) + this.StoreName.GetHashCode();
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
