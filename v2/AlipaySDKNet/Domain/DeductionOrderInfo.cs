using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionOrderInfo : AopObject
    {
        /// <summary>
        /// 订购单ID
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 凭证序列号
        /// </summary>
        [XmlElement("certificate_serial")]
        public string CertificateSerial { get; set; }

        /// <summary>
        /// 扣款金额，单位：分
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 扣款失败原因
        /// </summary>
        [XmlElement("deduction_fail_reason")]
        public string DeductionFailReason { get; set; }

        /// <summary>
        /// 扣款失败次数
        /// </summary>
        [XmlElement("deduction_fail_times")]
        public long DeductionFailTimes { get; set; }

        /// <summary>
        /// 扣款单ID
        /// </summary>
        [XmlElement("deduction_order_id")]
        public string DeductionOrderId { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("deduction_order_type")]
        public string DeductionOrderType { get; set; }

        /// <summary>
        /// 扣款状态
        /// </summary>
        [XmlElement("deduction_status")]
        public string DeductionStatus { get; set; }

        /// <summary>
        /// 实际扣款时间
        /// </summary>
        [XmlElement("deduction_time")]
        public string DeductionTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 计划扣款时间
        /// </summary>
        [XmlElement("plan_deduction_time")]
        public string PlanDeductionTime { get; set; }

        /// <summary>
        /// 分期单ID
        /// </summary>
        [XmlElement("sub_order_id")]
        public string SubOrderId { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
