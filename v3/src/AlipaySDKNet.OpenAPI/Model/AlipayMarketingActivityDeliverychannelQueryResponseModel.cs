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
    /// AlipayMarketingActivityDeliverychannelQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityDeliverychannelQueryResponseModel")]
    public partial class AlipayMarketingActivityDeliverychannelQueryResponseModel : IEquatable<AlipayMarketingActivityDeliverychannelQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliverychannelQueryResponseModel" /> class.
        /// </summary>
        /// <param name="deliveryChannelInfoList">\&quot;可投放的渠道信息列表。 用于表达当前可以投放的渠道列表信息\&quot;.</param>
        /// <param name="pageNum">查询的页码。 特别说明： 页码从1开始。.</param>
        /// <param name="pageSize">每页查询个数.</param>
        /// <param name="totalSize">可返回的渠道总数.</param>
        public AlipayMarketingActivityDeliverychannelQueryResponseModel(List<DeliveryChannelInfo> deliveryChannelInfoList = default(List<DeliveryChannelInfo>), string pageNum = default(string), string pageSize = default(string), string totalSize = default(string))
        {
            this.DeliveryChannelInfoList = deliveryChannelInfoList;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// \&quot;可投放的渠道信息列表。 用于表达当前可以投放的渠道列表信息\&quot;
        /// </summary>
        /// <value>\&quot;可投放的渠道信息列表。 用于表达当前可以投放的渠道列表信息\&quot;</value>
        [DataMember(Name = "delivery_channel_info_list", EmitDefaultValue = false)]
        public List<DeliveryChannelInfo> DeliveryChannelInfoList { get; set; }

        /// <summary>
        /// 查询的页码。 特别说明： 页码从1开始。
        /// </summary>
        /// <value>查询的页码。 特别说明： 页码从1开始。</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页查询个数
        /// </summary>
        /// <value>每页查询个数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 可返回的渠道总数
        /// </summary>
        /// <value>可返回的渠道总数</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public string TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityDeliverychannelQueryResponseModel {\n");
            sb.Append("  DeliveryChannelInfoList: ").Append(DeliveryChannelInfoList).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityDeliverychannelQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityDeliverychannelQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityDeliverychannelQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityDeliverychannelQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryChannelInfoList == input.DeliveryChannelInfoList ||
                    this.DeliveryChannelInfoList != null &&
                    input.DeliveryChannelInfoList != null &&
                    this.DeliveryChannelInfoList.SequenceEqual(input.DeliveryChannelInfoList)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    (this.PageNum != null &&
                    this.PageNum.Equals(input.PageNum))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    (this.TotalSize != null &&
                    this.TotalSize.Equals(input.TotalSize))
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
                if (this.DeliveryChannelInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryChannelInfoList.GetHashCode();
                }
                if (this.PageNum != null)
                {
                    hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                if (this.TotalSize != null)
                {
                    hashCode = (hashCode * 59) + this.TotalSize.GetHashCode();
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
