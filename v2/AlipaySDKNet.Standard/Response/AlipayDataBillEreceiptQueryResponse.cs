using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataBillEreceiptQueryResponse.
    /// </summary>
    public class AlipayDataBillEreceiptQueryResponse : AopResponse
    {
        /// <summary>
        /// 下载链接，status 为 SUCCESS 时返回。用户可以使用此http链接下载文件内容。有效时间为 30s。  生成文件为PDF格式，下载即可获取电子回单 PDF 内容。
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 如果生成失败，则会返回失败原因
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 处理状态。枚举值如下： INIT：初始化。 PROCESS：处理中。 SUCCESS：成功。 FAIL：失败。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
