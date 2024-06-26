using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransInnovateAppCreateandpayResponse.
    /// </summary>
    public class AlipayFundTransInnovateAppCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 该笔转账在支付宝系统内部的单据ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户端的唯一订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// SUCCESS：转账成功； WAIT_PAY：转账订单等待支付； CLOSE：订单超时关闭，截止订单支付超时时间(time_expire)仍未支付，单据状态会变更为CLOSED；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
