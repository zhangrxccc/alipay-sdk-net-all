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
    /// ArRelInvoiceOpenApiResponse
    /// </summary>
    [DataContract(Name = "ArRelInvoiceOpenApiResponse")]
    public partial class ArRelInvoiceOpenApiResponse : IEquatable<ArRelInvoiceOpenApiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArRelInvoiceOpenApiResponse" /> class.
        /// </summary>
        /// <param name="arInvoiceLines">arInvoiceLines.</param>
        /// <param name="buyerAddress">购方的地址.</param>
        /// <param name="buyerBankAccount">购方银行账号.</param>
        /// <param name="buyerBankName">购方开户行名称.</param>
        /// <param name="buyerInvoiceTitle">购方发票抬头，用于打印在发票上.</param>
        /// <param name="buyerTaxNo">购方税号.</param>
        /// <param name="buyerTelephone">购方的电话号码.</param>
        /// <param name="canLink">是否可以关联账单.</param>
        /// <param name="creator">创建人.</param>
        /// <param name="drawer">开票人.</param>
        /// <param name="elcInvoiceUrl">电子发票在oss上的存储地址.</param>
        /// <param name="gmtCreate">创建时间.</param>
        /// <param name="gmtModified">修改时间.</param>
        /// <param name="instId">对应发票所在OU的id，用于标示该发票所述的OU。.</param>
        /// <param name="invoiceAmt">invoiceAmt.</param>
        /// <param name="invoiceChannel">开票渠道，01：在线，02：线下.</param>
        /// <param name="invoiceCode">发票编码.</param>
        /// <param name="invoiceDate">发票的开票日期，yyyyMMdd.</param>
        /// <param name="invoiceId">发票ID，唯一标示一张发票.</param>
        /// <param name="invoiceMaterial">发票介质，01：电子，02：纸质.</param>
        /// <param name="invoiceNo">发票号码.</param>
        /// <param name="invoiceNote">发票备注.</param>
        /// <param name="invoiceStatus">发票状态：用于标示发票当前的状态，状态类型以及相关含义 01：待开票，02：开票中，03：已开票，04：作废中，05：已作废，06：红冲中，07：已红冲，08：部分红冲，09：无效.</param>
        /// <param name="invoiceType">发票类型：01：专票，02：普票，03：营业税发票，04：国际形式发票，05：其它发票.</param>
        /// <param name="ipId">对应发票商户的ipId，在主站标示mid，在其他环境标示ip_id。.</param>
        /// <param name="ipRoleId">商户结算的ipRoleId，表示商户的结算对象，在主站表示pid。.</param>
        /// <param name="lastModer">最近修改人.</param>
        /// <param name="linkedAmt">linkedAmt.</param>
        /// <param name="mailStatus">发票开出后的邮寄状态，具体状态说明 01：待邮寄，02：已邮寄，03：退回中，04：已退回.</param>
        /// <param name="memo">备注.</param>
        /// <param name="noBillInvoiceFlag">是否是无账单发票 Y：是 N：不是.</param>
        /// <param name="online">是否为线上发票 true：是， false：不是.</param>
        /// <param name="payee">收款人.</param>
        /// <param name="recentMailId">邮件信息的主键，用于‘根据发票邮寄ID获取当前的邮寄信息’的查询输入。.</param>
        /// <param name="red">是否红字 Y：红字， N：蓝字.</param>
        /// <param name="redAmt">redAmt.</param>
        /// <param name="reviewer">复核人.</param>
        /// <param name="sellerAddress">销方公司地址.</param>
        /// <param name="sellerBankAccount">销方银行账号.</param>
        /// <param name="sellerBankName">销方开户行名称.</param>
        /// <param name="sellerCompanyName">销方公司名称.</param>
        /// <param name="sellerTaxNo">销方税号，用于打印在发票上.</param>
        /// <param name="sellerTelephone">销方公司电话.</param>
        /// <param name="tntInstId">租户id.</param>
        public ArRelInvoiceOpenApiResponse(ArInvoiceLineOpenApiResponse arInvoiceLines = default(ArInvoiceLineOpenApiResponse), string buyerAddress = default(string), string buyerBankAccount = default(string), string buyerBankName = default(string), string buyerInvoiceTitle = default(string), string buyerTaxNo = default(string), string buyerTelephone = default(string), bool canLink = default(bool), string creator = default(string), string drawer = default(string), string elcInvoiceUrl = default(string), string gmtCreate = default(string), string gmtModified = default(string), string instId = default(string), MultiCurrencyMoneyOpenApi invoiceAmt = default(MultiCurrencyMoneyOpenApi), string invoiceChannel = default(string), string invoiceCode = default(string), string invoiceDate = default(string), string invoiceId = default(string), string invoiceMaterial = default(string), string invoiceNo = default(string), string invoiceNote = default(string), string invoiceStatus = default(string), string invoiceType = default(string), string ipId = default(string), string ipRoleId = default(string), string lastModer = default(string), MultiCurrencyMoneyOpenApi linkedAmt = default(MultiCurrencyMoneyOpenApi), string mailStatus = default(string), string memo = default(string), string noBillInvoiceFlag = default(string), bool online = default(bool), string payee = default(string), string recentMailId = default(string), string red = default(string), MultiCurrencyMoneyOpenApi redAmt = default(MultiCurrencyMoneyOpenApi), string reviewer = default(string), string sellerAddress = default(string), string sellerBankAccount = default(string), string sellerBankName = default(string), string sellerCompanyName = default(string), string sellerTaxNo = default(string), string sellerTelephone = default(string), string tntInstId = default(string))
        {
            this.ArInvoiceLines = arInvoiceLines;
            this.BuyerAddress = buyerAddress;
            this.BuyerBankAccount = buyerBankAccount;
            this.BuyerBankName = buyerBankName;
            this.BuyerInvoiceTitle = buyerInvoiceTitle;
            this.BuyerTaxNo = buyerTaxNo;
            this.BuyerTelephone = buyerTelephone;
            this.CanLink = canLink;
            this.Creator = creator;
            this.Drawer = drawer;
            this.ElcInvoiceUrl = elcInvoiceUrl;
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.InstId = instId;
            this.InvoiceAmt = invoiceAmt;
            this.InvoiceChannel = invoiceChannel;
            this.InvoiceCode = invoiceCode;
            this.InvoiceDate = invoiceDate;
            this.InvoiceId = invoiceId;
            this.InvoiceMaterial = invoiceMaterial;
            this.InvoiceNo = invoiceNo;
            this.InvoiceNote = invoiceNote;
            this.InvoiceStatus = invoiceStatus;
            this.InvoiceType = invoiceType;
            this.IpId = ipId;
            this.IpRoleId = ipRoleId;
            this.LastModer = lastModer;
            this.LinkedAmt = linkedAmt;
            this.MailStatus = mailStatus;
            this.Memo = memo;
            this.NoBillInvoiceFlag = noBillInvoiceFlag;
            this.Online = online;
            this.Payee = payee;
            this.RecentMailId = recentMailId;
            this.Red = red;
            this.RedAmt = redAmt;
            this.Reviewer = reviewer;
            this.SellerAddress = sellerAddress;
            this.SellerBankAccount = sellerBankAccount;
            this.SellerBankName = sellerBankName;
            this.SellerCompanyName = sellerCompanyName;
            this.SellerTaxNo = sellerTaxNo;
            this.SellerTelephone = sellerTelephone;
            this.TntInstId = tntInstId;
        }

        /// <summary>
        /// Gets or Sets ArInvoiceLines
        /// </summary>
        [DataMember(Name = "ar_invoice_lines", EmitDefaultValue = false)]
        public ArInvoiceLineOpenApiResponse ArInvoiceLines { get; set; }

        /// <summary>
        /// 购方的地址
        /// </summary>
        /// <value>购方的地址</value>
        [DataMember(Name = "buyer_address", EmitDefaultValue = false)]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        /// <value>购方银行账号</value>
        [DataMember(Name = "buyer_bank_account", EmitDefaultValue = false)]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购方开户行名称
        /// </summary>
        /// <value>购方开户行名称</value>
        [DataMember(Name = "buyer_bank_name", EmitDefaultValue = false)]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 购方发票抬头，用于打印在发票上
        /// </summary>
        /// <value>购方发票抬头，用于打印在发票上</value>
        [DataMember(Name = "buyer_invoice_title", EmitDefaultValue = false)]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        /// <value>购方税号</value>
        [DataMember(Name = "buyer_tax_no", EmitDefaultValue = false)]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购方的电话号码
        /// </summary>
        /// <value>购方的电话号码</value>
        [DataMember(Name = "buyer_telephone", EmitDefaultValue = false)]
        public string BuyerTelephone { get; set; }

        /// <summary>
        /// 是否可以关联账单
        /// </summary>
        /// <value>是否可以关联账单</value>
        [DataMember(Name = "can_link", EmitDefaultValue = true)]
        public bool CanLink { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        /// <value>创建人</value>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        public string Creator { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        /// <value>开票人</value>
        [DataMember(Name = "drawer", EmitDefaultValue = false)]
        public string Drawer { get; set; }

        /// <summary>
        /// 电子发票在oss上的存储地址
        /// </summary>
        /// <value>电子发票在oss上的存储地址</value>
        [DataMember(Name = "elc_invoice_url", EmitDefaultValue = false)]
        public string ElcInvoiceUrl { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value>修改时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 对应发票所在OU的id，用于标示该发票所述的OU。
        /// </summary>
        /// <value>对应发票所在OU的id，用于标示该发票所述的OU。</value>
        [DataMember(Name = "inst_id", EmitDefaultValue = false)]
        public string InstId { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceAmt
        /// </summary>
        [DataMember(Name = "invoice_amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 开票渠道，01：在线，02：线下
        /// </summary>
        /// <value>开票渠道，01：在线，02：线下</value>
        [DataMember(Name = "invoice_channel", EmitDefaultValue = false)]
        public string InvoiceChannel { get; set; }

        /// <summary>
        /// 发票编码
        /// </summary>
        /// <value>发票编码</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票的开票日期，yyyyMMdd
        /// </summary>
        /// <value>发票的开票日期，yyyyMMdd</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票ID，唯一标示一张发票
        /// </summary>
        /// <value>发票ID，唯一标示一张发票</value>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票介质，01：电子，02：纸质
        /// </summary>
        /// <value>发票介质，01：电子，02：纸质</value>
        [DataMember(Name = "invoice_material", EmitDefaultValue = false)]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        /// <value>发票号码</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票备注
        /// </summary>
        /// <value>发票备注</value>
        [DataMember(Name = "invoice_note", EmitDefaultValue = false)]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 发票状态：用于标示发票当前的状态，状态类型以及相关含义 01：待开票，02：开票中，03：已开票，04：作废中，05：已作废，06：红冲中，07：已红冲，08：部分红冲，09：无效
        /// </summary>
        /// <value>发票状态：用于标示发票当前的状态，状态类型以及相关含义 01：待开票，02：开票中，03：已开票，04：作废中，05：已作废，06：红冲中，07：已红冲，08：部分红冲，09：无效</value>
        [DataMember(Name = "invoice_status", EmitDefaultValue = false)]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票类型：01：专票，02：普票，03：营业税发票，04：国际形式发票，05：其它发票
        /// </summary>
        /// <value>发票类型：01：专票，02：普票，03：营业税发票，04：国际形式发票，05：其它发票</value>
        [DataMember(Name = "invoice_type", EmitDefaultValue = false)]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 对应发票商户的ipId，在主站标示mid，在其他环境标示ip_id。
        /// </summary>
        /// <value>对应发票商户的ipId，在主站标示mid，在其他环境标示ip_id。</value>
        [DataMember(Name = "ip_id", EmitDefaultValue = false)]
        public string IpId { get; set; }

        /// <summary>
        /// 商户结算的ipRoleId，表示商户的结算对象，在主站表示pid。
        /// </summary>
        /// <value>商户结算的ipRoleId，表示商户的结算对象，在主站表示pid。</value>
        [DataMember(Name = "ip_role_id", EmitDefaultValue = false)]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 最近修改人
        /// </summary>
        /// <value>最近修改人</value>
        [DataMember(Name = "last_moder", EmitDefaultValue = false)]
        public string LastModer { get; set; }

        /// <summary>
        /// Gets or Sets LinkedAmt
        /// </summary>
        [DataMember(Name = "linked_amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi LinkedAmt { get; set; }

        /// <summary>
        /// 发票开出后的邮寄状态，具体状态说明 01：待邮寄，02：已邮寄，03：退回中，04：已退回
        /// </summary>
        /// <value>发票开出后的邮寄状态，具体状态说明 01：待邮寄，02：已邮寄，03：退回中，04：已退回</value>
        [DataMember(Name = "mail_status", EmitDefaultValue = false)]
        public string MailStatus { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>备注</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 是否是无账单发票 Y：是 N：不是
        /// </summary>
        /// <value>是否是无账单发票 Y：是 N：不是</value>
        [DataMember(Name = "no_bill_invoice_flag", EmitDefaultValue = false)]
        public string NoBillInvoiceFlag { get; set; }

        /// <summary>
        /// 是否为线上发票 true：是， false：不是
        /// </summary>
        /// <value>是否为线上发票 true：是， false：不是</value>
        [DataMember(Name = "online", EmitDefaultValue = true)]
        public bool Online { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        /// <value>收款人</value>
        [DataMember(Name = "payee", EmitDefaultValue = false)]
        public string Payee { get; set; }

        /// <summary>
        /// 邮件信息的主键，用于‘根据发票邮寄ID获取当前的邮寄信息’的查询输入。
        /// </summary>
        /// <value>邮件信息的主键，用于‘根据发票邮寄ID获取当前的邮寄信息’的查询输入。</value>
        [DataMember(Name = "recent_mail_id", EmitDefaultValue = false)]
        public string RecentMailId { get; set; }

        /// <summary>
        /// 是否红字 Y：红字， N：蓝字
        /// </summary>
        /// <value>是否红字 Y：红字， N：蓝字</value>
        [DataMember(Name = "red", EmitDefaultValue = false)]
        public string Red { get; set; }

        /// <summary>
        /// Gets or Sets RedAmt
        /// </summary>
        [DataMember(Name = "red_amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi RedAmt { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        /// <value>复核人</value>
        [DataMember(Name = "reviewer", EmitDefaultValue = false)]
        public string Reviewer { get; set; }

        /// <summary>
        /// 销方公司地址
        /// </summary>
        /// <value>销方公司地址</value>
        [DataMember(Name = "seller_address", EmitDefaultValue = false)]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销方银行账号
        /// </summary>
        /// <value>销方银行账号</value>
        [DataMember(Name = "seller_bank_account", EmitDefaultValue = false)]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销方开户行名称
        /// </summary>
        /// <value>销方开户行名称</value>
        [DataMember(Name = "seller_bank_name", EmitDefaultValue = false)]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 销方公司名称
        /// </summary>
        /// <value>销方公司名称</value>
        [DataMember(Name = "seller_company_name", EmitDefaultValue = false)]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// 销方税号，用于打印在发票上
        /// </summary>
        /// <value>销方税号，用于打印在发票上</value>
        [DataMember(Name = "seller_tax_no", EmitDefaultValue = false)]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销方公司电话
        /// </summary>
        /// <value>销方公司电话</value>
        [DataMember(Name = "seller_telephone", EmitDefaultValue = false)]
        public string SellerTelephone { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        /// <value>租户id</value>
        [DataMember(Name = "tnt_inst_id", EmitDefaultValue = false)]
        public string TntInstId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArRelInvoiceOpenApiResponse {\n");
            sb.Append("  ArInvoiceLines: ").Append(ArInvoiceLines).Append("\n");
            sb.Append("  BuyerAddress: ").Append(BuyerAddress).Append("\n");
            sb.Append("  BuyerBankAccount: ").Append(BuyerBankAccount).Append("\n");
            sb.Append("  BuyerBankName: ").Append(BuyerBankName).Append("\n");
            sb.Append("  BuyerInvoiceTitle: ").Append(BuyerInvoiceTitle).Append("\n");
            sb.Append("  BuyerTaxNo: ").Append(BuyerTaxNo).Append("\n");
            sb.Append("  BuyerTelephone: ").Append(BuyerTelephone).Append("\n");
            sb.Append("  CanLink: ").Append(CanLink).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Drawer: ").Append(Drawer).Append("\n");
            sb.Append("  ElcInvoiceUrl: ").Append(ElcInvoiceUrl).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  InstId: ").Append(InstId).Append("\n");
            sb.Append("  InvoiceAmt: ").Append(InvoiceAmt).Append("\n");
            sb.Append("  InvoiceChannel: ").Append(InvoiceChannel).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  InvoiceMaterial: ").Append(InvoiceMaterial).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  InvoiceNote: ").Append(InvoiceNote).Append("\n");
            sb.Append("  InvoiceStatus: ").Append(InvoiceStatus).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  IpId: ").Append(IpId).Append("\n");
            sb.Append("  IpRoleId: ").Append(IpRoleId).Append("\n");
            sb.Append("  LastModer: ").Append(LastModer).Append("\n");
            sb.Append("  LinkedAmt: ").Append(LinkedAmt).Append("\n");
            sb.Append("  MailStatus: ").Append(MailStatus).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  NoBillInvoiceFlag: ").Append(NoBillInvoiceFlag).Append("\n");
            sb.Append("  Online: ").Append(Online).Append("\n");
            sb.Append("  Payee: ").Append(Payee).Append("\n");
            sb.Append("  RecentMailId: ").Append(RecentMailId).Append("\n");
            sb.Append("  Red: ").Append(Red).Append("\n");
            sb.Append("  RedAmt: ").Append(RedAmt).Append("\n");
            sb.Append("  Reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  SellerAddress: ").Append(SellerAddress).Append("\n");
            sb.Append("  SellerBankAccount: ").Append(SellerBankAccount).Append("\n");
            sb.Append("  SellerBankName: ").Append(SellerBankName).Append("\n");
            sb.Append("  SellerCompanyName: ").Append(SellerCompanyName).Append("\n");
            sb.Append("  SellerTaxNo: ").Append(SellerTaxNo).Append("\n");
            sb.Append("  SellerTelephone: ").Append(SellerTelephone).Append("\n");
            sb.Append("  TntInstId: ").Append(TntInstId).Append("\n");
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
            return this.Equals(input as ArRelInvoiceOpenApiResponse);
        }

        /// <summary>
        /// Returns true if ArRelInvoiceOpenApiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ArRelInvoiceOpenApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArRelInvoiceOpenApiResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ArInvoiceLines == input.ArInvoiceLines ||
                    (this.ArInvoiceLines != null &&
                    this.ArInvoiceLines.Equals(input.ArInvoiceLines))
                ) && 
                (
                    this.BuyerAddress == input.BuyerAddress ||
                    (this.BuyerAddress != null &&
                    this.BuyerAddress.Equals(input.BuyerAddress))
                ) && 
                (
                    this.BuyerBankAccount == input.BuyerBankAccount ||
                    (this.BuyerBankAccount != null &&
                    this.BuyerBankAccount.Equals(input.BuyerBankAccount))
                ) && 
                (
                    this.BuyerBankName == input.BuyerBankName ||
                    (this.BuyerBankName != null &&
                    this.BuyerBankName.Equals(input.BuyerBankName))
                ) && 
                (
                    this.BuyerInvoiceTitle == input.BuyerInvoiceTitle ||
                    (this.BuyerInvoiceTitle != null &&
                    this.BuyerInvoiceTitle.Equals(input.BuyerInvoiceTitle))
                ) && 
                (
                    this.BuyerTaxNo == input.BuyerTaxNo ||
                    (this.BuyerTaxNo != null &&
                    this.BuyerTaxNo.Equals(input.BuyerTaxNo))
                ) && 
                (
                    this.BuyerTelephone == input.BuyerTelephone ||
                    (this.BuyerTelephone != null &&
                    this.BuyerTelephone.Equals(input.BuyerTelephone))
                ) && 
                (
                    this.CanLink == input.CanLink ||
                    this.CanLink.Equals(input.CanLink)
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Drawer == input.Drawer ||
                    (this.Drawer != null &&
                    this.Drawer.Equals(input.Drawer))
                ) && 
                (
                    this.ElcInvoiceUrl == input.ElcInvoiceUrl ||
                    (this.ElcInvoiceUrl != null &&
                    this.ElcInvoiceUrl.Equals(input.ElcInvoiceUrl))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.InstId == input.InstId ||
                    (this.InstId != null &&
                    this.InstId.Equals(input.InstId))
                ) && 
                (
                    this.InvoiceAmt == input.InvoiceAmt ||
                    (this.InvoiceAmt != null &&
                    this.InvoiceAmt.Equals(input.InvoiceAmt))
                ) && 
                (
                    this.InvoiceChannel == input.InvoiceChannel ||
                    (this.InvoiceChannel != null &&
                    this.InvoiceChannel.Equals(input.InvoiceChannel))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.InvoiceMaterial == input.InvoiceMaterial ||
                    (this.InvoiceMaterial != null &&
                    this.InvoiceMaterial.Equals(input.InvoiceMaterial))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.InvoiceNote == input.InvoiceNote ||
                    (this.InvoiceNote != null &&
                    this.InvoiceNote.Equals(input.InvoiceNote))
                ) && 
                (
                    this.InvoiceStatus == input.InvoiceStatus ||
                    (this.InvoiceStatus != null &&
                    this.InvoiceStatus.Equals(input.InvoiceStatus))
                ) && 
                (
                    this.InvoiceType == input.InvoiceType ||
                    (this.InvoiceType != null &&
                    this.InvoiceType.Equals(input.InvoiceType))
                ) && 
                (
                    this.IpId == input.IpId ||
                    (this.IpId != null &&
                    this.IpId.Equals(input.IpId))
                ) && 
                (
                    this.IpRoleId == input.IpRoleId ||
                    (this.IpRoleId != null &&
                    this.IpRoleId.Equals(input.IpRoleId))
                ) && 
                (
                    this.LastModer == input.LastModer ||
                    (this.LastModer != null &&
                    this.LastModer.Equals(input.LastModer))
                ) && 
                (
                    this.LinkedAmt == input.LinkedAmt ||
                    (this.LinkedAmt != null &&
                    this.LinkedAmt.Equals(input.LinkedAmt))
                ) && 
                (
                    this.MailStatus == input.MailStatus ||
                    (this.MailStatus != null &&
                    this.MailStatus.Equals(input.MailStatus))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.NoBillInvoiceFlag == input.NoBillInvoiceFlag ||
                    (this.NoBillInvoiceFlag != null &&
                    this.NoBillInvoiceFlag.Equals(input.NoBillInvoiceFlag))
                ) && 
                (
                    this.Online == input.Online ||
                    this.Online.Equals(input.Online)
                ) && 
                (
                    this.Payee == input.Payee ||
                    (this.Payee != null &&
                    this.Payee.Equals(input.Payee))
                ) && 
                (
                    this.RecentMailId == input.RecentMailId ||
                    (this.RecentMailId != null &&
                    this.RecentMailId.Equals(input.RecentMailId))
                ) && 
                (
                    this.Red == input.Red ||
                    (this.Red != null &&
                    this.Red.Equals(input.Red))
                ) && 
                (
                    this.RedAmt == input.RedAmt ||
                    (this.RedAmt != null &&
                    this.RedAmt.Equals(input.RedAmt))
                ) && 
                (
                    this.Reviewer == input.Reviewer ||
                    (this.Reviewer != null &&
                    this.Reviewer.Equals(input.Reviewer))
                ) && 
                (
                    this.SellerAddress == input.SellerAddress ||
                    (this.SellerAddress != null &&
                    this.SellerAddress.Equals(input.SellerAddress))
                ) && 
                (
                    this.SellerBankAccount == input.SellerBankAccount ||
                    (this.SellerBankAccount != null &&
                    this.SellerBankAccount.Equals(input.SellerBankAccount))
                ) && 
                (
                    this.SellerBankName == input.SellerBankName ||
                    (this.SellerBankName != null &&
                    this.SellerBankName.Equals(input.SellerBankName))
                ) && 
                (
                    this.SellerCompanyName == input.SellerCompanyName ||
                    (this.SellerCompanyName != null &&
                    this.SellerCompanyName.Equals(input.SellerCompanyName))
                ) && 
                (
                    this.SellerTaxNo == input.SellerTaxNo ||
                    (this.SellerTaxNo != null &&
                    this.SellerTaxNo.Equals(input.SellerTaxNo))
                ) && 
                (
                    this.SellerTelephone == input.SellerTelephone ||
                    (this.SellerTelephone != null &&
                    this.SellerTelephone.Equals(input.SellerTelephone))
                ) && 
                (
                    this.TntInstId == input.TntInstId ||
                    (this.TntInstId != null &&
                    this.TntInstId.Equals(input.TntInstId))
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
                if (this.ArInvoiceLines != null)
                {
                    hashCode = (hashCode * 59) + this.ArInvoiceLines.GetHashCode();
                }
                if (this.BuyerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerAddress.GetHashCode();
                }
                if (this.BuyerBankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerBankAccount.GetHashCode();
                }
                if (this.BuyerBankName != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerBankName.GetHashCode();
                }
                if (this.BuyerInvoiceTitle != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerInvoiceTitle.GetHashCode();
                }
                if (this.BuyerTaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerTaxNo.GetHashCode();
                }
                if (this.BuyerTelephone != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerTelephone.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CanLink.GetHashCode();
                if (this.Creator != null)
                {
                    hashCode = (hashCode * 59) + this.Creator.GetHashCode();
                }
                if (this.Drawer != null)
                {
                    hashCode = (hashCode * 59) + this.Drawer.GetHashCode();
                }
                if (this.ElcInvoiceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ElcInvoiceUrl.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.InstId != null)
                {
                    hashCode = (hashCode * 59) + this.InstId.GetHashCode();
                }
                if (this.InvoiceAmt != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceAmt.GetHashCode();
                }
                if (this.InvoiceChannel != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceChannel.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.InvoiceId != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceId.GetHashCode();
                }
                if (this.InvoiceMaterial != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceMaterial.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.InvoiceNote != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNote.GetHashCode();
                }
                if (this.InvoiceStatus != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceStatus.GetHashCode();
                }
                if (this.InvoiceType != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceType.GetHashCode();
                }
                if (this.IpId != null)
                {
                    hashCode = (hashCode * 59) + this.IpId.GetHashCode();
                }
                if (this.IpRoleId != null)
                {
                    hashCode = (hashCode * 59) + this.IpRoleId.GetHashCode();
                }
                if (this.LastModer != null)
                {
                    hashCode = (hashCode * 59) + this.LastModer.GetHashCode();
                }
                if (this.LinkedAmt != null)
                {
                    hashCode = (hashCode * 59) + this.LinkedAmt.GetHashCode();
                }
                if (this.MailStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MailStatus.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.NoBillInvoiceFlag != null)
                {
                    hashCode = (hashCode * 59) + this.NoBillInvoiceFlag.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Online.GetHashCode();
                if (this.Payee != null)
                {
                    hashCode = (hashCode * 59) + this.Payee.GetHashCode();
                }
                if (this.RecentMailId != null)
                {
                    hashCode = (hashCode * 59) + this.RecentMailId.GetHashCode();
                }
                if (this.Red != null)
                {
                    hashCode = (hashCode * 59) + this.Red.GetHashCode();
                }
                if (this.RedAmt != null)
                {
                    hashCode = (hashCode * 59) + this.RedAmt.GetHashCode();
                }
                if (this.Reviewer != null)
                {
                    hashCode = (hashCode * 59) + this.Reviewer.GetHashCode();
                }
                if (this.SellerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.SellerAddress.GetHashCode();
                }
                if (this.SellerBankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.SellerBankAccount.GetHashCode();
                }
                if (this.SellerBankName != null)
                {
                    hashCode = (hashCode * 59) + this.SellerBankName.GetHashCode();
                }
                if (this.SellerCompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.SellerCompanyName.GetHashCode();
                }
                if (this.SellerTaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.SellerTaxNo.GetHashCode();
                }
                if (this.SellerTelephone != null)
                {
                    hashCode = (hashCode * 59) + this.SellerTelephone.GetHashCode();
                }
                if (this.TntInstId != null)
                {
                    hashCode = (hashCode * 59) + this.TntInstId.GetHashCode();
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
