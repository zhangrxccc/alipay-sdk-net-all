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
    /// MultiCurrencyMoneyOpenApi
    /// </summary>
    [DataContract(Name = "MultiCurrencyMoneyOpenApi")]
    public partial class MultiCurrencyMoneyOpenApi : IEquatable<MultiCurrencyMoneyOpenApi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiCurrencyMoneyOpenApi" /> class.
        /// </summary>
        /// <param name="cent">分.</param>
        /// <param name="currencyValue">币种类型值.</param>
        public MultiCurrencyMoneyOpenApi(int cent = default(int), string currencyValue = default(string))
        {
            this.Cent = cent;
            this.CurrencyValue = currencyValue;
        }

        /// <summary>
        /// 分
        /// </summary>
        /// <value>分</value>
        [DataMember(Name = "cent", EmitDefaultValue = false)]
        public int Cent { get; set; }

        /// <summary>
        /// 币种类型值
        /// </summary>
        /// <value>币种类型值</value>
        [DataMember(Name = "currency_value", EmitDefaultValue = false)]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultiCurrencyMoneyOpenApi {\n");
            sb.Append("  Cent: ").Append(Cent).Append("\n");
            sb.Append("  CurrencyValue: ").Append(CurrencyValue).Append("\n");
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
            return this.Equals(input as MultiCurrencyMoneyOpenApi);
        }

        /// <summary>
        /// Returns true if MultiCurrencyMoneyOpenApi instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiCurrencyMoneyOpenApi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiCurrencyMoneyOpenApi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cent == input.Cent ||
                    this.Cent.Equals(input.Cent)
                ) && 
                (
                    this.CurrencyValue == input.CurrencyValue ||
                    (this.CurrencyValue != null &&
                    this.CurrencyValue.Equals(input.CurrencyValue))
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
                hashCode = (hashCode * 59) + this.Cent.GetHashCode();
                if (this.CurrencyValue != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyValue.GetHashCode();
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
