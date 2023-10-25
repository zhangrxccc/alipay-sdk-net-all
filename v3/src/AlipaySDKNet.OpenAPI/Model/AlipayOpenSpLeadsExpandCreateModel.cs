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
    /// AlipayOpenSpLeadsExpandCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpLeadsExpandCreateModel")]
    public partial class AlipayOpenSpLeadsExpandCreateModel : IEquatable<AlipayOpenSpLeadsExpandCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpLeadsExpandCreateModel" /> class.
        /// </summary>
        /// <param name="address">拓展助手商机地址.</param>
        /// <param name="cityCode">拓展助手商机地址市code.</param>
        /// <param name="cityName">拓展助手商机地址市名称.</param>
        /// <param name="districtCode">拓展助手商机地址区code.</param>
        /// <param name="districtName">拓展助手商机地址区名称.</param>
        /// <param name="email">拓展助手商机邮箱.</param>
        /// <param name="latitude">拓展助手商机地址纬度.</param>
        /// <param name="longitude">拓展助手商机地址经度.</param>
        /// <param name="mcc">mcc行业.</param>
        /// <param name="merchantPid">2088账号.</param>
        /// <param name="name">拓展助手商机名称.</param>
        /// <param name="outBizNo">外部幂等唯一键.</param>
        /// <param name="phone">拓展助手商机联系电话.</param>
        /// <param name="provinceCode">拓展助手商机地址省code.</param>
        /// <param name="provinceName">拓展助手商机地址省名称.</param>
        /// <param name="scene">拓展助手场景，参数约定.</param>
        public AlipayOpenSpLeadsExpandCreateModel(string address = default(string), string cityCode = default(string), string cityName = default(string), string districtCode = default(string), string districtName = default(string), string email = default(string), string latitude = default(string), string longitude = default(string), string mcc = default(string), string merchantPid = default(string), string name = default(string), string outBizNo = default(string), string phone = default(string), string provinceCode = default(string), string provinceName = default(string), string scene = default(string))
        {
            this.Address = address;
            this.CityCode = cityCode;
            this.CityName = cityName;
            this.DistrictCode = districtCode;
            this.DistrictName = districtName;
            this.Email = email;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Mcc = mcc;
            this.MerchantPid = merchantPid;
            this.Name = name;
            this.OutBizNo = outBizNo;
            this.Phone = phone;
            this.ProvinceCode = provinceCode;
            this.ProvinceName = provinceName;
            this.Scene = scene;
        }

        /// <summary>
        /// 拓展助手商机地址
        /// </summary>
        /// <value>拓展助手商机地址</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 拓展助手商机地址市code
        /// </summary>
        /// <value>拓展助手商机地址市code</value>
        [DataMember(Name = "city_code", EmitDefaultValue = false)]
        public string CityCode { get; set; }

        /// <summary>
        /// 拓展助手商机地址市名称
        /// </summary>
        /// <value>拓展助手商机地址市名称</value>
        [DataMember(Name = "city_name", EmitDefaultValue = false)]
        public string CityName { get; set; }

        /// <summary>
        /// 拓展助手商机地址区code
        /// </summary>
        /// <value>拓展助手商机地址区code</value>
        [DataMember(Name = "district_code", EmitDefaultValue = false)]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 拓展助手商机地址区名称
        /// </summary>
        /// <value>拓展助手商机地址区名称</value>
        [DataMember(Name = "district_name", EmitDefaultValue = false)]
        public string DistrictName { get; set; }

        /// <summary>
        /// 拓展助手商机邮箱
        /// </summary>
        /// <value>拓展助手商机邮箱</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// 拓展助手商机地址纬度
        /// </summary>
        /// <value>拓展助手商机地址纬度</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public string Latitude { get; set; }

        /// <summary>
        /// 拓展助手商机地址经度
        /// </summary>
        /// <value>拓展助手商机地址经度</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public string Longitude { get; set; }

        /// <summary>
        /// mcc行业
        /// </summary>
        /// <value>mcc行业</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        public string Mcc { get; set; }

        /// <summary>
        /// 2088账号
        /// </summary>
        /// <value>2088账号</value>
        [DataMember(Name = "merchant_pid", EmitDefaultValue = false)]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 拓展助手商机名称
        /// </summary>
        /// <value>拓展助手商机名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 外部幂等唯一键
        /// </summary>
        /// <value>外部幂等唯一键</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 拓展助手商机联系电话
        /// </summary>
        /// <value>拓展助手商机联系电话</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// 拓展助手商机地址省code
        /// </summary>
        /// <value>拓展助手商机地址省code</value>
        [DataMember(Name = "province_code", EmitDefaultValue = false)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 拓展助手商机地址省名称
        /// </summary>
        /// <value>拓展助手商机地址省名称</value>
        [DataMember(Name = "province_name", EmitDefaultValue = false)]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 拓展助手场景，参数约定
        /// </summary>
        /// <value>拓展助手场景，参数约定</value>
        [DataMember(Name = "scene", EmitDefaultValue = false)]
        public string Scene { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSpLeadsExpandCreateModel {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CityCode: ").Append(CityCode).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("  DistrictCode: ").Append(DistrictCode).Append("\n");
            sb.Append("  DistrictName: ").Append(DistrictName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  MerchantPid: ").Append(MerchantPid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  ProvinceCode: ").Append(ProvinceCode).Append("\n");
            sb.Append("  ProvinceName: ").Append(ProvinceName).Append("\n");
            sb.Append("  Scene: ").Append(Scene).Append("\n");
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
            return this.Equals(input as AlipayOpenSpLeadsExpandCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpLeadsExpandCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpLeadsExpandCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpLeadsExpandCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.CityCode == input.CityCode ||
                    (this.CityCode != null &&
                    this.CityCode.Equals(input.CityCode))
                ) && 
                (
                    this.CityName == input.CityName ||
                    (this.CityName != null &&
                    this.CityName.Equals(input.CityName))
                ) && 
                (
                    this.DistrictCode == input.DistrictCode ||
                    (this.DistrictCode != null &&
                    this.DistrictCode.Equals(input.DistrictCode))
                ) && 
                (
                    this.DistrictName == input.DistrictName ||
                    (this.DistrictName != null &&
                    this.DistrictName.Equals(input.DistrictName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Mcc == input.Mcc ||
                    (this.Mcc != null &&
                    this.Mcc.Equals(input.Mcc))
                ) && 
                (
                    this.MerchantPid == input.MerchantPid ||
                    (this.MerchantPid != null &&
                    this.MerchantPid.Equals(input.MerchantPid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.ProvinceCode == input.ProvinceCode ||
                    (this.ProvinceCode != null &&
                    this.ProvinceCode.Equals(input.ProvinceCode))
                ) && 
                (
                    this.ProvinceName == input.ProvinceName ||
                    (this.ProvinceName != null &&
                    this.ProvinceName.Equals(input.ProvinceName))
                ) && 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.CityCode != null)
                {
                    hashCode = (hashCode * 59) + this.CityCode.GetHashCode();
                }
                if (this.CityName != null)
                {
                    hashCode = (hashCode * 59) + this.CityName.GetHashCode();
                }
                if (this.DistrictCode != null)
                {
                    hashCode = (hashCode * 59) + this.DistrictCode.GetHashCode();
                }
                if (this.DistrictName != null)
                {
                    hashCode = (hashCode * 59) + this.DistrictName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.Mcc != null)
                {
                    hashCode = (hashCode * 59) + this.Mcc.GetHashCode();
                }
                if (this.MerchantPid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantPid.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.ProvinceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceCode.GetHashCode();
                }
                if (this.ProvinceName != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceName.GetHashCode();
                }
                if (this.Scene != null)
                {
                    hashCode = (hashCode * 59) + this.Scene.GetHashCode();
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
