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
    /// IsvMerchantSalesDetailRequest
    /// </summary>
    [DataContract(Name = "IsvMerchantSalesDetailRequest")]
    public partial class IsvMerchantSalesDetailRequest : IEquatable<IsvMerchantSalesDetailRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsvMerchantSalesDetailRequest" /> class.
        /// </summary>
        /// <param name="couponsQuantity">配券数.</param>
        /// <param name="deviceDetail">设备详情.</param>
        /// <param name="merchantPid">商户pid.</param>
        /// <param name="miniAppid">小程序appid，若推广的商品不为小程序，则不传此参数.</param>
        /// <param name="operationPlace">作业地.</param>
        /// <param name="outBizNo">外部业务号，传isv系统生成的账单号，需要保证唯一.</param>
        /// <param name="promotorPid">推广服务商(S2)pid.</param>
        /// <param name="salesAmount">销售金额，这里填写的是整数，单位为分，比如1元，那么输入100.</param>
        /// <param name="salesQuantity">销售笔数.</param>
        /// <param name="subPromotorPid">推广服务商(S2)子账号pid.</param>
        /// <param name="writeOffAmount">核销金额，这里填写的是整数，单位为分，比如1元，那么输入100.</param>
        /// <param name="writeOffQuantity">核销数.</param>
        public IsvMerchantSalesDetailRequest(string couponsQuantity = default(string), string deviceDetail = default(string), string merchantPid = default(string), string miniAppid = default(string), string operationPlace = default(string), string outBizNo = default(string), string promotorPid = default(string), string salesAmount = default(string), string salesQuantity = default(string), string subPromotorPid = default(string), string writeOffAmount = default(string), string writeOffQuantity = default(string))
        {
            this.CouponsQuantity = couponsQuantity;
            this.DeviceDetail = deviceDetail;
            this.MerchantPid = merchantPid;
            this.MiniAppid = miniAppid;
            this.OperationPlace = operationPlace;
            this.OutBizNo = outBizNo;
            this.PromotorPid = promotorPid;
            this.SalesAmount = salesAmount;
            this.SalesQuantity = salesQuantity;
            this.SubPromotorPid = subPromotorPid;
            this.WriteOffAmount = writeOffAmount;
            this.WriteOffQuantity = writeOffQuantity;
        }

        /// <summary>
        /// 配券数
        /// </summary>
        /// <value>配券数</value>
        [DataMember(Name = "coupons_quantity", EmitDefaultValue = false)]
        public string CouponsQuantity { get; set; }

        /// <summary>
        /// 设备详情
        /// </summary>
        /// <value>设备详情</value>
        [DataMember(Name = "device_detail", EmitDefaultValue = false)]
        public string DeviceDetail { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        /// <value>商户pid</value>
        [DataMember(Name = "merchant_pid", EmitDefaultValue = false)]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 小程序appid，若推广的商品不为小程序，则不传此参数
        /// </summary>
        /// <value>小程序appid，若推广的商品不为小程序，则不传此参数</value>
        [DataMember(Name = "mini_appid", EmitDefaultValue = false)]
        public string MiniAppid { get; set; }

        /// <summary>
        /// 作业地
        /// </summary>
        /// <value>作业地</value>
        [DataMember(Name = "operation_place", EmitDefaultValue = false)]
        public string OperationPlace { get; set; }

        /// <summary>
        /// 外部业务号，传isv系统生成的账单号，需要保证唯一
        /// </summary>
        /// <value>外部业务号，传isv系统生成的账单号，需要保证唯一</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 推广服务商(S2)pid
        /// </summary>
        /// <value>推广服务商(S2)pid</value>
        [DataMember(Name = "promotor_pid", EmitDefaultValue = false)]
        public string PromotorPid { get; set; }

        /// <summary>
        /// 销售金额，这里填写的是整数，单位为分，比如1元，那么输入100
        /// </summary>
        /// <value>销售金额，这里填写的是整数，单位为分，比如1元，那么输入100</value>
        [DataMember(Name = "sales_amount", EmitDefaultValue = false)]
        public string SalesAmount { get; set; }

        /// <summary>
        /// 销售笔数
        /// </summary>
        /// <value>销售笔数</value>
        [DataMember(Name = "sales_quantity", EmitDefaultValue = false)]
        public string SalesQuantity { get; set; }

        /// <summary>
        /// 推广服务商(S2)子账号pid
        /// </summary>
        /// <value>推广服务商(S2)子账号pid</value>
        [DataMember(Name = "sub_promotor_pid", EmitDefaultValue = false)]
        public string SubPromotorPid { get; set; }

        /// <summary>
        /// 核销金额，这里填写的是整数，单位为分，比如1元，那么输入100
        /// </summary>
        /// <value>核销金额，这里填写的是整数，单位为分，比如1元，那么输入100</value>
        [DataMember(Name = "write_off_amount", EmitDefaultValue = false)]
        public string WriteOffAmount { get; set; }

        /// <summary>
        /// 核销数
        /// </summary>
        /// <value>核销数</value>
        [DataMember(Name = "write_off_quantity", EmitDefaultValue = false)]
        public string WriteOffQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IsvMerchantSalesDetailRequest {\n");
            sb.Append("  CouponsQuantity: ").Append(CouponsQuantity).Append("\n");
            sb.Append("  DeviceDetail: ").Append(DeviceDetail).Append("\n");
            sb.Append("  MerchantPid: ").Append(MerchantPid).Append("\n");
            sb.Append("  MiniAppid: ").Append(MiniAppid).Append("\n");
            sb.Append("  OperationPlace: ").Append(OperationPlace).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PromotorPid: ").Append(PromotorPid).Append("\n");
            sb.Append("  SalesAmount: ").Append(SalesAmount).Append("\n");
            sb.Append("  SalesQuantity: ").Append(SalesQuantity).Append("\n");
            sb.Append("  SubPromotorPid: ").Append(SubPromotorPid).Append("\n");
            sb.Append("  WriteOffAmount: ").Append(WriteOffAmount).Append("\n");
            sb.Append("  WriteOffQuantity: ").Append(WriteOffQuantity).Append("\n");
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
            return this.Equals(input as IsvMerchantSalesDetailRequest);
        }

        /// <summary>
        /// Returns true if IsvMerchantSalesDetailRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of IsvMerchantSalesDetailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsvMerchantSalesDetailRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CouponsQuantity == input.CouponsQuantity ||
                    (this.CouponsQuantity != null &&
                    this.CouponsQuantity.Equals(input.CouponsQuantity))
                ) && 
                (
                    this.DeviceDetail == input.DeviceDetail ||
                    (this.DeviceDetail != null &&
                    this.DeviceDetail.Equals(input.DeviceDetail))
                ) && 
                (
                    this.MerchantPid == input.MerchantPid ||
                    (this.MerchantPid != null &&
                    this.MerchantPid.Equals(input.MerchantPid))
                ) && 
                (
                    this.MiniAppid == input.MiniAppid ||
                    (this.MiniAppid != null &&
                    this.MiniAppid.Equals(input.MiniAppid))
                ) && 
                (
                    this.OperationPlace == input.OperationPlace ||
                    (this.OperationPlace != null &&
                    this.OperationPlace.Equals(input.OperationPlace))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PromotorPid == input.PromotorPid ||
                    (this.PromotorPid != null &&
                    this.PromotorPid.Equals(input.PromotorPid))
                ) && 
                (
                    this.SalesAmount == input.SalesAmount ||
                    (this.SalesAmount != null &&
                    this.SalesAmount.Equals(input.SalesAmount))
                ) && 
                (
                    this.SalesQuantity == input.SalesQuantity ||
                    (this.SalesQuantity != null &&
                    this.SalesQuantity.Equals(input.SalesQuantity))
                ) && 
                (
                    this.SubPromotorPid == input.SubPromotorPid ||
                    (this.SubPromotorPid != null &&
                    this.SubPromotorPid.Equals(input.SubPromotorPid))
                ) && 
                (
                    this.WriteOffAmount == input.WriteOffAmount ||
                    (this.WriteOffAmount != null &&
                    this.WriteOffAmount.Equals(input.WriteOffAmount))
                ) && 
                (
                    this.WriteOffQuantity == input.WriteOffQuantity ||
                    (this.WriteOffQuantity != null &&
                    this.WriteOffQuantity.Equals(input.WriteOffQuantity))
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
                if (this.CouponsQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.CouponsQuantity.GetHashCode();
                }
                if (this.DeviceDetail != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceDetail.GetHashCode();
                }
                if (this.MerchantPid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantPid.GetHashCode();
                }
                if (this.MiniAppid != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppid.GetHashCode();
                }
                if (this.OperationPlace != null)
                {
                    hashCode = (hashCode * 59) + this.OperationPlace.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PromotorPid != null)
                {
                    hashCode = (hashCode * 59) + this.PromotorPid.GetHashCode();
                }
                if (this.SalesAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SalesAmount.GetHashCode();
                }
                if (this.SalesQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.SalesQuantity.GetHashCode();
                }
                if (this.SubPromotorPid != null)
                {
                    hashCode = (hashCode * 59) + this.SubPromotorPid.GetHashCode();
                }
                if (this.WriteOffAmount != null)
                {
                    hashCode = (hashCode * 59) + this.WriteOffAmount.GetHashCode();
                }
                if (this.WriteOffQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.WriteOffQuantity.GetHashCode();
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
