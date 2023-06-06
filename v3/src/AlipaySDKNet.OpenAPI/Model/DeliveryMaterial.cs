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
    /// DeliveryMaterial
    /// </summary>
    [DataContract(Name = "DeliveryMaterial")]
    public partial class DeliveryMaterial : IEquatable<DeliveryMaterial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryMaterial" /> class.
        /// </summary>
        /// <param name="deliverySingleMaterial">deliverySingleMaterial.</param>
        /// <param name="materialIdList">素材ID，通过alipay.marketing.material.create接口提供的素材组.</param>
        public DeliveryMaterial(DeliverySingleMaterial deliverySingleMaterial = default(DeliverySingleMaterial), List<string> materialIdList = default(List<string>))
        {
            this.DeliverySingleMaterial = deliverySingleMaterial;
            this.MaterialIdList = materialIdList;
        }

        /// <summary>
        /// Gets or Sets DeliverySingleMaterial
        /// </summary>
        [DataMember(Name = "delivery_single_material", EmitDefaultValue = false)]
        public DeliverySingleMaterial DeliverySingleMaterial { get; set; }

        /// <summary>
        /// 素材ID，通过alipay.marketing.material.create接口提供的素材组
        /// </summary>
        /// <value>素材ID，通过alipay.marketing.material.create接口提供的素材组</value>
        [DataMember(Name = "material_id_list", EmitDefaultValue = false)]
        public List<string> MaterialIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryMaterial {\n");
            sb.Append("  DeliverySingleMaterial: ").Append(DeliverySingleMaterial).Append("\n");
            sb.Append("  MaterialIdList: ").Append(MaterialIdList).Append("\n");
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
            return this.Equals(input as DeliveryMaterial);
        }

        /// <summary>
        /// Returns true if DeliveryMaterial instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryMaterial input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliverySingleMaterial == input.DeliverySingleMaterial ||
                    (this.DeliverySingleMaterial != null &&
                    this.DeliverySingleMaterial.Equals(input.DeliverySingleMaterial))
                ) && 
                (
                    this.MaterialIdList == input.MaterialIdList ||
                    this.MaterialIdList != null &&
                    input.MaterialIdList != null &&
                    this.MaterialIdList.SequenceEqual(input.MaterialIdList)
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
                if (this.DeliverySingleMaterial != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverySingleMaterial.GetHashCode();
                }
                if (this.MaterialIdList != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialIdList.GetHashCode();
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
