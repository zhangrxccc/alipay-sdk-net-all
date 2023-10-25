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
    /// EndTimeInfo
    /// </summary>
    [DataContract(Name = "EndTimeInfo")]
    public partial class EndTimeInfo : IEquatable<EndTimeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndTimeInfo" /> class.
        /// </summary>
        /// <param name="endTime">结束时间  格式：HH:mm:ss.</param>
        /// <param name="endTimeType">结束时间类型.</param>
        public EndTimeInfo(string endTime = default(string), string endTimeType = default(string))
        {
            this.EndTime = endTime;
            this.EndTimeType = endTimeType;
        }

        /// <summary>
        /// 结束时间  格式：HH:mm:ss
        /// </summary>
        /// <value>结束时间  格式：HH:mm:ss</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 结束时间类型
        /// </summary>
        /// <value>结束时间类型</value>
        [DataMember(Name = "end_time_type", EmitDefaultValue = false)]
        public string EndTimeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EndTimeInfo {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  EndTimeType: ").Append(EndTimeType).Append("\n");
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
            return this.Equals(input as EndTimeInfo);
        }

        /// <summary>
        /// Returns true if EndTimeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EndTimeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndTimeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.EndTimeType == input.EndTimeType ||
                    (this.EndTimeType != null &&
                    this.EndTimeType.Equals(input.EndTimeType))
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
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.EndTimeType != null)
                {
                    hashCode = (hashCode * 59) + this.EndTimeType.GetHashCode();
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
