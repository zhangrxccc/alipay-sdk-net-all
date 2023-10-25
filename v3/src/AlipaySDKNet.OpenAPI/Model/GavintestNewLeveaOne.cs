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
    /// GavintestNewLeveaOne
    /// </summary>
    [DataContract(Name = "GavintestNewLeveaOne")]
    public partial class GavintestNewLeveaOne : IEquatable<GavintestNewLeveaOne>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GavintestNewLeveaOne" /> class.
        /// </summary>
        /// <param name="boolen">2.</param>
        /// <param name="ces">21.</param>
        /// <param name="des">12.</param>
        /// <param name="str">1.</param>
        public GavintestNewLeveaOne(bool boolen = default(bool), List<int> ces = default(List<int>), string des = default(string), List<string> str = default(List<string>))
        {
            this.Boolen = boolen;
            this.Ces = ces;
            this.Des = des;
            this.Str = str;
        }

        /// <summary>
        /// 2
        /// </summary>
        /// <value>2</value>
        [DataMember(Name = "boolen", EmitDefaultValue = true)]
        public bool Boolen { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        /// <value>21</value>
        [DataMember(Name = "ces", EmitDefaultValue = false)]
        public List<int> Ces { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        /// <value>12</value>
        [DataMember(Name = "des", EmitDefaultValue = false)]
        public string Des { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "str", EmitDefaultValue = false)]
        public List<string> Str { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GavintestNewLeveaOne {\n");
            sb.Append("  Boolen: ").Append(Boolen).Append("\n");
            sb.Append("  Ces: ").Append(Ces).Append("\n");
            sb.Append("  Des: ").Append(Des).Append("\n");
            sb.Append("  Str: ").Append(Str).Append("\n");
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
            return this.Equals(input as GavintestNewLeveaOne);
        }

        /// <summary>
        /// Returns true if GavintestNewLeveaOne instances are equal
        /// </summary>
        /// <param name="input">Instance of GavintestNewLeveaOne to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GavintestNewLeveaOne input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Boolen == input.Boolen ||
                    this.Boolen.Equals(input.Boolen)
                ) && 
                (
                    this.Ces == input.Ces ||
                    this.Ces != null &&
                    input.Ces != null &&
                    this.Ces.SequenceEqual(input.Ces)
                ) && 
                (
                    this.Des == input.Des ||
                    (this.Des != null &&
                    this.Des.Equals(input.Des))
                ) && 
                (
                    this.Str == input.Str ||
                    this.Str != null &&
                    input.Str != null &&
                    this.Str.SequenceEqual(input.Str)
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
                hashCode = (hashCode * 59) + this.Boolen.GetHashCode();
                if (this.Ces != null)
                {
                    hashCode = (hashCode * 59) + this.Ces.GetHashCode();
                }
                if (this.Des != null)
                {
                    hashCode = (hashCode * 59) + this.Des.GetHashCode();
                }
                if (this.Str != null)
                {
                    hashCode = (hashCode * 59) + this.Str.GetHashCode();
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
