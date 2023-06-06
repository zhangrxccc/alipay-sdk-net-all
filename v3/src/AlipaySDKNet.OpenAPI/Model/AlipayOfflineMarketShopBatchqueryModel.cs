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
    /// AlipayOfflineMarketShopBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayOfflineMarketShopBatchqueryModel")]
    public partial class AlipayOfflineMarketShopBatchqueryModel : IEquatable<AlipayOfflineMarketShopBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOfflineMarketShopBatchqueryModel" /> class.
        /// </summary>
        /// <param name="bizChannel">表示接口查询门店的业务渠道限制：ALL、 POS、不传。不传代表只查询普通门店，传入POS代表只查询简易门店，传入ALL代表查询普通门店和简易门店。.</param>
        /// <param name="pageNo">页码，第一页传入\&quot;1\&quot;，默认500个结果为一页。此参数必须是大于0的正整数，为0时将查询报错。.</param>
        public AlipayOfflineMarketShopBatchqueryModel(string bizChannel = default(string), string pageNo = default(string))
        {
            this.BizChannel = bizChannel;
            this.PageNo = pageNo;
        }

        /// <summary>
        /// 表示接口查询门店的业务渠道限制：ALL、 POS、不传。不传代表只查询普通门店，传入POS代表只查询简易门店，传入ALL代表查询普通门店和简易门店。
        /// </summary>
        /// <value>表示接口查询门店的业务渠道限制：ALL、 POS、不传。不传代表只查询普通门店，传入POS代表只查询简易门店，传入ALL代表查询普通门店和简易门店。</value>
        [DataMember(Name = "biz_channel", EmitDefaultValue = false)]
        public string BizChannel { get; set; }

        /// <summary>
        /// 页码，第一页传入\&quot;1\&quot;，默认500个结果为一页。此参数必须是大于0的正整数，为0时将查询报错。
        /// </summary>
        /// <value>页码，第一页传入\&quot;1\&quot;，默认500个结果为一页。此参数必须是大于0的正整数，为0时将查询报错。</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public string PageNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOfflineMarketShopBatchqueryModel {\n");
            sb.Append("  BizChannel: ").Append(BizChannel).Append("\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
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
            return this.Equals(input as AlipayOfflineMarketShopBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayOfflineMarketShopBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOfflineMarketShopBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOfflineMarketShopBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizChannel == input.BizChannel ||
                    (this.BizChannel != null &&
                    this.BizChannel.Equals(input.BizChannel))
                ) && 
                (
                    this.PageNo == input.PageNo ||
                    (this.PageNo != null &&
                    this.PageNo.Equals(input.PageNo))
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
                if (this.BizChannel != null)
                {
                    hashCode = (hashCode * 59) + this.BizChannel.GetHashCode();
                }
                if (this.PageNo != null)
                {
                    hashCode = (hashCode * 59) + this.PageNo.GetHashCode();
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
