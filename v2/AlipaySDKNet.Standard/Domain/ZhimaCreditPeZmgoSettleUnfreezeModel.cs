using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoSettleUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoSettleUnfreezeModel : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花呗先享协议号
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 解冻成功时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 解冻的描述
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标识请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。由商户传入，最终返回给商户。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 解冻金额
        /// </summary>
        [XmlElement("unfreeze_amount")]
        public string UnfreezeAmount { get; set; }

        /// <summary>
        /// 解冻相关拓展字段
        /// </summary>
        [XmlElement("unfreeze_extend_params")]
        public UnfreezeExtendParams UnfreezeExtendParams { get; set; }
    }
}
