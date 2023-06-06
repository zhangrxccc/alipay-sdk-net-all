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
    /// DateRuleInfo
    /// </summary>
    [DataContract(Name = "DateRuleInfo")]
    public partial class DateRuleInfo : IEquatable<DateRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateRuleInfo" /> class.
        /// </summary>
        /// <param name="dateRangeInfo">dateRangeInfo.</param>
        /// <param name="timeRangeInfo">timeRangeInfo.</param>
        public DateRuleInfo(DateRangeInfo dateRangeInfo = default(DateRangeInfo), TimeRangeInfo timeRangeInfo = default(TimeRangeInfo))
        {
            this.DateRangeInfo = dateRangeInfo;
            this.TimeRangeInfo = timeRangeInfo;
        }

        /// <summary>
        /// Gets or Sets DateRangeInfo
        /// </summary>
        [DataMember(Name = "date_range_info", EmitDefaultValue = false)]
        public DateRangeInfo DateRangeInfo { get; set; }

        /// <summary>
        /// Gets or Sets TimeRangeInfo
        /// </summary>
        [DataMember(Name = "time_range_info", EmitDefaultValue = false)]
        public TimeRangeInfo TimeRangeInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DateRuleInfo {\n");
            sb.Append("  DateRangeInfo: ").Append(DateRangeInfo).Append("\n");
            sb.Append("  TimeRangeInfo: ").Append(TimeRangeInfo).Append("\n");
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
            return this.Equals(input as DateRuleInfo);
        }

        /// <summary>
        /// Returns true if DateRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DateRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateRuleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DateRangeInfo == input.DateRangeInfo ||
                    (this.DateRangeInfo != null &&
                    this.DateRangeInfo.Equals(input.DateRangeInfo))
                ) && 
                (
                    this.TimeRangeInfo == input.TimeRangeInfo ||
                    (this.TimeRangeInfo != null &&
                    this.TimeRangeInfo.Equals(input.TimeRangeInfo))
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
                if (this.DateRangeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DateRangeInfo.GetHashCode();
                }
                if (this.TimeRangeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TimeRangeInfo.GetHashCode();
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
