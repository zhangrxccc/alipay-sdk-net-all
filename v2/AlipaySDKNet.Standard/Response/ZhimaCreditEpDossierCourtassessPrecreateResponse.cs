using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierCourtassessPrecreateResponse.
    /// </summary>
    public class ZhimaCreditEpDossierCourtassessPrecreateResponse : AopResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
