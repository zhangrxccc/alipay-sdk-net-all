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
    /// AlipayOpenAgentCommonSignModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAgentCommonSignModel")]
    public partial class AlipayOpenAgentCommonSignModel : IEquatable<AlipayOpenAgentCommonSignModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentCommonSignModel" /> class.
        /// </summary>
        /// <param name="alipayLifeName">支付宝生活号(原服务窗)名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name。1、2、3少选择一个填写）.</param>
        /// <param name="appMarket">投放应用市场.</param>
        /// <param name="appName">商户的APP应用名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）.</param>
        /// <param name="appStatus">应用状态.</param>
        /// <param name="appTestAccount">可以登录该应用的测试账户.</param>
        /// <param name="appTestAccountPassword">可以登录此应用的账户的密码。对app_test_account的登录密码。.</param>
        /// <param name="batchNo">代商户操作事务编号，通过alipay.open.agent.create接口进行创建。.</param>
        /// <param name="businessLicenseNo">营业执照号码.</param>
        /// <param name="dateLimitation">营业期限.</param>
        /// <param name="downloadLink">应用下载链接.</param>
        /// <param name="h5Memo">网站扩展信息文本.</param>
        /// <param name="h5Sites">H5网站地址.</param>
        /// <param name="h5Status">H5网站状态.</param>
        /// <param name="lifeAppId">请输入被签约商户的支付宝生活号ID编号.</param>
        /// <param name="longTerm">营业期限是否长期有效.</param>
        /// <param name="mccCode">&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/common/02khjv\&quot;&gt;商家经营类目&lt;/a&gt; 中的“经营类目编码”.</param>
        /// <param name="miniAppId">请输入被签约商家下任意小程序APPID ID编号.</param>
        /// <param name="miniAppName">小程序名称.</param>
        /// <param name="mobileType">移动设备类型，当开通电脑网站支付产品时不需赋值；当开通手机网站支付时，传H5；当开通JSAPI时，传APP；当开通预授权支付产品，且交易场景选择“mobile”(移动设备)时，需要从APP,H5中至少选择一个，可多选，字符串英文逗号分隔。.</param>
        /// <param name="productCode">isv要代商户签约产品码，产品码是支付宝内部对产品的唯一标识.</param>
        /// <param name="rate">服务费率（%），例如：请输入0.38~0.6 之间（小数点后两位，可取0.38%及0.6%），直播买卖通涉及JSAPI支付产品，交易手续费为 0.38%-0.6%，后续费率变化可参考支付宝标准服务费。 当签约且授权标识 sign_and_auth&#x3D;true 时，该费率信息必填。.</param>
        /// <param name="shopCityCode">门店所在城市.</param>
        /// <param name="shopDetailAddress">门店详细地址.</param>
        /// <param name="shopDistrictCode">门店所在区/县.</param>
        /// <param name="shopName">门店名称.</param>
        /// <param name="shopProvinceCode">门店所在省份.</param>
        /// <param name="specialLicenseType">合约特殊资质的类型，不传默认99.</param>
        /// <param name="tradeScene">交易场景，当开通产品为电脑网站支付时，传pc；当开通产品为手机网站支付时，传mobile；当开通产品为JSAPI时，传tiny_app；当开通产品为预授权支付时，下面括号中三个至少传一个（tiny_app,mobile,offline_store），可多选，字符串用英文逗号分隔.</param>
        /// <param name="webSites">接入网址信息（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）.</param>
        /// <param name="webStatus">网站状态，枚举值为：ONLINE，OFFLINE.</param>
        /// <param name="webTestAccount">可以登录此网站的测试账户。.</param>
        /// <param name="webTestAccountPassword">可以登录此网站的账户的密码。对应web_test_account的登录密码.</param>
        /// <param name="wechatOfficialAccountName">1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写(该字段已经不在使用，废弃，不用填写).</param>
        public AlipayOpenAgentCommonSignModel(string alipayLifeName = default(string), string appMarket = default(string), string appName = default(string), string appStatus = default(string), string appTestAccount = default(string), string appTestAccountPassword = default(string), string batchNo = default(string), string businessLicenseNo = default(string), string dateLimitation = default(string), string downloadLink = default(string), string h5Memo = default(string), string h5Sites = default(string), string h5Status = default(string), string lifeAppId = default(string), bool longTerm = default(bool), string mccCode = default(string), string miniAppId = default(string), string miniAppName = default(string), string mobileType = default(string), string productCode = default(string), string rate = default(string), string shopCityCode = default(string), string shopDetailAddress = default(string), string shopDistrictCode = default(string), string shopName = default(string), string shopProvinceCode = default(string), string specialLicenseType = default(string), string tradeScene = default(string), List<string> webSites = default(List<string>), string webStatus = default(string), string webTestAccount = default(string), string webTestAccountPassword = default(string), string wechatOfficialAccountName = default(string))
        {
            this.AlipayLifeName = alipayLifeName;
            this.AppMarket = appMarket;
            this.AppName = appName;
            this.AppStatus = appStatus;
            this.AppTestAccount = appTestAccount;
            this.AppTestAccountPassword = appTestAccountPassword;
            this.BatchNo = batchNo;
            this.BusinessLicenseNo = businessLicenseNo;
            this.DateLimitation = dateLimitation;
            this.DownloadLink = downloadLink;
            this.H5Memo = h5Memo;
            this.H5Sites = h5Sites;
            this.H5Status = h5Status;
            this.LifeAppId = lifeAppId;
            this.LongTerm = longTerm;
            this.MccCode = mccCode;
            this.MiniAppId = miniAppId;
            this.MiniAppName = miniAppName;
            this.MobileType = mobileType;
            this.ProductCode = productCode;
            this.Rate = rate;
            this.ShopCityCode = shopCityCode;
            this.ShopDetailAddress = shopDetailAddress;
            this.ShopDistrictCode = shopDistrictCode;
            this.ShopName = shopName;
            this.ShopProvinceCode = shopProvinceCode;
            this.SpecialLicenseType = specialLicenseType;
            this.TradeScene = tradeScene;
            this.WebSites = webSites;
            this.WebStatus = webStatus;
            this.WebTestAccount = webTestAccount;
            this.WebTestAccountPassword = webTestAccountPassword;
            this.WechatOfficialAccountName = wechatOfficialAccountName;
        }

        /// <summary>
        /// 支付宝生活号(原服务窗)名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name。1、2、3少选择一个填写）
        /// </summary>
        /// <value>支付宝生活号(原服务窗)名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name。1、2、3少选择一个填写）</value>
        [DataMember(Name = "alipay_life_name", EmitDefaultValue = false)]
        public string AlipayLifeName { get; set; }

        /// <summary>
        /// 投放应用市场
        /// </summary>
        /// <value>投放应用市场</value>
        [DataMember(Name = "app_market", EmitDefaultValue = false)]
        public string AppMarket { get; set; }

        /// <summary>
        /// 商户的APP应用名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        /// <value>商户的APP应用名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        /// <value>应用状态</value>
        [DataMember(Name = "app_status", EmitDefaultValue = false)]
        public string AppStatus { get; set; }

        /// <summary>
        /// 可以登录该应用的测试账户
        /// </summary>
        /// <value>可以登录该应用的测试账户</value>
        [DataMember(Name = "app_test_account", EmitDefaultValue = false)]
        public string AppTestAccount { get; set; }

        /// <summary>
        /// 可以登录此应用的账户的密码。对app_test_account的登录密码。
        /// </summary>
        /// <value>可以登录此应用的账户的密码。对app_test_account的登录密码。</value>
        [DataMember(Name = "app_test_account_password", EmitDefaultValue = false)]
        public string AppTestAccountPassword { get; set; }

        /// <summary>
        /// 代商户操作事务编号，通过alipay.open.agent.create接口进行创建。
        /// </summary>
        /// <value>代商户操作事务编号，通过alipay.open.agent.create接口进行创建。</value>
        [DataMember(Name = "batch_no", EmitDefaultValue = false)]
        public string BatchNo { get; set; }

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
        /// 应用下载链接
        /// </summary>
        /// <value>应用下载链接</value>
        [DataMember(Name = "download_link", EmitDefaultValue = false)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// 网站扩展信息文本
        /// </summary>
        /// <value>网站扩展信息文本</value>
        [DataMember(Name = "h_5_memo", EmitDefaultValue = false)]
        public string H5Memo { get; set; }

        /// <summary>
        /// H5网站地址
        /// </summary>
        /// <value>H5网站地址</value>
        [DataMember(Name = "h_5_sites", EmitDefaultValue = false)]
        public string H5Sites { get; set; }

        /// <summary>
        /// H5网站状态
        /// </summary>
        /// <value>H5网站状态</value>
        [DataMember(Name = "h_5_status", EmitDefaultValue = false)]
        public string H5Status { get; set; }

        /// <summary>
        /// 请输入被签约商户的支付宝生活号ID编号
        /// </summary>
        /// <value>请输入被签约商户的支付宝生活号ID编号</value>
        [DataMember(Name = "life_app_id", EmitDefaultValue = false)]
        public string LifeAppId { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        /// <value>营业期限是否长期有效</value>
        [DataMember(Name = "long_term", EmitDefaultValue = true)]
        public bool LongTerm { get; set; }

        /// <summary>
        /// &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/common/02khjv\&quot;&gt;商家经营类目&lt;/a&gt; 中的“经营类目编码”
        /// </summary>
        /// <value>&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/common/02khjv\&quot;&gt;商家经营类目&lt;/a&gt; 中的“经营类目编码”</value>
        [DataMember(Name = "mcc_code", EmitDefaultValue = false)]
        public string MccCode { get; set; }

        /// <summary>
        /// 请输入被签约商家下任意小程序APPID ID编号
        /// </summary>
        /// <value>请输入被签约商家下任意小程序APPID ID编号</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        /// <value>小程序名称</value>
        [DataMember(Name = "mini_app_name", EmitDefaultValue = false)]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 移动设备类型，当开通电脑网站支付产品时不需赋值；当开通手机网站支付时，传H5；当开通JSAPI时，传APP；当开通预授权支付产品，且交易场景选择“mobile”(移动设备)时，需要从APP,H5中至少选择一个，可多选，字符串英文逗号分隔。
        /// </summary>
        /// <value>移动设备类型，当开通电脑网站支付产品时不需赋值；当开通手机网站支付时，传H5；当开通JSAPI时，传APP；当开通预授权支付产品，且交易场景选择“mobile”(移动设备)时，需要从APP,H5中至少选择一个，可多选，字符串英文逗号分隔。</value>
        [DataMember(Name = "mobile_type", EmitDefaultValue = false)]
        public string MobileType { get; set; }

        /// <summary>
        /// isv要代商户签约产品码，产品码是支付宝内部对产品的唯一标识
        /// </summary>
        /// <value>isv要代商户签约产品码，产品码是支付宝内部对产品的唯一标识</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 服务费率（%），例如：请输入0.38~0.6 之间（小数点后两位，可取0.38%及0.6%），直播买卖通涉及JSAPI支付产品，交易手续费为 0.38%-0.6%，后续费率变化可参考支付宝标准服务费。 当签约且授权标识 sign_and_auth&#x3D;true 时，该费率信息必填。
        /// </summary>
        /// <value>服务费率（%），例如：请输入0.38~0.6 之间（小数点后两位，可取0.38%及0.6%），直播买卖通涉及JSAPI支付产品，交易手续费为 0.38%-0.6%，后续费率变化可参考支付宝标准服务费。 当签约且授权标识 sign_and_auth&#x3D;true 时，该费率信息必填。</value>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public string Rate { get; set; }

        /// <summary>
        /// 门店所在城市
        /// </summary>
        /// <value>门店所在城市</value>
        [DataMember(Name = "shop_city_code", EmitDefaultValue = false)]
        public string ShopCityCode { get; set; }

        /// <summary>
        /// 门店详细地址
        /// </summary>
        /// <value>门店详细地址</value>
        [DataMember(Name = "shop_detail_address", EmitDefaultValue = false)]
        public string ShopDetailAddress { get; set; }

        /// <summary>
        /// 门店所在区/县
        /// </summary>
        /// <value>门店所在区/县</value>
        [DataMember(Name = "shop_district_code", EmitDefaultValue = false)]
        public string ShopDistrictCode { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        /// <value>门店名称</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店所在省份
        /// </summary>
        /// <value>门店所在省份</value>
        [DataMember(Name = "shop_province_code", EmitDefaultValue = false)]
        public string ShopProvinceCode { get; set; }

        /// <summary>
        /// 合约特殊资质的类型，不传默认99
        /// </summary>
        /// <value>合约特殊资质的类型，不传默认99</value>
        [DataMember(Name = "special_license_type", EmitDefaultValue = false)]
        public string SpecialLicenseType { get; set; }

        /// <summary>
        /// 交易场景，当开通产品为电脑网站支付时，传pc；当开通产品为手机网站支付时，传mobile；当开通产品为JSAPI时，传tiny_app；当开通产品为预授权支付时，下面括号中三个至少传一个（tiny_app,mobile,offline_store），可多选，字符串用英文逗号分隔
        /// </summary>
        /// <value>交易场景，当开通产品为电脑网站支付时，传pc；当开通产品为手机网站支付时，传mobile；当开通产品为JSAPI时，传tiny_app；当开通产品为预授权支付时，下面括号中三个至少传一个（tiny_app,mobile,offline_store），可多选，字符串用英文逗号分隔</value>
        [DataMember(Name = "trade_scene", EmitDefaultValue = false)]
        public string TradeScene { get; set; }

        /// <summary>
        /// 接入网址信息（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        /// <value>接入网址信息（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）</value>
        [DataMember(Name = "web_sites", EmitDefaultValue = false)]
        public List<string> WebSites { get; set; }

        /// <summary>
        /// 网站状态，枚举值为：ONLINE，OFFLINE
        /// </summary>
        /// <value>网站状态，枚举值为：ONLINE，OFFLINE</value>
        [DataMember(Name = "web_status", EmitDefaultValue = false)]
        public string WebStatus { get; set; }

        /// <summary>
        /// 可以登录此网站的测试账户。
        /// </summary>
        /// <value>可以登录此网站的测试账户。</value>
        [DataMember(Name = "web_test_account", EmitDefaultValue = false)]
        public string WebTestAccount { get; set; }

        /// <summary>
        /// 可以登录此网站的账户的密码。对应web_test_account的登录密码
        /// </summary>
        /// <value>可以登录此网站的账户的密码。对应web_test_account的登录密码</value>
        [DataMember(Name = "web_test_account_password", EmitDefaultValue = false)]
        public string WebTestAccountPassword { get; set; }

        /// <summary>
        /// 1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写(该字段已经不在使用，废弃，不用填写)
        /// </summary>
        /// <value>1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写(该字段已经不在使用，废弃，不用填写)</value>
        [DataMember(Name = "wechat_official_account_name", EmitDefaultValue = false)]
        [Obsolete]
        public string WechatOfficialAccountName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAgentCommonSignModel {\n");
            sb.Append("  AlipayLifeName: ").Append(AlipayLifeName).Append("\n");
            sb.Append("  AppMarket: ").Append(AppMarket).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppStatus: ").Append(AppStatus).Append("\n");
            sb.Append("  AppTestAccount: ").Append(AppTestAccount).Append("\n");
            sb.Append("  AppTestAccountPassword: ").Append(AppTestAccountPassword).Append("\n");
            sb.Append("  BatchNo: ").Append(BatchNo).Append("\n");
            sb.Append("  BusinessLicenseNo: ").Append(BusinessLicenseNo).Append("\n");
            sb.Append("  DateLimitation: ").Append(DateLimitation).Append("\n");
            sb.Append("  DownloadLink: ").Append(DownloadLink).Append("\n");
            sb.Append("  H5Memo: ").Append(H5Memo).Append("\n");
            sb.Append("  H5Sites: ").Append(H5Sites).Append("\n");
            sb.Append("  H5Status: ").Append(H5Status).Append("\n");
            sb.Append("  LifeAppId: ").Append(LifeAppId).Append("\n");
            sb.Append("  LongTerm: ").Append(LongTerm).Append("\n");
            sb.Append("  MccCode: ").Append(MccCode).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  MiniAppName: ").Append(MiniAppName).Append("\n");
            sb.Append("  MobileType: ").Append(MobileType).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  ShopCityCode: ").Append(ShopCityCode).Append("\n");
            sb.Append("  ShopDetailAddress: ").Append(ShopDetailAddress).Append("\n");
            sb.Append("  ShopDistrictCode: ").Append(ShopDistrictCode).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  ShopProvinceCode: ").Append(ShopProvinceCode).Append("\n");
            sb.Append("  SpecialLicenseType: ").Append(SpecialLicenseType).Append("\n");
            sb.Append("  TradeScene: ").Append(TradeScene).Append("\n");
            sb.Append("  WebSites: ").Append(WebSites).Append("\n");
            sb.Append("  WebStatus: ").Append(WebStatus).Append("\n");
            sb.Append("  WebTestAccount: ").Append(WebTestAccount).Append("\n");
            sb.Append("  WebTestAccountPassword: ").Append(WebTestAccountPassword).Append("\n");
            sb.Append("  WechatOfficialAccountName: ").Append(WechatOfficialAccountName).Append("\n");
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
            return this.Equals(input as AlipayOpenAgentCommonSignModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentCommonSignModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentCommonSignModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentCommonSignModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlipayLifeName == input.AlipayLifeName ||
                    (this.AlipayLifeName != null &&
                    this.AlipayLifeName.Equals(input.AlipayLifeName))
                ) && 
                (
                    this.AppMarket == input.AppMarket ||
                    (this.AppMarket != null &&
                    this.AppMarket.Equals(input.AppMarket))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppStatus == input.AppStatus ||
                    (this.AppStatus != null &&
                    this.AppStatus.Equals(input.AppStatus))
                ) && 
                (
                    this.AppTestAccount == input.AppTestAccount ||
                    (this.AppTestAccount != null &&
                    this.AppTestAccount.Equals(input.AppTestAccount))
                ) && 
                (
                    this.AppTestAccountPassword == input.AppTestAccountPassword ||
                    (this.AppTestAccountPassword != null &&
                    this.AppTestAccountPassword.Equals(input.AppTestAccountPassword))
                ) && 
                (
                    this.BatchNo == input.BatchNo ||
                    (this.BatchNo != null &&
                    this.BatchNo.Equals(input.BatchNo))
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
                    this.DownloadLink == input.DownloadLink ||
                    (this.DownloadLink != null &&
                    this.DownloadLink.Equals(input.DownloadLink))
                ) && 
                (
                    this.H5Memo == input.H5Memo ||
                    (this.H5Memo != null &&
                    this.H5Memo.Equals(input.H5Memo))
                ) && 
                (
                    this.H5Sites == input.H5Sites ||
                    (this.H5Sites != null &&
                    this.H5Sites.Equals(input.H5Sites))
                ) && 
                (
                    this.H5Status == input.H5Status ||
                    (this.H5Status != null &&
                    this.H5Status.Equals(input.H5Status))
                ) && 
                (
                    this.LifeAppId == input.LifeAppId ||
                    (this.LifeAppId != null &&
                    this.LifeAppId.Equals(input.LifeAppId))
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
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.MiniAppName == input.MiniAppName ||
                    (this.MiniAppName != null &&
                    this.MiniAppName.Equals(input.MiniAppName))
                ) && 
                (
                    this.MobileType == input.MobileType ||
                    (this.MobileType != null &&
                    this.MobileType.Equals(input.MobileType))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.ShopCityCode == input.ShopCityCode ||
                    (this.ShopCityCode != null &&
                    this.ShopCityCode.Equals(input.ShopCityCode))
                ) && 
                (
                    this.ShopDetailAddress == input.ShopDetailAddress ||
                    (this.ShopDetailAddress != null &&
                    this.ShopDetailAddress.Equals(input.ShopDetailAddress))
                ) && 
                (
                    this.ShopDistrictCode == input.ShopDistrictCode ||
                    (this.ShopDistrictCode != null &&
                    this.ShopDistrictCode.Equals(input.ShopDistrictCode))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.ShopProvinceCode == input.ShopProvinceCode ||
                    (this.ShopProvinceCode != null &&
                    this.ShopProvinceCode.Equals(input.ShopProvinceCode))
                ) && 
                (
                    this.SpecialLicenseType == input.SpecialLicenseType ||
                    (this.SpecialLicenseType != null &&
                    this.SpecialLicenseType.Equals(input.SpecialLicenseType))
                ) && 
                (
                    this.TradeScene == input.TradeScene ||
                    (this.TradeScene != null &&
                    this.TradeScene.Equals(input.TradeScene))
                ) && 
                (
                    this.WebSites == input.WebSites ||
                    this.WebSites != null &&
                    input.WebSites != null &&
                    this.WebSites.SequenceEqual(input.WebSites)
                ) && 
                (
                    this.WebStatus == input.WebStatus ||
                    (this.WebStatus != null &&
                    this.WebStatus.Equals(input.WebStatus))
                ) && 
                (
                    this.WebTestAccount == input.WebTestAccount ||
                    (this.WebTestAccount != null &&
                    this.WebTestAccount.Equals(input.WebTestAccount))
                ) && 
                (
                    this.WebTestAccountPassword == input.WebTestAccountPassword ||
                    (this.WebTestAccountPassword != null &&
                    this.WebTestAccountPassword.Equals(input.WebTestAccountPassword))
                ) && 
                (
                    this.WechatOfficialAccountName == input.WechatOfficialAccountName ||
                    (this.WechatOfficialAccountName != null &&
                    this.WechatOfficialAccountName.Equals(input.WechatOfficialAccountName))
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
                if (this.AlipayLifeName != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayLifeName.GetHashCode();
                }
                if (this.AppMarket != null)
                {
                    hashCode = (hashCode * 59) + this.AppMarket.GetHashCode();
                }
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.AppStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AppStatus.GetHashCode();
                }
                if (this.AppTestAccount != null)
                {
                    hashCode = (hashCode * 59) + this.AppTestAccount.GetHashCode();
                }
                if (this.AppTestAccountPassword != null)
                {
                    hashCode = (hashCode * 59) + this.AppTestAccountPassword.GetHashCode();
                }
                if (this.BatchNo != null)
                {
                    hashCode = (hashCode * 59) + this.BatchNo.GetHashCode();
                }
                if (this.BusinessLicenseNo != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicenseNo.GetHashCode();
                }
                if (this.DateLimitation != null)
                {
                    hashCode = (hashCode * 59) + this.DateLimitation.GetHashCode();
                }
                if (this.DownloadLink != null)
                {
                    hashCode = (hashCode * 59) + this.DownloadLink.GetHashCode();
                }
                if (this.H5Memo != null)
                {
                    hashCode = (hashCode * 59) + this.H5Memo.GetHashCode();
                }
                if (this.H5Sites != null)
                {
                    hashCode = (hashCode * 59) + this.H5Sites.GetHashCode();
                }
                if (this.H5Status != null)
                {
                    hashCode = (hashCode * 59) + this.H5Status.GetHashCode();
                }
                if (this.LifeAppId != null)
                {
                    hashCode = (hashCode * 59) + this.LifeAppId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LongTerm.GetHashCode();
                if (this.MccCode != null)
                {
                    hashCode = (hashCode * 59) + this.MccCode.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.MiniAppName != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppName.GetHashCode();
                }
                if (this.MobileType != null)
                {
                    hashCode = (hashCode * 59) + this.MobileType.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.Rate != null)
                {
                    hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                }
                if (this.ShopCityCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShopCityCode.GetHashCode();
                }
                if (this.ShopDetailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ShopDetailAddress.GetHashCode();
                }
                if (this.ShopDistrictCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShopDistrictCode.GetHashCode();
                }
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
                }
                if (this.ShopProvinceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShopProvinceCode.GetHashCode();
                }
                if (this.SpecialLicenseType != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialLicenseType.GetHashCode();
                }
                if (this.TradeScene != null)
                {
                    hashCode = (hashCode * 59) + this.TradeScene.GetHashCode();
                }
                if (this.WebSites != null)
                {
                    hashCode = (hashCode * 59) + this.WebSites.GetHashCode();
                }
                if (this.WebStatus != null)
                {
                    hashCode = (hashCode * 59) + this.WebStatus.GetHashCode();
                }
                if (this.WebTestAccount != null)
                {
                    hashCode = (hashCode * 59) + this.WebTestAccount.GetHashCode();
                }
                if (this.WebTestAccountPassword != null)
                {
                    hashCode = (hashCode * 59) + this.WebTestAccountPassword.GetHashCode();
                }
                if (this.WechatOfficialAccountName != null)
                {
                    hashCode = (hashCode * 59) + this.WechatOfficialAccountName.GetHashCode();
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
