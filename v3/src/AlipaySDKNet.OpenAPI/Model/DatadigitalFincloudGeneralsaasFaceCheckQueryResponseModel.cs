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
    /// DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel
    /// </summary>
    [DataContract(Name = "DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel")]
    public partial class DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel : IEquatable<DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel" /> class.
        /// </summary>
        /// <param name="alivePhoto">如果设置了need_alive_photo的值不为N，则该字段返回人脸照片的base64编码字符串。.</param>
        /// <param name="attackFlag">已废弃.</param>
        /// <param name="certifyState">PROCESSING：初始化；SUCCESS：检测成功；FAIL：检测失败.</param>
        /// <param name="quality">double值，人脸图片质量分.</param>
        /// <param name="score">已废弃.</param>
        public DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel(string alivePhoto = default(string), string attackFlag = default(string), string certifyState = default(string), string quality = default(string), string score = default(string))
        {
            this.AlivePhoto = alivePhoto;
            this.AttackFlag = attackFlag;
            this.CertifyState = certifyState;
            this.Quality = quality;
            this.Score = score;
        }

        /// <summary>
        /// 如果设置了need_alive_photo的值不为N，则该字段返回人脸照片的base64编码字符串。
        /// </summary>
        /// <value>如果设置了need_alive_photo的值不为N，则该字段返回人脸照片的base64编码字符串。</value>
        [DataMember(Name = "alive_photo", EmitDefaultValue = false)]
        public string AlivePhoto { get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        /// <value>已废弃</value>
        [DataMember(Name = "attack_flag", EmitDefaultValue = false)]
        public string AttackFlag { get; set; }

        /// <summary>
        /// PROCESSING：初始化；SUCCESS：检测成功；FAIL：检测失败
        /// </summary>
        /// <value>PROCESSING：初始化；SUCCESS：检测成功；FAIL：检测失败</value>
        [DataMember(Name = "certify_state", EmitDefaultValue = false)]
        public string CertifyState { get; set; }

        /// <summary>
        /// double值，人脸图片质量分
        /// </summary>
        /// <value>double值，人脸图片质量分</value>
        [DataMember(Name = "quality", EmitDefaultValue = false)]
        public string Quality { get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        /// <value>已废弃</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public string Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel {\n");
            sb.Append("  AlivePhoto: ").Append(AlivePhoto).Append("\n");
            sb.Append("  AttackFlag: ").Append(AttackFlag).Append("\n");
            sb.Append("  CertifyState: ").Append(CertifyState).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return this.Equals(input as DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel);
        }

        /// <summary>
        /// Returns true if DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatadigitalFincloudGeneralsaasFaceCheckQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlivePhoto == input.AlivePhoto ||
                    (this.AlivePhoto != null &&
                    this.AlivePhoto.Equals(input.AlivePhoto))
                ) && 
                (
                    this.AttackFlag == input.AttackFlag ||
                    (this.AttackFlag != null &&
                    this.AttackFlag.Equals(input.AttackFlag))
                ) && 
                (
                    this.CertifyState == input.CertifyState ||
                    (this.CertifyState != null &&
                    this.CertifyState.Equals(input.CertifyState))
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
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
                if (this.AlivePhoto != null)
                {
                    hashCode = (hashCode * 59) + this.AlivePhoto.GetHashCode();
                }
                if (this.AttackFlag != null)
                {
                    hashCode = (hashCode * 59) + this.AttackFlag.GetHashCode();
                }
                if (this.CertifyState != null)
                {
                    hashCode = (hashCode * 59) + this.CertifyState.GetHashCode();
                }
                if (this.Quality != null)
                {
                    hashCode = (hashCode * 59) + this.Quality.GetHashCode();
                }
                if (this.Score != null)
                {
                    hashCode = (hashCode * 59) + this.Score.GetHashCode();
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
