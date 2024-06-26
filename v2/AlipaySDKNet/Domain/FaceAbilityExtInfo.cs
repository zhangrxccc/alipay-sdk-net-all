using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FaceAbilityExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceAbilityExtInfo : AopObject
    {
        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("algfactors")]
        public string Algfactors { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("blur")]
        public string Blur { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 比对源渠道信息
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// maxRule:选择最大脸规则；  centerRule：选择中心脸规则；  默认空字符串表示不进行选脸
        /// </summary>
        [XmlElement("choose_face_rule")]
        public string ChooseFaceRule { get; set; }

        /// <summary>
        /// 2D或者3D，默认2D
        /// </summary>
        [XmlElement("face_data_type")]
        public string FaceDataType { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// 是否存在攻击
        /// </summary>
        [XmlElement("hasrisk")]
        public string Hasrisk { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("joint_quality")]
        public long JointQuality { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("light")]
        public string Light { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("occlusion")]
        public string Occlusion { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("pose")]
        public string Pose { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// 质量不合格时的质量返回码
        /// </summary>
        [XmlElement("quality_code")]
        public string QualityCode { get; set; }

        /// <summary>
        /// 质量是否合格
        /// </summary>
        [XmlElement("qualityok")]
        public bool Qualityok { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("rect")]
        public string Rect { get; set; }

        /// <summary>
        /// 已不支持
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 活体源，customer：业务方自定义采集；alisp:支付宝小程序
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
