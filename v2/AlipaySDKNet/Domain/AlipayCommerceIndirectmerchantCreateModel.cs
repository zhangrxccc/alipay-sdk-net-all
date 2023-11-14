using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIndirectmerchantCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIndirectmerchantCreateModel : AopObject
    {
        /// <summary>
        /// 行业模版code，默认不用传，当是水奶行业时需要传shui或者nai
        /// </summary>
        [XmlElement("industry_template_code")]
        public string IndustryTemplateCode { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 商家logo图片id，字段值来源于上传接口的返回值，上传接口文档：https://opendocs.alipay.com/apis/069sh7
        /// </summary>
        [XmlElement("logo_image_id")]
        public string LogoImageId { get; set; }

        /// <summary>
        /// 商家logo图片地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 分账关系信息
        /// </summary>
        [XmlArray("merchant_settle_relation_list")]
        [XmlArrayItem("merchant_settle_relation_processor_request")]
        public List<MerchantSettleRelationProcessorRequest> MerchantSettleRelationList { get; set; }

        /// <summary>
        /// 商家联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
