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
    /// AlipayOpenMiniTemplatemsgMaketingstatusModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTemplatemsgMaketingstatusModifyModel")]
    public partial class AlipayOpenMiniTemplatemsgMaketingstatusModifyModel : IEquatable<AlipayOpenMiniTemplatemsgMaketingstatusModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTemplatemsgMaketingstatusModifyModel" /> class.
        /// </summary>
        /// <param name="detailId">营销投放详情id.</param>
        /// <param name="status">投放详情状态值，如：INIT:下线状态，ON_LINE:上线状态，DELETED:删除状态.</param>
        public AlipayOpenMiniTemplatemsgMaketingstatusModifyModel(string detailId = default(string), string status = default(string))
        {
            this.DetailId = detailId;
            this.Status = status;
        }

        /// <summary>
        /// 营销投放详情id
        /// </summary>
        /// <value>营销投放详情id</value>
        [DataMember(Name = "detail_id", EmitDefaultValue = false)]
        public string DetailId { get; set; }

        /// <summary>
        /// 投放详情状态值，如：INIT:下线状态，ON_LINE:上线状态，DELETED:删除状态
        /// </summary>
        /// <value>投放详情状态值，如：INIT:下线状态，ON_LINE:上线状态，DELETED:删除状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniTemplatemsgMaketingstatusModifyModel {\n");
            sb.Append("  DetailId: ").Append(DetailId).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniTemplatemsgMaketingstatusModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTemplatemsgMaketingstatusModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTemplatemsgMaketingstatusModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTemplatemsgMaketingstatusModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DetailId == input.DetailId ||
                    (this.DetailId != null &&
                    this.DetailId.Equals(input.DetailId))
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
                if (this.DetailId != null)
                {
                    hashCode = (hashCode * 59) + this.DetailId.GetHashCode();
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
