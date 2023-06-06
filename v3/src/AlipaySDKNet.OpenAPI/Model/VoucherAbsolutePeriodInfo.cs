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
    /// VoucherAbsolutePeriodInfo
    /// </summary>
    [DataContract(Name = "VoucherAbsolutePeriodInfo")]
    public partial class VoucherAbsolutePeriodInfo : IEquatable<VoucherAbsolutePeriodInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAbsolutePeriodInfo" /> class.
        /// </summary>
        /// <param name="timeRestrictInfo">timeRestrictInfo.</param>
        /// <param name="validBeginTime">券可使用的开始时间。 格式为：yyyy-MM-dd HH:mm:ss。.</param>
        /// <param name="validEndTime">券可使用的结束时间。 格式为yyyy-MM-dd HH:mm:ss。.</param>
        public VoucherAbsolutePeriodInfo(TimeRestrictInfo timeRestrictInfo = default(TimeRestrictInfo), string validBeginTime = default(string), string validEndTime = default(string))
        {
            this.TimeRestrictInfo = timeRestrictInfo;
            this.ValidBeginTime = validBeginTime;
            this.ValidEndTime = validEndTime;
        }

        /// <summary>
        /// Gets or Sets TimeRestrictInfo
        /// </summary>
        [DataMember(Name = "time_restrict_info", EmitDefaultValue = false)]
        public TimeRestrictInfo TimeRestrictInfo { get; set; }

        /// <summary>
        /// 券可使用的开始时间。 格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        /// <value>券可使用的开始时间。 格式为：yyyy-MM-dd HH:mm:ss。</value>
        [DataMember(Name = "valid_begin_time", EmitDefaultValue = false)]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 券可使用的结束时间。 格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        /// <value>券可使用的结束时间。 格式为yyyy-MM-dd HH:mm:ss。</value>
        [DataMember(Name = "valid_end_time", EmitDefaultValue = false)]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAbsolutePeriodInfo {\n");
            sb.Append("  TimeRestrictInfo: ").Append(TimeRestrictInfo).Append("\n");
            sb.Append("  ValidBeginTime: ").Append(ValidBeginTime).Append("\n");
            sb.Append("  ValidEndTime: ").Append(ValidEndTime).Append("\n");
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
            return this.Equals(input as VoucherAbsolutePeriodInfo);
        }

        /// <summary>
        /// Returns true if VoucherAbsolutePeriodInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAbsolutePeriodInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAbsolutePeriodInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TimeRestrictInfo == input.TimeRestrictInfo ||
                    (this.TimeRestrictInfo != null &&
                    this.TimeRestrictInfo.Equals(input.TimeRestrictInfo))
                ) && 
                (
                    this.ValidBeginTime == input.ValidBeginTime ||
                    (this.ValidBeginTime != null &&
                    this.ValidBeginTime.Equals(input.ValidBeginTime))
                ) && 
                (
                    this.ValidEndTime == input.ValidEndTime ||
                    (this.ValidEndTime != null &&
                    this.ValidEndTime.Equals(input.ValidEndTime))
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
                if (this.TimeRestrictInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TimeRestrictInfo.GetHashCode();
                }
                if (this.ValidBeginTime != null)
                {
                    hashCode = (hashCode * 59) + this.ValidBeginTime.GetHashCode();
                }
                if (this.ValidEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.ValidEndTime.GetHashCode();
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
