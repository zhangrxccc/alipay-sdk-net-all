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
    /// AlipayMerchantLiveItemplanModifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantLiveItemplanModifyResponseModel")]
    public partial class AlipayMerchantLiveItemplanModifyResponseModel : IEquatable<AlipayMerchantLiveItemplanModifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantLiveItemplanModifyResponseModel" /> class.
        /// </summary>
        /// <param name="msgInfo">针对操作结果的说明.</param>
        public AlipayMerchantLiveItemplanModifyResponseModel(string msgInfo = default(string))
        {
            this.MsgInfo = msgInfo;
        }

        /// <summary>
        /// 针对操作结果的说明
        /// </summary>
        /// <value>针对操作结果的说明</value>
        [DataMember(Name = "msg_info", EmitDefaultValue = false)]
        public string MsgInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantLiveItemplanModifyResponseModel {\n");
            sb.Append("  MsgInfo: ").Append(MsgInfo).Append("\n");
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
            return this.Equals(input as AlipayMerchantLiveItemplanModifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantLiveItemplanModifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantLiveItemplanModifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantLiveItemplanModifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MsgInfo == input.MsgInfo ||
                    (this.MsgInfo != null &&
                    this.MsgInfo.Equals(input.MsgInfo))
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
                if (this.MsgInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MsgInfo.GetHashCode();
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
