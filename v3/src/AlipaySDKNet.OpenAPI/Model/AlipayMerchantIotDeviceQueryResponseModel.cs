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
    /// AlipayMerchantIotDeviceQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantIotDeviceQueryResponseModel")]
    public partial class AlipayMerchantIotDeviceQueryResponseModel : IEquatable<AlipayMerchantIotDeviceQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIotDeviceQueryResponseModel" /> class.
        /// </summary>
        /// <param name="merchantType">商户类型。direct表示直连商户，indirect表示间连商户。.</param>
        /// <param name="pid">设备绑定的商户支付宝pid。直连场景为商户收单pid，间连场景为商户smid绑定的pid。.</param>
        /// <param name="shopId">设备绑定的门店ID。.</param>
        /// <param name="smid">商户smid。直连场景为空。.</param>
        public AlipayMerchantIotDeviceQueryResponseModel(string merchantType = default(string), string pid = default(string), string shopId = default(string), string smid = default(string))
        {
            this.MerchantType = merchantType;
            this.Pid = pid;
            this.ShopId = shopId;
            this.Smid = smid;
        }

        /// <summary>
        /// 商户类型。direct表示直连商户，indirect表示间连商户。
        /// </summary>
        /// <value>商户类型。direct表示直连商户，indirect表示间连商户。</value>
        [DataMember(Name = "merchant_type", EmitDefaultValue = false)]
        public string MerchantType { get; set; }

        /// <summary>
        /// 设备绑定的商户支付宝pid。直连场景为商户收单pid，间连场景为商户smid绑定的pid。
        /// </summary>
        /// <value>设备绑定的商户支付宝pid。直连场景为商户收单pid，间连场景为商户smid绑定的pid。</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// 设备绑定的门店ID。
        /// </summary>
        /// <value>设备绑定的门店ID。</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户smid。直连场景为空。
        /// </summary>
        /// <value>商户smid。直连场景为空。</value>
        [DataMember(Name = "smid", EmitDefaultValue = false)]
        public string Smid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantIotDeviceQueryResponseModel {\n");
            sb.Append("  MerchantType: ").Append(MerchantType).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  Smid: ").Append(Smid).Append("\n");
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
            return this.Equals(input as AlipayMerchantIotDeviceQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantIotDeviceQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantIotDeviceQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantIotDeviceQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantType == input.MerchantType ||
                    (this.MerchantType != null &&
                    this.MerchantType.Equals(input.MerchantType))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.Smid == input.Smid ||
                    (this.Smid != null &&
                    this.Smid.Equals(input.Smid))
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
                if (this.MerchantType != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantType.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
                }
                if (this.Smid != null)
                {
                    hashCode = (hashCode * 59) + this.Smid.GetHashCode();
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
