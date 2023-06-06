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
    /// LabelFilter
    /// </summary>
    [DataContract(Name = "LabelFilter")]
    public partial class LabelFilter : IEquatable<LabelFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelFilter" /> class.
        /// </summary>
        /// <param name="columnName">标签组名，商户自定义的标签固定为label_id_list，支付宝开放的标签详见&lt;a href&#x3D;\&quot;http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/FirstPartOfTagsFromAlipay.xlsx\&quot;&gt;支付宝开放标签&lt;/a&gt;.</param>
        /// <param name="op">操作符，支持&#x3D;、!&#x3D;、in三个操作符；其中in表示是某几个标签中的一个.</param>
        /// <param name="values">标签数组，用于组装最后的表达式.</param>
        public LabelFilter(string columnName = default(string), string op = default(string), List<string> values = default(List<string>))
        {
            this.ColumnName = columnName;
            this.Op = op;
            this.Values = values;
        }

        /// <summary>
        /// 标签组名，商户自定义的标签固定为label_id_list，支付宝开放的标签详见&lt;a href&#x3D;\&quot;http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/FirstPartOfTagsFromAlipay.xlsx\&quot;&gt;支付宝开放标签&lt;/a&gt;
        /// </summary>
        /// <value>标签组名，商户自定义的标签固定为label_id_list，支付宝开放的标签详见&lt;a href&#x3D;\&quot;http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/FirstPartOfTagsFromAlipay.xlsx\&quot;&gt;支付宝开放标签&lt;/a&gt;</value>
        [DataMember(Name = "column_name", EmitDefaultValue = false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// 操作符，支持&#x3D;、!&#x3D;、in三个操作符；其中in表示是某几个标签中的一个
        /// </summary>
        /// <value>操作符，支持&#x3D;、!&#x3D;、in三个操作符；其中in表示是某几个标签中的一个</value>
        [DataMember(Name = "op", EmitDefaultValue = false)]
        public string Op { get; set; }

        /// <summary>
        /// 标签数组，用于组装最后的表达式
        /// </summary>
        /// <value>标签数组，用于组装最后的表达式</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LabelFilter {\n");
            sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as LabelFilter);
        }

        /// <summary>
        /// Returns true if LabelFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ColumnName == input.ColumnName ||
                    (this.ColumnName != null &&
                    this.ColumnName.Equals(input.ColumnName))
                ) && 
                (
                    this.Op == input.Op ||
                    (this.Op != null &&
                    this.Op.Equals(input.Op))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.ColumnName != null)
                {
                    hashCode = (hashCode * 59) + this.ColumnName.GetHashCode();
                }
                if (this.Op != null)
                {
                    hashCode = (hashCode * 59) + this.Op.GetHashCode();
                }
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
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
