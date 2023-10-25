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
    /// AlipayOpenMiniResourceRecordNotifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniResourceRecordNotifyModel")]
    public partial class AlipayOpenMiniResourceRecordNotifyModel : IEquatable<AlipayOpenMiniResourceRecordNotifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniResourceRecordNotifyModel" /> class.
        /// </summary>
        /// <param name="authorId">媒体唤起时传入的支付宝id.</param>
        /// <param name="miniAppId">支付宝appid，代表一个小程序的唯一标识.</param>
        /// <param name="_params">媒体唤起时提供的额外参数值列表，这里可能有多个值，打平以后拼入。即url_decode(authcbparams).</param>
        /// <param name="siteId">回调的siteid 淘宝账号唯一.</param>
        /// <param name="source">媒体来源，标识调用方.</param>
        /// <param name="taobaoId">淘宝id.</param>
        /// <param name="taobaoNick">淘宝昵称.</param>
        public AlipayOpenMiniResourceRecordNotifyModel(string authorId = default(string), string miniAppId = default(string), string _params = default(string), string siteId = default(string), string source = default(string), string taobaoId = default(string), string taobaoNick = default(string))
        {
            this.AuthorId = authorId;
            this.MiniAppId = miniAppId;
            this.Params = _params;
            this.SiteId = siteId;
            this.Source = source;
            this.TaobaoId = taobaoId;
            this.TaobaoNick = taobaoNick;
        }

        /// <summary>
        /// 媒体唤起时传入的支付宝id
        /// </summary>
        /// <value>媒体唤起时传入的支付宝id</value>
        [DataMember(Name = "author_id", EmitDefaultValue = false)]
        public string AuthorId { get; set; }

        /// <summary>
        /// 支付宝appid，代表一个小程序的唯一标识
        /// </summary>
        /// <value>支付宝appid，代表一个小程序的唯一标识</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 媒体唤起时提供的额外参数值列表，这里可能有多个值，打平以后拼入。即url_decode(authcbparams)
        /// </summary>
        /// <value>媒体唤起时提供的额外参数值列表，这里可能有多个值，打平以后拼入。即url_decode(authcbparams)</value>
        [DataMember(Name = "params", EmitDefaultValue = false)]
        public string Params { get; set; }

        /// <summary>
        /// 回调的siteid 淘宝账号唯一
        /// </summary>
        /// <value>回调的siteid 淘宝账号唯一</value>
        [DataMember(Name = "site_id", EmitDefaultValue = false)]
        public string SiteId { get; set; }

        /// <summary>
        /// 媒体来源，标识调用方
        /// </summary>
        /// <value>媒体来源，标识调用方</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// 淘宝id
        /// </summary>
        /// <value>淘宝id</value>
        [DataMember(Name = "taobao_id", EmitDefaultValue = false)]
        public string TaobaoId { get; set; }

        /// <summary>
        /// 淘宝昵称
        /// </summary>
        /// <value>淘宝昵称</value>
        [DataMember(Name = "taobao_nick", EmitDefaultValue = false)]
        public string TaobaoNick { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniResourceRecordNotifyModel {\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  TaobaoId: ").Append(TaobaoId).Append("\n");
            sb.Append("  TaobaoNick: ").Append(TaobaoNick).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniResourceRecordNotifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniResourceRecordNotifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniResourceRecordNotifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniResourceRecordNotifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
                ) && 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.TaobaoId == input.TaobaoId ||
                    (this.TaobaoId != null &&
                    this.TaobaoId.Equals(input.TaobaoId))
                ) && 
                (
                    this.TaobaoNick == input.TaobaoNick ||
                    (this.TaobaoNick != null &&
                    this.TaobaoNick.Equals(input.TaobaoNick))
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
                if (this.AuthorId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorId.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.Params != null)
                {
                    hashCode = (hashCode * 59) + this.Params.GetHashCode();
                }
                if (this.SiteId != null)
                {
                    hashCode = (hashCode * 59) + this.SiteId.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.TaobaoId != null)
                {
                    hashCode = (hashCode * 59) + this.TaobaoId.GetHashCode();
                }
                if (this.TaobaoNick != null)
                {
                    hashCode = (hashCode * 59) + this.TaobaoNick.GetHashCode();
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
