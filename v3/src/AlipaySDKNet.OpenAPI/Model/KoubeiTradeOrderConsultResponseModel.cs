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
    /// KoubeiTradeOrderConsultResponseModel
    /// </summary>
    [DataContract(Name = "KoubeiTradeOrderConsultResponseModel")]
    public partial class KoubeiTradeOrderConsultResponseModel : IEquatable<KoubeiTradeOrderConsultResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KoubeiTradeOrderConsultResponseModel" /> class.
        /// </summary>
        /// <param name="buyerPayAmount">用户实付金额.</param>
        /// <param name="discountDetail">优惠信息.</param>
        /// <param name="mCardDetail">mCardDetail.</param>
        /// <param name="requestId">请求中的request_id.</param>
        public KoubeiTradeOrderConsultResponseModel(string buyerPayAmount = default(string), List<DiscountDetail> discountDetail = default(List<DiscountDetail>), MCardDetail mCardDetail = default(MCardDetail), string requestId = default(string))
        {
            this.BuyerPayAmount = buyerPayAmount;
            this.DiscountDetail = discountDetail;
            this.MCardDetail = mCardDetail;
            this.RequestId = requestId;
        }

        /// <summary>
        /// 用户实付金额
        /// </summary>
        /// <value>用户实付金额</value>
        [DataMember(Name = "buyer_pay_amount", EmitDefaultValue = false)]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        /// <value>优惠信息</value>
        [DataMember(Name = "discount_detail", EmitDefaultValue = false)]
        public List<DiscountDetail> DiscountDetail { get; set; }

        /// <summary>
        /// Gets or Sets MCardDetail
        /// </summary>
        [DataMember(Name = "m_card_detail", EmitDefaultValue = false)]
        public MCardDetail MCardDetail { get; set; }

        /// <summary>
        /// 请求中的request_id
        /// </summary>
        /// <value>请求中的request_id</value>
        [DataMember(Name = "request_id", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KoubeiTradeOrderConsultResponseModel {\n");
            sb.Append("  BuyerPayAmount: ").Append(BuyerPayAmount).Append("\n");
            sb.Append("  DiscountDetail: ").Append(DiscountDetail).Append("\n");
            sb.Append("  MCardDetail: ").Append(MCardDetail).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as KoubeiTradeOrderConsultResponseModel);
        }

        /// <summary>
        /// Returns true if KoubeiTradeOrderConsultResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of KoubeiTradeOrderConsultResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KoubeiTradeOrderConsultResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuyerPayAmount == input.BuyerPayAmount ||
                    (this.BuyerPayAmount != null &&
                    this.BuyerPayAmount.Equals(input.BuyerPayAmount))
                ) && 
                (
                    this.DiscountDetail == input.DiscountDetail ||
                    this.DiscountDetail != null &&
                    input.DiscountDetail != null &&
                    this.DiscountDetail.SequenceEqual(input.DiscountDetail)
                ) && 
                (
                    this.MCardDetail == input.MCardDetail ||
                    (this.MCardDetail != null &&
                    this.MCardDetail.Equals(input.MCardDetail))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.BuyerPayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerPayAmount.GetHashCode();
                }
                if (this.DiscountDetail != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountDetail.GetHashCode();
                }
                if (this.MCardDetail != null)
                {
                    hashCode = (hashCode * 59) + this.MCardDetail.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
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
