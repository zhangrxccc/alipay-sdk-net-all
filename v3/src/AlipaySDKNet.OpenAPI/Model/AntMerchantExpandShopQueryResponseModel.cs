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
    /// AntMerchantExpandShopQueryResponseModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandShopQueryResponseModel")]
    public partial class AntMerchantExpandShopQueryResponseModel : IEquatable<AntMerchantExpandShopQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopQueryResponseModel" /> class.
        /// </summary>
        /// <param name="brandId">品牌id.</param>
        /// <param name="businessAddress">businessAddress.</param>
        /// <param name="businessTime">店铺经营时间。.</param>
        /// <param name="certImage">营业执照图片url。返回值为一个有访问时限的链接.</param>
        /// <param name="certName">营业执照名称，值为营业执照或统一社会信用代码证上的名称。.</param>
        /// <param name="certNo">证件号码.</param>
        /// <param name="certType">证件类型，取值范围：201：营业执照；2011:多证合一(统一社会信用代码)。.</param>
        /// <param name="contactInfos">联系人信息。.</param>
        /// <param name="contactMobile">店铺联系手机.</param>
        /// <param name="contactPhone">店铺的联系固话.</param>
        /// <param name="extInfos">扩展信息列表。key值需要向对应行业的bd进行申请。.</param>
        /// <param name="ipRoleId">商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。若未传入shop_id 则本参数与store_id均必填。.</param>
        /// <param name="legalCertNo">法人身份证号。.</param>
        /// <param name="legalName">法人名称。.</param>
        /// <param name="licenseAuthLetterImage">营业执照授权函。返回值为一个有访问时限的链接.</param>
        /// <param name="memo">备注.</param>
        /// <param name="newShopCategory">新版门店类目标准二级类目code.</param>
        /// <param name="outDoorImages">门头照，返回值为一个有访问时限的链接.</param>
        /// <param name="qualifications">行业特殊资质。.</param>
        /// <param name="scene">场景.</param>
        /// <param name="settleAlipayLogonId">结算支付宝账号的登录号.</param>
        /// <param name="shopCategory">店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目.</param>
        /// <param name="shopId">支付宝侧蚂蚁店铺 id。传入本参数后可不填 store_id 及 ip_role_id。.</param>
        /// <param name="shopInfoStatus">当前名称、地址、经纬度信息准确一致，可用于数字化经营场景消费.</param>
        /// <param name="shopName">店铺名称。.</param>
        /// <param name="shopRecommendInfo">shopRecommendInfo.</param>
        /// <param name="shopType">店铺经营类型，01表示直营，02表示加盟.</param>
        /// <param name="storeId">商户侧门店编号。表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号。若未传入 shop_id  则本参数与与ip_role_id均必填。.</param>
        public AntMerchantExpandShopQueryResponseModel(string brandId = default(string), AddressInfo businessAddress = default(AddressInfo), List<ShopBusinessTime> businessTime = default(List<ShopBusinessTime>), string certImage = default(string), string certName = default(string), string certNo = default(string), string certType = default(string), List<ContactInfo> contactInfos = default(List<ContactInfo>), string contactMobile = default(string), string contactPhone = default(string), List<ShopExtInfo> extInfos = default(List<ShopExtInfo>), string ipRoleId = default(string), string legalCertNo = default(string), string legalName = default(string), string licenseAuthLetterImage = default(string), string memo = default(string), string newShopCategory = default(string), List<string> outDoorImages = default(List<string>), List<IndustryQualificationInfo> qualifications = default(List<IndustryQualificationInfo>), string scene = default(string), string settleAlipayLogonId = default(string), string shopCategory = default(string), string shopId = default(string), string shopInfoStatus = default(string), string shopName = default(string), ShopRecommendInfo shopRecommendInfo = default(ShopRecommendInfo), string shopType = default(string), string storeId = default(string))
        {
            this.BrandId = brandId;
            this.BusinessAddress = businessAddress;
            this.BusinessTime = businessTime;
            this.CertImage = certImage;
            this.CertName = certName;
            this.CertNo = certNo;
            this.CertType = certType;
            this.ContactInfos = contactInfos;
            this.ContactMobile = contactMobile;
            this.ContactPhone = contactPhone;
            this.ExtInfos = extInfos;
            this.IpRoleId = ipRoleId;
            this.LegalCertNo = legalCertNo;
            this.LegalName = legalName;
            this.LicenseAuthLetterImage = licenseAuthLetterImage;
            this.Memo = memo;
            this.NewShopCategory = newShopCategory;
            this.OutDoorImages = outDoorImages;
            this.Qualifications = qualifications;
            this.Scene = scene;
            this.SettleAlipayLogonId = settleAlipayLogonId;
            this.ShopCategory = shopCategory;
            this.ShopId = shopId;
            this.ShopInfoStatus = shopInfoStatus;
            this.ShopName = shopName;
            this.ShopRecommendInfo = shopRecommendInfo;
            this.ShopType = shopType;
            this.StoreId = storeId;
        }

        /// <summary>
        /// 品牌id
        /// </summary>
        /// <value>品牌id</value>
        [DataMember(Name = "brand_id", EmitDefaultValue = false)]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or Sets BusinessAddress
        /// </summary>
        [DataMember(Name = "business_address", EmitDefaultValue = false)]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 店铺经营时间。
        /// </summary>
        /// <value>店铺经营时间。</value>
        [DataMember(Name = "business_time", EmitDefaultValue = false)]
        public List<ShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 营业执照图片url。返回值为一个有访问时限的链接
        /// </summary>
        /// <value>营业执照图片url。返回值为一个有访问时限的链接</value>
        [DataMember(Name = "cert_image", EmitDefaultValue = false)]
        public string CertImage { get; set; }

        /// <summary>
        /// 营业执照名称，值为营业执照或统一社会信用代码证上的名称。
        /// </summary>
        /// <value>营业执照名称，值为营业执照或统一社会信用代码证上的名称。</value>
        [DataMember(Name = "cert_name", EmitDefaultValue = false)]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        /// <value>证件号码</value>
        [DataMember(Name = "cert_no", EmitDefaultValue = false)]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，取值范围：201：营业执照；2011:多证合一(统一社会信用代码)。
        /// </summary>
        /// <value>证件类型，取值范围：201：营业执照；2011:多证合一(统一社会信用代码)。</value>
        [DataMember(Name = "cert_type", EmitDefaultValue = false)]
        public string CertType { get; set; }

        /// <summary>
        /// 联系人信息。
        /// </summary>
        /// <value>联系人信息。</value>
        [DataMember(Name = "contact_infos", EmitDefaultValue = false)]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 店铺联系手机
        /// </summary>
        /// <value>店铺联系手机</value>
        [DataMember(Name = "contact_mobile", EmitDefaultValue = false)]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固话
        /// </summary>
        /// <value>店铺的联系固话</value>
        [DataMember(Name = "contact_phone", EmitDefaultValue = false)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 扩展信息列表。key值需要向对应行业的bd进行申请。
        /// </summary>
        /// <value>扩展信息列表。key值需要向对应行业的bd进行申请。</value>
        [DataMember(Name = "ext_infos", EmitDefaultValue = false)]
        public List<ShopExtInfo> ExtInfos { get; set; }

        /// <summary>
        /// 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。若未传入shop_id 则本参数与store_id均必填。
        /// </summary>
        /// <value>商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。若未传入shop_id 则本参数与store_id均必填。</value>
        [DataMember(Name = "ip_role_id", EmitDefaultValue = false)]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 法人身份证号。
        /// </summary>
        /// <value>法人身份证号。</value>
        [DataMember(Name = "legal_cert_no", EmitDefaultValue = false)]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称。
        /// </summary>
        /// <value>法人名称。</value>
        [DataMember(Name = "legal_name", EmitDefaultValue = false)]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照授权函。返回值为一个有访问时限的链接
        /// </summary>
        /// <value>营业执照授权函。返回值为一个有访问时限的链接</value>
        [DataMember(Name = "license_auth_letter_image", EmitDefaultValue = false)]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>备注</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code
        /// </summary>
        /// <value>新版门店类目标准二级类目code</value>
        [DataMember(Name = "new_shop_category", EmitDefaultValue = false)]
        public string NewShopCategory { get; set; }

        /// <summary>
        /// 门头照，返回值为一个有访问时限的链接
        /// </summary>
        /// <value>门头照，返回值为一个有访问时限的链接</value>
        [DataMember(Name = "out_door_images", EmitDefaultValue = false)]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 行业特殊资质。
        /// </summary>
        /// <value>行业特殊资质。</value>
        [DataMember(Name = "qualifications", EmitDefaultValue = false)]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        /// <value>场景</value>
        [DataMember(Name = "scene", EmitDefaultValue = false)]
        public string Scene { get; set; }

        /// <summary>
        /// 结算支付宝账号的登录号
        /// </summary>
        /// <value>结算支付宝账号的登录号</value>
        [DataMember(Name = "settle_alipay_logon_id", EmitDefaultValue = false)]
        public string SettleAlipayLogonId { get; set; }

        /// <summary>
        /// 店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目
        /// </summary>
        /// <value>店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目</value>
        [DataMember(Name = "shop_category", EmitDefaultValue = false)]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 支付宝侧蚂蚁店铺 id。传入本参数后可不填 store_id 及 ip_role_id。
        /// </summary>
        /// <value>支付宝侧蚂蚁店铺 id。传入本参数后可不填 store_id 及 ip_role_id。</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// 当前名称、地址、经纬度信息准确一致，可用于数字化经营场景消费
        /// </summary>
        /// <value>当前名称、地址、经纬度信息准确一致，可用于数字化经营场景消费</value>
        [DataMember(Name = "shop_info_status", EmitDefaultValue = false)]
        public string ShopInfoStatus { get; set; }

        /// <summary>
        /// 店铺名称。
        /// </summary>
        /// <value>店铺名称。</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// Gets or Sets ShopRecommendInfo
        /// </summary>
        [DataMember(Name = "shop_recommend_info", EmitDefaultValue = false)]
        public ShopRecommendInfo ShopRecommendInfo { get; set; }

        /// <summary>
        /// 店铺经营类型，01表示直营，02表示加盟
        /// </summary>
        /// <value>店铺经营类型，01表示直营，02表示加盟</value>
        [DataMember(Name = "shop_type", EmitDefaultValue = false)]
        public string ShopType { get; set; }

        /// <summary>
        /// 商户侧门店编号。表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号。若未传入 shop_id  则本参数与与ip_role_id均必填。
        /// </summary>
        /// <value>商户侧门店编号。表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号。若未传入 shop_id  则本参数与与ip_role_id均必填。</value>
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntMerchantExpandShopQueryResponseModel {\n");
            sb.Append("  BrandId: ").Append(BrandId).Append("\n");
            sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
            sb.Append("  BusinessTime: ").Append(BusinessTime).Append("\n");
            sb.Append("  CertImage: ").Append(CertImage).Append("\n");
            sb.Append("  CertName: ").Append(CertName).Append("\n");
            sb.Append("  CertNo: ").Append(CertNo).Append("\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  ContactInfos: ").Append(ContactInfos).Append("\n");
            sb.Append("  ContactMobile: ").Append(ContactMobile).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  ExtInfos: ").Append(ExtInfos).Append("\n");
            sb.Append("  IpRoleId: ").Append(IpRoleId).Append("\n");
            sb.Append("  LegalCertNo: ").Append(LegalCertNo).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  LicenseAuthLetterImage: ").Append(LicenseAuthLetterImage).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  NewShopCategory: ").Append(NewShopCategory).Append("\n");
            sb.Append("  OutDoorImages: ").Append(OutDoorImages).Append("\n");
            sb.Append("  Qualifications: ").Append(Qualifications).Append("\n");
            sb.Append("  Scene: ").Append(Scene).Append("\n");
            sb.Append("  SettleAlipayLogonId: ").Append(SettleAlipayLogonId).Append("\n");
            sb.Append("  ShopCategory: ").Append(ShopCategory).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  ShopInfoStatus: ").Append(ShopInfoStatus).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  ShopRecommendInfo: ").Append(ShopRecommendInfo).Append("\n");
            sb.Append("  ShopType: ").Append(ShopType).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
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
            return this.Equals(input as AntMerchantExpandShopQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandShopQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandShopQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandShopQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BrandId == input.BrandId ||
                    (this.BrandId != null &&
                    this.BrandId.Equals(input.BrandId))
                ) && 
                (
                    this.BusinessAddress == input.BusinessAddress ||
                    (this.BusinessAddress != null &&
                    this.BusinessAddress.Equals(input.BusinessAddress))
                ) && 
                (
                    this.BusinessTime == input.BusinessTime ||
                    this.BusinessTime != null &&
                    input.BusinessTime != null &&
                    this.BusinessTime.SequenceEqual(input.BusinessTime)
                ) && 
                (
                    this.CertImage == input.CertImage ||
                    (this.CertImage != null &&
                    this.CertImage.Equals(input.CertImage))
                ) && 
                (
                    this.CertName == input.CertName ||
                    (this.CertName != null &&
                    this.CertName.Equals(input.CertName))
                ) && 
                (
                    this.CertNo == input.CertNo ||
                    (this.CertNo != null &&
                    this.CertNo.Equals(input.CertNo))
                ) && 
                (
                    this.CertType == input.CertType ||
                    (this.CertType != null &&
                    this.CertType.Equals(input.CertType))
                ) && 
                (
                    this.ContactInfos == input.ContactInfos ||
                    this.ContactInfos != null &&
                    input.ContactInfos != null &&
                    this.ContactInfos.SequenceEqual(input.ContactInfos)
                ) && 
                (
                    this.ContactMobile == input.ContactMobile ||
                    (this.ContactMobile != null &&
                    this.ContactMobile.Equals(input.ContactMobile))
                ) && 
                (
                    this.ContactPhone == input.ContactPhone ||
                    (this.ContactPhone != null &&
                    this.ContactPhone.Equals(input.ContactPhone))
                ) && 
                (
                    this.ExtInfos == input.ExtInfos ||
                    this.ExtInfos != null &&
                    input.ExtInfos != null &&
                    this.ExtInfos.SequenceEqual(input.ExtInfos)
                ) && 
                (
                    this.IpRoleId == input.IpRoleId ||
                    (this.IpRoleId != null &&
                    this.IpRoleId.Equals(input.IpRoleId))
                ) && 
                (
                    this.LegalCertNo == input.LegalCertNo ||
                    (this.LegalCertNo != null &&
                    this.LegalCertNo.Equals(input.LegalCertNo))
                ) && 
                (
                    this.LegalName == input.LegalName ||
                    (this.LegalName != null &&
                    this.LegalName.Equals(input.LegalName))
                ) && 
                (
                    this.LicenseAuthLetterImage == input.LicenseAuthLetterImage ||
                    (this.LicenseAuthLetterImage != null &&
                    this.LicenseAuthLetterImage.Equals(input.LicenseAuthLetterImage))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.NewShopCategory == input.NewShopCategory ||
                    (this.NewShopCategory != null &&
                    this.NewShopCategory.Equals(input.NewShopCategory))
                ) && 
                (
                    this.OutDoorImages == input.OutDoorImages ||
                    this.OutDoorImages != null &&
                    input.OutDoorImages != null &&
                    this.OutDoorImages.SequenceEqual(input.OutDoorImages)
                ) && 
                (
                    this.Qualifications == input.Qualifications ||
                    this.Qualifications != null &&
                    input.Qualifications != null &&
                    this.Qualifications.SequenceEqual(input.Qualifications)
                ) && 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
                ) && 
                (
                    this.SettleAlipayLogonId == input.SettleAlipayLogonId ||
                    (this.SettleAlipayLogonId != null &&
                    this.SettleAlipayLogonId.Equals(input.SettleAlipayLogonId))
                ) && 
                (
                    this.ShopCategory == input.ShopCategory ||
                    (this.ShopCategory != null &&
                    this.ShopCategory.Equals(input.ShopCategory))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.ShopInfoStatus == input.ShopInfoStatus ||
                    (this.ShopInfoStatus != null &&
                    this.ShopInfoStatus.Equals(input.ShopInfoStatus))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.ShopRecommendInfo == input.ShopRecommendInfo ||
                    (this.ShopRecommendInfo != null &&
                    this.ShopRecommendInfo.Equals(input.ShopRecommendInfo))
                ) && 
                (
                    this.ShopType == input.ShopType ||
                    (this.ShopType != null &&
                    this.ShopType.Equals(input.ShopType))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
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
                if (this.BrandId != null)
                {
                    hashCode = (hashCode * 59) + this.BrandId.GetHashCode();
                }
                if (this.BusinessAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessAddress.GetHashCode();
                }
                if (this.BusinessTime != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessTime.GetHashCode();
                }
                if (this.CertImage != null)
                {
                    hashCode = (hashCode * 59) + this.CertImage.GetHashCode();
                }
                if (this.CertName != null)
                {
                    hashCode = (hashCode * 59) + this.CertName.GetHashCode();
                }
                if (this.CertNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertNo.GetHashCode();
                }
                if (this.CertType != null)
                {
                    hashCode = (hashCode * 59) + this.CertType.GetHashCode();
                }
                if (this.ContactInfos != null)
                {
                    hashCode = (hashCode * 59) + this.ContactInfos.GetHashCode();
                }
                if (this.ContactMobile != null)
                {
                    hashCode = (hashCode * 59) + this.ContactMobile.GetHashCode();
                }
                if (this.ContactPhone != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPhone.GetHashCode();
                }
                if (this.ExtInfos != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfos.GetHashCode();
                }
                if (this.IpRoleId != null)
                {
                    hashCode = (hashCode * 59) + this.IpRoleId.GetHashCode();
                }
                if (this.LegalCertNo != null)
                {
                    hashCode = (hashCode * 59) + this.LegalCertNo.GetHashCode();
                }
                if (this.LegalName != null)
                {
                    hashCode = (hashCode * 59) + this.LegalName.GetHashCode();
                }
                if (this.LicenseAuthLetterImage != null)
                {
                    hashCode = (hashCode * 59) + this.LicenseAuthLetterImage.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.NewShopCategory != null)
                {
                    hashCode = (hashCode * 59) + this.NewShopCategory.GetHashCode();
                }
                if (this.OutDoorImages != null)
                {
                    hashCode = (hashCode * 59) + this.OutDoorImages.GetHashCode();
                }
                if (this.Qualifications != null)
                {
                    hashCode = (hashCode * 59) + this.Qualifications.GetHashCode();
                }
                if (this.Scene != null)
                {
                    hashCode = (hashCode * 59) + this.Scene.GetHashCode();
                }
                if (this.SettleAlipayLogonId != null)
                {
                    hashCode = (hashCode * 59) + this.SettleAlipayLogonId.GetHashCode();
                }
                if (this.ShopCategory != null)
                {
                    hashCode = (hashCode * 59) + this.ShopCategory.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
                }
                if (this.ShopInfoStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ShopInfoStatus.GetHashCode();
                }
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
                }
                if (this.ShopRecommendInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ShopRecommendInfo.GetHashCode();
                }
                if (this.ShopType != null)
                {
                    hashCode = (hashCode * 59) + this.ShopType.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
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
