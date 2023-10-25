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
    /// AlipayUserUserinfoShareResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserUserinfoShareResponseModel")]
    public partial class AlipayUserUserinfoShareResponseModel : IEquatable<AlipayUserUserinfoShareResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserUserinfoShareResponseModel" /> class.
        /// </summary>
        /// <param name="address">详细地址。.</param>
        /// <param name="addressCode">区域编码，暂时不返回值.</param>
        /// <param name="alipayUserId">支付宝用户ID.</param>
        /// <param name="area">区县名称。.</param>
        /// <param name="avatar">用户头像.</param>
        /// <param name="balanceFreezeType">【注意】当is_balance_frozen为“F”时，改字段不会返回.  CTU - -- - CTU冻结，允许用户开启  ALIBABA - -- - ALIBABA冻结，允许用户开启  SERVER - -- - 后台冻结，允许用户开启  USER - -- -  用户冻结   CTU_N- -- - CTU冻结，不允许用户开启  ALIBABA_N - -- - ALIBABA冻结，不允许用户开启  SERVER_N - -- - 后台冻结，不允许用户开启  UNKNOWN - -- - 降级、或查询超时.</param>
        /// <param name="birthday">用户生日.</param>
        /// <param name="certNo">证件号码.</param>
        /// <param name="certTypeValue">0:身份证  1:护照  2:军官证  3:士兵证  4:回乡证  5:临时身份证  6:户口簿  7:警官证  8:台胞证  9:营业执照  10其它证件.</param>
        /// <param name="city">市名称。.</param>
        /// <param name="defaultDeliverAddress">是否默认收货地址，暂时不返回值.</param>
        /// <param name="deliverAddressList">收货人地址列表.</param>
        /// <param name="deliverArea">收货人所在区县.</param>
        /// <param name="deliverCity">收货人所在城市.</param>
        /// <param name="deliverFullname">收货人全称.</param>
        /// <param name="deliverMobile">收货地址的联系人移动电话。.</param>
        /// <param name="deliverPhone">收货地址的联系人固定电话。.</param>
        /// <param name="deliverProvince">收货人所在省份.</param>
        /// <param name="email">用户支付宝账号绑定的邮箱地址.</param>
        /// <param name="familyName">姓氏，取的是realName中的首个字符，对非中文、中文复姓支持较差。.</param>
        /// <param name="firmName">公司名称（用户类型是公司类型时公司名称才有此字段）。.</param>
        /// <param name="gender">性别（F：女性；M：男性）.</param>
        /// <param name="isBalanceFrozen">T- -被冻结；F- -未冻结.</param>
        /// <param name="isBankAuth">T为是银行卡认证，F为非银行卡认证。.</param>
        /// <param name="isCertified">是否通过实名认证。T是通过 F是没有实名认证.</param>
        /// <param name="isCertifyGradeA">T：表示A类实名认证；F：表示非A类实名认证.</param>
        /// <param name="isIdAuth">T为是身份证认证，F为非身份证认证。.</param>
        /// <param name="isLicenceAuth">T为通过营业执照认证，F为没有通过.</param>
        /// <param name="isMobileAuth">T为是手机认证，F为非手机认证。.</param>
        /// <param name="isStudentCertified">是否是学生.</param>
        /// <param name="mobile">手机号码。.</param>
        /// <param name="nickName">用户昵称.</param>
        /// <param name="phone">电话号码。.</param>
        /// <param name="province">省份名称。.</param>
        /// <param name="realName">用户的真实姓名。.</param>
        /// <param name="reducedBirthday">生日的月和日，MMdd格式.</param>
        /// <param name="userId">用户的userId.</param>
        /// <param name="userStatus">用户状态（Q/T/B/W）。  Q代表快速注册用户  T代表已认证用户  B代表被冻结账户  W代表已注册，未激活的账户.</param>
        /// <param name="userTypeValue">用户类型（1/2）  1代表公司账户2代表个人账户.</param>
        /// <param name="zip">邮政编码。.</param>
        public AlipayUserUserinfoShareResponseModel(string address = default(string), string addressCode = default(string), string alipayUserId = default(string), string area = default(string), string avatar = default(string), string balanceFreezeType = default(string), string birthday = default(string), string certNo = default(string), string certTypeValue = default(string), string city = default(string), string defaultDeliverAddress = default(string), List<DeliverAddress> deliverAddressList = default(List<DeliverAddress>), string deliverArea = default(string), string deliverCity = default(string), string deliverFullname = default(string), string deliverMobile = default(string), string deliverPhone = default(string), string deliverProvince = default(string), string email = default(string), string familyName = default(string), string firmName = default(string), string gender = default(string), string isBalanceFrozen = default(string), string isBankAuth = default(string), string isCertified = default(string), string isCertifyGradeA = default(string), string isIdAuth = default(string), string isLicenceAuth = default(string), string isMobileAuth = default(string), string isStudentCertified = default(string), string mobile = default(string), string nickName = default(string), string phone = default(string), string province = default(string), string realName = default(string), string reducedBirthday = default(string), string userId = default(string), string userStatus = default(string), string userTypeValue = default(string), string zip = default(string))
        {
            this.Address = address;
            this.AddressCode = addressCode;
            this.AlipayUserId = alipayUserId;
            this.Area = area;
            this.Avatar = avatar;
            this.BalanceFreezeType = balanceFreezeType;
            this.Birthday = birthday;
            this.CertNo = certNo;
            this.CertTypeValue = certTypeValue;
            this.City = city;
            this.DefaultDeliverAddress = defaultDeliverAddress;
            this.DeliverAddressList = deliverAddressList;
            this.DeliverArea = deliverArea;
            this.DeliverCity = deliverCity;
            this.DeliverFullname = deliverFullname;
            this.DeliverMobile = deliverMobile;
            this.DeliverPhone = deliverPhone;
            this.DeliverProvince = deliverProvince;
            this.Email = email;
            this.FamilyName = familyName;
            this.FirmName = firmName;
            this.Gender = gender;
            this.IsBalanceFrozen = isBalanceFrozen;
            this.IsBankAuth = isBankAuth;
            this.IsCertified = isCertified;
            this.IsCertifyGradeA = isCertifyGradeA;
            this.IsIdAuth = isIdAuth;
            this.IsLicenceAuth = isLicenceAuth;
            this.IsMobileAuth = isMobileAuth;
            this.IsStudentCertified = isStudentCertified;
            this.Mobile = mobile;
            this.NickName = nickName;
            this.Phone = phone;
            this.Province = province;
            this.RealName = realName;
            this.ReducedBirthday = reducedBirthday;
            this.UserId = userId;
            this.UserStatus = userStatus;
            this.UserTypeValue = userTypeValue;
            this.Zip = zip;
        }

        /// <summary>
        /// 详细地址。
        /// </summary>
        /// <value>详细地址。</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 区域编码，暂时不返回值
        /// </summary>
        /// <value>区域编码，暂时不返回值</value>
        [DataMember(Name = "address_code", EmitDefaultValue = false)]
        public string AddressCode { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        /// <value>支付宝用户ID</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 区县名称。
        /// </summary>
        /// <value>区县名称。</value>
        [DataMember(Name = "area", EmitDefaultValue = false)]
        public string Area { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        /// <value>用户头像</value>
        [DataMember(Name = "avatar", EmitDefaultValue = false)]
        public string Avatar { get; set; }

        /// <summary>
        /// 【注意】当is_balance_frozen为“F”时，改字段不会返回.  CTU - -- - CTU冻结，允许用户开启  ALIBABA - -- - ALIBABA冻结，允许用户开启  SERVER - -- - 后台冻结，允许用户开启  USER - -- -  用户冻结   CTU_N- -- - CTU冻结，不允许用户开启  ALIBABA_N - -- - ALIBABA冻结，不允许用户开启  SERVER_N - -- - 后台冻结，不允许用户开启  UNKNOWN - -- - 降级、或查询超时
        /// </summary>
        /// <value>【注意】当is_balance_frozen为“F”时，改字段不会返回.  CTU - -- - CTU冻结，允许用户开启  ALIBABA - -- - ALIBABA冻结，允许用户开启  SERVER - -- - 后台冻结，允许用户开启  USER - -- -  用户冻结   CTU_N- -- - CTU冻结，不允许用户开启  ALIBABA_N - -- - ALIBABA冻结，不允许用户开启  SERVER_N - -- - 后台冻结，不允许用户开启  UNKNOWN - -- - 降级、或查询超时</value>
        [DataMember(Name = "balance_freeze_type", EmitDefaultValue = false)]
        public string BalanceFreezeType { get; set; }

        /// <summary>
        /// 用户生日
        /// </summary>
        /// <value>用户生日</value>
        [DataMember(Name = "birthday", EmitDefaultValue = false)]
        public string Birthday { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        /// <value>证件号码</value>
        [DataMember(Name = "cert_no", EmitDefaultValue = false)]
        public string CertNo { get; set; }

        /// <summary>
        /// 0:身份证  1:护照  2:军官证  3:士兵证  4:回乡证  5:临时身份证  6:户口簿  7:警官证  8:台胞证  9:营业执照  10其它证件
        /// </summary>
        /// <value>0:身份证  1:护照  2:军官证  3:士兵证  4:回乡证  5:临时身份证  6:户口簿  7:警官证  8:台胞证  9:营业执照  10其它证件</value>
        [DataMember(Name = "cert_type_value", EmitDefaultValue = false)]
        public string CertTypeValue { get; set; }

        /// <summary>
        /// 市名称。
        /// </summary>
        /// <value>市名称。</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// 是否默认收货地址，暂时不返回值
        /// </summary>
        /// <value>是否默认收货地址，暂时不返回值</value>
        [DataMember(Name = "default_deliver_address", EmitDefaultValue = false)]
        public string DefaultDeliverAddress { get; set; }

        /// <summary>
        /// 收货人地址列表
        /// </summary>
        /// <value>收货人地址列表</value>
        [DataMember(Name = "deliver_address_list", EmitDefaultValue = false)]
        public List<DeliverAddress> DeliverAddressList { get; set; }

        /// <summary>
        /// 收货人所在区县
        /// </summary>
        /// <value>收货人所在区县</value>
        [DataMember(Name = "deliver_area", EmitDefaultValue = false)]
        public string DeliverArea { get; set; }

        /// <summary>
        /// 收货人所在城市
        /// </summary>
        /// <value>收货人所在城市</value>
        [DataMember(Name = "deliver_city", EmitDefaultValue = false)]
        public string DeliverCity { get; set; }

        /// <summary>
        /// 收货人全称
        /// </summary>
        /// <value>收货人全称</value>
        [DataMember(Name = "deliver_fullname", EmitDefaultValue = false)]
        public string DeliverFullname { get; set; }

        /// <summary>
        /// 收货地址的联系人移动电话。
        /// </summary>
        /// <value>收货地址的联系人移动电话。</value>
        [DataMember(Name = "deliver_mobile", EmitDefaultValue = false)]
        public string DeliverMobile { get; set; }

        /// <summary>
        /// 收货地址的联系人固定电话。
        /// </summary>
        /// <value>收货地址的联系人固定电话。</value>
        [DataMember(Name = "deliver_phone", EmitDefaultValue = false)]
        public string DeliverPhone { get; set; }

        /// <summary>
        /// 收货人所在省份
        /// </summary>
        /// <value>收货人所在省份</value>
        [DataMember(Name = "deliver_province", EmitDefaultValue = false)]
        public string DeliverProvince { get; set; }

        /// <summary>
        /// 用户支付宝账号绑定的邮箱地址
        /// </summary>
        /// <value>用户支付宝账号绑定的邮箱地址</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// 姓氏，取的是realName中的首个字符，对非中文、中文复姓支持较差。
        /// </summary>
        /// <value>姓氏，取的是realName中的首个字符，对非中文、中文复姓支持较差。</value>
        [DataMember(Name = "family_name", EmitDefaultValue = false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// 公司名称（用户类型是公司类型时公司名称才有此字段）。
        /// </summary>
        /// <value>公司名称（用户类型是公司类型时公司名称才有此字段）。</value>
        [DataMember(Name = "firm_name", EmitDefaultValue = false)]
        public string FirmName { get; set; }

        /// <summary>
        /// 性别（F：女性；M：男性）
        /// </summary>
        /// <value>性别（F：女性；M：男性）</value>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// T- -被冻结；F- -未冻结
        /// </summary>
        /// <value>T- -被冻结；F- -未冻结</value>
        [DataMember(Name = "is_balance_frozen", EmitDefaultValue = false)]
        public string IsBalanceFrozen { get; set; }

        /// <summary>
        /// T为是银行卡认证，F为非银行卡认证。
        /// </summary>
        /// <value>T为是银行卡认证，F为非银行卡认证。</value>
        [DataMember(Name = "is_bank_auth", EmitDefaultValue = false)]
        public string IsBankAuth { get; set; }

        /// <summary>
        /// 是否通过实名认证。T是通过 F是没有实名认证
        /// </summary>
        /// <value>是否通过实名认证。T是通过 F是没有实名认证</value>
        [DataMember(Name = "is_certified", EmitDefaultValue = false)]
        public string IsCertified { get; set; }

        /// <summary>
        /// T：表示A类实名认证；F：表示非A类实名认证
        /// </summary>
        /// <value>T：表示A类实名认证；F：表示非A类实名认证</value>
        [DataMember(Name = "is_certify_grade_a", EmitDefaultValue = false)]
        public string IsCertifyGradeA { get; set; }

        /// <summary>
        /// T为是身份证认证，F为非身份证认证。
        /// </summary>
        /// <value>T为是身份证认证，F为非身份证认证。</value>
        [DataMember(Name = "is_id_auth", EmitDefaultValue = false)]
        public string IsIdAuth { get; set; }

        /// <summary>
        /// T为通过营业执照认证，F为没有通过
        /// </summary>
        /// <value>T为通过营业执照认证，F为没有通过</value>
        [DataMember(Name = "is_licence_auth", EmitDefaultValue = false)]
        public string IsLicenceAuth { get; set; }

        /// <summary>
        /// T为是手机认证，F为非手机认证。
        /// </summary>
        /// <value>T为是手机认证，F为非手机认证。</value>
        [DataMember(Name = "is_mobile_auth", EmitDefaultValue = false)]
        public string IsMobileAuth { get; set; }

        /// <summary>
        /// 是否是学生
        /// </summary>
        /// <value>是否是学生</value>
        [DataMember(Name = "is_student_certified", EmitDefaultValue = false)]
        public string IsStudentCertified { get; set; }

        /// <summary>
        /// 手机号码。
        /// </summary>
        /// <value>手机号码。</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        /// <value>用户昵称</value>
        [DataMember(Name = "nick_name", EmitDefaultValue = false)]
        public string NickName { get; set; }

        /// <summary>
        /// 电话号码。
        /// </summary>
        /// <value>电话号码。</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// 省份名称。
        /// </summary>
        /// <value>省份名称。</value>
        [DataMember(Name = "province", EmitDefaultValue = false)]
        public string Province { get; set; }

        /// <summary>
        /// 用户的真实姓名。
        /// </summary>
        /// <value>用户的真实姓名。</value>
        [DataMember(Name = "real_name", EmitDefaultValue = false)]
        public string RealName { get; set; }

        /// <summary>
        /// 生日的月和日，MMdd格式
        /// </summary>
        /// <value>生日的月和日，MMdd格式</value>
        [DataMember(Name = "reduced_birthday", EmitDefaultValue = false)]
        public string ReducedBirthday { get; set; }

        /// <summary>
        /// 用户的userId
        /// </summary>
        /// <value>用户的userId</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户状态（Q/T/B/W）。  Q代表快速注册用户  T代表已认证用户  B代表被冻结账户  W代表已注册，未激活的账户
        /// </summary>
        /// <value>用户状态（Q/T/B/W）。  Q代表快速注册用户  T代表已认证用户  B代表被冻结账户  W代表已注册，未激活的账户</value>
        [DataMember(Name = "user_status", EmitDefaultValue = false)]
        public string UserStatus { get; set; }

        /// <summary>
        /// 用户类型（1/2）  1代表公司账户2代表个人账户
        /// </summary>
        /// <value>用户类型（1/2）  1代表公司账户2代表个人账户</value>
        [DataMember(Name = "user_type_value", EmitDefaultValue = false)]
        public string UserTypeValue { get; set; }

        /// <summary>
        /// 邮政编码。
        /// </summary>
        /// <value>邮政编码。</value>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserUserinfoShareResponseModel {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressCode: ").Append(AddressCode).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  BalanceFreezeType: ").Append(BalanceFreezeType).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  CertNo: ").Append(CertNo).Append("\n");
            sb.Append("  CertTypeValue: ").Append(CertTypeValue).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  DefaultDeliverAddress: ").Append(DefaultDeliverAddress).Append("\n");
            sb.Append("  DeliverAddressList: ").Append(DeliverAddressList).Append("\n");
            sb.Append("  DeliverArea: ").Append(DeliverArea).Append("\n");
            sb.Append("  DeliverCity: ").Append(DeliverCity).Append("\n");
            sb.Append("  DeliverFullname: ").Append(DeliverFullname).Append("\n");
            sb.Append("  DeliverMobile: ").Append(DeliverMobile).Append("\n");
            sb.Append("  DeliverPhone: ").Append(DeliverPhone).Append("\n");
            sb.Append("  DeliverProvince: ").Append(DeliverProvince).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  FirmName: ").Append(FirmName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  IsBalanceFrozen: ").Append(IsBalanceFrozen).Append("\n");
            sb.Append("  IsBankAuth: ").Append(IsBankAuth).Append("\n");
            sb.Append("  IsCertified: ").Append(IsCertified).Append("\n");
            sb.Append("  IsCertifyGradeA: ").Append(IsCertifyGradeA).Append("\n");
            sb.Append("  IsIdAuth: ").Append(IsIdAuth).Append("\n");
            sb.Append("  IsLicenceAuth: ").Append(IsLicenceAuth).Append("\n");
            sb.Append("  IsMobileAuth: ").Append(IsMobileAuth).Append("\n");
            sb.Append("  IsStudentCertified: ").Append(IsStudentCertified).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  RealName: ").Append(RealName).Append("\n");
            sb.Append("  ReducedBirthday: ").Append(ReducedBirthday).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  UserTypeValue: ").Append(UserTypeValue).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
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
            return this.Equals(input as AlipayUserUserinfoShareResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserUserinfoShareResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserUserinfoShareResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserUserinfoShareResponseModel input)
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
                    this.AddressCode == input.AddressCode ||
                    (this.AddressCode != null &&
                    this.AddressCode.Equals(input.AddressCode))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.BalanceFreezeType == input.BalanceFreezeType ||
                    (this.BalanceFreezeType != null &&
                    this.BalanceFreezeType.Equals(input.BalanceFreezeType))
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
                ) && 
                (
                    this.CertNo == input.CertNo ||
                    (this.CertNo != null &&
                    this.CertNo.Equals(input.CertNo))
                ) && 
                (
                    this.CertTypeValue == input.CertTypeValue ||
                    (this.CertTypeValue != null &&
                    this.CertTypeValue.Equals(input.CertTypeValue))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.DefaultDeliverAddress == input.DefaultDeliverAddress ||
                    (this.DefaultDeliverAddress != null &&
                    this.DefaultDeliverAddress.Equals(input.DefaultDeliverAddress))
                ) && 
                (
                    this.DeliverAddressList == input.DeliverAddressList ||
                    this.DeliverAddressList != null &&
                    input.DeliverAddressList != null &&
                    this.DeliverAddressList.SequenceEqual(input.DeliverAddressList)
                ) && 
                (
                    this.DeliverArea == input.DeliverArea ||
                    (this.DeliverArea != null &&
                    this.DeliverArea.Equals(input.DeliverArea))
                ) && 
                (
                    this.DeliverCity == input.DeliverCity ||
                    (this.DeliverCity != null &&
                    this.DeliverCity.Equals(input.DeliverCity))
                ) && 
                (
                    this.DeliverFullname == input.DeliverFullname ||
                    (this.DeliverFullname != null &&
                    this.DeliverFullname.Equals(input.DeliverFullname))
                ) && 
                (
                    this.DeliverMobile == input.DeliverMobile ||
                    (this.DeliverMobile != null &&
                    this.DeliverMobile.Equals(input.DeliverMobile))
                ) && 
                (
                    this.DeliverPhone == input.DeliverPhone ||
                    (this.DeliverPhone != null &&
                    this.DeliverPhone.Equals(input.DeliverPhone))
                ) && 
                (
                    this.DeliverProvince == input.DeliverProvince ||
                    (this.DeliverProvince != null &&
                    this.DeliverProvince.Equals(input.DeliverProvince))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
                ) && 
                (
                    this.FirmName == input.FirmName ||
                    (this.FirmName != null &&
                    this.FirmName.Equals(input.FirmName))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.IsBalanceFrozen == input.IsBalanceFrozen ||
                    (this.IsBalanceFrozen != null &&
                    this.IsBalanceFrozen.Equals(input.IsBalanceFrozen))
                ) && 
                (
                    this.IsBankAuth == input.IsBankAuth ||
                    (this.IsBankAuth != null &&
                    this.IsBankAuth.Equals(input.IsBankAuth))
                ) && 
                (
                    this.IsCertified == input.IsCertified ||
                    (this.IsCertified != null &&
                    this.IsCertified.Equals(input.IsCertified))
                ) && 
                (
                    this.IsCertifyGradeA == input.IsCertifyGradeA ||
                    (this.IsCertifyGradeA != null &&
                    this.IsCertifyGradeA.Equals(input.IsCertifyGradeA))
                ) && 
                (
                    this.IsIdAuth == input.IsIdAuth ||
                    (this.IsIdAuth != null &&
                    this.IsIdAuth.Equals(input.IsIdAuth))
                ) && 
                (
                    this.IsLicenceAuth == input.IsLicenceAuth ||
                    (this.IsLicenceAuth != null &&
                    this.IsLicenceAuth.Equals(input.IsLicenceAuth))
                ) && 
                (
                    this.IsMobileAuth == input.IsMobileAuth ||
                    (this.IsMobileAuth != null &&
                    this.IsMobileAuth.Equals(input.IsMobileAuth))
                ) && 
                (
                    this.IsStudentCertified == input.IsStudentCertified ||
                    (this.IsStudentCertified != null &&
                    this.IsStudentCertified.Equals(input.IsStudentCertified))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.RealName == input.RealName ||
                    (this.RealName != null &&
                    this.RealName.Equals(input.RealName))
                ) && 
                (
                    this.ReducedBirthday == input.ReducedBirthday ||
                    (this.ReducedBirthday != null &&
                    this.ReducedBirthday.Equals(input.ReducedBirthday))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserStatus == input.UserStatus ||
                    (this.UserStatus != null &&
                    this.UserStatus.Equals(input.UserStatus))
                ) && 
                (
                    this.UserTypeValue == input.UserTypeValue ||
                    (this.UserTypeValue != null &&
                    this.UserTypeValue.Equals(input.UserTypeValue))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
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
                if (this.AddressCode != null)
                {
                    hashCode = (hashCode * 59) + this.AddressCode.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.Area != null)
                {
                    hashCode = (hashCode * 59) + this.Area.GetHashCode();
                }
                if (this.Avatar != null)
                {
                    hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                }
                if (this.BalanceFreezeType != null)
                {
                    hashCode = (hashCode * 59) + this.BalanceFreezeType.GetHashCode();
                }
                if (this.Birthday != null)
                {
                    hashCode = (hashCode * 59) + this.Birthday.GetHashCode();
                }
                if (this.CertNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertNo.GetHashCode();
                }
                if (this.CertTypeValue != null)
                {
                    hashCode = (hashCode * 59) + this.CertTypeValue.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.DefaultDeliverAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultDeliverAddress.GetHashCode();
                }
                if (this.DeliverAddressList != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverAddressList.GetHashCode();
                }
                if (this.DeliverArea != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverArea.GetHashCode();
                }
                if (this.DeliverCity != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverCity.GetHashCode();
                }
                if (this.DeliverFullname != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverFullname.GetHashCode();
                }
                if (this.DeliverMobile != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverMobile.GetHashCode();
                }
                if (this.DeliverPhone != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverPhone.GetHashCode();
                }
                if (this.DeliverProvince != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverProvince.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.FamilyName != null)
                {
                    hashCode = (hashCode * 59) + this.FamilyName.GetHashCode();
                }
                if (this.FirmName != null)
                {
                    hashCode = (hashCode * 59) + this.FirmName.GetHashCode();
                }
                if (this.Gender != null)
                {
                    hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                }
                if (this.IsBalanceFrozen != null)
                {
                    hashCode = (hashCode * 59) + this.IsBalanceFrozen.GetHashCode();
                }
                if (this.IsBankAuth != null)
                {
                    hashCode = (hashCode * 59) + this.IsBankAuth.GetHashCode();
                }
                if (this.IsCertified != null)
                {
                    hashCode = (hashCode * 59) + this.IsCertified.GetHashCode();
                }
                if (this.IsCertifyGradeA != null)
                {
                    hashCode = (hashCode * 59) + this.IsCertifyGradeA.GetHashCode();
                }
                if (this.IsIdAuth != null)
                {
                    hashCode = (hashCode * 59) + this.IsIdAuth.GetHashCode();
                }
                if (this.IsLicenceAuth != null)
                {
                    hashCode = (hashCode * 59) + this.IsLicenceAuth.GetHashCode();
                }
                if (this.IsMobileAuth != null)
                {
                    hashCode = (hashCode * 59) + this.IsMobileAuth.GetHashCode();
                }
                if (this.IsStudentCertified != null)
                {
                    hashCode = (hashCode * 59) + this.IsStudentCertified.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.NickName != null)
                {
                    hashCode = (hashCode * 59) + this.NickName.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Province != null)
                {
                    hashCode = (hashCode * 59) + this.Province.GetHashCode();
                }
                if (this.RealName != null)
                {
                    hashCode = (hashCode * 59) + this.RealName.GetHashCode();
                }
                if (this.ReducedBirthday != null)
                {
                    hashCode = (hashCode * 59) + this.ReducedBirthday.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.UserStatus != null)
                {
                    hashCode = (hashCode * 59) + this.UserStatus.GetHashCode();
                }
                if (this.UserTypeValue != null)
                {
                    hashCode = (hashCode * 59) + this.UserTypeValue.GetHashCode();
                }
                if (this.Zip != null)
                {
                    hashCode = (hashCode * 59) + this.Zip.GetHashCode();
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
