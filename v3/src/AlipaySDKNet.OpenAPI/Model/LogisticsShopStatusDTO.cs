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
    /// LogisticsShopStatusDTO
    /// </summary>
    [DataContract(Name = "LogisticsShopStatusDTO")]
    public partial class LogisticsShopStatusDTO : IEquatable<LogisticsShopStatusDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogisticsShopStatusDTO" /> class.
        /// </summary>
        /// <param name="auditDesc">商家在配送公司的账户的审核说明..</param>
        /// <param name="logisticsCode">配送公司物流编码。.</param>
        /// <param name="logisticsName">配送公司名称。.</param>
        /// <param name="status">门店状态，AUDITING:审核中，AUDIT_REJECT:审核驳回，VALID:已生效，UPDATING:更新中，WAIT_CREATE:待开通(存量门店若需要支持后面新增的配送公司，需要调用门店更新接口发起申请).</param>
        public LogisticsShopStatusDTO(string auditDesc = default(string), string logisticsCode = default(string), string logisticsName = default(string), string status = default(string))
        {
            this.AuditDesc = auditDesc;
            this.LogisticsCode = logisticsCode;
            this.LogisticsName = logisticsName;
            this.Status = status;
        }

        /// <summary>
        /// 商家在配送公司的账户的审核说明.
        /// </summary>
        /// <value>商家在配送公司的账户的审核说明.</value>
        [DataMember(Name = "audit_desc", EmitDefaultValue = false)]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 配送公司物流编码。
        /// </summary>
        /// <value>配送公司物流编码。</value>
        [DataMember(Name = "logistics_code", EmitDefaultValue = false)]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 配送公司名称。
        /// </summary>
        /// <value>配送公司名称。</value>
        [DataMember(Name = "logistics_name", EmitDefaultValue = false)]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 门店状态，AUDITING:审核中，AUDIT_REJECT:审核驳回，VALID:已生效，UPDATING:更新中，WAIT_CREATE:待开通(存量门店若需要支持后面新增的配送公司，需要调用门店更新接口发起申请)
        /// </summary>
        /// <value>门店状态，AUDITING:审核中，AUDIT_REJECT:审核驳回，VALID:已生效，UPDATING:更新中，WAIT_CREATE:待开通(存量门店若需要支持后面新增的配送公司，需要调用门店更新接口发起申请)</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogisticsShopStatusDTO {\n");
            sb.Append("  AuditDesc: ").Append(AuditDesc).Append("\n");
            sb.Append("  LogisticsCode: ").Append(LogisticsCode).Append("\n");
            sb.Append("  LogisticsName: ").Append(LogisticsName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as LogisticsShopStatusDTO);
        }

        /// <summary>
        /// Returns true if LogisticsShopStatusDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of LogisticsShopStatusDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogisticsShopStatusDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuditDesc == input.AuditDesc ||
                    (this.AuditDesc != null &&
                    this.AuditDesc.Equals(input.AuditDesc))
                ) && 
                (
                    this.LogisticsCode == input.LogisticsCode ||
                    (this.LogisticsCode != null &&
                    this.LogisticsCode.Equals(input.LogisticsCode))
                ) && 
                (
                    this.LogisticsName == input.LogisticsName ||
                    (this.LogisticsName != null &&
                    this.LogisticsName.Equals(input.LogisticsName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AuditDesc != null)
                {
                    hashCode = (hashCode * 59) + this.AuditDesc.GetHashCode();
                }
                if (this.LogisticsCode != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsCode.GetHashCode();
                }
                if (this.LogisticsName != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsName.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
