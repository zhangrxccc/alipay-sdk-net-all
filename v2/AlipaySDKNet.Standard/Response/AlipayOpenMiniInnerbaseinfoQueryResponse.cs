using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序别名，简称
        /// </summary>
        [XmlElement("app_alias_name")]
        public string AppAliasName { get; set; }

        /// <summary>
        /// 类目Id列表
        /// </summary>
        [XmlElement("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述
        /// </summary>
        [XmlElement("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序英文名称
        /// </summary>
        [XmlElement("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 手淘开放平台鉴权key，支付宝不需要
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 小程序应用logo图标
        /// </summary>
        [XmlElement("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序简介
        /// </summary>
        [XmlElement("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序类型，TINYAPP_TEMPLATE，TINYAPP_NORMAL，TINYAPP_PLUGIN
        /// </summary>
        [XmlElement("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 小程序所属主体信息
        /// </summary>
        [XmlElement("dev_id")]
        public string DevId { get; set; }

        /// <summary>
        /// 小程序主体创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 小程序主体更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 小程序Id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 新小程序前台类目，一级与二级、三级用下划线隔开，最多可以选四个类目，类目之间;隔开。使用后不再读取app_category_ids值，老前台类目将废弃
        /// </summary>
        [XmlElement("mini_category_ids")]
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 应用创建来源，alipay = 支付宝，taobao = 淘宝
        /// </summary>
        [XmlElement("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 小程序主体信息
        /// </summary>
        [XmlElement("owner_entity")]
        public string OwnerEntity { get; set; }

        /// <summary>
        /// 小程序主体头像信息
        /// </summary>
        [XmlElement("owner_portrait")]
        public string OwnerPortrait { get; set; }

        /// <summary>
        /// AUTO/自动更新、MANUAL/手动更新
        /// </summary>
        [XmlElement("plugin_refresh_type")]
        public string PluginRefreshType { get; set; }

        /// <summary>
        /// 小程序客服邮箱
        /// </summary>
        [XmlElement("service_email")]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }
    }
}
