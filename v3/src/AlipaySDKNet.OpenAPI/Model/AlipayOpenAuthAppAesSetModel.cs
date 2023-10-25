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
    /// AlipayOpenAuthAppAesSetModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAuthAppAesSetModel")]
    public partial class AlipayOpenAuthAppAesSetModel : IEquatable<AlipayOpenAuthAppAesSetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAuthAppAesSetModel" /> class.
        /// </summary>
        /// <param name="merchantAppId">商家应用appId.</param>
        public AlipayOpenAuthAppAesSetModel(string merchantAppId = default(string))
        {
            this.MerchantAppId = merchantAppId;
        }

        /// <summary>
        /// 商家应用appId
        /// </summary>
        /// <value>商家应用appId</value>
        [DataMember(Name = "merchant_app_id", EmitDefaultValue = false)]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAuthAppAesSetModel {\n");
            sb.Append("  MerchantAppId: ").Append(MerchantAppId).Append("\n");
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
            return this.Equals(input as AlipayOpenAuthAppAesSetModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAuthAppAesSetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAuthAppAesSetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAuthAppAesSetModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantAppId == input.MerchantAppId ||
                    (this.MerchantAppId != null &&
                    this.MerchantAppId.Equals(input.MerchantAppId))
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
                if (this.MerchantAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAppId.GetHashCode();
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
