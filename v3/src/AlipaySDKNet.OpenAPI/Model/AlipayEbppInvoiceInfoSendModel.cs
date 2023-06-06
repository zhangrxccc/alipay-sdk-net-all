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
    /// AlipayEbppInvoiceInfoSendModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceInfoSendModel")]
    public partial class AlipayEbppInvoiceInfoSendModel : IEquatable<AlipayEbppInvoiceInfoSendModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInfoSendModel" /> class.
        /// </summary>
        /// <param name="invoiceInfoList">发票信息列表.</param>
        /// <param name="mShortName">开票商户品牌简称，与商户入驻时的品牌简称保持一致。.</param>
        /// <param name="subMShortName">开票商户门店简称，与商户入驻时的门店简称保持一致。.</param>
        public AlipayEbppInvoiceInfoSendModel(List<InvoiceSendOpenModel> invoiceInfoList = default(List<InvoiceSendOpenModel>), string mShortName = default(string), string subMShortName = default(string))
        {
            this.InvoiceInfoList = invoiceInfoList;
            this.MShortName = mShortName;
            this.SubMShortName = subMShortName;
        }

        /// <summary>
        /// 发票信息列表
        /// </summary>
        /// <value>发票信息列表</value>
        [DataMember(Name = "invoice_info_list", EmitDefaultValue = false)]
        public List<InvoiceSendOpenModel> InvoiceInfoList { get; set; }

        /// <summary>
        /// 开票商户品牌简称，与商户入驻时的品牌简称保持一致。
        /// </summary>
        /// <value>开票商户品牌简称，与商户入驻时的品牌简称保持一致。</value>
        [DataMember(Name = "m_short_name", EmitDefaultValue = false)]
        public string MShortName { get; set; }

        /// <summary>
        /// 开票商户门店简称，与商户入驻时的门店简称保持一致。
        /// </summary>
        /// <value>开票商户门店简称，与商户入驻时的门店简称保持一致。</value>
        [DataMember(Name = "sub_m_short_name", EmitDefaultValue = false)]
        public string SubMShortName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceInfoSendModel {\n");
            sb.Append("  InvoiceInfoList: ").Append(InvoiceInfoList).Append("\n");
            sb.Append("  MShortName: ").Append(MShortName).Append("\n");
            sb.Append("  SubMShortName: ").Append(SubMShortName).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceInfoSendModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceInfoSendModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceInfoSendModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceInfoSendModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvoiceInfoList == input.InvoiceInfoList ||
                    this.InvoiceInfoList != null &&
                    input.InvoiceInfoList != null &&
                    this.InvoiceInfoList.SequenceEqual(input.InvoiceInfoList)
                ) && 
                (
                    this.MShortName == input.MShortName ||
                    (this.MShortName != null &&
                    this.MShortName.Equals(input.MShortName))
                ) && 
                (
                    this.SubMShortName == input.SubMShortName ||
                    (this.SubMShortName != null &&
                    this.SubMShortName.Equals(input.SubMShortName))
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
                if (this.InvoiceInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceInfoList.GetHashCode();
                }
                if (this.MShortName != null)
                {
                    hashCode = (hashCode * 59) + this.MShortName.GetHashCode();
                }
                if (this.SubMShortName != null)
                {
                    hashCode = (hashCode * 59) + this.SubMShortName.GetHashCode();
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
