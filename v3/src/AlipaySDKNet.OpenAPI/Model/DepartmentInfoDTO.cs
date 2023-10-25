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
    /// DepartmentInfoDTO
    /// </summary>
    [DataContract(Name = "DepartmentInfoDTO")]
    public partial class DepartmentInfoDTO : IEquatable<DepartmentInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentInfoDTO" /> class.
        /// </summary>
        /// <param name="departmentCode">部门编码.</param>
        /// <param name="departmentId">部门id.</param>
        /// <param name="departmentName">部门名称.</param>
        /// <param name="gmtCreate">创建时间.</param>
        /// <param name="gmtModified">修改时间.</param>
        /// <param name="parentDepartmentId">上级部门id，特殊值-1表示根部门.</param>
        public DepartmentInfoDTO(string departmentCode = default(string), string departmentId = default(string), string departmentName = default(string), string gmtCreate = default(string), string gmtModified = default(string), string parentDepartmentId = default(string))
        {
            this.DepartmentCode = departmentCode;
            this.DepartmentId = departmentId;
            this.DepartmentName = departmentName;
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.ParentDepartmentId = parentDepartmentId;
        }

        /// <summary>
        /// 部门编码
        /// </summary>
        /// <value>部门编码</value>
        [DataMember(Name = "department_code", EmitDefaultValue = false)]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        /// <value>部门id</value>
        [DataMember(Name = "department_id", EmitDefaultValue = false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        /// <value>部门名称</value>
        [DataMember(Name = "department_name", EmitDefaultValue = false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value>修改时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 上级部门id，特殊值-1表示根部门
        /// </summary>
        /// <value>上级部门id，特殊值-1表示根部门</value>
        [DataMember(Name = "parent_department_id", EmitDefaultValue = false)]
        public string ParentDepartmentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepartmentInfoDTO {\n");
            sb.Append("  DepartmentCode: ").Append(DepartmentCode).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  DepartmentName: ").Append(DepartmentName).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  ParentDepartmentId: ").Append(ParentDepartmentId).Append("\n");
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
            return this.Equals(input as DepartmentInfoDTO);
        }

        /// <summary>
        /// Returns true if DepartmentInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DepartmentInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepartmentInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DepartmentCode == input.DepartmentCode ||
                    (this.DepartmentCode != null &&
                    this.DepartmentCode.Equals(input.DepartmentCode))
                ) && 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
                ) && 
                (
                    this.DepartmentName == input.DepartmentName ||
                    (this.DepartmentName != null &&
                    this.DepartmentName.Equals(input.DepartmentName))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.ParentDepartmentId == input.ParentDepartmentId ||
                    (this.ParentDepartmentId != null &&
                    this.ParentDepartmentId.Equals(input.ParentDepartmentId))
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
                if (this.DepartmentCode != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentCode.GetHashCode();
                }
                if (this.DepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentId.GetHashCode();
                }
                if (this.DepartmentName != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentName.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.ParentDepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentDepartmentId.GetHashCode();
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
