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
    /// AlipayMerchantItemFileUploadRequest
    /// </summary>
    [DataContract(Name = "alipay_merchant_item_file_upload_request")]
    public partial class AlipayMerchantItemFileUploadRequest : IEquatable<AlipayMerchantItemFileUploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantItemFileUploadRequest" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="fileContent">fileContent.</param>
        public AlipayMerchantItemFileUploadRequest(AlipayMerchantItemFileUploadModel data = default(AlipayMerchantItemFileUploadModel), System.IO.Stream fileContent = default(System.IO.Stream))
        {
            this.Data = data;
            this.FileContent = fileContent;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public AlipayMerchantItemFileUploadModel Data { get; set; }

        /// <summary>
        /// Gets or Sets FileContent
        /// </summary>
        [DataMember(Name = "file_content", EmitDefaultValue = false)]
        public System.IO.Stream FileContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantItemFileUploadRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  FileContent: ").Append(FileContent).Append("\n");
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
            return this.Equals(input as AlipayMerchantItemFileUploadRequest);
        }

        /// <summary>
        /// Returns true if AlipayMerchantItemFileUploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantItemFileUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantItemFileUploadRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.FileContent == input.FileContent ||
                    (this.FileContent != null &&
                    this.FileContent.Equals(input.FileContent))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.FileContent != null)
                {
                    hashCode = (hashCode * 59) + this.FileContent.GetHashCode();
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
