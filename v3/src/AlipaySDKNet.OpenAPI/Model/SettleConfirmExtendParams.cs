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
    /// SettleConfirmExtendParams
    /// </summary>
    [DataContract(Name = "SettleConfirmExtendParams")]
    public partial class SettleConfirmExtendParams : IEquatable<SettleConfirmExtendParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettleConfirmExtendParams" /> class.
        /// </summary>
        /// <param name="royaltyFreeze">是否进行资金冻结，用于后续分账，true表示冻结，false或不传表示不冻结.</param>
        public SettleConfirmExtendParams(string royaltyFreeze = default(string))
        {
            this.RoyaltyFreeze = royaltyFreeze;
        }

        /// <summary>
        /// 是否进行资金冻结，用于后续分账，true表示冻结，false或不传表示不冻结
        /// </summary>
        /// <value>是否进行资金冻结，用于后续分账，true表示冻结，false或不传表示不冻结</value>
        [DataMember(Name = "royalty_freeze", EmitDefaultValue = false)]
        public string RoyaltyFreeze { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettleConfirmExtendParams {\n");
            sb.Append("  RoyaltyFreeze: ").Append(RoyaltyFreeze).Append("\n");
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
            return this.Equals(input as SettleConfirmExtendParams);
        }

        /// <summary>
        /// Returns true if SettleConfirmExtendParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SettleConfirmExtendParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettleConfirmExtendParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoyaltyFreeze == input.RoyaltyFreeze ||
                    (this.RoyaltyFreeze != null &&
                    this.RoyaltyFreeze.Equals(input.RoyaltyFreeze))
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
                if (this.RoyaltyFreeze != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyFreeze.GetHashCode();
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
