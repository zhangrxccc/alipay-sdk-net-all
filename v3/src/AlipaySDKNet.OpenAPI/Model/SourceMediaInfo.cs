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
    /// SourceMediaInfo
    /// </summary>
    [DataContract(Name = "SourceMediaInfo")]
    public partial class SourceMediaInfo : IEquatable<SourceMediaInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceMediaInfo" /> class.
        /// </summary>
        /// <param name="mediaId">素材ID，对应“支付宝文件上传接口”获取的file_id.</param>
        /// <param name="mediaType">素材类型。  image：图片  video：视频 cover_static：静态封面.</param>
        public SourceMediaInfo(string mediaId = default(string), string mediaType = default(string))
        {
            this.MediaId = mediaId;
            this.MediaType = mediaType;
        }

        /// <summary>
        /// 素材ID，对应“支付宝文件上传接口”获取的file_id
        /// </summary>
        /// <value>素材ID，对应“支付宝文件上传接口”获取的file_id</value>
        [DataMember(Name = "media_id", EmitDefaultValue = false)]
        public string MediaId { get; set; }

        /// <summary>
        /// 素材类型。  image：图片  video：视频 cover_static：静态封面
        /// </summary>
        /// <value>素材类型。  image：图片  video：视频 cover_static：静态封面</value>
        [DataMember(Name = "media_type", EmitDefaultValue = false)]
        public string MediaType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SourceMediaInfo {\n");
            sb.Append("  MediaId: ").Append(MediaId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
            return this.Equals(input as SourceMediaInfo);
        }

        /// <summary>
        /// Returns true if SourceMediaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceMediaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceMediaInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MediaId == input.MediaId ||
                    (this.MediaId != null &&
                    this.MediaId.Equals(input.MediaId))
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
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
                if (this.MediaId != null)
                {
                    hashCode = (hashCode * 59) + this.MediaId.GetHashCode();
                }
                if (this.MediaType != null)
                {
                    hashCode = (hashCode * 59) + this.MediaType.GetHashCode();
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
