using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxUserinfoQueryResponse.
    /// </summary>
    public class AlipayOverseasTaxUserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户是否符合支付宝退税资金收款条件。包括用户状态，认证状态等的校验。true为符合支付宝退税资金收款条件，false为不符合
        /// </summary>
        [XmlElement("eligible")]
        public bool Eligible { get; set; }

        /// <summary>
        /// 用户状态非法，只有eligible为false时才有意义。 类型有： REAL_NAME_UNCERTIFIED，根据机构需求，可以提示用户稍后进行实名认证，然后继续流程，或者拒绝用户继续操作。 ILLEGAL_USER，非法用户，终结流程。 USER_ACCOUNT_FREEZED，用户已被冻结，终结流程。
        /// </summary>
        [XmlElement("eligible_msg")]
        public string EligibleMsg { get; set; }

        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户Id:蚂蚁统一会员ID,唯一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名:用户真实名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
