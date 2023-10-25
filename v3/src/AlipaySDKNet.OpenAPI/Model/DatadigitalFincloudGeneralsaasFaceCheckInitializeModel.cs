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
    /// DatadigitalFincloudGeneralsaasFaceCheckInitializeModel
    /// </summary>
    [DataContract(Name = "DatadigitalFincloudGeneralsaasFaceCheckInitializeModel")]
    public partial class DatadigitalFincloudGeneralsaasFaceCheckInitializeModel : IEquatable<DatadigitalFincloudGeneralsaasFaceCheckInitializeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceCheckInitializeModel" /> class.
        /// </summary>
        /// <param name="bizCode">DATA_DIGITAL_BIZ_CODE_FACE_CHECK_LIVE，代表活体检测。.</param>
        /// <param name="outerOrderNo">客户业务单据号。.</param>
        public DatadigitalFincloudGeneralsaasFaceCheckInitializeModel(string bizCode = default(string), string outerOrderNo = default(string))
        {
            this.BizCode = bizCode;
            this.OuterOrderNo = outerOrderNo;
        }

        /// <summary>
        /// DATA_DIGITAL_BIZ_CODE_FACE_CHECK_LIVE，代表活体检测。
        /// </summary>
        /// <value>DATA_DIGITAL_BIZ_CODE_FACE_CHECK_LIVE，代表活体检测。</value>
        [DataMember(Name = "biz_code", EmitDefaultValue = false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 客户业务单据号。
        /// </summary>
        /// <value>客户业务单据号。</value>
        [DataMember(Name = "outer_order_no", EmitDefaultValue = false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatadigitalFincloudGeneralsaasFaceCheckInitializeModel {\n");
            sb.Append("  BizCode: ").Append(BizCode).Append("\n");
            sb.Append("  OuterOrderNo: ").Append(OuterOrderNo).Append("\n");
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
            return this.Equals(input as DatadigitalFincloudGeneralsaasFaceCheckInitializeModel);
        }

        /// <summary>
        /// Returns true if DatadigitalFincloudGeneralsaasFaceCheckInitializeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DatadigitalFincloudGeneralsaasFaceCheckInitializeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatadigitalFincloudGeneralsaasFaceCheckInitializeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizCode == input.BizCode ||
                    (this.BizCode != null &&
                    this.BizCode.Equals(input.BizCode))
                ) && 
                (
                    this.OuterOrderNo == input.OuterOrderNo ||
                    (this.OuterOrderNo != null &&
                    this.OuterOrderNo.Equals(input.OuterOrderNo))
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
                if (this.BizCode != null)
                {
                    hashCode = (hashCode * 59) + this.BizCode.GetHashCode();
                }
                if (this.OuterOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OuterOrderNo.GetHashCode();
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
