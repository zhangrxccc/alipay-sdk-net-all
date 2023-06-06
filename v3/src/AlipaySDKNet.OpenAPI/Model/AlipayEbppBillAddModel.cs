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
    /// AlipayEbppBillAddModel
    /// </summary>
    [DataContract(Name = "AlipayEbppBillAddModel")]
    public partial class AlipayEbppBillAddModel : IEquatable<AlipayEbppBillAddModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppBillAddModel" /> class.
        /// </summary>
        /// <param name="bankBillNo">外部订单号.</param>
        /// <param name="billDate">账单的账期，格式为 yyyyMMdd。例如：202012表示2020年12月的账单。.</param>
        /// <param name="billKey">账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。.</param>
        /// <param name="chargeInst">支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。.</param>
        /// <param name="extendField">扩展属性.</param>
        /// <param name="merchantOrderNo">输出机构的业务流水号，需要保证唯一性.</param>
        /// <param name="mobile">用户的手机号.</param>
        /// <param name="orderType">支付宝订单类型。枚举支持： *JF：公共事业缴纳。 *WUYE：物业缴费。 *HK：信用卡还款。 *TX：通讯缴费。.</param>
        /// <param name="ownerName">拥有该账单的用户姓名.</param>
        /// <param name="payAmount">缴费金额。用户支付的总金额。单位为 元（人民币）。取值范围为[0.01，100000000.00]，精确到小数点后两位。.</param>
        /// <param name="serviceAmount">账单的服务费。.</param>
        /// <param name="subOrderType">子业务类型是业务类型的下一级概念。枚举支持： *WATER：缴水费。 *ELECTRIC：缴电费。 *GAS：缴燃气费。 *COMMUN：缴固话宽带费。 *CATV：缴有线电视费。 *WUYE：缴物业费。 *RC：定期还车贷代扣。 *RH：定期还房贷代扣。 *RR：定期还房租代扣。 *RN：定期还网贷代扣。 *CZ：手机充值代扣。 例如：WATER表示JF下面的水费。.</param>
        /// <param name="trafficLocation">交通违章地点，sub_order_type&#x3D;TRAFFIC时填写。.</param>
        /// <param name="trafficRegulations">违章行为，sub_order_type&#x3D;TRAFFIC时填写。.</param>
        public AlipayEbppBillAddModel(string bankBillNo = default(string), string billDate = default(string), string billKey = default(string), string chargeInst = default(string), string extendField = default(string), string merchantOrderNo = default(string), string mobile = default(string), string orderType = default(string), string ownerName = default(string), string payAmount = default(string), string serviceAmount = default(string), string subOrderType = default(string), string trafficLocation = default(string), string trafficRegulations = default(string))
        {
            this.BankBillNo = bankBillNo;
            this.BillDate = billDate;
            this.BillKey = billKey;
            this.ChargeInst = chargeInst;
            this.ExtendField = extendField;
            this.MerchantOrderNo = merchantOrderNo;
            this.Mobile = mobile;
            this.OrderType = orderType;
            this.OwnerName = ownerName;
            this.PayAmount = payAmount;
            this.ServiceAmount = serviceAmount;
            this.SubOrderType = subOrderType;
            this.TrafficLocation = trafficLocation;
            this.TrafficRegulations = trafficRegulations;
        }

        /// <summary>
        /// 外部订单号
        /// </summary>
        /// <value>外部订单号</value>
        [DataMember(Name = "bank_bill_no", EmitDefaultValue = false)]
        public string BankBillNo { get; set; }

        /// <summary>
        /// 账单的账期，格式为 yyyyMMdd。例如：202012表示2020年12月的账单。
        /// </summary>
        /// <value>账单的账期，格式为 yyyyMMdd。例如：202012表示2020年12月的账单。</value>
        [DataMember(Name = "bill_date", EmitDefaultValue = false)]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。
        /// </summary>
        /// <value>账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。</value>
        [DataMember(Name = "bill_key", EmitDefaultValue = false)]
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。
        /// </summary>
        /// <value>支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。</value>
        [DataMember(Name = "charge_inst", EmitDefaultValue = false)]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        /// <value>扩展属性</value>
        [DataMember(Name = "extend_field", EmitDefaultValue = false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性
        /// </summary>
        /// <value>输出机构的业务流水号，需要保证唯一性</value>
        [DataMember(Name = "merchant_order_no", EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 用户的手机号
        /// </summary>
        /// <value>用户的手机号</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝订单类型。枚举支持： *JF：公共事业缴纳。 *WUYE：物业缴费。 *HK：信用卡还款。 *TX：通讯缴费。
        /// </summary>
        /// <value>支付宝订单类型。枚举支持： *JF：公共事业缴纳。 *WUYE：物业缴费。 *HK：信用卡还款。 *TX：通讯缴费。</value>
        [DataMember(Name = "order_type", EmitDefaultValue = false)]
        public string OrderType { get; set; }

        /// <summary>
        /// 拥有该账单的用户姓名
        /// </summary>
        /// <value>拥有该账单的用户姓名</value>
        [DataMember(Name = "owner_name", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 缴费金额。用户支付的总金额。单位为 元（人民币）。取值范围为[0.01，100000000.00]，精确到小数点后两位。
        /// </summary>
        /// <value>缴费金额。用户支付的总金额。单位为 元（人民币）。取值范围为[0.01，100000000.00]，精确到小数点后两位。</value>
        [DataMember(Name = "pay_amount", EmitDefaultValue = false)]
        public string PayAmount { get; set; }

        /// <summary>
        /// 账单的服务费。
        /// </summary>
        /// <value>账单的服务费。</value>
        [DataMember(Name = "service_amount", EmitDefaultValue = false)]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 子业务类型是业务类型的下一级概念。枚举支持： *WATER：缴水费。 *ELECTRIC：缴电费。 *GAS：缴燃气费。 *COMMUN：缴固话宽带费。 *CATV：缴有线电视费。 *WUYE：缴物业费。 *RC：定期还车贷代扣。 *RH：定期还房贷代扣。 *RR：定期还房租代扣。 *RN：定期还网贷代扣。 *CZ：手机充值代扣。 例如：WATER表示JF下面的水费。
        /// </summary>
        /// <value>子业务类型是业务类型的下一级概念。枚举支持： *WATER：缴水费。 *ELECTRIC：缴电费。 *GAS：缴燃气费。 *COMMUN：缴固话宽带费。 *CATV：缴有线电视费。 *WUYE：缴物业费。 *RC：定期还车贷代扣。 *RH：定期还房贷代扣。 *RR：定期还房租代扣。 *RN：定期还网贷代扣。 *CZ：手机充值代扣。 例如：WATER表示JF下面的水费。</value>
        [DataMember(Name = "sub_order_type", EmitDefaultValue = false)]
        public string SubOrderType { get; set; }

        /// <summary>
        /// 交通违章地点，sub_order_type&#x3D;TRAFFIC时填写。
        /// </summary>
        /// <value>交通违章地点，sub_order_type&#x3D;TRAFFIC时填写。</value>
        [DataMember(Name = "traffic_location", EmitDefaultValue = false)]
        public string TrafficLocation { get; set; }

        /// <summary>
        /// 违章行为，sub_order_type&#x3D;TRAFFIC时填写。
        /// </summary>
        /// <value>违章行为，sub_order_type&#x3D;TRAFFIC时填写。</value>
        [DataMember(Name = "traffic_regulations", EmitDefaultValue = false)]
        public string TrafficRegulations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppBillAddModel {\n");
            sb.Append("  BankBillNo: ").Append(BankBillNo).Append("\n");
            sb.Append("  BillDate: ").Append(BillDate).Append("\n");
            sb.Append("  BillKey: ").Append(BillKey).Append("\n");
            sb.Append("  ChargeInst: ").Append(ChargeInst).Append("\n");
            sb.Append("  ExtendField: ").Append(ExtendField).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
            sb.Append("  ServiceAmount: ").Append(ServiceAmount).Append("\n");
            sb.Append("  SubOrderType: ").Append(SubOrderType).Append("\n");
            sb.Append("  TrafficLocation: ").Append(TrafficLocation).Append("\n");
            sb.Append("  TrafficRegulations: ").Append(TrafficRegulations).Append("\n");
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
            return this.Equals(input as AlipayEbppBillAddModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppBillAddModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppBillAddModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppBillAddModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankBillNo == input.BankBillNo ||
                    (this.BankBillNo != null &&
                    this.BankBillNo.Equals(input.BankBillNo))
                ) && 
                (
                    this.BillDate == input.BillDate ||
                    (this.BillDate != null &&
                    this.BillDate.Equals(input.BillDate))
                ) && 
                (
                    this.BillKey == input.BillKey ||
                    (this.BillKey != null &&
                    this.BillKey.Equals(input.BillKey))
                ) && 
                (
                    this.ChargeInst == input.ChargeInst ||
                    (this.ChargeInst != null &&
                    this.ChargeInst.Equals(input.ChargeInst))
                ) && 
                (
                    this.ExtendField == input.ExtendField ||
                    (this.ExtendField != null &&
                    this.ExtendField.Equals(input.ExtendField))
                ) && 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
                ) && 
                (
                    this.ServiceAmount == input.ServiceAmount ||
                    (this.ServiceAmount != null &&
                    this.ServiceAmount.Equals(input.ServiceAmount))
                ) && 
                (
                    this.SubOrderType == input.SubOrderType ||
                    (this.SubOrderType != null &&
                    this.SubOrderType.Equals(input.SubOrderType))
                ) && 
                (
                    this.TrafficLocation == input.TrafficLocation ||
                    (this.TrafficLocation != null &&
                    this.TrafficLocation.Equals(input.TrafficLocation))
                ) && 
                (
                    this.TrafficRegulations == input.TrafficRegulations ||
                    (this.TrafficRegulations != null &&
                    this.TrafficRegulations.Equals(input.TrafficRegulations))
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
                if (this.BankBillNo != null)
                {
                    hashCode = (hashCode * 59) + this.BankBillNo.GetHashCode();
                }
                if (this.BillDate != null)
                {
                    hashCode = (hashCode * 59) + this.BillDate.GetHashCode();
                }
                if (this.BillKey != null)
                {
                    hashCode = (hashCode * 59) + this.BillKey.GetHashCode();
                }
                if (this.ChargeInst != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeInst.GetHashCode();
                }
                if (this.ExtendField != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendField.GetHashCode();
                }
                if (this.MerchantOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantOrderNo.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.OrderType != null)
                {
                    hashCode = (hashCode * 59) + this.OrderType.GetHashCode();
                }
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.PayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PayAmount.GetHashCode();
                }
                if (this.ServiceAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAmount.GetHashCode();
                }
                if (this.SubOrderType != null)
                {
                    hashCode = (hashCode * 59) + this.SubOrderType.GetHashCode();
                }
                if (this.TrafficLocation != null)
                {
                    hashCode = (hashCode * 59) + this.TrafficLocation.GetHashCode();
                }
                if (this.TrafficRegulations != null)
                {
                    hashCode = (hashCode * 59) + this.TrafficRegulations.GetHashCode();
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
