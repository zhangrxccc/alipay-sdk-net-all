using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarTradeOrderQueryResponse.
    /// </summary>
    public class AlipayEcoMycarTradeOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 车主平台交易号，交易订单唯一标记。与车主业务平台订单号相同。
        /// </summary>
        [XmlElement("biz_trade_no")]
        public string BizTradeNo { get; set; }

        /// <summary>
        /// 买家支付宝Uid
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 交易关闭时间，格式'yyyy-MM-dd HH:mm:ss'
        /// </summary>
        [XmlElement("gmt_closed")]
        public string GmtClosed { get; set; }

        /// <summary>
        /// 交易订单创建时间，格式'yyyy-MM-dd HH:mm:ss'
        /// </summary>
        [XmlElement("gmt_created")]
        public string GmtCreated { get; set; }

        /// <summary>
        /// 支付时间，格式'yyyy-MM-dd HH:mm:ss'
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 支付成功时间，格式'yyyy-MM-dd HH:mm:ss'
        /// </summary>
        [XmlElement("gmt_payment_success")]
        public string GmtPaymentSuccess { get; set; }

        /// <summary>
        /// 退款时间。该笔交易有退款操作时该字段才有值。格式：'yyyy-MM-dd HH:mm:ss'
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 退款成功时间。笔交易有退款操作时该字段才有值。格式：'yyyy-MM-dd HH:mm:ss'
        /// </summary>
        [XmlElement("gmt_refund_success")]
        public string GmtRefundSuccess { get; set; }

        /// <summary>
        /// 交易订单最后更改时间，格式'yyyy-MM-dd HH:mm:ss'
        /// </summary>
        [XmlElement("gmt_updated")]
        public string GmtUpdated { get; set; }

        /// <summary>
        /// 应用维度用户ID，唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_biz_trade_no")]
        public string OutBizTradeNo { get; set; }

        /// <summary>
        /// 已退回金额，单位元，精确到小数点后两位。笔交易有退款操作时该字段才有值。
        /// </summary>
        [XmlElement("send_back_fee")]
        public string SendBackFee { get; set; }

        /// <summary>
        /// 车主平台门店编号
        /// </summary>
        [XmlElement("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 订单主题，商品的标题/交易标题/订单标题/订单关键字等。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单摘要信息，对一笔交易的具体描述，由车主业务系统组织。 车主平台订单列表透出内容。
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 交易金额，单位元， 精确到小数点后两位。
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 支付宝交易号。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 车主平台交易状态  0：创建；1：支付成功；2：支付失败；3：支付完成；4：支付中；5：交易关闭；6：转为退款；8：退款成功；7：退款失败；9：交易完结
        /// </summary>
        [XmlElement("trade_status")]
        public long TradeStatus { get; set; }

        /// <summary>
        /// 订单类型，1：洗车，2：保养，3:洗车，4:4s店。
        /// </summary>
        [XmlElement("trade_type")]
        public long TradeType { get; set; }
    }
}
