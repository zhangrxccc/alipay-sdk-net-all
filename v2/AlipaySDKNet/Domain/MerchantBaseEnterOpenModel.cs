using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantBaseEnterOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantBaseEnterOpenModel : AopObject
    {
        /// <summary>
        /// 登陆账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 商户logo文件流信息，该字段为文件流经base64编码后得到的字符串。
        /// </summary>
        [XmlElement("logo_info")]
        public string LogoInfo { get; set; }

        /// <summary>
        /// 商户品牌全称。
        /// </summary>
        [XmlElement("m_name")]
        public string MName { get; set; }

        /// <summary>
        /// 商户品牌简称
        /// </summary>
        [XmlElement("m_short_name")]
        public string MShortName { get; set; }
    }
}
