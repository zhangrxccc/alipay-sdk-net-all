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
    /// AlipayEbppInvoiceEinvpackageQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEinvpackageQueryResponseModel")]
    public partial class AlipayEbppInvoiceEinvpackageQueryResponseModel : IEquatable<AlipayEbppInvoiceEinvpackageQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEinvpackageQueryResponseModel" /> class.
        /// </summary>
        /// <param name="packageItemInfoList">发票包明细数据.</param>
        public AlipayEbppInvoiceEinvpackageQueryResponseModel(List<PackageItemOpenInfo> packageItemInfoList = default(List<PackageItemOpenInfo>))
        {
            this.PackageItemInfoList = packageItemInfoList;
        }

        /// <summary>
        /// 发票包明细数据
        /// </summary>
        /// <value>发票包明细数据</value>
        [DataMember(Name = "package_item_info_list", EmitDefaultValue = false)]
        public List<PackageItemOpenInfo> PackageItemInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEinvpackageQueryResponseModel {\n");
            sb.Append("  PackageItemInfoList: ").Append(PackageItemInfoList).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEinvpackageQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEinvpackageQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEinvpackageQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEinvpackageQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PackageItemInfoList == input.PackageItemInfoList ||
                    this.PackageItemInfoList != null &&
                    input.PackageItemInfoList != null &&
                    this.PackageItemInfoList.SequenceEqual(input.PackageItemInfoList)
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
                if (this.PackageItemInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.PackageItemInfoList.GetHashCode();
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
