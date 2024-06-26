using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoCumulationSyncResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoCumulationSyncResponse : AopResponse
    {
        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。 累计成功后返回此字段。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 数据回传失败原因描述。 累计失败后返回此字段。
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 用户userId，蚂蚁统一会员ID。 累计成功后返回此字段。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号。需保证唯一，若接口调用失败，提示信息为更换幂等号，商户更换此字段重新发起调用。 累计成功后返回此字段。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户userId，蚂蚁统一会员ID。 累计成功后返回此字段。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
