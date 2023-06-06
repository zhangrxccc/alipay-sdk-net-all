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
    /// KoubeiTradeOrderConsultModel
    /// </summary>
    [DataContract(Name = "KoubeiTradeOrderConsultModel")]
    public partial class KoubeiTradeOrderConsultModel : IEquatable<KoubeiTradeOrderConsultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KoubeiTradeOrderConsultModel" /> class.
        /// </summary>
        /// <param name="apdidToken">用户设备信息,通过钱包容器提供的JSAPI接口获取，  一、接口使用方法：  AlipayJSBridge.call(&#39;getO2ODeviceToken&#39;, {                  appName: &#39;kb_isv_110229&#39;,                  appKey:&#39;98y6VvdaDLpoqWZw&#39;              },              function (result) {                   }          );      });  二、result数据结构：   1、调用失败： {\&quot;error\&quot;:xxx,\&quot;errorMessage\&quot;:\&quot;xxx\&quot;}     2、调用成功： {&#39;appToken&#39;:&#39;xxxssajkjkjkxdkwqkqwb&#39;}.</param>
        /// <param name="goodsInfo">商品明细列表。注意：单品总金额不能大于订单金额.</param>
        /// <param name="requestId">唯一请求id，开放者请确保每次请求的唯一性。.</param>
        /// <param name="shopId">支付宝门店编号.</param>
        /// <param name="totalAmount">订单总金额，单位元，精确到小数点后两位，取值范围[0.01,999999999]。 注意：如果同时传入了【不可打折金额】，【订单总金额】两者，则必须满足【不可打折金额】&lt;&#x3D;【订单总金额】。.</param>
        /// <param name="undiscountableAmount">不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0,999999999]。 注意：如果同时传入了【不可打折金额】、【订单总金额】，则必须满足【不可打折金额】&lt;&#x3D;【订单总金额】。.</param>
        /// <param name="userId">支付宝用户 Id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。.</param>
        public KoubeiTradeOrderConsultModel(string apdidToken = default(string), List<GoodsInfo> goodsInfo = default(List<GoodsInfo>), string requestId = default(string), string shopId = default(string), string totalAmount = default(string), string undiscountableAmount = default(string), string userId = default(string))
        {
            this.ApdidToken = apdidToken;
            this.GoodsInfo = goodsInfo;
            this.RequestId = requestId;
            this.ShopId = shopId;
            this.TotalAmount = totalAmount;
            this.UndiscountableAmount = undiscountableAmount;
            this.UserId = userId;
        }

        /// <summary>
        /// 用户设备信息,通过钱包容器提供的JSAPI接口获取，  一、接口使用方法：  AlipayJSBridge.call(&#39;getO2ODeviceToken&#39;, {                  appName: &#39;kb_isv_110229&#39;,                  appKey:&#39;98y6VvdaDLpoqWZw&#39;              },              function (result) {                   }          );      });  二、result数据结构：   1、调用失败： {\&quot;error\&quot;:xxx,\&quot;errorMessage\&quot;:\&quot;xxx\&quot;}     2、调用成功： {&#39;appToken&#39;:&#39;xxxssajkjkjkxdkwqkqwb&#39;}
        /// </summary>
        /// <value>用户设备信息,通过钱包容器提供的JSAPI接口获取，  一、接口使用方法：  AlipayJSBridge.call(&#39;getO2ODeviceToken&#39;, {                  appName: &#39;kb_isv_110229&#39;,                  appKey:&#39;98y6VvdaDLpoqWZw&#39;              },              function (result) {                   }          );      });  二、result数据结构：   1、调用失败： {\&quot;error\&quot;:xxx,\&quot;errorMessage\&quot;:\&quot;xxx\&quot;}     2、调用成功： {&#39;appToken&#39;:&#39;xxxssajkjkjkxdkwqkqwb&#39;}</value>
        [DataMember(Name = "apdid_token", EmitDefaultValue = false)]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 商品明细列表。注意：单品总金额不能大于订单金额
        /// </summary>
        /// <value>商品明细列表。注意：单品总金额不能大于订单金额</value>
        [DataMember(Name = "goods_info", EmitDefaultValue = false)]
        public List<GoodsInfo> GoodsInfo { get; set; }

        /// <summary>
        /// 唯一请求id，开放者请确保每次请求的唯一性。
        /// </summary>
        /// <value>唯一请求id，开放者请确保每次请求的唯一性。</value>
        [DataMember(Name = "request_id", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 支付宝门店编号
        /// </summary>
        /// <value>支付宝门店编号</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// 订单总金额，单位元，精确到小数点后两位，取值范围[0.01,999999999]。 注意：如果同时传入了【不可打折金额】，【订单总金额】两者，则必须满足【不可打折金额】&lt;&#x3D;【订单总金额】。
        /// </summary>
        /// <value>订单总金额，单位元，精确到小数点后两位，取值范围[0.01,999999999]。 注意：如果同时传入了【不可打折金额】，【订单总金额】两者，则必须满足【不可打折金额】&lt;&#x3D;【订单总金额】。</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0,999999999]。 注意：如果同时传入了【不可打折金额】、【订单总金额】，则必须满足【不可打折金额】&lt;&#x3D;【订单总金额】。
        /// </summary>
        /// <value>不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0,999999999]。 注意：如果同时传入了【不可打折金额】、【订单总金额】，则必须满足【不可打折金额】&lt;&#x3D;【订单总金额】。</value>
        [DataMember(Name = "undiscountable_amount", EmitDefaultValue = false)]
        public string UndiscountableAmount { get; set; }

        /// <summary>
        /// 支付宝用户 Id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        /// <value>支付宝用户 Id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KoubeiTradeOrderConsultModel {\n");
            sb.Append("  ApdidToken: ").Append(ApdidToken).Append("\n");
            sb.Append("  GoodsInfo: ").Append(GoodsInfo).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  UndiscountableAmount: ").Append(UndiscountableAmount).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as KoubeiTradeOrderConsultModel);
        }

        /// <summary>
        /// Returns true if KoubeiTradeOrderConsultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of KoubeiTradeOrderConsultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KoubeiTradeOrderConsultModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApdidToken == input.ApdidToken ||
                    (this.ApdidToken != null &&
                    this.ApdidToken.Equals(input.ApdidToken))
                ) && 
                (
                    this.GoodsInfo == input.GoodsInfo ||
                    this.GoodsInfo != null &&
                    input.GoodsInfo != null &&
                    this.GoodsInfo.SequenceEqual(input.GoodsInfo)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.UndiscountableAmount == input.UndiscountableAmount ||
                    (this.UndiscountableAmount != null &&
                    this.UndiscountableAmount.Equals(input.UndiscountableAmount))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.ApdidToken != null)
                {
                    hashCode = (hashCode * 59) + this.ApdidToken.GetHashCode();
                }
                if (this.GoodsInfo != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsInfo.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.UndiscountableAmount != null)
                {
                    hashCode = (hashCode * 59) + this.UndiscountableAmount.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
