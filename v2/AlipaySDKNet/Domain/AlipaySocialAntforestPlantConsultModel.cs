using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestPlantConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestPlantConsultModel : AopObject
    {
        /// <summary>
        /// 出账购买树种的账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 兑换类型，默认是ACCOUNT，走account账户扣能量
        /// </summary>
        [XmlElement("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 项目id，需要配合其他查询接口，查询到相关的项目之后使用。不限于树种，还包括保护地等
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
