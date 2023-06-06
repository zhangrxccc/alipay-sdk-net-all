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
    /// AlipayMarketingCardBenefitCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardBenefitCreateResponseModel")]
    public partial class AlipayMarketingCardBenefitCreateResponseModel : IEquatable<AlipayMarketingCardBenefitCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardBenefitCreateResponseModel" /> class.
        /// </summary>
        /// <param name="benefitId">权益ID.</param>
        public AlipayMarketingCardBenefitCreateResponseModel(string benefitId = default(string))
        {
            this.BenefitId = benefitId;
        }

        /// <summary>
        /// 权益ID
        /// </summary>
        /// <value>权益ID</value>
        [DataMember(Name = "benefit_id", EmitDefaultValue = false)]
        public string BenefitId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardBenefitCreateResponseModel {\n");
            sb.Append("  BenefitId: ").Append(BenefitId).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardBenefitCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardBenefitCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardBenefitCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardBenefitCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BenefitId == input.BenefitId ||
                    (this.BenefitId != null &&
                    this.BenefitId.Equals(input.BenefitId))
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
                if (this.BenefitId != null)
                {
                    hashCode = (hashCode * 59) + this.BenefitId.GetHashCode();
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
