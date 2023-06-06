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
    /// AlipayOpenSearchOrderdetailQueryModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchOrderdetailQueryModel")]
    public partial class AlipayOpenSearchOrderdetailQueryModel : IEquatable<AlipayOpenSearchOrderdetailQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchOrderdetailQueryModel" /> class.
        /// </summary>
        /// <param name="bizData">bizData.</param>
        /// <param name="bizType">表示修改内容的业务类型.</param>
        /// <param name="optType">进行具体操作的类型比如：create、mod、cancel.</param>
        public AlipayOpenSearchOrderdetailQueryModel(SearchOrderRequest bizData = default(SearchOrderRequest), string bizType = default(string), string optType = default(string))
        {
            this.BizData = bizData;
            this.BizType = bizType;
            this.OptType = optType;
        }

        /// <summary>
        /// Gets or Sets BizData
        /// </summary>
        [DataMember(Name = "biz_data", EmitDefaultValue = false)]
        public SearchOrderRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        /// <value>表示修改内容的业务类型</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体操作的类型比如：create、mod、cancel
        /// </summary>
        /// <value>进行具体操作的类型比如：create、mod、cancel</value>
        [DataMember(Name = "opt_type", EmitDefaultValue = false)]
        public string OptType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchOrderdetailQueryModel {\n");
            sb.Append("  BizData: ").Append(BizData).Append("\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  OptType: ").Append(OptType).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchOrderdetailQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchOrderdetailQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchOrderdetailQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchOrderdetailQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizData == input.BizData ||
                    (this.BizData != null &&
                    this.BizData.Equals(input.BizData))
                ) && 
                (
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
                ) && 
                (
                    this.OptType == input.OptType ||
                    (this.OptType != null &&
                    this.OptType.Equals(input.OptType))
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
                if (this.BizData != null)
                {
                    hashCode = (hashCode * 59) + this.BizData.GetHashCode();
                }
                if (this.BizType != null)
                {
                    hashCode = (hashCode * 59) + this.BizType.GetHashCode();
                }
                if (this.OptType != null)
                {
                    hashCode = (hashCode * 59) + this.OptType.GetHashCode();
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
