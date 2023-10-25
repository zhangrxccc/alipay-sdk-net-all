/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-25
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// TemplateActionInfoDTO
    /// </summary>
    [DataContract(Name = "TemplateActionInfoDTO")]
    public partial class TemplateActionInfoDTO : IEquatable<TemplateActionInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateActionInfoDTO" /> class.
        /// </summary>
        /// <param name="code">行动点业务CODE，商户自定义.</param>
        /// <param name="miniAppUrl">miniAppUrl.</param>
        /// <param name="text">行动点展示文案.</param>
        /// <param name="url">行动点跳转链接，当url_type填\&quot;url\&quot;或不填时必填，支持http(s)和支付宝schema地址等.</param>
        /// <param name="urlType">跳转链接类型，不填则默认为url类型：  url：对应填写url参数  miniAppUrl: 对应填写mini_app_url参数，跳转至指定的支付宝小程序页面.</param>
        public TemplateActionInfoDTO(string code = default(string), TemplateActionMiniAppUrlDTO miniAppUrl = default(TemplateActionMiniAppUrlDTO), string text = default(string), string url = default(string), string urlType = default(string))
        {
            this.Code = code;
            this.MiniAppUrl = miniAppUrl;
            this.Text = text;
            this.Url = url;
            this.UrlType = urlType;
        }

        /// <summary>
        /// 行动点业务CODE，商户自定义
        /// </summary>
        /// <value>行动点业务CODE，商户自定义</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets MiniAppUrl
        /// </summary>
        [DataMember(Name = "mini_app_url", EmitDefaultValue = false)]
        public TemplateActionMiniAppUrlDTO MiniAppUrl { get; set; }

        /// <summary>
        /// 行动点展示文案
        /// </summary>
        /// <value>行动点展示文案</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// 行动点跳转链接，当url_type填\&quot;url\&quot;或不填时必填，支持http(s)和支付宝schema地址等
        /// </summary>
        /// <value>行动点跳转链接，当url_type填\&quot;url\&quot;或不填时必填，支持http(s)和支付宝schema地址等</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// 跳转链接类型，不填则默认为url类型：  url：对应填写url参数  miniAppUrl: 对应填写mini_app_url参数，跳转至指定的支付宝小程序页面
        /// </summary>
        /// <value>跳转链接类型，不填则默认为url类型：  url：对应填写url参数  miniAppUrl: 对应填写mini_app_url参数，跳转至指定的支付宝小程序页面</value>
        [DataMember(Name = "url_type", EmitDefaultValue = false)]
        public string UrlType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateActionInfoDTO {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  MiniAppUrl: ").Append(MiniAppUrl).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UrlType: ").Append(UrlType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateActionInfoDTO);
        }

        /// <summary>
        /// Returns true if TemplateActionInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateActionInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateActionInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.MiniAppUrl == input.MiniAppUrl ||
                    (this.MiniAppUrl != null &&
                    this.MiniAppUrl.Equals(input.MiniAppUrl))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.UrlType == input.UrlType ||
                    (this.UrlType != null &&
                    this.UrlType.Equals(input.UrlType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.MiniAppUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppUrl.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.UrlType != null)
                {
                    hashCode = (hashCode * 59) + this.UrlType.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
