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
    /// OrderLogisticsInformationRequest
    /// </summary>
    [DataContract(Name = "OrderLogisticsInformationRequest")]
    public partial class OrderLogisticsInformationRequest : IEquatable<OrderLogisticsInformationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLogisticsInformationRequest" /> class.
        /// </summary>
        /// <param name="logisticsCode">物流公司编号。  物流公司编号值请查看产品文档.</param>
        /// <param name="trackingNo">物流单号.</param>
        public OrderLogisticsInformationRequest(string logisticsCode = default(string), string trackingNo = default(string))
        {
            this.LogisticsCode = logisticsCode;
            this.TrackingNo = trackingNo;
        }

        /// <summary>
        /// 物流公司编号。  物流公司编号值请查看产品文档
        /// </summary>
        /// <value>物流公司编号。  物流公司编号值请查看产品文档</value>
        [DataMember(Name = "logistics_code", EmitDefaultValue = false)]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        /// <value>物流单号</value>
        [DataMember(Name = "tracking_no", EmitDefaultValue = false)]
        public string TrackingNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderLogisticsInformationRequest {\n");
            sb.Append("  LogisticsCode: ").Append(LogisticsCode).Append("\n");
            sb.Append("  TrackingNo: ").Append(TrackingNo).Append("\n");
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
            return this.Equals(input as OrderLogisticsInformationRequest);
        }

        /// <summary>
        /// Returns true if OrderLogisticsInformationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderLogisticsInformationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLogisticsInformationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogisticsCode == input.LogisticsCode ||
                    (this.LogisticsCode != null &&
                    this.LogisticsCode.Equals(input.LogisticsCode))
                ) && 
                (
                    this.TrackingNo == input.TrackingNo ||
                    (this.TrackingNo != null &&
                    this.TrackingNo.Equals(input.TrackingNo))
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
                if (this.LogisticsCode != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsCode.GetHashCode();
                }
                if (this.TrackingNo != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingNo.GetHashCode();
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
