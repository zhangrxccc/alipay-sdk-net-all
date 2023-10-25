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
    /// AlipayMarketingActivityBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityBatchqueryModel")]
    public partial class AlipayMarketingActivityBatchqueryModel : IEquatable<AlipayMarketingActivityBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityBatchqueryModel" /> class.
        /// </summary>
        /// <param name="activityStatus">活动状态 。 ACTIVE:活动已激活，表示活动已经生效，等到活动开始(publish_start_time)之后用户就可以参与活动。 PAUSE:活动已暂停，表示商户临时暂停该活动，该状态下用户不能参与活动。.</param>
        /// <param name="merchantAccessMode">商户接入模式。.</param>
        /// <param name="merchantId">商户PID,默认为当前接口调用商户。.</param>
        /// <param name="pageNum">分页查询页码。.</param>
        /// <param name="pageSize">分页查询单页数据条数。.</param>
        public AlipayMarketingActivityBatchqueryModel(string activityStatus = default(string), string merchantAccessMode = default(string), string merchantId = default(string), int pageNum = default(int), int pageSize = default(int))
        {
            this.ActivityStatus = activityStatus;
            this.MerchantAccessMode = merchantAccessMode;
            this.MerchantId = merchantId;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// 活动状态 。 ACTIVE:活动已激活，表示活动已经生效，等到活动开始(publish_start_time)之后用户就可以参与活动。 PAUSE:活动已暂停，表示商户临时暂停该活动，该状态下用户不能参与活动。
        /// </summary>
        /// <value>活动状态 。 ACTIVE:活动已激活，表示活动已经生效，等到活动开始(publish_start_time)之后用户就可以参与活动。 PAUSE:活动已暂停，表示商户临时暂停该活动，该状态下用户不能参与活动。</value>
        [DataMember(Name = "activity_status", EmitDefaultValue = false)]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商户接入模式。
        /// </summary>
        /// <value>商户接入模式。</value>
        [DataMember(Name = "merchant_access_mode", EmitDefaultValue = false)]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 商户PID,默认为当前接口调用商户。
        /// </summary>
        /// <value>商户PID,默认为当前接口调用商户。</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 分页查询页码。
        /// </summary>
        /// <value>分页查询页码。</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。
        /// </summary>
        /// <value>分页查询单页数据条数。</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityBatchqueryModel {\n");
            sb.Append("  ActivityStatus: ").Append(ActivityStatus).Append("\n");
            sb.Append("  MerchantAccessMode: ").Append(MerchantAccessMode).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityStatus == input.ActivityStatus ||
                    (this.ActivityStatus != null &&
                    this.ActivityStatus.Equals(input.ActivityStatus))
                ) && 
                (
                    this.MerchantAccessMode == input.MerchantAccessMode ||
                    (this.MerchantAccessMode != null &&
                    this.MerchantAccessMode.Equals(input.MerchantAccessMode))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                if (this.ActivityStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityStatus.GetHashCode();
                }
                if (this.MerchantAccessMode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccessMode.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
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
