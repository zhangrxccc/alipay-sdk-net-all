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
    /// WidgetActivityInfo
    /// </summary>
    [DataContract(Name = "WidgetActivityInfo")]
    public partial class WidgetActivityInfo : IEquatable<WidgetActivityInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetActivityInfo" /> class.
        /// </summary>
        /// <param name="activityClickUrl">活动点击跳转到小程序的链接地址.</param>
        /// <param name="activityId">活动的唯一标识，同一个小程序橱窗下，该标识唯一，请开发者自行保证.</param>
        /// <param name="activityName">活动名称.</param>
        /// <param name="activityPictureUrls">活动图片链接,最多不能超过5个.</param>
        public WidgetActivityInfo(string activityClickUrl = default(string), string activityId = default(string), string activityName = default(string), List<string> activityPictureUrls = default(List<string>))
        {
            this.ActivityClickUrl = activityClickUrl;
            this.ActivityId = activityId;
            this.ActivityName = activityName;
            this.ActivityPictureUrls = activityPictureUrls;
        }

        /// <summary>
        /// 活动点击跳转到小程序的链接地址
        /// </summary>
        /// <value>活动点击跳转到小程序的链接地址</value>
        [DataMember(Name = "activity_click_url", EmitDefaultValue = false)]
        public string ActivityClickUrl { get; set; }

        /// <summary>
        /// 活动的唯一标识，同一个小程序橱窗下，该标识唯一，请开发者自行保证
        /// </summary>
        /// <value>活动的唯一标识，同一个小程序橱窗下，该标识唯一，请开发者自行保证</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        /// <value>活动名称</value>
        [DataMember(Name = "activity_name", EmitDefaultValue = false)]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动图片链接,最多不能超过5个
        /// </summary>
        /// <value>活动图片链接,最多不能超过5个</value>
        [DataMember(Name = "activity_picture_urls", EmitDefaultValue = false)]
        public List<string> ActivityPictureUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WidgetActivityInfo {\n");
            sb.Append("  ActivityClickUrl: ").Append(ActivityClickUrl).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ActivityName: ").Append(ActivityName).Append("\n");
            sb.Append("  ActivityPictureUrls: ").Append(ActivityPictureUrls).Append("\n");
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
            return this.Equals(input as WidgetActivityInfo);
        }

        /// <summary>
        /// Returns true if WidgetActivityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of WidgetActivityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WidgetActivityInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityClickUrl == input.ActivityClickUrl ||
                    (this.ActivityClickUrl != null &&
                    this.ActivityClickUrl.Equals(input.ActivityClickUrl))
                ) && 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.ActivityName == input.ActivityName ||
                    (this.ActivityName != null &&
                    this.ActivityName.Equals(input.ActivityName))
                ) && 
                (
                    this.ActivityPictureUrls == input.ActivityPictureUrls ||
                    this.ActivityPictureUrls != null &&
                    input.ActivityPictureUrls != null &&
                    this.ActivityPictureUrls.SequenceEqual(input.ActivityPictureUrls)
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
                if (this.ActivityClickUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityClickUrl.GetHashCode();
                }
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
                }
                if (this.ActivityName != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityName.GetHashCode();
                }
                if (this.ActivityPictureUrls != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityPictureUrls.GetHashCode();
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
