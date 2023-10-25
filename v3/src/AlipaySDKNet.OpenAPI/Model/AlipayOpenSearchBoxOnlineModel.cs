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
    /// AlipayOpenSearchBoxOnlineModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchBoxOnlineModel")]
    public partial class AlipayOpenSearchBoxOnlineModel : IEquatable<AlipayOpenSearchBoxOnlineModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchBoxOnlineModel" /> class.
        /// </summary>
        /// <param name="boxId">搜索直达配置id.</param>
        /// <param name="merchantId">商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。.</param>
        public AlipayOpenSearchBoxOnlineModel(string boxId = default(string), string merchantId = default(string))
        {
            this.BoxId = boxId;
            this.MerchantId = merchantId;
        }

        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        /// <value>搜索直达配置id</value>
        [DataMember(Name = "box_id", EmitDefaultValue = false)]
        public string BoxId { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。
        /// </summary>
        /// <value>商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchBoxOnlineModel {\n");
            sb.Append("  BoxId: ").Append(BoxId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchBoxOnlineModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchBoxOnlineModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchBoxOnlineModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchBoxOnlineModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BoxId == input.BoxId ||
                    (this.BoxId != null &&
                    this.BoxId.Equals(input.BoxId))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
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
                if (this.BoxId != null)
                {
                    hashCode = (hashCode * 59) + this.BoxId.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
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
