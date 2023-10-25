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
    /// VoucherFileInfo
    /// </summary>
    [DataContract(Name = "VoucherFileInfo")]
    public partial class VoucherFileInfo : IEquatable<VoucherFileInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherFileInfo" /> class.
        /// </summary>
        /// <param name="fileDownloadUrl">发票文件下载.</param>
        /// <param name="fileName">文件名.</param>
        /// <param name="fileType">文件类型.</param>
        public VoucherFileInfo(string fileDownloadUrl = default(string), string fileName = default(string), string fileType = default(string))
        {
            this.FileDownloadUrl = fileDownloadUrl;
            this.FileName = fileName;
            this.FileType = fileType;
        }

        /// <summary>
        /// 发票文件下载
        /// </summary>
        /// <value>发票文件下载</value>
        [DataMember(Name = "file_download_url", EmitDefaultValue = false)]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        /// <value>文件名</value>
        [DataMember(Name = "file_name", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        /// <value>文件类型</value>
        [DataMember(Name = "file_type", EmitDefaultValue = false)]
        public string FileType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherFileInfo {\n");
            sb.Append("  FileDownloadUrl: ").Append(FileDownloadUrl).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
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
            return this.Equals(input as VoucherFileInfo);
        }

        /// <summary>
        /// Returns true if VoucherFileInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherFileInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherFileInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileDownloadUrl == input.FileDownloadUrl ||
                    (this.FileDownloadUrl != null &&
                    this.FileDownloadUrl.Equals(input.FileDownloadUrl))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
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
                if (this.FileDownloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileDownloadUrl.GetHashCode();
                }
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                if (this.FileType != null)
                {
                    hashCode = (hashCode * 59) + this.FileType.GetHashCode();
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
