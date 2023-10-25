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
    /// LogisticsCompanyIstd
    /// </summary>
    [DataContract(Name = "LogisticsCompanyIstd")]
    public partial class LogisticsCompanyIstd : IEquatable<LogisticsCompanyIstd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogisticsCompanyIstd" /> class.
        /// </summary>
        /// <param name="logisticsCode">即时配送公司编码，由支付宝分配.</param>
        /// <param name="serviceCodes">即时配送公司服务代码列表.</param>
        public LogisticsCompanyIstd(string logisticsCode = default(string), List<ServiceCodeIstd> serviceCodes = default(List<ServiceCodeIstd>))
        {
            this.LogisticsCode = logisticsCode;
            this.ServiceCodes = serviceCodes;
        }

        /// <summary>
        /// 即时配送公司编码，由支付宝分配
        /// </summary>
        /// <value>即时配送公司编码，由支付宝分配</value>
        [DataMember(Name = "logistics_code", EmitDefaultValue = false)]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 即时配送公司服务代码列表
        /// </summary>
        /// <value>即时配送公司服务代码列表</value>
        [DataMember(Name = "service_codes", EmitDefaultValue = false)]
        public List<ServiceCodeIstd> ServiceCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogisticsCompanyIstd {\n");
            sb.Append("  LogisticsCode: ").Append(LogisticsCode).Append("\n");
            sb.Append("  ServiceCodes: ").Append(ServiceCodes).Append("\n");
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
            return this.Equals(input as LogisticsCompanyIstd);
        }

        /// <summary>
        /// Returns true if LogisticsCompanyIstd instances are equal
        /// </summary>
        /// <param name="input">Instance of LogisticsCompanyIstd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogisticsCompanyIstd input)
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
                    this.ServiceCodes == input.ServiceCodes ||
                    this.ServiceCodes != null &&
                    input.ServiceCodes != null &&
                    this.ServiceCodes.SequenceEqual(input.ServiceCodes)
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
                if (this.ServiceCodes != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCodes.GetHashCode();
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
