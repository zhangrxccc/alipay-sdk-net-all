/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-06-06
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
    /// IsvSpiDefinition
    /// </summary>
    [DataContract(Name = "IsvSpiDefinition")]
    public partial class IsvSpiDefinition : IEquatable<IsvSpiDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsvSpiDefinition" /> class.
        /// </summary>
        /// <param name="bizCode">ISV自定义的标识功能的业务代码，不可重复.</param>
        /// <param name="description">spi功能描述.</param>
        /// <param name="icon">功能图标文件url.</param>
        /// <param name="spiEndpoint">spi接口服务地址.</param>
        /// <param name="spiExtProperty">spi接口扩展参数，json格式字符串.</param>
        /// <param name="spiKey">CCM预先定义的spi key，与插件位置有关.</param>
        /// <param name="spiName">SPI 名称.</param>
        public IsvSpiDefinition(string bizCode = default(string), string description = default(string), string icon = default(string), string spiEndpoint = default(string), string spiExtProperty = default(string), string spiKey = default(string), string spiName = default(string))
        {
            this.BizCode = bizCode;
            this.Description = description;
            this.Icon = icon;
            this.SpiEndpoint = spiEndpoint;
            this.SpiExtProperty = spiExtProperty;
            this.SpiKey = spiKey;
            this.SpiName = spiName;
        }

        /// <summary>
        /// ISV自定义的标识功能的业务代码，不可重复
        /// </summary>
        /// <value>ISV自定义的标识功能的业务代码，不可重复</value>
        [DataMember(Name = "biz_code", EmitDefaultValue = false)]
        public string BizCode { get; set; }

        /// <summary>
        /// spi功能描述
        /// </summary>
        /// <value>spi功能描述</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 功能图标文件url
        /// </summary>
        /// <value>功能图标文件url</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// spi接口服务地址
        /// </summary>
        /// <value>spi接口服务地址</value>
        [DataMember(Name = "spi_endpoint", EmitDefaultValue = false)]
        public string SpiEndpoint { get; set; }

        /// <summary>
        /// spi接口扩展参数，json格式字符串
        /// </summary>
        /// <value>spi接口扩展参数，json格式字符串</value>
        [DataMember(Name = "spi_ext_property", EmitDefaultValue = false)]
        public string SpiExtProperty { get; set; }

        /// <summary>
        /// CCM预先定义的spi key，与插件位置有关
        /// </summary>
        /// <value>CCM预先定义的spi key，与插件位置有关</value>
        [DataMember(Name = "spi_key", EmitDefaultValue = false)]
        public string SpiKey { get; set; }

        /// <summary>
        /// SPI 名称
        /// </summary>
        /// <value>SPI 名称</value>
        [DataMember(Name = "spi_name", EmitDefaultValue = false)]
        public string SpiName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IsvSpiDefinition {\n");
            sb.Append("  BizCode: ").Append(BizCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  SpiEndpoint: ").Append(SpiEndpoint).Append("\n");
            sb.Append("  SpiExtProperty: ").Append(SpiExtProperty).Append("\n");
            sb.Append("  SpiKey: ").Append(SpiKey).Append("\n");
            sb.Append("  SpiName: ").Append(SpiName).Append("\n");
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
            return this.Equals(input as IsvSpiDefinition);
        }

        /// <summary>
        /// Returns true if IsvSpiDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of IsvSpiDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsvSpiDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizCode == input.BizCode ||
                    (this.BizCode != null &&
                    this.BizCode.Equals(input.BizCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.SpiEndpoint == input.SpiEndpoint ||
                    (this.SpiEndpoint != null &&
                    this.SpiEndpoint.Equals(input.SpiEndpoint))
                ) && 
                (
                    this.SpiExtProperty == input.SpiExtProperty ||
                    (this.SpiExtProperty != null &&
                    this.SpiExtProperty.Equals(input.SpiExtProperty))
                ) && 
                (
                    this.SpiKey == input.SpiKey ||
                    (this.SpiKey != null &&
                    this.SpiKey.Equals(input.SpiKey))
                ) && 
                (
                    this.SpiName == input.SpiName ||
                    (this.SpiName != null &&
                    this.SpiName.Equals(input.SpiName))
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
                if (this.BizCode != null)
                {
                    hashCode = (hashCode * 59) + this.BizCode.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.SpiEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.SpiEndpoint.GetHashCode();
                }
                if (this.SpiExtProperty != null)
                {
                    hashCode = (hashCode * 59) + this.SpiExtProperty.GetHashCode();
                }
                if (this.SpiKey != null)
                {
                    hashCode = (hashCode * 59) + this.SpiKey.GetHashCode();
                }
                if (this.SpiName != null)
                {
                    hashCode = (hashCode * 59) + this.SpiName.GetHashCode();
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
