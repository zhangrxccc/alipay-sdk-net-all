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
    /// AlipayOpenSpLeadsExpandCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpLeadsExpandCreateResponseModel")]
    public partial class AlipayOpenSpLeadsExpandCreateResponseModel : IEquatable<AlipayOpenSpLeadsExpandCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpLeadsExpandCreateResponseModel" /> class.
        /// </summary>
        /// <param name="leadsId">商机id.</param>
        public AlipayOpenSpLeadsExpandCreateResponseModel(string leadsId = default(string))
        {
            this.LeadsId = leadsId;
        }

        /// <summary>
        /// 商机id
        /// </summary>
        /// <value>商机id</value>
        [DataMember(Name = "leads_id", EmitDefaultValue = false)]
        public string LeadsId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSpLeadsExpandCreateResponseModel {\n");
            sb.Append("  LeadsId: ").Append(LeadsId).Append("\n");
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
            return this.Equals(input as AlipayOpenSpLeadsExpandCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpLeadsExpandCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpLeadsExpandCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpLeadsExpandCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LeadsId == input.LeadsId ||
                    (this.LeadsId != null &&
                    this.LeadsId.Equals(input.LeadsId))
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
                if (this.LeadsId != null)
                {
                    hashCode = (hashCode * 59) + this.LeadsId.GetHashCode();
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
