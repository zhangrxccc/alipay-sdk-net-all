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
    /// Data
    /// </summary>
    [DataContract(Name = "Data")]
    public partial class Data : IEquatable<Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data" /> class.
        /// </summary>
        /// <param name="alipayOpenIdList">支付宝用户唯一标识列表.</param>
        /// <param name="alipayUserIdList">对应userIdList，标准Alipay UserId列表.</param>
        /// <param name="openIdList">支付宝用户唯一标识列表.</param>
        /// <param name="userIdList">用户id列表.</param>
        public Data(List<string> alipayOpenIdList = default(List<string>), List<string> alipayUserIdList = default(List<string>), List<string> openIdList = default(List<string>), List<string> userIdList = default(List<string>))
        {
            this.AlipayOpenIdList = alipayOpenIdList;
            this.AlipayUserIdList = alipayUserIdList;
            this.OpenIdList = openIdList;
            this.UserIdList = userIdList;
        }

        /// <summary>
        /// 支付宝用户唯一标识列表
        /// </summary>
        /// <value>支付宝用户唯一标识列表</value>
        [DataMember(Name = "alipay_open_id_list", EmitDefaultValue = false)]
        public List<string> AlipayOpenIdList { get; set; }

        /// <summary>
        /// 对应userIdList，标准Alipay UserId列表
        /// </summary>
        /// <value>对应userIdList，标准Alipay UserId列表</value>
        [DataMember(Name = "alipay_user_id_list", EmitDefaultValue = false)]
        public List<string> AlipayUserIdList { get; set; }

        /// <summary>
        /// 支付宝用户唯一标识列表
        /// </summary>
        /// <value>支付宝用户唯一标识列表</value>
        [DataMember(Name = "open_id_list", EmitDefaultValue = false)]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// 用户id列表
        /// </summary>
        /// <value>用户id列表</value>
        [DataMember(Name = "user_id_list", EmitDefaultValue = false)]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Data {\n");
            sb.Append("  AlipayOpenIdList: ").Append(AlipayOpenIdList).Append("\n");
            sb.Append("  AlipayUserIdList: ").Append(AlipayUserIdList).Append("\n");
            sb.Append("  OpenIdList: ").Append(OpenIdList).Append("\n");
            sb.Append("  UserIdList: ").Append(UserIdList).Append("\n");
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
            return this.Equals(input as Data);
        }

        /// <summary>
        /// Returns true if Data instances are equal
        /// </summary>
        /// <param name="input">Instance of Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Data input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlipayOpenIdList == input.AlipayOpenIdList ||
                    this.AlipayOpenIdList != null &&
                    input.AlipayOpenIdList != null &&
                    this.AlipayOpenIdList.SequenceEqual(input.AlipayOpenIdList)
                ) && 
                (
                    this.AlipayUserIdList == input.AlipayUserIdList ||
                    this.AlipayUserIdList != null &&
                    input.AlipayUserIdList != null &&
                    this.AlipayUserIdList.SequenceEqual(input.AlipayUserIdList)
                ) && 
                (
                    this.OpenIdList == input.OpenIdList ||
                    this.OpenIdList != null &&
                    input.OpenIdList != null &&
                    this.OpenIdList.SequenceEqual(input.OpenIdList)
                ) && 
                (
                    this.UserIdList == input.UserIdList ||
                    this.UserIdList != null &&
                    input.UserIdList != null &&
                    this.UserIdList.SequenceEqual(input.UserIdList)
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
                if (this.AlipayOpenIdList != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayOpenIdList.GetHashCode();
                }
                if (this.AlipayUserIdList != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserIdList.GetHashCode();
                }
                if (this.OpenIdList != null)
                {
                    hashCode = (hashCode * 59) + this.OpenIdList.GetHashCode();
                }
                if (this.UserIdList != null)
                {
                    hashCode = (hashCode * 59) + this.UserIdList.GetHashCode();
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
