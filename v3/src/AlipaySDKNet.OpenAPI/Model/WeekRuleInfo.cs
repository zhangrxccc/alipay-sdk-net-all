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
    /// WeekRuleInfo
    /// </summary>
    [DataContract(Name = "WeekRuleInfo")]
    public partial class WeekRuleInfo : IEquatable<WeekRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeekRuleInfo" /> class.
        /// </summary>
        /// <param name="timeRangeInfo">timeRangeInfo.</param>
        /// <param name="weekDay">星期数，以“,”连接多个星期数.</param>
        public WeekRuleInfo(TimeRangeInfo timeRangeInfo = default(TimeRangeInfo), string weekDay = default(string))
        {
            this.TimeRangeInfo = timeRangeInfo;
            this.WeekDay = weekDay;
        }

        /// <summary>
        /// Gets or Sets TimeRangeInfo
        /// </summary>
        [DataMember(Name = "time_range_info", EmitDefaultValue = false)]
        public TimeRangeInfo TimeRangeInfo { get; set; }

        /// <summary>
        /// 星期数，以“,”连接多个星期数
        /// </summary>
        /// <value>星期数，以“,”连接多个星期数</value>
        [DataMember(Name = "week_day", EmitDefaultValue = false)]
        public string WeekDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WeekRuleInfo {\n");
            sb.Append("  TimeRangeInfo: ").Append(TimeRangeInfo).Append("\n");
            sb.Append("  WeekDay: ").Append(WeekDay).Append("\n");
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
            return this.Equals(input as WeekRuleInfo);
        }

        /// <summary>
        /// Returns true if WeekRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of WeekRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeekRuleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TimeRangeInfo == input.TimeRangeInfo ||
                    (this.TimeRangeInfo != null &&
                    this.TimeRangeInfo.Equals(input.TimeRangeInfo))
                ) && 
                (
                    this.WeekDay == input.WeekDay ||
                    (this.WeekDay != null &&
                    this.WeekDay.Equals(input.WeekDay))
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
                if (this.TimeRangeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TimeRangeInfo.GetHashCode();
                }
                if (this.WeekDay != null)
                {
                    hashCode = (hashCode * 59) + this.WeekDay.GetHashCode();
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
