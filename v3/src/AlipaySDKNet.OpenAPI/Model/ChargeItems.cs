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
    /// ChargeItems
    /// </summary>
    [DataContract(Name = "ChargeItems")]
    public partial class ChargeItems : IEquatable<ChargeItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeItems" /> class.
        /// </summary>
        /// <param name="itemMandatory">缴费项是否必选  如果缴费项是多选模式，此参数生效。 “Y”表示必填，“N”或空表示非必填。.</param>
        /// <param name="itemMaximum">缴费项最大可选数  如果缴费项是多选模式，此参数生效，范围是1-9，如果为空，则最大项默认为9.</param>
        /// <param name="itemName">缴费项名称.</param>
        /// <param name="itemPrice">缴费项金额.</param>
        /// <param name="itemSerialNumber">缴费项序号，如果缴费项是多选模式，此项为必填，建议从1开始的连续数字，  用户支付成功后，通过passback_params参数带回已选择的缴费项。例如:orderNo&#x3D;uoo234234&amp;isvOrderNo&#x3D;24werwe&amp;items&#x3D;1-2|2-1|3-5  1-2|2-1|3-5 表示：缴费项序列号-缴费项数|缴费项序列号-缴费项数.</param>
        public ChargeItems(string itemMandatory = default(string), int itemMaximum = default(int), string itemName = default(string), string itemPrice = default(string), int itemSerialNumber = default(int))
        {
            this.ItemMandatory = itemMandatory;
            this.ItemMaximum = itemMaximum;
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
            this.ItemSerialNumber = itemSerialNumber;
        }

        /// <summary>
        /// 缴费项是否必选  如果缴费项是多选模式，此参数生效。 “Y”表示必填，“N”或空表示非必填。
        /// </summary>
        /// <value>缴费项是否必选  如果缴费项是多选模式，此参数生效。 “Y”表示必填，“N”或空表示非必填。</value>
        [DataMember(Name = "item_mandatory", EmitDefaultValue = false)]
        public string ItemMandatory { get; set; }

        /// <summary>
        /// 缴费项最大可选数  如果缴费项是多选模式，此参数生效，范围是1-9，如果为空，则最大项默认为9
        /// </summary>
        /// <value>缴费项最大可选数  如果缴费项是多选模式，此参数生效，范围是1-9，如果为空，则最大项默认为9</value>
        [DataMember(Name = "item_maximum", EmitDefaultValue = false)]
        public int ItemMaximum { get; set; }

        /// <summary>
        /// 缴费项名称
        /// </summary>
        /// <value>缴费项名称</value>
        [DataMember(Name = "item_name", EmitDefaultValue = false)]
        public string ItemName { get; set; }

        /// <summary>
        /// 缴费项金额
        /// </summary>
        /// <value>缴费项金额</value>
        [DataMember(Name = "item_price", EmitDefaultValue = false)]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 缴费项序号，如果缴费项是多选模式，此项为必填，建议从1开始的连续数字，  用户支付成功后，通过passback_params参数带回已选择的缴费项。例如:orderNo&#x3D;uoo234234&amp;isvOrderNo&#x3D;24werwe&amp;items&#x3D;1-2|2-1|3-5  1-2|2-1|3-5 表示：缴费项序列号-缴费项数|缴费项序列号-缴费项数
        /// </summary>
        /// <value>缴费项序号，如果缴费项是多选模式，此项为必填，建议从1开始的连续数字，  用户支付成功后，通过passback_params参数带回已选择的缴费项。例如:orderNo&#x3D;uoo234234&amp;isvOrderNo&#x3D;24werwe&amp;items&#x3D;1-2|2-1|3-5  1-2|2-1|3-5 表示：缴费项序列号-缴费项数|缴费项序列号-缴费项数</value>
        [DataMember(Name = "item_serial_number", EmitDefaultValue = false)]
        public int ItemSerialNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeItems {\n");
            sb.Append("  ItemMandatory: ").Append(ItemMandatory).Append("\n");
            sb.Append("  ItemMaximum: ").Append(ItemMaximum).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  ItemPrice: ").Append(ItemPrice).Append("\n");
            sb.Append("  ItemSerialNumber: ").Append(ItemSerialNumber).Append("\n");
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
            return this.Equals(input as ChargeItems);
        }

        /// <summary>
        /// Returns true if ChargeItems instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeItems input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemMandatory == input.ItemMandatory ||
                    (this.ItemMandatory != null &&
                    this.ItemMandatory.Equals(input.ItemMandatory))
                ) && 
                (
                    this.ItemMaximum == input.ItemMaximum ||
                    this.ItemMaximum.Equals(input.ItemMaximum)
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
                ) && 
                (
                    this.ItemPrice == input.ItemPrice ||
                    (this.ItemPrice != null &&
                    this.ItemPrice.Equals(input.ItemPrice))
                ) && 
                (
                    this.ItemSerialNumber == input.ItemSerialNumber ||
                    this.ItemSerialNumber.Equals(input.ItemSerialNumber)
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
                if (this.ItemMandatory != null)
                {
                    hashCode = (hashCode * 59) + this.ItemMandatory.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemMaximum.GetHashCode();
                if (this.ItemName != null)
                {
                    hashCode = (hashCode * 59) + this.ItemName.GetHashCode();
                }
                if (this.ItemPrice != null)
                {
                    hashCode = (hashCode * 59) + this.ItemPrice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemSerialNumber.GetHashCode();
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
