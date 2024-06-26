using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenPublicMatchuserFollowQueryResponse.
    /// </summary>
    public class AlipayOpenPublicMatchuserFollowQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户是否关注，T代表已关注，F代表未关注
        /// </summary>
        [XmlElement("is_follow")]
        public string IsFollow { get; set; }

        /// <summary>
        /// 支付宝用户的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头的16位长度字符串
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
