using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationUserPointRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationUserPointRefundModel : AopObject
    {
        /// <summary>
        /// 原始扣减积分的请求ID
        /// </summary>
        [XmlElement("exchange_request_id")]
        public string ExchangeRequestId { get; set; }

        /// <summary>
        /// 蚂蚁统一open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 退回原因，例如：RETURN_GOODS-退货
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 每次请求的ID。可使用唯一的业务单号，用来做幂等控制。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景代码，由行业运营平台分配，提供枚举值。 user_id + scene_code 确定退还积分的场景。
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 来源渠道，行业运营平台分配，例如：linkedmall
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
