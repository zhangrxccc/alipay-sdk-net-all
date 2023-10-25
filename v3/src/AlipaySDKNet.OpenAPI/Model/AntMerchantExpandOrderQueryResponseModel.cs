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
    /// AntMerchantExpandOrderQueryResponseModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandOrderQueryResponseModel")]
    public partial class AntMerchantExpandOrderQueryResponseModel : IEquatable<AntMerchantExpandOrderQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandOrderQueryResponseModel" /> class.
        /// </summary>
        /// <param name="applyTime">申请单创建时间.</param>
        /// <param name="extInfo">返回申请单相关参数。当前返回内容有cardAliasNo，smid.</param>
        /// <param name="ipRoleId">商户角色id。间连商户或平台商二级商户业务中，本字段表示smid。审核通过后生成。.</param>
        /// <param name="merchantName">商户名称.</param>
        /// <param name="status">申请单状态。.</param>
        public AntMerchantExpandOrderQueryResponseModel(string applyTime = default(string), string extInfo = default(string), List<string> ipRoleId = default(List<string>), string merchantName = default(string), string status = default(string))
        {
            this.ApplyTime = applyTime;
            this.ExtInfo = extInfo;
            this.IpRoleId = ipRoleId;
            this.MerchantName = merchantName;
            this.Status = status;
        }

        /// <summary>
        /// 申请单创建时间
        /// </summary>
        /// <value>申请单创建时间</value>
        [DataMember(Name = "apply_time", EmitDefaultValue = false)]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 返回申请单相关参数。当前返回内容有cardAliasNo，smid
        /// </summary>
        /// <value>返回申请单相关参数。当前返回内容有cardAliasNo，smid</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户角色id。间连商户或平台商二级商户业务中，本字段表示smid。审核通过后生成。
        /// </summary>
        /// <value>商户角色id。间连商户或平台商二级商户业务中，本字段表示smid。审核通过后生成。</value>
        [DataMember(Name = "ip_role_id", EmitDefaultValue = false)]
        public List<string> IpRoleId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        /// <value>商户名称</value>
        [DataMember(Name = "merchant_name", EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// 申请单状态。
        /// </summary>
        /// <value>申请单状态。</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntMerchantExpandOrderQueryResponseModel {\n");
            sb.Append("  ApplyTime: ").Append(ApplyTime).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  IpRoleId: ").Append(IpRoleId).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AntMerchantExpandOrderQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandOrderQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandOrderQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandOrderQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyTime == input.ApplyTime ||
                    (this.ApplyTime != null &&
                    this.ApplyTime.Equals(input.ApplyTime))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.IpRoleId == input.IpRoleId ||
                    this.IpRoleId != null &&
                    input.IpRoleId != null &&
                    this.IpRoleId.SequenceEqual(input.IpRoleId)
                ) && 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ApplyTime != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyTime.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.IpRoleId != null)
                {
                    hashCode = (hashCode * 59) + this.IpRoleId.GetHashCode();
                }
                if (this.MerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantName.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
