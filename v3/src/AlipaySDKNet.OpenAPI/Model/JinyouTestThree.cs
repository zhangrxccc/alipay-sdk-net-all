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
    /// JinyouTestThree
    /// </summary>
    [DataContract(Name = "JinyouTestThree")]
    public partial class JinyouTestThree : IEquatable<JinyouTestThree>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JinyouTestThree" /> class.
        /// </summary>
        /// <param name="th1F">th1F.</param>
        /// <param name="th2N">无枚举值.</param>
        /// <param name="th3N">1.</param>
        public JinyouTestThree(JinyouTestTwo th1F = default(JinyouTestTwo), string th2N = default(string), bool th3N = default(bool))
        {
            this.Th1F = th1F;
            this.Th2N = th2N;
            this.Th3N = th3N;
        }

        /// <summary>
        /// Gets or Sets Th1F
        /// </summary>
        [DataMember(Name = "th_1_f", EmitDefaultValue = false)]
        public JinyouTestTwo Th1F { get; set; }

        /// <summary>
        /// 无枚举值
        /// </summary>
        /// <value>无枚举值</value>
        [DataMember(Name = "th_2_n", EmitDefaultValue = false)]
        public string Th2N { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "th_3_n", EmitDefaultValue = true)]
        public bool Th3N { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JinyouTestThree {\n");
            sb.Append("  Th1F: ").Append(Th1F).Append("\n");
            sb.Append("  Th2N: ").Append(Th2N).Append("\n");
            sb.Append("  Th3N: ").Append(Th3N).Append("\n");
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
            return this.Equals(input as JinyouTestThree);
        }

        /// <summary>
        /// Returns true if JinyouTestThree instances are equal
        /// </summary>
        /// <param name="input">Instance of JinyouTestThree to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JinyouTestThree input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Th1F == input.Th1F ||
                    (this.Th1F != null &&
                    this.Th1F.Equals(input.Th1F))
                ) && 
                (
                    this.Th2N == input.Th2N ||
                    (this.Th2N != null &&
                    this.Th2N.Equals(input.Th2N))
                ) && 
                (
                    this.Th3N == input.Th3N ||
                    this.Th3N.Equals(input.Th3N)
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
                if (this.Th1F != null)
                {
                    hashCode = (hashCode * 59) + this.Th1F.GetHashCode();
                }
                if (this.Th2N != null)
                {
                    hashCode = (hashCode * 59) + this.Th2N.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Th3N.GetHashCode();
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
