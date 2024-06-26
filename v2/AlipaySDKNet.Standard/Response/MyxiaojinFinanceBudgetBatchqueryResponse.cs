using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MyxiaojinFinanceBudgetBatchqueryResponse.
    /// </summary>
    public class MyxiaojinFinanceBudgetBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 预算业务申请信息
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("cfbudmac_biz_budget_d_t_o")]
        public List<CfbudmacBizBudgetDTO> ResultData { get; set; }

        /// <summary>
        /// 错误码对应的详细错误信息，助于排查问题
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
