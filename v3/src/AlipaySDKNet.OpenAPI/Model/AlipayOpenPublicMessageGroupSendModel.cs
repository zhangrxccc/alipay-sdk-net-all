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
    /// AlipayOpenPublicMessageGroupSendModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMessageGroupSendModel")]
    public partial class AlipayOpenPublicMessageGroupSendModel : IEquatable<AlipayOpenPublicMessageGroupSendModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageGroupSendModel" /> class.
        /// </summary>
        /// <param name="articles">图文消息，当 msg_type为image-text，本参数必填。.</param>
        /// <param name="groupId">分组ID，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create\&quot;&gt;alipay.open.public.group.create&lt;/a&gt;（用户分组创建接口) 创建用户分组获取。.</param>
        /// <param name="image">image.</param>
        /// <param name="msgType">消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。 .</param>
        /// <param name="text">text.</param>
        public AlipayOpenPublicMessageGroupSendModel(List<Article> articles = default(List<Article>), string groupId = default(string), Image image = default(Image), string msgType = default(string), Text text = default(Text))
        {
            this.Articles = articles;
            this.GroupId = groupId;
            this.Image = image;
            this.MsgType = msgType;
            this.Text = text;
        }

        /// <summary>
        /// 图文消息，当 msg_type为image-text，本参数必填。
        /// </summary>
        /// <value>图文消息，当 msg_type为image-text，本参数必填。</value>
        [DataMember(Name = "articles", EmitDefaultValue = false)]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 分组ID，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create\&quot;&gt;alipay.open.public.group.create&lt;/a&gt;（用户分组创建接口) 创建用户分组获取。
        /// </summary>
        /// <value>分组ID，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create\&quot;&gt;alipay.open.public.group.create&lt;/a&gt;（用户分组创建接口) 创建用户分组获取。</value>
        [DataMember(Name = "group_id", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public Image Image { get; set; }

        /// <summary>
        /// 消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。 
        /// </summary>
        /// <value>消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。 </value>
        [DataMember(Name = "msg_type", EmitDefaultValue = false)]
        public string MsgType { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public Text Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicMessageGroupSendModel {\n");
            sb.Append("  Articles: ").Append(Articles).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  MsgType: ").Append(MsgType).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicMessageGroupSendModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMessageGroupSendModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMessageGroupSendModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMessageGroupSendModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Articles == input.Articles ||
                    this.Articles != null &&
                    input.Articles != null &&
                    this.Articles.SequenceEqual(input.Articles)
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.MsgType == input.MsgType ||
                    (this.MsgType != null &&
                    this.MsgType.Equals(input.MsgType))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Articles != null)
                {
                    hashCode = (hashCode * 59) + this.Articles.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.MsgType != null)
                {
                    hashCode = (hashCode * 59) + this.MsgType.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
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
