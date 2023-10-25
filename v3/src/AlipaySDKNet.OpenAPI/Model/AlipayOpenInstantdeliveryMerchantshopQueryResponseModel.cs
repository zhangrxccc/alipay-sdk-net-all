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
    /// AlipayOpenInstantdeliveryMerchantshopQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenInstantdeliveryMerchantshopQueryResponseModel")]
    public partial class AlipayOpenInstantdeliveryMerchantshopQueryResponseModel : IEquatable<AlipayOpenInstantdeliveryMerchantshopQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenInstantdeliveryMerchantshopQueryResponseModel" /> class.
        /// </summary>
        /// <param name="contactName">联系人姓名.</param>
        /// <param name="detailAddress">地址。商户详细经营地址或人员所在地点。.</param>
        /// <param name="enterpriseCity">城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）.</param>
        /// <param name="enterpriseDistrict">区县编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）.</param>
        /// <param name="enterpriseProvince">省份编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）.</param>
        /// <param name="latitude">纬度，浮点型,小数点后最多保留6位 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker.</param>
        /// <param name="logisticsShopStatus">在配送公司的门店状态。.</param>
        /// <param name="longitude">经度，浮点型, 小数点后最多保留6位。 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker.</param>
        /// <param name="phone">联系人电话/手机号。.</param>
        /// <param name="poiid">高德poiid.</param>
        /// <param name="shopCategory">店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目.</param>
        /// <param name="shopName">门店名称，最长不超过256个字符.</param>
        /// <param name="shopNo">商家门店编码。.</param>
        public AlipayOpenInstantdeliveryMerchantshopQueryResponseModel(string contactName = default(string), string detailAddress = default(string), string enterpriseCity = default(string), string enterpriseDistrict = default(string), string enterpriseProvince = default(string), string latitude = default(string), List<LogisticsShopStatusDTO> logisticsShopStatus = default(List<LogisticsShopStatusDTO>), string longitude = default(string), string phone = default(string), string poiid = default(string), string shopCategory = default(string), string shopName = default(string), string shopNo = default(string))
        {
            this.ContactName = contactName;
            this.DetailAddress = detailAddress;
            this.EnterpriseCity = enterpriseCity;
            this.EnterpriseDistrict = enterpriseDistrict;
            this.EnterpriseProvince = enterpriseProvince;
            this.Latitude = latitude;
            this.LogisticsShopStatus = logisticsShopStatus;
            this.Longitude = longitude;
            this.Phone = phone;
            this.Poiid = poiid;
            this.ShopCategory = shopCategory;
            this.ShopName = shopName;
            this.ShopNo = shopNo;
        }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        /// <value>联系人姓名</value>
        [DataMember(Name = "contact_name", EmitDefaultValue = false)]
        public string ContactName { get; set; }

        /// <summary>
        /// 地址。商户详细经营地址或人员所在地点。
        /// </summary>
        /// <value>地址。商户详细经营地址或人员所在地点。</value>
        [DataMember(Name = "detail_address", EmitDefaultValue = false)]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        /// <value>城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）</value>
        [DataMember(Name = "enterprise_city", EmitDefaultValue = false)]
        public string EnterpriseCity { get; set; }

        /// <summary>
        /// 区县编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        /// <value>区县编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）</value>
        [DataMember(Name = "enterprise_district", EmitDefaultValue = false)]
        public string EnterpriseDistrict { get; set; }

        /// <summary>
        /// 省份编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        /// <value>省份编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）</value>
        [DataMember(Name = "enterprise_province", EmitDefaultValue = false)]
        public string EnterpriseProvince { get; set; }

        /// <summary>
        /// 纬度，浮点型,小数点后最多保留6位 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        /// <value>纬度，浮点型,小数点后最多保留6位 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public string Latitude { get; set; }

        /// <summary>
        /// 在配送公司的门店状态。
        /// </summary>
        /// <value>在配送公司的门店状态。</value>
        [DataMember(Name = "logistics_shop_status", EmitDefaultValue = false)]
        public List<LogisticsShopStatusDTO> LogisticsShopStatus { get; set; }

        /// <summary>
        /// 经度，浮点型, 小数点后最多保留6位。 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        /// <value>经度，浮点型, 小数点后最多保留6位。 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public string Longitude { get; set; }

        /// <summary>
        /// 联系人电话/手机号。
        /// </summary>
        /// <value>联系人电话/手机号。</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// 高德poiid
        /// </summary>
        /// <value>高德poiid</value>
        [DataMember(Name = "poiid", EmitDefaultValue = false)]
        public string Poiid { get; set; }

        /// <summary>
        /// 店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目
        /// </summary>
        /// <value>店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目</value>
        [DataMember(Name = "shop_category", EmitDefaultValue = false)]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 门店名称，最长不超过256个字符
        /// </summary>
        /// <value>门店名称，最长不超过256个字符</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// 商家门店编码。
        /// </summary>
        /// <value>商家门店编码。</value>
        [DataMember(Name = "shop_no", EmitDefaultValue = false)]
        public string ShopNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenInstantdeliveryMerchantshopQueryResponseModel {\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  DetailAddress: ").Append(DetailAddress).Append("\n");
            sb.Append("  EnterpriseCity: ").Append(EnterpriseCity).Append("\n");
            sb.Append("  EnterpriseDistrict: ").Append(EnterpriseDistrict).Append("\n");
            sb.Append("  EnterpriseProvince: ").Append(EnterpriseProvince).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  LogisticsShopStatus: ").Append(LogisticsShopStatus).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Poiid: ").Append(Poiid).Append("\n");
            sb.Append("  ShopCategory: ").Append(ShopCategory).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  ShopNo: ").Append(ShopNo).Append("\n");
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
            return this.Equals(input as AlipayOpenInstantdeliveryMerchantshopQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenInstantdeliveryMerchantshopQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenInstantdeliveryMerchantshopQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenInstantdeliveryMerchantshopQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.DetailAddress == input.DetailAddress ||
                    (this.DetailAddress != null &&
                    this.DetailAddress.Equals(input.DetailAddress))
                ) && 
                (
                    this.EnterpriseCity == input.EnterpriseCity ||
                    (this.EnterpriseCity != null &&
                    this.EnterpriseCity.Equals(input.EnterpriseCity))
                ) && 
                (
                    this.EnterpriseDistrict == input.EnterpriseDistrict ||
                    (this.EnterpriseDistrict != null &&
                    this.EnterpriseDistrict.Equals(input.EnterpriseDistrict))
                ) && 
                (
                    this.EnterpriseProvince == input.EnterpriseProvince ||
                    (this.EnterpriseProvince != null &&
                    this.EnterpriseProvince.Equals(input.EnterpriseProvince))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.LogisticsShopStatus == input.LogisticsShopStatus ||
                    this.LogisticsShopStatus != null &&
                    input.LogisticsShopStatus != null &&
                    this.LogisticsShopStatus.SequenceEqual(input.LogisticsShopStatus)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Poiid == input.Poiid ||
                    (this.Poiid != null &&
                    this.Poiid.Equals(input.Poiid))
                ) && 
                (
                    this.ShopCategory == input.ShopCategory ||
                    (this.ShopCategory != null &&
                    this.ShopCategory.Equals(input.ShopCategory))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.ShopNo == input.ShopNo ||
                    (this.ShopNo != null &&
                    this.ShopNo.Equals(input.ShopNo))
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
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
                }
                if (this.DetailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DetailAddress.GetHashCode();
                }
                if (this.EnterpriseCity != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseCity.GetHashCode();
                }
                if (this.EnterpriseDistrict != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseDistrict.GetHashCode();
                }
                if (this.EnterpriseProvince != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseProvince.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.LogisticsShopStatus != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsShopStatus.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Poiid != null)
                {
                    hashCode = (hashCode * 59) + this.Poiid.GetHashCode();
                }
                if (this.ShopCategory != null)
                {
                    hashCode = (hashCode * 59) + this.ShopCategory.GetHashCode();
                }
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
                }
                if (this.ShopNo != null)
                {
                    hashCode = (hashCode * 59) + this.ShopNo.GetHashCode();
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
