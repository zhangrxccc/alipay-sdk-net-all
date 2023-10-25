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
    /// AlipayEbppInvoiceFileOutputQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceFileOutputQueryResponseModel")]
    public partial class AlipayEbppInvoiceFileOutputQueryResponseModel : IEquatable<AlipayEbppInvoiceFileOutputQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceFileOutputQueryResponseModel" /> class.
        /// </summary>
        /// <param name="fileType">发票文件类型pdf或ofd.</param>
        /// <param name="invoiceFileContent">发票文件内容,需要先base64解码，获取原始byte[]类型文件流.</param>
        public AlipayEbppInvoiceFileOutputQueryResponseModel(string fileType = default(string), string invoiceFileContent = default(string))
        {
            this.FileType = fileType;
            this.InvoiceFileContent = invoiceFileContent;
        }

        /// <summary>
        /// 发票文件类型pdf或ofd
        /// </summary>
        /// <value>发票文件类型pdf或ofd</value>
        [DataMember(Name = "file_type", EmitDefaultValue = false)]
        public string FileType { get; set; }

        /// <summary>
        /// 发票文件内容,需要先base64解码，获取原始byte[]类型文件流
        /// </summary>
        /// <value>发票文件内容,需要先base64解码，获取原始byte[]类型文件流</value>
        [DataMember(Name = "invoice_file_content", EmitDefaultValue = false)]
        public string InvoiceFileContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceFileOutputQueryResponseModel {\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  InvoiceFileContent: ").Append(InvoiceFileContent).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceFileOutputQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceFileOutputQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceFileOutputQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceFileOutputQueryResponseModel input)
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
                    this.InvoiceFileContent == input.InvoiceFileContent ||
                    (this.InvoiceFileContent != null &&
                    this.InvoiceFileContent.Equals(input.InvoiceFileContent))
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
                if (this.InvoiceFileContent != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceFileContent.GetHashCode();
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
