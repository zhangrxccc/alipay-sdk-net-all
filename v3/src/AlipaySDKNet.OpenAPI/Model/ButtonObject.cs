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
    /// ButtonObject
    /// </summary>
    [DataContract(Name = "ButtonObject")]
    public partial class ButtonObject : IEquatable<ButtonObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonObject" /> class.
        /// </summary>
        /// <param name="actionParam">当actionType为link时，该参数为url链接；  当actionType为out时，该参数为用户自定义参数；  当actionType为tel时，该参数为电话号码。  当action_type为map时，该参数为查看地图的关键字。  当action_type为consumption时，该参数可不传。  该参数最长255个字符，不允许冒号等特殊字符。.</param>
        /// <param name="actionType">菜单类型：  out——事件型菜单；  link——链接型菜单；  tel——点击拨打电话；  map——点击查看地图；  consumption——点击查看用户与生活号管理员账号之间的消费记录.</param>
        /// <param name="icon">icon图片url，必须是http协议的url，尺寸为60X60，最大不超过5M，请先调用&lt;a href&#x3D;\&quot;https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload\&quot;&gt; 图片上传接口&lt;/a&gt;获得图片url.</param>
        /// <param name="name">菜单名称，icon菜单名称不超过5个汉字，文本菜单名称不超过9个汉字，编码格式为GBK.</param>
        /// <param name="subButton">二级菜单数组，若sub_button为空，则一级菜单必须指定action_type和action_param的值，二级菜单个数可以为1~5个。.</param>
        public ButtonObject(string actionParam = default(string), string actionType = default(string), string icon = default(string), string name = default(string), List<SubButton> subButton = default(List<SubButton>))
        {
            this.ActionParam = actionParam;
            this.ActionType = actionType;
            this.Icon = icon;
            this.Name = name;
            this.SubButton = subButton;
        }

        /// <summary>
        /// 当actionType为link时，该参数为url链接；  当actionType为out时，该参数为用户自定义参数；  当actionType为tel时，该参数为电话号码。  当action_type为map时，该参数为查看地图的关键字。  当action_type为consumption时，该参数可不传。  该参数最长255个字符，不允许冒号等特殊字符。
        /// </summary>
        /// <value>当actionType为link时，该参数为url链接；  当actionType为out时，该参数为用户自定义参数；  当actionType为tel时，该参数为电话号码。  当action_type为map时，该参数为查看地图的关键字。  当action_type为consumption时，该参数可不传。  该参数最长255个字符，不允许冒号等特殊字符。</value>
        [DataMember(Name = "action_param", EmitDefaultValue = false)]
        public string ActionParam { get; set; }

        /// <summary>
        /// 菜单类型：  out——事件型菜单；  link——链接型菜单；  tel——点击拨打电话；  map——点击查看地图；  consumption——点击查看用户与生活号管理员账号之间的消费记录
        /// </summary>
        /// <value>菜单类型：  out——事件型菜单；  link——链接型菜单；  tel——点击拨打电话；  map——点击查看地图；  consumption——点击查看用户与生活号管理员账号之间的消费记录</value>
        [DataMember(Name = "action_type", EmitDefaultValue = false)]
        public string ActionType { get; set; }

        /// <summary>
        /// icon图片url，必须是http协议的url，尺寸为60X60，最大不超过5M，请先调用&lt;a href&#x3D;\&quot;https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload\&quot;&gt; 图片上传接口&lt;/a&gt;获得图片url
        /// </summary>
        /// <value>icon图片url，必须是http协议的url，尺寸为60X60，最大不超过5M，请先调用&lt;a href&#x3D;\&quot;https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload\&quot;&gt; 图片上传接口&lt;/a&gt;获得图片url</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// 菜单名称，icon菜单名称不超过5个汉字，文本菜单名称不超过9个汉字，编码格式为GBK
        /// </summary>
        /// <value>菜单名称，icon菜单名称不超过5个汉字，文本菜单名称不超过9个汉字，编码格式为GBK</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 二级菜单数组，若sub_button为空，则一级菜单必须指定action_type和action_param的值，二级菜单个数可以为1~5个。
        /// </summary>
        /// <value>二级菜单数组，若sub_button为空，则一级菜单必须指定action_type和action_param的值，二级菜单个数可以为1~5个。</value>
        [DataMember(Name = "sub_button", EmitDefaultValue = false)]
        public List<SubButton> SubButton { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ButtonObject {\n");
            sb.Append("  ActionParam: ").Append(ActionParam).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubButton: ").Append(SubButton).Append("\n");
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
            return this.Equals(input as ButtonObject);
        }

        /// <summary>
        /// Returns true if ButtonObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ButtonObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ButtonObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionParam == input.ActionParam ||
                    (this.ActionParam != null &&
                    this.ActionParam.Equals(input.ActionParam))
                ) && 
                (
                    this.ActionType == input.ActionType ||
                    (this.ActionType != null &&
                    this.ActionType.Equals(input.ActionType))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubButton == input.SubButton ||
                    this.SubButton != null &&
                    input.SubButton != null &&
                    this.SubButton.SequenceEqual(input.SubButton)
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
                if (this.ActionParam != null)
                {
                    hashCode = (hashCode * 59) + this.ActionParam.GetHashCode();
                }
                if (this.ActionType != null)
                {
                    hashCode = (hashCode * 59) + this.ActionType.GetHashCode();
                }
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SubButton != null)
                {
                    hashCode = (hashCode * 59) + this.SubButton.GetHashCode();
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
