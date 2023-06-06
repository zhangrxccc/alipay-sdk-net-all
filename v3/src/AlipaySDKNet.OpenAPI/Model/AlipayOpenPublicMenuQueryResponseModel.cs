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
    /// AlipayOpenPublicMenuQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMenuQueryResponseModel")]
    public partial class AlipayOpenPublicMenuQueryResponseModel : IEquatable<AlipayOpenPublicMenuQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMenuQueryResponseModel" /> class.
        /// </summary>
        /// <param name="menuContent">一级菜单数组，个数应为1~4个.</param>
        public AlipayOpenPublicMenuQueryResponseModel(string menuContent = default(string))
        {
            this.MenuContent = menuContent;
        }

        /// <summary>
        /// 一级菜单数组，个数应为1~4个
        /// </summary>
        /// <value>一级菜单数组，个数应为1~4个</value>
        [DataMember(Name = "menu_content", EmitDefaultValue = false)]
        public string MenuContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicMenuQueryResponseModel {\n");
            sb.Append("  MenuContent: ").Append(MenuContent).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicMenuQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMenuQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMenuQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMenuQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MenuContent == input.MenuContent ||
                    (this.MenuContent != null &&
                    this.MenuContent.Equals(input.MenuContent))
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
                if (this.MenuContent != null)
                {
                    hashCode = (hashCode * 59) + this.MenuContent.GetHashCode();
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
