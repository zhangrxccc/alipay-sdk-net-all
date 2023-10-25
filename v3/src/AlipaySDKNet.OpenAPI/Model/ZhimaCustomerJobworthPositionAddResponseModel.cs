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
    /// ZhimaCustomerJobworthPositionAddResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCustomerJobworthPositionAddResponseModel")]
    public partial class ZhimaCustomerJobworthPositionAddResponseModel : IEquatable<ZhimaCustomerJobworthPositionAddResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthPositionAddResponseModel" /> class.
        /// </summary>
        /// <param name="positionId">岗位信息ID.</param>
        /// <param name="subCode">业务错误.</param>
        /// <param name="subMsg">业务错误信息.</param>
        public ZhimaCustomerJobworthPositionAddResponseModel(string positionId = default(string), string subCode = default(string), string subMsg = default(string))
        {
            this.PositionId = positionId;
            this.SubCode = subCode;
            this.SubMsg = subMsg;
        }

        /// <summary>
        /// 岗位信息ID
        /// </summary>
        /// <value>岗位信息ID</value>
        [DataMember(Name = "position_id", EmitDefaultValue = false)]
        public string PositionId { get; set; }

        /// <summary>
        /// 业务错误
        /// </summary>
        /// <value>业务错误</value>
        [DataMember(Name = "sub_code", EmitDefaultValue = false)]
        public string SubCode { get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        /// <value>业务错误信息</value>
        [DataMember(Name = "sub_msg", EmitDefaultValue = false)]
        public string SubMsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCustomerJobworthPositionAddResponseModel {\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  SubCode: ").Append(SubCode).Append("\n");
            sb.Append("  SubMsg: ").Append(SubMsg).Append("\n");
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
            return this.Equals(input as ZhimaCustomerJobworthPositionAddResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCustomerJobworthPositionAddResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCustomerJobworthPositionAddResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCustomerJobworthPositionAddResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PositionId == input.PositionId ||
                    (this.PositionId != null &&
                    this.PositionId.Equals(input.PositionId))
                ) && 
                (
                    this.SubCode == input.SubCode ||
                    (this.SubCode != null &&
                    this.SubCode.Equals(input.SubCode))
                ) && 
                (
                    this.SubMsg == input.SubMsg ||
                    (this.SubMsg != null &&
                    this.SubMsg.Equals(input.SubMsg))
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
                if (this.PositionId != null)
                {
                    hashCode = (hashCode * 59) + this.PositionId.GetHashCode();
                }
                if (this.SubCode != null)
                {
                    hashCode = (hashCode * 59) + this.SubCode.GetHashCode();
                }
                if (this.SubMsg != null)
                {
                    hashCode = (hashCode * 59) + this.SubMsg.GetHashCode();
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
