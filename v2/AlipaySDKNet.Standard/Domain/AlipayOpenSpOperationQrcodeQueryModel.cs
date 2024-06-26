using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpOperationQrcodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpOperationQrcodeQueryModel : AopObject
    {
        /// <summary>
        /// 接入的产品编号。 操作类型为绑定的，填OPENAPI_BIND_DEFAULT; 操作类型为授权的，填OPENAPI_AUTH_DEFAULT
        /// </summary>
        [XmlElement("access_product_code")]
        public string AccessProductCode { get; set; }

        /// <summary>
        /// 支付宝登录账号。通常为手机号或者邮箱。 若被代运营者是间连商户，该字段无需填写。 若为直连商户，则 merchant_no 和 alipay_account 不能同时为空，都有值优先取 merchant_no。
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 场景授权列表结构结构：场景codeA:权限code1,权限code2;场景codeB:权限code1,权限code2;
        /// </summary>
        [XmlElement("isv_scene_permissions")]
        public string IsvScenePermissions { get; set; }

        /// <summary>
        /// 支付宝商户号。注意仅支持 2088 开头的间连商户。 若被代运营者是间连商户，则 merchant_no 必填； 若为直连商户，则 merchant_no 和 alipay_account 不能同时为空，都有值优先取 merchant_no。
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 代运营操作类型。取值如下： * ACCOUNT_BIND：账号绑定，仅支持间连商户。 * OPERATION_AUTH：代运营授权，支持间连、直连商户。
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部操作流水，由服务商自定义，需确保每次操作唯一。仅支持数字、字母、下划线组合。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
