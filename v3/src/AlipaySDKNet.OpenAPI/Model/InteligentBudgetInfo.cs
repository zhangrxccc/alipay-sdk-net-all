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
    /// InteligentBudgetInfo
    /// </summary>
    [DataContract(Name = "InteligentBudgetInfo")]
    public partial class InteligentBudgetInfo : IEquatable<InteligentBudgetInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentBudgetInfo" /> class.
        /// </summary>
        /// <param name="budgetTotal">预算数量.</param>
        /// <param name="budgetType">预算类型，枚举（QUANTITY：数量预算）.</param>
        public InteligentBudgetInfo(string budgetTotal = default(string), string budgetType = default(string))
        {
            this.BudgetTotal = budgetTotal;
            this.BudgetType = budgetType;
        }

        /// <summary>
        /// 预算数量
        /// </summary>
        /// <value>预算数量</value>
        [DataMember(Name = "budget_total", EmitDefaultValue = false)]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型，枚举（QUANTITY：数量预算）
        /// </summary>
        /// <value>预算类型，枚举（QUANTITY：数量预算）</value>
        [DataMember(Name = "budget_type", EmitDefaultValue = false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentBudgetInfo {\n");
            sb.Append("  BudgetTotal: ").Append(BudgetTotal).Append("\n");
            sb.Append("  BudgetType: ").Append(BudgetType).Append("\n");
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
            return this.Equals(input as InteligentBudgetInfo);
        }

        /// <summary>
        /// Returns true if InteligentBudgetInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentBudgetInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentBudgetInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BudgetTotal == input.BudgetTotal ||
                    (this.BudgetTotal != null &&
                    this.BudgetTotal.Equals(input.BudgetTotal))
                ) && 
                (
                    this.BudgetType == input.BudgetType ||
                    (this.BudgetType != null &&
                    this.BudgetType.Equals(input.BudgetType))
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
                if (this.BudgetTotal != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetTotal.GetHashCode();
                }
                if (this.BudgetType != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetType.GetHashCode();
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
