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
    /// AlipaySecurityProdSssQueryModel
    /// </summary>
    [DataContract(Name = "AlipaySecurityProdSssQueryModel")]
    public partial class AlipaySecurityProdSssQueryModel : IEquatable<AlipaySecurityProdSssQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySecurityProdSssQueryModel" /> class.
        /// </summary>
        /// <param name="tesst">stst.</param>
        /// <param name="xxx">xxx.</param>
        public AlipaySecurityProdSssQueryModel(List<PromiseDetail> tesst = default(List<PromiseDetail>), JinyouTestFive xxx = default(JinyouTestFive))
        {
            this.Tesst = tesst;
            this.Xxx = xxx;
        }

        /// <summary>
        /// stst
        /// </summary>
        /// <value>stst</value>
        [DataMember(Name = "tesst", EmitDefaultValue = false)]
        public List<PromiseDetail> Tesst { get; set; }

        /// <summary>
        /// Gets or Sets Xxx
        /// </summary>
        [DataMember(Name = "xxx", EmitDefaultValue = false)]
        public JinyouTestFive Xxx { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipaySecurityProdSssQueryModel {\n");
            sb.Append("  Tesst: ").Append(Tesst).Append("\n");
            sb.Append("  Xxx: ").Append(Xxx).Append("\n");
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
            return this.Equals(input as AlipaySecurityProdSssQueryModel);
        }

        /// <summary>
        /// Returns true if AlipaySecurityProdSssQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipaySecurityProdSssQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipaySecurityProdSssQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Tesst == input.Tesst ||
                    this.Tesst != null &&
                    input.Tesst != null &&
                    this.Tesst.SequenceEqual(input.Tesst)
                ) && 
                (
                    this.Xxx == input.Xxx ||
                    (this.Xxx != null &&
                    this.Xxx.Equals(input.Xxx))
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
                if (this.Tesst != null)
                {
                    hashCode = (hashCode * 59) + this.Tesst.GetHashCode();
                }
                if (this.Xxx != null)
                {
                    hashCode = (hashCode * 59) + this.Xxx.GetHashCode();
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
