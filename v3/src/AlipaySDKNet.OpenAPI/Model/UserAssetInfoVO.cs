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
    /// UserAssetInfoVO
    /// </summary>
    [DataContract(Name = "UserAssetInfoVO")]
    public partial class UserAssetInfoVO : IEquatable<UserAssetInfoVO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAssetInfoVO" /> class.
        /// </summary>
        /// <param name="assetId">资产ID.</param>
        /// <param name="assetType">资产类型.</param>
        /// <param name="userId">支付宝用户ID.</param>
        /// <param name="userOpenId">支付宝用户开放ID.</param>
        public UserAssetInfoVO(string assetId = default(string), string assetType = default(string), string userId = default(string), string userOpenId = default(string))
        {
            this.AssetId = assetId;
            this.AssetType = assetType;
            this.UserId = userId;
            this.UserOpenId = userOpenId;
        }

        /// <summary>
        /// 资产ID
        /// </summary>
        /// <value>资产ID</value>
        [DataMember(Name = "asset_id", EmitDefaultValue = false)]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        /// <value>资产类型</value>
        [DataMember(Name = "asset_type", EmitDefaultValue = false)]
        public string AssetType { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        /// <value>支付宝用户ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝用户开放ID
        /// </summary>
        /// <value>支付宝用户开放ID</value>
        [DataMember(Name = "user_open_id", EmitDefaultValue = false)]
        public string UserOpenId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAssetInfoVO {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserOpenId: ").Append(UserOpenId).Append("\n");
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
            return this.Equals(input as UserAssetInfoVO);
        }

        /// <summary>
        /// Returns true if UserAssetInfoVO instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAssetInfoVO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAssetInfoVO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserOpenId == input.UserOpenId ||
                    (this.UserOpenId != null &&
                    this.UserOpenId.Equals(input.UserOpenId))
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
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                if (this.AssetType != null)
                {
                    hashCode = (hashCode * 59) + this.AssetType.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.UserOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.UserOpenId.GetHashCode();
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
