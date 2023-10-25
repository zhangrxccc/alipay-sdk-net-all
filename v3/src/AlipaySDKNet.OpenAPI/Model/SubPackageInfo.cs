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
    /// SubPackageInfo
    /// </summary>
    [DataContract(Name = "SubPackageInfo")]
    public partial class SubPackageInfo : IEquatable<SubPackageInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubPackageInfo" /> class.
        /// </summary>
        /// <param name="buildedPackageUrl">构建好的结果地址.</param>
        /// <param name="newBuildedPackageUrl">构建好的分包地址.</param>
        /// <param name="newSize">2.0分包大小，单位字节.</param>
        /// <param name="path">分包路径.</param>
        /// <param name="size">分包大小，单位字节.</param>
        /// <param name="sourceUrl">源码地址.</param>
        /// <param name="type">分包类型： MAIN ｜ SUB.</param>
        public SubPackageInfo(string buildedPackageUrl = default(string), string newBuildedPackageUrl = default(string), string newSize = default(string), string path = default(string), string size = default(string), string sourceUrl = default(string), string type = default(string))
        {
            this.BuildedPackageUrl = buildedPackageUrl;
            this.NewBuildedPackageUrl = newBuildedPackageUrl;
            this.NewSize = newSize;
            this.Path = path;
            this.Size = size;
            this.SourceUrl = sourceUrl;
            this.Type = type;
        }

        /// <summary>
        /// 构建好的结果地址
        /// </summary>
        /// <value>构建好的结果地址</value>
        [DataMember(Name = "builded_package_url", EmitDefaultValue = false)]
        public string BuildedPackageUrl { get; set; }

        /// <summary>
        /// 构建好的分包地址
        /// </summary>
        /// <value>构建好的分包地址</value>
        [DataMember(Name = "new_builded_package_url", EmitDefaultValue = false)]
        public string NewBuildedPackageUrl { get; set; }

        /// <summary>
        /// 2.0分包大小，单位字节
        /// </summary>
        /// <value>2.0分包大小，单位字节</value>
        [DataMember(Name = "new_size", EmitDefaultValue = false)]
        public string NewSize { get; set; }

        /// <summary>
        /// 分包路径
        /// </summary>
        /// <value>分包路径</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// 分包大小，单位字节
        /// </summary>
        /// <value>分包大小，单位字节</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public string Size { get; set; }

        /// <summary>
        /// 源码地址
        /// </summary>
        /// <value>源码地址</value>
        [DataMember(Name = "source_url", EmitDefaultValue = false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// 分包类型： MAIN ｜ SUB
        /// </summary>
        /// <value>分包类型： MAIN ｜ SUB</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubPackageInfo {\n");
            sb.Append("  BuildedPackageUrl: ").Append(BuildedPackageUrl).Append("\n");
            sb.Append("  NewBuildedPackageUrl: ").Append(NewBuildedPackageUrl).Append("\n");
            sb.Append("  NewSize: ").Append(NewSize).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  SourceUrl: ").Append(SourceUrl).Append("\n");
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
            return this.Equals(input as SubPackageInfo);
        }

        /// <summary>
        /// Returns true if SubPackageInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SubPackageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubPackageInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuildedPackageUrl == input.BuildedPackageUrl ||
                    (this.BuildedPackageUrl != null &&
                    this.BuildedPackageUrl.Equals(input.BuildedPackageUrl))
                ) && 
                (
                    this.NewBuildedPackageUrl == input.NewBuildedPackageUrl ||
                    (this.NewBuildedPackageUrl != null &&
                    this.NewBuildedPackageUrl.Equals(input.NewBuildedPackageUrl))
                ) && 
                (
                    this.NewSize == input.NewSize ||
                    (this.NewSize != null &&
                    this.NewSize.Equals(input.NewSize))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.SourceUrl == input.SourceUrl ||
                    (this.SourceUrl != null &&
                    this.SourceUrl.Equals(input.SourceUrl))
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
                if (this.BuildedPackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BuildedPackageUrl.GetHashCode();
                }
                if (this.NewBuildedPackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NewBuildedPackageUrl.GetHashCode();
                }
                if (this.NewSize != null)
                {
                    hashCode = (hashCode * 59) + this.NewSize.GetHashCode();
                }
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                if (this.SourceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SourceUrl.GetHashCode();
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
