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
    /// DisplayConfig
    /// </summary>
    [DataContract(Name = "DisplayConfig")]
    public partial class DisplayConfig : IEquatable<DisplayConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayConfig" /> class.
        /// </summary>
        /// <param name="slogan">券的宣传语  含圈人的直领活动，且投放渠道选择了支付成功页或店铺的情况下必填.</param>
        /// <param name="sloganImg">券的宣传图片文件ID  含圈人的直领活动，且投放渠道选择了店铺的情况下必填.</param>
        public DisplayConfig(string slogan = default(string), string sloganImg = default(string))
        {
            this.Slogan = slogan;
            this.SloganImg = sloganImg;
        }

        /// <summary>
        /// 券的宣传语  含圈人的直领活动，且投放渠道选择了支付成功页或店铺的情况下必填
        /// </summary>
        /// <value>券的宣传语  含圈人的直领活动，且投放渠道选择了支付成功页或店铺的情况下必填</value>
        [DataMember(Name = "slogan", EmitDefaultValue = false)]
        public string Slogan { get; set; }

        /// <summary>
        /// 券的宣传图片文件ID  含圈人的直领活动，且投放渠道选择了店铺的情况下必填
        /// </summary>
        /// <value>券的宣传图片文件ID  含圈人的直领活动，且投放渠道选择了店铺的情况下必填</value>
        [DataMember(Name = "slogan_img", EmitDefaultValue = false)]
        public string SloganImg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisplayConfig {\n");
            sb.Append("  Slogan: ").Append(Slogan).Append("\n");
            sb.Append("  SloganImg: ").Append(SloganImg).Append("\n");
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
            return this.Equals(input as DisplayConfig);
        }

        /// <summary>
        /// Returns true if DisplayConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplayConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Slogan == input.Slogan ||
                    (this.Slogan != null &&
                    this.Slogan.Equals(input.Slogan))
                ) && 
                (
                    this.SloganImg == input.SloganImg ||
                    (this.SloganImg != null &&
                    this.SloganImg.Equals(input.SloganImg))
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
                if (this.Slogan != null)
                {
                    hashCode = (hashCode * 59) + this.Slogan.GetHashCode();
                }
                if (this.SloganImg != null)
                {
                    hashCode = (hashCode * 59) + this.SloganImg.GetHashCode();
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
