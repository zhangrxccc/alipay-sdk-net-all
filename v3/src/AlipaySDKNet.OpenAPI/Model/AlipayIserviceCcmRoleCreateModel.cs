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
    /// AlipayIserviceCcmRoleCreateModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmRoleCreateModel")]
    public partial class AlipayIserviceCcmRoleCreateModel : IEquatable<AlipayIserviceCcmRoleCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmRoleCreateModel" /> class.
        /// </summary>
        /// <param name="ccsInstanceId">部门id（即租户实例ID、数据权限ID）.</param>
        /// <param name="creatorId">创建人id.</param>
        /// <param name="description">角色描述信息.</param>
        /// <param name="functionIds">角色关联额功能点id.</param>
        /// <param name="name">角色名.</param>
        public AlipayIserviceCcmRoleCreateModel(string ccsInstanceId = default(string), string creatorId = default(string), string description = default(string), List<string> functionIds = default(List<string>), string name = default(string))
        {
            this.CcsInstanceId = ccsInstanceId;
            this.CreatorId = creatorId;
            this.Description = description;
            this.FunctionIds = functionIds;
            this.Name = name;
        }

        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        /// <value>部门id（即租户实例ID、数据权限ID）</value>
        [DataMember(Name = "ccs_instance_id", EmitDefaultValue = false)]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        /// <value>创建人id</value>
        [DataMember(Name = "creator_id", EmitDefaultValue = false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 角色描述信息
        /// </summary>
        /// <value>角色描述信息</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 角色关联额功能点id
        /// </summary>
        /// <value>角色关联额功能点id</value>
        [DataMember(Name = "function_ids", EmitDefaultValue = false)]
        public List<string> FunctionIds { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        /// <value>角色名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmRoleCreateModel {\n");
            sb.Append("  CcsInstanceId: ").Append(CcsInstanceId).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FunctionIds: ").Append(FunctionIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmRoleCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmRoleCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmRoleCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmRoleCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CcsInstanceId == input.CcsInstanceId ||
                    (this.CcsInstanceId != null &&
                    this.CcsInstanceId.Equals(input.CcsInstanceId))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FunctionIds == input.FunctionIds ||
                    this.FunctionIds != null &&
                    input.FunctionIds != null &&
                    this.FunctionIds.SequenceEqual(input.FunctionIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.CcsInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.CcsInstanceId.GetHashCode();
                }
                if (this.CreatorId != null)
                {
                    hashCode = (hashCode * 59) + this.CreatorId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FunctionIds != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionIds.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
