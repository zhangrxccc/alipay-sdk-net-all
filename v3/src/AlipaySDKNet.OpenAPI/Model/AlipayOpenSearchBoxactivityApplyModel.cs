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
    /// AlipayOpenSearchBoxactivityApplyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchBoxactivityApplyModel")]
    public partial class AlipayOpenSearchBoxactivityApplyModel : IEquatable<AlipayOpenSearchBoxactivityApplyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchBoxactivityApplyModel" /> class.
        /// </summary>
        /// <param name="actionUrl">活动链接，必须为关联的小程序的页面链接（链接以 alipays 开头），可参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/support/01rb18\&quot;&gt; 小程序scheme链接介绍 &lt;/a&gt;.</param>
        /// <param name="backgroundWord">创建banner活动时，可添加底纹推广词，有机会在首页搜索框内展示，提升banner活动曝光机会.</param>
        /// <param name="boxId">搜索直达配置id.</param>
        /// <param name="endTime">活动结束时间，开始和结束时间之间不得超过90天.</param>
        /// <param name="materialId">当material_type&#x3D;\&quot;IMAGE\&quot;时，为图片id；当material_type&#x3D;\&quot;VIDEO\&quot;时，为视频id。小程序直达仅支持图片类型。图片id可以通过调用&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03hvl1?ref&#x3D;api\&quot;&gt; 支付宝文件上传接口 &lt;/a&gt;上传图片，获取图片id(bizCode：search_box_banner)。&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/b/03al6f\&quot;&gt; 图片规范 &lt;/a&gt;.</param>
        /// <param name="materialType">IMAGE-图片/VIDEO-视频.</param>
        /// <param name="merchantId">商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。.</param>
        /// <param name="startTime">活动开始时间，开始和结束时间之间不得超过90天.</param>
        /// <param name="targetAppid">跳转应用ID.</param>
        /// <param name="targetAppname">跳转小程序名称.</param>
        /// <param name="targetRegions">投放目标区域列表.</param>
        /// <param name="title">活动标题.</param>
        /// <param name="videoInfo">videoInfo.</param>
        public AlipayOpenSearchBoxactivityApplyModel(string actionUrl = default(string), string backgroundWord = default(string), string boxId = default(string), string endTime = default(string), string materialId = default(string), string materialType = default(string), string merchantId = default(string), string startTime = default(string), string targetAppid = default(string), string targetAppname = default(string), List<DeliveryTargetRegion> targetRegions = default(List<DeliveryTargetRegion>), string title = default(string), SearchBoxActivityVideoInfo videoInfo = default(SearchBoxActivityVideoInfo))
        {
            this.ActionUrl = actionUrl;
            this.BackgroundWord = backgroundWord;
            this.BoxId = boxId;
            this.EndTime = endTime;
            this.MaterialId = materialId;
            this.MaterialType = materialType;
            this.MerchantId = merchantId;
            this.StartTime = startTime;
            this.TargetAppid = targetAppid;
            this.TargetAppname = targetAppname;
            this.TargetRegions = targetRegions;
            this.Title = title;
            this.VideoInfo = videoInfo;
        }

        /// <summary>
        /// 活动链接，必须为关联的小程序的页面链接（链接以 alipays 开头），可参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/support/01rb18\&quot;&gt; 小程序scheme链接介绍 &lt;/a&gt;
        /// </summary>
        /// <value>活动链接，必须为关联的小程序的页面链接（链接以 alipays 开头），可参考&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/support/01rb18\&quot;&gt; 小程序scheme链接介绍 &lt;/a&gt;</value>
        [DataMember(Name = "action_url", EmitDefaultValue = false)]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 创建banner活动时，可添加底纹推广词，有机会在首页搜索框内展示，提升banner活动曝光机会
        /// </summary>
        /// <value>创建banner活动时，可添加底纹推广词，有机会在首页搜索框内展示，提升banner活动曝光机会</value>
        [DataMember(Name = "background_word", EmitDefaultValue = false)]
        public string BackgroundWord { get; set; }

        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        /// <value>搜索直达配置id</value>
        [DataMember(Name = "box_id", EmitDefaultValue = false)]
        public string BoxId { get; set; }

        /// <summary>
        /// 活动结束时间，开始和结束时间之间不得超过90天
        /// </summary>
        /// <value>活动结束时间，开始和结束时间之间不得超过90天</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 当material_type&#x3D;\&quot;IMAGE\&quot;时，为图片id；当material_type&#x3D;\&quot;VIDEO\&quot;时，为视频id。小程序直达仅支持图片类型。图片id可以通过调用&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03hvl1?ref&#x3D;api\&quot;&gt; 支付宝文件上传接口 &lt;/a&gt;上传图片，获取图片id(bizCode：search_box_banner)。&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/b/03al6f\&quot;&gt; 图片规范 &lt;/a&gt;
        /// </summary>
        /// <value>当material_type&#x3D;\&quot;IMAGE\&quot;时，为图片id；当material_type&#x3D;\&quot;VIDEO\&quot;时，为视频id。小程序直达仅支持图片类型。图片id可以通过调用&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/03hvl1?ref&#x3D;api\&quot;&gt; 支付宝文件上传接口 &lt;/a&gt;上传图片，获取图片id(bizCode：search_box_banner)。&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/b/03al6f\&quot;&gt; 图片规范 &lt;/a&gt;</value>
        [DataMember(Name = "material_id", EmitDefaultValue = false)]
        public string MaterialId { get; set; }

        /// <summary>
        /// IMAGE-图片/VIDEO-视频
        /// </summary>
        /// <value>IMAGE-图片/VIDEO-视频</value>
        [DataMember(Name = "material_type", EmitDefaultValue = false)]
        public string MaterialType { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。
        /// </summary>
        /// <value>商户id，代运营模式下传入。代运营模式，需要服务商已获得商家\&quot;运营支付宝小程序\&quot;授权。</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 活动开始时间，开始和结束时间之间不得超过90天
        /// </summary>
        /// <value>活动开始时间，开始和结束时间之间不得超过90天</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 跳转应用ID
        /// </summary>
        /// <value>跳转应用ID</value>
        [DataMember(Name = "target_appid", EmitDefaultValue = false)]
        public string TargetAppid { get; set; }

        /// <summary>
        /// 跳转小程序名称
        /// </summary>
        /// <value>跳转小程序名称</value>
        [DataMember(Name = "target_appname", EmitDefaultValue = false)]
        public string TargetAppname { get; set; }

        /// <summary>
        /// 投放目标区域列表
        /// </summary>
        /// <value>投放目标区域列表</value>
        [DataMember(Name = "target_regions", EmitDefaultValue = false)]
        public List<DeliveryTargetRegion> TargetRegions { get; set; }

        /// <summary>
        /// 活动标题
        /// </summary>
        /// <value>活动标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets VideoInfo
        /// </summary>
        [DataMember(Name = "video_info", EmitDefaultValue = false)]
        public SearchBoxActivityVideoInfo VideoInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchBoxactivityApplyModel {\n");
            sb.Append("  ActionUrl: ").Append(ActionUrl).Append("\n");
            sb.Append("  BackgroundWord: ").Append(BackgroundWord).Append("\n");
            sb.Append("  BoxId: ").Append(BoxId).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  MaterialId: ").Append(MaterialId).Append("\n");
            sb.Append("  MaterialType: ").Append(MaterialType).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  TargetAppid: ").Append(TargetAppid).Append("\n");
            sb.Append("  TargetAppname: ").Append(TargetAppname).Append("\n");
            sb.Append("  TargetRegions: ").Append(TargetRegions).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  VideoInfo: ").Append(VideoInfo).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchBoxactivityApplyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchBoxactivityApplyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchBoxactivityApplyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchBoxactivityApplyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionUrl == input.ActionUrl ||
                    (this.ActionUrl != null &&
                    this.ActionUrl.Equals(input.ActionUrl))
                ) && 
                (
                    this.BackgroundWord == input.BackgroundWord ||
                    (this.BackgroundWord != null &&
                    this.BackgroundWord.Equals(input.BackgroundWord))
                ) && 
                (
                    this.BoxId == input.BoxId ||
                    (this.BoxId != null &&
                    this.BoxId.Equals(input.BoxId))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.MaterialId == input.MaterialId ||
                    (this.MaterialId != null &&
                    this.MaterialId.Equals(input.MaterialId))
                ) && 
                (
                    this.MaterialType == input.MaterialType ||
                    (this.MaterialType != null &&
                    this.MaterialType.Equals(input.MaterialType))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.TargetAppid == input.TargetAppid ||
                    (this.TargetAppid != null &&
                    this.TargetAppid.Equals(input.TargetAppid))
                ) && 
                (
                    this.TargetAppname == input.TargetAppname ||
                    (this.TargetAppname != null &&
                    this.TargetAppname.Equals(input.TargetAppname))
                ) && 
                (
                    this.TargetRegions == input.TargetRegions ||
                    this.TargetRegions != null &&
                    input.TargetRegions != null &&
                    this.TargetRegions.SequenceEqual(input.TargetRegions)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.VideoInfo == input.VideoInfo ||
                    (this.VideoInfo != null &&
                    this.VideoInfo.Equals(input.VideoInfo))
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
                if (this.ActionUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ActionUrl.GetHashCode();
                }
                if (this.BackgroundWord != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundWord.GetHashCode();
                }
                if (this.BoxId != null)
                {
                    hashCode = (hashCode * 59) + this.BoxId.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.MaterialId != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialId.GetHashCode();
                }
                if (this.MaterialType != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialType.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.TargetAppid != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAppid.GetHashCode();
                }
                if (this.TargetAppname != null)
                {
                    hashCode = (hashCode * 59) + this.TargetAppname.GetHashCode();
                }
                if (this.TargetRegions != null)
                {
                    hashCode = (hashCode * 59) + this.TargetRegions.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.VideoInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VideoInfo.GetHashCode();
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
