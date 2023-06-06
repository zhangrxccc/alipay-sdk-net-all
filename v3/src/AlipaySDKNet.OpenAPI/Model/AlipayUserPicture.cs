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
    /// AlipayUserPicture
    /// </summary>
    [DataContract(Name = "AlipayUserPicture")]
    public partial class AlipayUserPicture : IEquatable<AlipayUserPicture>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserPicture" /> class.
        /// </summary>
        /// <param name="pictureType">图片类型，包括身份证正反面、营业执照等.</param>
        /// <param name="pictureUrl">用于调用alipay.user.certify.image.fetch接口，获取图片资源.</param>
        public AlipayUserPicture(string pictureType = default(string), string pictureUrl = default(string))
        {
            this.PictureType = pictureType;
            this.PictureUrl = pictureUrl;
        }

        /// <summary>
        /// 图片类型，包括身份证正反面、营业执照等
        /// </summary>
        /// <value>图片类型，包括身份证正反面、营业执照等</value>
        [DataMember(Name = "picture_type", EmitDefaultValue = false)]
        public string PictureType { get; set; }

        /// <summary>
        /// 用于调用alipay.user.certify.image.fetch接口，获取图片资源
        /// </summary>
        /// <value>用于调用alipay.user.certify.image.fetch接口，获取图片资源</value>
        [DataMember(Name = "picture_url", EmitDefaultValue = false)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserPicture {\n");
            sb.Append("  PictureType: ").Append(PictureType).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
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
            return this.Equals(input as AlipayUserPicture);
        }

        /// <summary>
        /// Returns true if AlipayUserPicture instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserPicture to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserPicture input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PictureType == input.PictureType ||
                    (this.PictureType != null &&
                    this.PictureType.Equals(input.PictureType))
                ) && 
                (
                    this.PictureUrl == input.PictureUrl ||
                    (this.PictureUrl != null &&
                    this.PictureUrl.Equals(input.PictureUrl))
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
                if (this.PictureType != null)
                {
                    hashCode = (hashCode * 59) + this.PictureType.GetHashCode();
                }
                if (this.PictureUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PictureUrl.GetHashCode();
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
