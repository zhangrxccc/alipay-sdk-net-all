using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankCardExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BankCardExtInfoDTO : AopObject
    {
        /// <summary>
        /// 收款账户类型。 1：对公（在金融机构开设的公司账户）,如果银行卡为对公，必须传递省市支行信息或者联行号 2：对私（在金融机构开设的个人账户
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 银行支行联行号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 收款银行所属支行
        /// </summary>
        [XmlElement("inst_branch_name")]
        public string InstBranchName { get; set; }

        /// <summary>
        /// 收款银行所在市
        /// </summary>
        [XmlElement("inst_city")]
        public string InstCity { get; set; }

        /// <summary>
        /// 当收款账户为对公账户时，机构名称必填；当收款账户为对私账户时，机构名称可为空。
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 银行所在省份
        /// </summary>
        [XmlElement("inst_province")]
        public string InstProvince { get; set; }
    }
}
