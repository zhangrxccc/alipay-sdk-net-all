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
    /// AuditEvidenceInfo
    /// </summary>
    [DataContract(Name = "AuditEvidenceInfo")]
    public partial class AuditEvidenceInfo : IEquatable<AuditEvidenceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEvidenceInfo" /> class.
        /// </summary>
        /// <param name="fileType">文件类型。包括.jpg .png .jpeg .pdf等.</param>
        /// <param name="url">文件url.</param>
        public AuditEvidenceInfo(string fileType = default(string), string url = default(string))
        {
            this.FileType = fileType;
            this.Url = url;
        }

        /// <summary>
        /// 文件类型。包括.jpg .png .jpeg .pdf等
        /// </summary>
        /// <value>文件类型。包括.jpg .png .jpeg .pdf等</value>
        [DataMember(Name = "file_type", EmitDefaultValue = false)]
        public string FileType { get; set; }

        /// <summary>
        /// 文件url
        /// </summary>
        /// <value>文件url</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuditEvidenceInfo {\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as AuditEvidenceInfo);
        }

        /// <summary>
        /// Returns true if AuditEvidenceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditEvidenceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditEvidenceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.FileType != null)
                {
                    hashCode = (hashCode * 59) + this.FileType.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
