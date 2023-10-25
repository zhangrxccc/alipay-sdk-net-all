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
    /// AlipayOpenMiniInnerappPluginuseconfigCancelModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerappPluginuseconfigCancelModel")]
    public partial class AlipayOpenMiniInnerappPluginuseconfigCancelModel : IEquatable<AlipayOpenMiniInnerappPluginuseconfigCancelModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerappPluginuseconfigCancelModel" /> class.
        /// </summary>
        /// <param name="appOrigin">来源.</param>
        /// <param name="bundleId">端id.</param>
        /// <param name="miniAppId">小程序应用 ID.</param>
        /// <param name="pluginDevVersion">插件研发版本.</param>
        /// <param name="pluginId">插件id.</param>
        public AlipayOpenMiniInnerappPluginuseconfigCancelModel(string appOrigin = default(string), string bundleId = default(string), string miniAppId = default(string), string pluginDevVersion = default(string), string pluginId = default(string))
        {
            this.AppOrigin = appOrigin;
            this.BundleId = bundleId;
            this.MiniAppId = miniAppId;
            this.PluginDevVersion = pluginDevVersion;
            this.PluginId = pluginId;
        }

        /// <summary>
        /// 来源
        /// </summary>
        /// <value>来源</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 端id
        /// </summary>
        /// <value>端id</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序应用 ID
        /// </summary>
        /// <value>小程序应用 ID</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 插件研发版本
        /// </summary>
        /// <value>插件研发版本</value>
        [DataMember(Name = "plugin_dev_version", EmitDefaultValue = false)]
        public string PluginDevVersion { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        /// <value>插件id</value>
        [DataMember(Name = "plugin_id", EmitDefaultValue = false)]
        public string PluginId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerappPluginuseconfigCancelModel {\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  PluginDevVersion: ").Append(PluginDevVersion).Append("\n");
            sb.Append("  PluginId: ").Append(PluginId).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerappPluginuseconfigCancelModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerappPluginuseconfigCancelModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerappPluginuseconfigCancelModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerappPluginuseconfigCancelModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppOrigin == input.AppOrigin ||
                    (this.AppOrigin != null &&
                    this.AppOrigin.Equals(input.AppOrigin))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.PluginDevVersion == input.PluginDevVersion ||
                    (this.PluginDevVersion != null &&
                    this.PluginDevVersion.Equals(input.PluginDevVersion))
                ) && 
                (
                    this.PluginId == input.PluginId ||
                    (this.PluginId != null &&
                    this.PluginId.Equals(input.PluginId))
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
                if (this.AppOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.AppOrigin.GetHashCode();
                }
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.PluginDevVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PluginDevVersion.GetHashCode();
                }
                if (this.PluginId != null)
                {
                    hashCode = (hashCode * 59) + this.PluginId.GetHashCode();
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
