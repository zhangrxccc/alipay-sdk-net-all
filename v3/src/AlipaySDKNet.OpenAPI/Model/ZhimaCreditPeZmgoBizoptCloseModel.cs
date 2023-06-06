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
    /// ZhimaCreditPeZmgoBizoptCloseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoBizoptCloseModel")]
    public partial class ZhimaCreditPeZmgoBizoptCloseModel : IEquatable<ZhimaCreditPeZmgoBizoptCloseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoBizoptCloseModel" /> class.
        /// </summary>
        /// <param name="alipayUserId">支付宝用户Id.</param>
        /// <param name="openId">支付宝用户Id.</param>
        /// <param name="outRequestNo">商户本次操作的请求流水号，由商户生成，请确保唯一性.</param>
        /// <param name="partnerId">商户Id.</param>
        /// <param name="templateId">芝麻GO配置模板Id.</param>
        public ZhimaCreditPeZmgoBizoptCloseModel(string alipayUserId = default(string), string openId = default(string), string outRequestNo = default(string), string partnerId = default(string), string templateId = default(string))
        {
            this.AlipayUserId = alipayUserId;
            this.OpenId = openId;
            this.OutRequestNo = outRequestNo;
            this.PartnerId = partnerId;
            this.TemplateId = templateId;
        }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        /// <value>支付宝用户Id</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        /// <value>支付宝用户Id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，由商户生成，请确保唯一性
        /// </summary>
        /// <value>商户本次操作的请求流水号，由商户生成，请确保唯一性</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户Id
        /// </summary>
        /// <value>商户Id</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 芝麻GO配置模板Id
        /// </summary>
        /// <value>芝麻GO配置模板Id</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPeZmgoBizoptCloseModel {\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoBizoptCloseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoBizoptCloseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoBizoptCloseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoBizoptCloseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
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
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
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
