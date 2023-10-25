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
    /// ZolozAuthenticationCustomerFtokenQueryResponseModel
    /// </summary>
    [DataContract(Name = "ZolozAuthenticationCustomerFtokenQueryResponseModel")]
    public partial class ZolozAuthenticationCustomerFtokenQueryResponseModel : IEquatable<ZolozAuthenticationCustomerFtokenQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZolozAuthenticationCustomerFtokenQueryResponseModel" /> class.
        /// </summary>
        /// <param name="ageCheckResult">年龄是否在指定范围内，未指定范围则返回空，true/false.</param>
        /// <param name="authimgBase64">图片base64 encodeString.</param>
        /// <param name="certName">证件姓名.</param>
        /// <param name="certNo">身份证号码.</param>
        /// <param name="faceId">由ISV定义的对自然人唯一编码，举例可以是身份证号码和姓名的MD5值，或者是其他编码方式，要求脱敏、随机且在ISV可以唯一说明一个自然人.</param>
        /// <param name="openId">支付宝用户open_id.</param>
        /// <param name="uid">支付宝uid.</param>
        /// <param name="uidTelPairList">用户名信息返回的列表.</param>
        public ZolozAuthenticationCustomerFtokenQueryResponseModel(string ageCheckResult = default(string), string authimgBase64 = default(string), string certName = default(string), string certNo = default(string), string faceId = default(string), string openId = default(string), string uid = default(string), List<ZhubUidTelPair> uidTelPairList = default(List<ZhubUidTelPair>))
        {
            this.AgeCheckResult = ageCheckResult;
            this.AuthimgBase64 = authimgBase64;
            this.CertName = certName;
            this.CertNo = certNo;
            this.FaceId = faceId;
            this.OpenId = openId;
            this.Uid = uid;
            this.UidTelPairList = uidTelPairList;
        }

        /// <summary>
        /// 年龄是否在指定范围内，未指定范围则返回空，true/false
        /// </summary>
        /// <value>年龄是否在指定范围内，未指定范围则返回空，true/false</value>
        [DataMember(Name = "age_check_result", EmitDefaultValue = false)]
        public string AgeCheckResult { get; set; }

        /// <summary>
        /// 图片base64 encodeString
        /// </summary>
        /// <value>图片base64 encodeString</value>
        [DataMember(Name = "authimg_base_64", EmitDefaultValue = false)]
        public string AuthimgBase64 { get; set; }

        /// <summary>
        /// 证件姓名
        /// </summary>
        /// <value>证件姓名</value>
        [DataMember(Name = "cert_name", EmitDefaultValue = false)]
        public string CertName { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        /// <value>身份证号码</value>
        [DataMember(Name = "cert_no", EmitDefaultValue = false)]
        public string CertNo { get; set; }

        /// <summary>
        /// 由ISV定义的对自然人唯一编码，举例可以是身份证号码和姓名的MD5值，或者是其他编码方式，要求脱敏、随机且在ISV可以唯一说明一个自然人
        /// </summary>
        /// <value>由ISV定义的对自然人唯一编码，举例可以是身份证号码和姓名的MD5值，或者是其他编码方式，要求脱敏、随机且在ISV可以唯一说明一个自然人</value>
        [DataMember(Name = "face_id", EmitDefaultValue = false)]
        public string FaceId { get; set; }

        /// <summary>
        /// 支付宝用户open_id
        /// </summary>
        /// <value>支付宝用户open_id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        /// <value>支付宝uid</value>
        [DataMember(Name = "uid", EmitDefaultValue = false)]
        public string Uid { get; set; }

        /// <summary>
        /// 用户名信息返回的列表
        /// </summary>
        /// <value>用户名信息返回的列表</value>
        [DataMember(Name = "uid_tel_pair_list", EmitDefaultValue = false)]
        public List<ZhubUidTelPair> UidTelPairList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZolozAuthenticationCustomerFtokenQueryResponseModel {\n");
            sb.Append("  AgeCheckResult: ").Append(AgeCheckResult).Append("\n");
            sb.Append("  AuthimgBase64: ").Append(AuthimgBase64).Append("\n");
            sb.Append("  CertName: ").Append(CertName).Append("\n");
            sb.Append("  CertNo: ").Append(CertNo).Append("\n");
            sb.Append("  FaceId: ").Append(FaceId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  UidTelPairList: ").Append(UidTelPairList).Append("\n");
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
            return this.Equals(input as ZolozAuthenticationCustomerFtokenQueryResponseModel);
        }

        /// <summary>
        /// Returns true if ZolozAuthenticationCustomerFtokenQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZolozAuthenticationCustomerFtokenQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZolozAuthenticationCustomerFtokenQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgeCheckResult == input.AgeCheckResult ||
                    (this.AgeCheckResult != null &&
                    this.AgeCheckResult.Equals(input.AgeCheckResult))
                ) && 
                (
                    this.AuthimgBase64 == input.AuthimgBase64 ||
                    (this.AuthimgBase64 != null &&
                    this.AuthimgBase64.Equals(input.AuthimgBase64))
                ) && 
                (
                    this.CertName == input.CertName ||
                    (this.CertName != null &&
                    this.CertName.Equals(input.CertName))
                ) && 
                (
                    this.CertNo == input.CertNo ||
                    (this.CertNo != null &&
                    this.CertNo.Equals(input.CertNo))
                ) && 
                (
                    this.FaceId == input.FaceId ||
                    (this.FaceId != null &&
                    this.FaceId.Equals(input.FaceId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.UidTelPairList == input.UidTelPairList ||
                    this.UidTelPairList != null &&
                    input.UidTelPairList != null &&
                    this.UidTelPairList.SequenceEqual(input.UidTelPairList)
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
                if (this.AgeCheckResult != null)
                {
                    hashCode = (hashCode * 59) + this.AgeCheckResult.GetHashCode();
                }
                if (this.AuthimgBase64 != null)
                {
                    hashCode = (hashCode * 59) + this.AuthimgBase64.GetHashCode();
                }
                if (this.CertName != null)
                {
                    hashCode = (hashCode * 59) + this.CertName.GetHashCode();
                }
                if (this.CertNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertNo.GetHashCode();
                }
                if (this.FaceId != null)
                {
                    hashCode = (hashCode * 59) + this.FaceId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.Uid != null)
                {
                    hashCode = (hashCode * 59) + this.Uid.GetHashCode();
                }
                if (this.UidTelPairList != null)
                {
                    hashCode = (hashCode * 59) + this.UidTelPairList.GetHashCode();
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
