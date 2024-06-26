using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoUserOilRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoUserOilRefundModel : AopObject
    {
        /// <summary>
        /// 原始使用积分时候的request_id，只有使用过的积分才能返回
        /// </summary>
        [XmlElement("exchange_request_id")]
        public string ExchangeRequestId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 退回原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 每次请求的ID。可使用唯一的业务单号，用来做幂等控制。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 来源，车险爱攒油团队分配
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
