using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenContentIotCouponQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenContentIotCouponQueryModel : AopObject
    {
        /// <summary>
        /// 活动ID，用于获取相应的活动信息，来源于商家在B站的配置
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 配置商家发券时使用的商家信息，需要和进入商家中心（B站）时使用的相同
        /// </summary>
        [XmlElement("auth_pid")]
        public string AuthPid { get; set; }

        /// <summary>
        /// 刷脸token，用于获取用户相关信息，来源于刷脸成功返回的一次性消费码
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }
    }
}
