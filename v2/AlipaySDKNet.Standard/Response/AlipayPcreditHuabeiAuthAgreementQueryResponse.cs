using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthAgreementQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议名称
        /// </summary>
        [XmlElement("agreement_name")]
        public string AgreementName { get; set; }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员协议号。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 协议状态。Y表示状态有效，N表示状态失效
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 花芝轻会员签约场景，商户和支付宝签约时确定，商户接入时需要咨询技术支持。
        /// </summary>
        [XmlElement("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号
        /// </summary>
        [XmlElement("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 签约时间。如果是在签状态，返回签约时间。
        /// </summary>
        [XmlElement("gmt_sign")]
        public string GmtSign { get; set; }

        /// <summary>
        /// 花芝轻会员协议解约时间。如果是解约状态，才返回该字段。
        /// </summary>
        [XmlElement("gmt_unsign")]
        public string GmtUnsign { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务类型，用于区分本次业务交互在商户侧具体的业务类别，提供给商家进行特定逻辑的处理
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 外部签约号，由商户提供，花芝轻会员协议中标识用户的唯一签约号（确保在商户系统中唯一）。由商户签约时传入，最终返回给商户。
        /// </summary>
        [XmlElement("out_sign_no")]
        public string OutSignNo { get; set; }

        /// <summary>
        /// 用户在本花芝轻会员协议中，剩余的总冻结额度（资金池总余额），数值能实时准确，可以用于核对。两位小数，单位元。
        /// </summary>
        [XmlElement("rest_freeze_amount")]
        public string RestFreezeAmount { get; set; }
    }
}
