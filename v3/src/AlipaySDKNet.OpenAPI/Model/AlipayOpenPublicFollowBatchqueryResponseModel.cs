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
    /// AlipayOpenPublicFollowBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicFollowBatchqueryResponseModel")]
    public partial class AlipayOpenPublicFollowBatchqueryResponseModel : IEquatable<AlipayOpenPublicFollowBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicFollowBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="count">本次调用获取的userId个数，最大值为10000.</param>
        /// <param name="nextUserId">查询分组的userid.</param>
        /// <param name="openId">支付宝用户的.</param>
        /// <param name="openIdList">支付宝用户的唯一标识列表.</param>
        /// <param name="userIdList">用户的userId列表.</param>
        public AlipayOpenPublicFollowBatchqueryResponseModel(string count = default(string), string nextUserId = default(string), string openId = default(string), List<string> openIdList = default(List<string>), List<string> userIdList = default(List<string>))
        {
            this.Count = count;
            this.NextUserId = nextUserId;
            this.OpenId = openId;
            this.OpenIdList = openIdList;
            this.UserIdList = userIdList;
        }

        /// <summary>
        /// 本次调用获取的userId个数，最大值为10000
        /// </summary>
        /// <value>本次调用获取的userId个数，最大值为10000</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public string Count { get; set; }

        /// <summary>
        /// 查询分组的userid
        /// </summary>
        /// <value>查询分组的userid</value>
        [DataMember(Name = "next_user_id", EmitDefaultValue = false)]
        public string NextUserId { get; set; }

        /// <summary>
        /// 支付宝用户的
        /// </summary>
        /// <value>支付宝用户的</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的唯一标识列表
        /// </summary>
        /// <value>支付宝用户的唯一标识列表</value>
        [DataMember(Name = "open_id_list", EmitDefaultValue = false)]
        public List<string> OpenIdList { get; set; }

        /// <summary>
        /// 用户的userId列表
        /// </summary>
        /// <value>用户的userId列表</value>
        [DataMember(Name = "user_id_list", EmitDefaultValue = false)]
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicFollowBatchqueryResponseModel {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  NextUserId: ").Append(NextUserId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicFollowBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicFollowBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicFollowBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicFollowBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.NextUserId == input.NextUserId ||
                    (this.NextUserId != null &&
                    this.NextUserId.Equals(input.NextUserId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
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
                if (this.Count != null)
                {
                    hashCode = (hashCode * 59) + this.Count.GetHashCode();
                }
                if (this.NextUserId != null)
                {
                    hashCode = (hashCode * 59) + this.NextUserId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
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
