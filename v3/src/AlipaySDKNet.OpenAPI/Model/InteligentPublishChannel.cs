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
    /// InteligentPublishChannel
    /// </summary>
    [DataContract(Name = "InteligentPublishChannel")]
    public partial class InteligentPublishChannel : IEquatable<InteligentPublishChannel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentPublishChannel" /> class.
        /// </summary>
        /// <param name="config">当type为MERCHANT_CROWD时，config需填入口令送的密码和图片，样例如下：\&quot;config\&quot;:\&quot;{\\\&quot;PASSWORD\\\&quot;:\\\&quot;口令送密码\\\&quot;,\\\&quot;BACKGROUND_LOGO\\\&quot;:\\\&quot;1T8Pp00AT7eo9NoAJkMR3AAAACMAAQEC\\\&quot;}\&quot;.</param>
        /// <param name="extInfo">扩展信息，无需配置.</param>
        /// <param name="name">渠道名称.</param>
        /// <param name="type">渠道类型，目前支持以下类型：  QR_CODE：二维码投放；  SHORT_LINK：短连接投放；  SHOP_DETAIL：店铺页投放；  PAYMENT_RESULT：支付成功页；  MERCHANT_CROWD：口令送；  URL_WITH_TOKEN：外部发奖活动，  只有活动类型为DIRECT_SEND时才支持；.</param>
        public InteligentPublishChannel(string config = default(string), string extInfo = default(string), string name = default(string), string type = default(string))
        {
            this.Config = config;
            this.ExtInfo = extInfo;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// 当type为MERCHANT_CROWD时，config需填入口令送的密码和图片，样例如下：\&quot;config\&quot;:\&quot;{\\\&quot;PASSWORD\\\&quot;:\\\&quot;口令送密码\\\&quot;,\\\&quot;BACKGROUND_LOGO\\\&quot;:\\\&quot;1T8Pp00AT7eo9NoAJkMR3AAAACMAAQEC\\\&quot;}\&quot;
        /// </summary>
        /// <value>当type为MERCHANT_CROWD时，config需填入口令送的密码和图片，样例如下：\&quot;config\&quot;:\&quot;{\\\&quot;PASSWORD\\\&quot;:\\\&quot;口令送密码\\\&quot;,\\\&quot;BACKGROUND_LOGO\\\&quot;:\\\&quot;1T8Pp00AT7eo9NoAJkMR3AAAACMAAQEC\\\&quot;}\&quot;</value>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public string Config { get; set; }

        /// <summary>
        /// 扩展信息，无需配置
        /// </summary>
        /// <value>扩展信息，无需配置</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        /// <value>渠道名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 渠道类型，目前支持以下类型：  QR_CODE：二维码投放；  SHORT_LINK：短连接投放；  SHOP_DETAIL：店铺页投放；  PAYMENT_RESULT：支付成功页；  MERCHANT_CROWD：口令送；  URL_WITH_TOKEN：外部发奖活动，  只有活动类型为DIRECT_SEND时才支持；
        /// </summary>
        /// <value>渠道类型，目前支持以下类型：  QR_CODE：二维码投放；  SHORT_LINK：短连接投放；  SHOP_DETAIL：店铺页投放；  PAYMENT_RESULT：支付成功页；  MERCHANT_CROWD：口令送；  URL_WITH_TOKEN：外部发奖活动，  只有活动类型为DIRECT_SEND时才支持；</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentPublishChannel {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as InteligentPublishChannel);
        }

        /// <summary>
        /// Returns true if InteligentPublishChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentPublishChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentPublishChannel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
