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
    /// AlipayOpenAgentFacetofaceSignModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAgentFacetofaceSignModel")]
    public partial class AlipayOpenAgentFacetofaceSignModel : IEquatable<AlipayOpenAgentFacetofaceSignModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentFacetofaceSignModel" /> class.
        /// </summary>
        /// <param name="batchNo">代商户操作事务编号，通过https://opendocs.alipay.com/apis/api_50/alipay.open.agent.create (开启代商户签约、创建应用事务)接口进行事务创建后获取。.</param>
        /// <param name="businessLicenseMobile">被邀请授权的营业执照法人手机号码，上传非同人营业执照时必填.</param>
        /// <param name="businessLicenseNo">营业执照号码.</param>
        /// <param name="dateLimitation">营业期限.</param>
        /// <param name="longTerm">营业期限是否长期有效.</param>
        /// <param name="mccCode">商家经营类目编码。参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE\&quot;&gt;商家经营类目2.0&lt;/a&gt; 中的“一级类目code_二级类目code”。.</param>
        /// <param name="rate">服务费率（%），0.38~0.6 之间（小数点后两位，可取0.38%及0.6%）。 当签约且授权标识 sign_and_auth&#x3D;true 时，该费率信息必填。.</param>
        /// <param name="shopAddress">shopAddress.</param>
        /// <param name="shopName">店铺名称.</param>
        /// <param name="signAndAuth">签约且授权标识，默认为false，只进行签约操作； 如果设置为true，则表示签约成功后，会自动进行应用授权操作。.</param>
        public AlipayOpenAgentFacetofaceSignModel(string batchNo = default(string), string businessLicenseMobile = default(string), string businessLicenseNo = default(string), string dateLimitation = default(string), bool longTerm = default(bool), string mccCode = default(string), string rate = default(string), SignAddressInfo shopAddress = default(SignAddressInfo), string shopName = default(string), bool signAndAuth = default(bool))
        {
            this.BatchNo = batchNo;
            this.BusinessLicenseMobile = businessLicenseMobile;
            this.BusinessLicenseNo = businessLicenseNo;
            this.DateLimitation = dateLimitation;
            this.LongTerm = longTerm;
            this.MccCode = mccCode;
            this.Rate = rate;
            this.ShopAddress = shopAddress;
            this.ShopName = shopName;
            this.SignAndAuth = signAndAuth;
        }

        /// <summary>
        /// 代商户操作事务编号，通过https://opendocs.alipay.com/apis/api_50/alipay.open.agent.create (开启代商户签约、创建应用事务)接口进行事务创建后获取。
        /// </summary>
        /// <value>代商户操作事务编号，通过https://opendocs.alipay.com/apis/api_50/alipay.open.agent.create (开启代商户签约、创建应用事务)接口进行事务创建后获取。</value>
        [DataMember(Name = "batch_no", EmitDefaultValue = false)]
        public string BatchNo { get; set; }

        /// <summary>
        /// 被邀请授权的营业执照法人手机号码，上传非同人营业执照时必填
        /// </summary>
        /// <value>被邀请授权的营业执照法人手机号码，上传非同人营业执照时必填</value>
        [DataMember(Name = "business_license_mobile", EmitDefaultValue = false)]
        public string BusinessLicenseMobile { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        /// <value>营业执照号码</value>
        [DataMember(Name = "business_license_no", EmitDefaultValue = false)]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        /// <value>营业期限</value>
        [DataMember(Name = "date_limitation", EmitDefaultValue = false)]
        public string DateLimitation { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        /// <value>营业期限是否长期有效</value>
        [DataMember(Name = "long_term", EmitDefaultValue = true)]
        public bool LongTerm { get; set; }

        /// <summary>
        /// 商家经营类目编码。参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE\&quot;&gt;商家经营类目2.0&lt;/a&gt; 中的“一级类目code_二级类目code”。
        /// </summary>
        /// <value>商家经营类目编码。参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE\&quot;&gt;商家经营类目2.0&lt;/a&gt; 中的“一级类目code_二级类目code”。</value>
        [DataMember(Name = "mcc_code", EmitDefaultValue = false)]
        public string MccCode { get; set; }

        /// <summary>
        /// 服务费率（%），0.38~0.6 之间（小数点后两位，可取0.38%及0.6%）。 当签约且授权标识 sign_and_auth&#x3D;true 时，该费率信息必填。
        /// </summary>
        /// <value>服务费率（%），0.38~0.6 之间（小数点后两位，可取0.38%及0.6%）。 当签约且授权标识 sign_and_auth&#x3D;true 时，该费率信息必填。</value>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public string Rate { get; set; }

        /// <summary>
        /// Gets or Sets ShopAddress
        /// </summary>
        [DataMember(Name = "shop_address", EmitDefaultValue = false)]
        public SignAddressInfo ShopAddress { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        /// <value>店铺名称</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// 签约且授权标识，默认为false，只进行签约操作； 如果设置为true，则表示签约成功后，会自动进行应用授权操作。
        /// </summary>
        /// <value>签约且授权标识，默认为false，只进行签约操作； 如果设置为true，则表示签约成功后，会自动进行应用授权操作。</value>
        [DataMember(Name = "sign_and_auth", EmitDefaultValue = true)]
        public bool SignAndAuth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAgentFacetofaceSignModel {\n");
            sb.Append("  BatchNo: ").Append(BatchNo).Append("\n");
            sb.Append("  BusinessLicenseMobile: ").Append(BusinessLicenseMobile).Append("\n");
            sb.Append("  BusinessLicenseNo: ").Append(BusinessLicenseNo).Append("\n");
            sb.Append("  DateLimitation: ").Append(DateLimitation).Append("\n");
            sb.Append("  LongTerm: ").Append(LongTerm).Append("\n");
            sb.Append("  MccCode: ").Append(MccCode).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  ShopAddress: ").Append(ShopAddress).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  SignAndAuth: ").Append(SignAndAuth).Append("\n");
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
            return this.Equals(input as AlipayOpenAgentFacetofaceSignModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentFacetofaceSignModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentFacetofaceSignModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentFacetofaceSignModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BatchNo == input.BatchNo ||
                    (this.BatchNo != null &&
                    this.BatchNo.Equals(input.BatchNo))
                ) && 
                (
                    this.BusinessLicenseMobile == input.BusinessLicenseMobile ||
                    (this.BusinessLicenseMobile != null &&
                    this.BusinessLicenseMobile.Equals(input.BusinessLicenseMobile))
                ) && 
                (
                    this.BusinessLicenseNo == input.BusinessLicenseNo ||
                    (this.BusinessLicenseNo != null &&
                    this.BusinessLicenseNo.Equals(input.BusinessLicenseNo))
                ) && 
                (
                    this.DateLimitation == input.DateLimitation ||
                    (this.DateLimitation != null &&
                    this.DateLimitation.Equals(input.DateLimitation))
                ) && 
                (
                    this.LongTerm == input.LongTerm ||
                    this.LongTerm.Equals(input.LongTerm)
                ) && 
                (
                    this.MccCode == input.MccCode ||
                    (this.MccCode != null &&
                    this.MccCode.Equals(input.MccCode))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.ShopAddress == input.ShopAddress ||
                    (this.ShopAddress != null &&
                    this.ShopAddress.Equals(input.ShopAddress))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.SignAndAuth == input.SignAndAuth ||
                    this.SignAndAuth.Equals(input.SignAndAuth)
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
                if (this.BatchNo != null)
                {
                    hashCode = (hashCode * 59) + this.BatchNo.GetHashCode();
                }
                if (this.BusinessLicenseMobile != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicenseMobile.GetHashCode();
                }
                if (this.BusinessLicenseNo != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicenseNo.GetHashCode();
                }
                if (this.DateLimitation != null)
                {
                    hashCode = (hashCode * 59) + this.DateLimitation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LongTerm.GetHashCode();
                if (this.MccCode != null)
                {
                    hashCode = (hashCode * 59) + this.MccCode.GetHashCode();
                }
                if (this.Rate != null)
                {
                    hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                }
                if (this.ShopAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ShopAddress.GetHashCode();
                }
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SignAndAuth.GetHashCode();
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
