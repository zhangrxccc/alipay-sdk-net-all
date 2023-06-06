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
    /// AlipayOpenMiniBaseinfoModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniBaseinfoModifyModel")]
    public partial class AlipayOpenMiniBaseinfoModifyModel : IEquatable<AlipayOpenMiniBaseinfoModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniBaseinfoModifyModel" /> class.
        /// </summary>
        /// <param name="appCategoryIds">11_12;12_13。小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以参考https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list 。.</param>
        /// <param name="appDesc">小程序描述，长度限制 20~400 个字符。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过https://opendocs.alipay.com/mini/03l21r查询当前小程序信息 .</param>
        /// <param name="appEnglishName">小程序应用英文名称。长度限制 3~30 个字符，仅支持包含中文、数字、英文、下划线、+、-。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过alipay.open.mini.baseinfo.query查询当前小程序信息.</param>
        /// <param name="appName">小程序名称。长度限制 3~30 个字符，仅支持包含中文、数字、英文、下划线、+、-。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过alipay.open.mini.baseinfo.query查询当前小程序信息.</param>
        /// <param name="appSlogan">小程序简介，一句话描述小程序功能，长度限制 10~32个字符。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过alipay.open.mini.baseinfo.query查询当前小程序信息.</param>
        /// <param name="miniCategoryIds">新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query 接口查询mini_category_list。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过https://opendocs.alipay.com/mini/03l21r查询当前小程序信息 注意：个人开发者不得使用企业类目。.</param>
        /// <param name="serviceEmail">小程序客服邮箱，如果不填默认采用当前小程序的应用客服邮箱，小程序客服电话和邮箱至少输入一个。如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。 注意：2021年7月1日后，该字段将逐步灰度为可选字段，请按可选开发。.</param>
        /// <param name="servicePhone">小程序客服电话，长度限制5~30个字符，仅支持包含数字和-。如果不填默认采用当前小程序的应用客服电话，小程序客服电话和邮箱至少输入一个。如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。 注意：2021年7月1日后，该字段将逐步灰度为必填字段，请按必填开发。.</param>
        public AlipayOpenMiniBaseinfoModifyModel(string appCategoryIds = default(string), string appDesc = default(string), string appEnglishName = default(string), string appName = default(string), string appSlogan = default(string), string miniCategoryIds = default(string), string serviceEmail = default(string), string servicePhone = default(string))
        {
            this.AppCategoryIds = appCategoryIds;
            this.AppDesc = appDesc;
            this.AppEnglishName = appEnglishName;
            this.AppName = appName;
            this.AppSlogan = appSlogan;
            this.MiniCategoryIds = miniCategoryIds;
            this.ServiceEmail = serviceEmail;
            this.ServicePhone = servicePhone;
        }

        /// <summary>
        /// 11_12;12_13。小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以参考https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list 。
        /// </summary>
        /// <value>11_12;12_13。小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以参考https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list 。</value>
        [DataMember(Name = "app_category_ids", EmitDefaultValue = false)]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序描述，长度限制 20~400 个字符。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过https://opendocs.alipay.com/mini/03l21r查询当前小程序信息 
        /// </summary>
        /// <value>小程序描述，长度限制 20~400 个字符。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过https://opendocs.alipay.com/mini/03l21r查询当前小程序信息 </value>
        [DataMember(Name = "app_desc", EmitDefaultValue = false)]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称。长度限制 3~30 个字符，仅支持包含中文、数字、英文、下划线、+、-。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过alipay.open.mini.baseinfo.query查询当前小程序信息
        /// </summary>
        /// <value>小程序应用英文名称。长度限制 3~30 个字符，仅支持包含中文、数字、英文、下划线、+、-。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过alipay.open.mini.baseinfo.query查询当前小程序信息</value>
        [DataMember(Name = "app_english_name", EmitDefaultValue = false)]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序名称。长度限制 3~30 个字符，仅支持包含中文、数字、英文、下划线、+、-。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过alipay.open.mini.baseinfo.query查询当前小程序信息
        /// </summary>
        /// <value>小程序名称。长度限制 3~30 个字符，仅支持包含中文、数字、英文、下划线、+、-。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过alipay.open.mini.baseinfo.query查询当前小程序信息</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序简介，一句话描述小程序功能，长度限制 10~32个字符。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过alipay.open.mini.baseinfo.query查询当前小程序信息
        /// </summary>
        /// <value>小程序简介，一句话描述小程序功能，长度限制 10~32个字符。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过alipay.open.mini.baseinfo.query查询当前小程序信息</value>
        [DataMember(Name = "app_slogan", EmitDefaultValue = false)]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query 接口查询mini_category_list。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过https://opendocs.alipay.com/mini/03l21r查询当前小程序信息 注意：个人开发者不得使用企业类目。
        /// </summary>
        /// <value>新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query 接口查询mini_category_list。 如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。如果前期没有设置过该信息，则本次为必填。可通过https://opendocs.alipay.com/mini/03l21r查询当前小程序信息 注意：个人开发者不得使用企业类目。</value>
        [DataMember(Name = "mini_category_ids", EmitDefaultValue = false)]
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 小程序客服邮箱，如果不填默认采用当前小程序的应用客服邮箱，小程序客服电话和邮箱至少输入一个。如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。 注意：2021年7月1日后，该字段将逐步灰度为可选字段，请按可选开发。
        /// </summary>
        /// <value>小程序客服邮箱，如果不填默认采用当前小程序的应用客服邮箱，小程序客服电话和邮箱至少输入一个。如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。 注意：2021年7月1日后，该字段将逐步灰度为可选字段，请按可选开发。</value>
        [DataMember(Name = "service_email", EmitDefaultValue = false)]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话，长度限制5~30个字符，仅支持包含数字和-。如果不填默认采用当前小程序的应用客服电话，小程序客服电话和邮箱至少输入一个。如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。 注意：2021年7月1日后，该字段将逐步灰度为必填字段，请按必填开发。
        /// </summary>
        /// <value>小程序客服电话，长度限制5~30个字符，仅支持包含数字和-。如果不填默认采用当前小程序的应用客服电话，小程序客服电话和邮箱至少输入一个。如果前期已经设置过该信息，本次可不填，平台将会为你默认上传该信息。 注意：2021年7月1日后，该字段将逐步灰度为必填字段，请按必填开发。</value>
        [DataMember(Name = "service_phone", EmitDefaultValue = false)]
        public string ServicePhone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniBaseinfoModifyModel {\n");
            sb.Append("  AppCategoryIds: ").Append(AppCategoryIds).Append("\n");
            sb.Append("  AppDesc: ").Append(AppDesc).Append("\n");
            sb.Append("  AppEnglishName: ").Append(AppEnglishName).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppSlogan: ").Append(AppSlogan).Append("\n");
            sb.Append("  MiniCategoryIds: ").Append(MiniCategoryIds).Append("\n");
            sb.Append("  ServiceEmail: ").Append(ServiceEmail).Append("\n");
            sb.Append("  ServicePhone: ").Append(ServicePhone).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniBaseinfoModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniBaseinfoModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniBaseinfoModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniBaseinfoModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppCategoryIds == input.AppCategoryIds ||
                    (this.AppCategoryIds != null &&
                    this.AppCategoryIds.Equals(input.AppCategoryIds))
                ) && 
                (
                    this.AppDesc == input.AppDesc ||
                    (this.AppDesc != null &&
                    this.AppDesc.Equals(input.AppDesc))
                ) && 
                (
                    this.AppEnglishName == input.AppEnglishName ||
                    (this.AppEnglishName != null &&
                    this.AppEnglishName.Equals(input.AppEnglishName))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppSlogan == input.AppSlogan ||
                    (this.AppSlogan != null &&
                    this.AppSlogan.Equals(input.AppSlogan))
                ) && 
                (
                    this.MiniCategoryIds == input.MiniCategoryIds ||
                    (this.MiniCategoryIds != null &&
                    this.MiniCategoryIds.Equals(input.MiniCategoryIds))
                ) && 
                (
                    this.ServiceEmail == input.ServiceEmail ||
                    (this.ServiceEmail != null &&
                    this.ServiceEmail.Equals(input.ServiceEmail))
                ) && 
                (
                    this.ServicePhone == input.ServicePhone ||
                    (this.ServicePhone != null &&
                    this.ServicePhone.Equals(input.ServicePhone))
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
                if (this.AppCategoryIds != null)
                {
                    hashCode = (hashCode * 59) + this.AppCategoryIds.GetHashCode();
                }
                if (this.AppDesc != null)
                {
                    hashCode = (hashCode * 59) + this.AppDesc.GetHashCode();
                }
                if (this.AppEnglishName != null)
                {
                    hashCode = (hashCode * 59) + this.AppEnglishName.GetHashCode();
                }
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.AppSlogan != null)
                {
                    hashCode = (hashCode * 59) + this.AppSlogan.GetHashCode();
                }
                if (this.MiniCategoryIds != null)
                {
                    hashCode = (hashCode * 59) + this.MiniCategoryIds.GetHashCode();
                }
                if (this.ServiceEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceEmail.GetHashCode();
                }
                if (this.ServicePhone != null)
                {
                    hashCode = (hashCode * 59) + this.ServicePhone.GetHashCode();
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
