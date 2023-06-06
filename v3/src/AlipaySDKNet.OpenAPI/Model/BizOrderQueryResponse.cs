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
    /// BizOrderQueryResponse
    /// </summary>
    [DataContract(Name = "BizOrderQueryResponse")]
    public partial class BizOrderQueryResponse : IEquatable<BizOrderQueryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BizOrderQueryResponse" /> class.
        /// </summary>
        /// <param name="action">操作动作。  CREATE_SHOP-创建门店，  MODIFY_SHOP-修改门店，  CREATE_ITEM-创建商品，  MODIFY_ITEM-修改商品，  EFFECTIVE_ITEM-上架商品，  INVALID_ITEM-下架商品，  RESUME_ITEM-暂停售卖商品，  PAUSE_ITEM-恢复售卖商品.</param>
        /// <param name="actionMode">操作模式：NORMAL-普通开店.</param>
        /// <param name="applyId">支付宝流水ID.</param>
        /// <param name="bizContextInfo">流水上下文信息，JSON格式。根据action不同对应的结构也不同，JSON字段与含义可参考各个接口的请求参数。.</param>
        /// <param name="bizId">业务主体ID。根据biz_type不同可能对应shop_id或item_id。  特别注意对于门店创建，当流水status&#x3D;SUCCESS时，此字段才为shop_id，其他状态时为0或空。.</param>
        /// <param name="bizType">业务类型：SHOP-店铺，ITEM-商品.</param>
        /// <param name="createTime">创建时间.</param>
        /// <param name="opId">操作用户的支付账号id.</param>
        /// <param name="requestId">注意：此字段并非外部商户请求时传入的request_id，暂时代表支付宝内部字段，请勿用。.</param>
        /// <param name="resultCode">流水处理结果码  &lt;a href&#x3D;\&quot;https://doc.open.alipay.com/doc2/detail.htm?spm&#x3D;a219a.7629140.0.0.lL9hGI&amp;treeId&#x3D;78&amp;articleId&#x3D;103834&amp;docType&#x3D;1#s2\&quot;&gt;点此查看&lt;/a&gt;.</param>
        /// <param name="resultDesc">流水处理结果描述.</param>
        /// <param name="status">流水状态：INIT-初始，PROCESS-处理中，SUCCESS-成功，FAIL-失败。.</param>
        /// <param name="subStatus">流水子状态：WAIT_CERTIFY-等待认证，LICENSE_AUDITING-证照审核中，RISK_AUDITING-风控审核中，WAIT_SIGN-等待签约，FINISH-终结。.</param>
        /// <param name="updateTime">更新时间.</param>
        public BizOrderQueryResponse(string action = default(string), string actionMode = default(string), string applyId = default(string), string bizContextInfo = default(string), string bizId = default(string), string bizType = default(string), string createTime = default(string), string opId = default(string), string requestId = default(string), string resultCode = default(string), string resultDesc = default(string), string status = default(string), string subStatus = default(string), string updateTime = default(string))
        {
            this.Action = action;
            this.ActionMode = actionMode;
            this.ApplyId = applyId;
            this.BizContextInfo = bizContextInfo;
            this.BizId = bizId;
            this.BizType = bizType;
            this.CreateTime = createTime;
            this.OpId = opId;
            this.RequestId = requestId;
            this.ResultCode = resultCode;
            this.ResultDesc = resultDesc;
            this.Status = status;
            this.SubStatus = subStatus;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// 操作动作。  CREATE_SHOP-创建门店，  MODIFY_SHOP-修改门店，  CREATE_ITEM-创建商品，  MODIFY_ITEM-修改商品，  EFFECTIVE_ITEM-上架商品，  INVALID_ITEM-下架商品，  RESUME_ITEM-暂停售卖商品，  PAUSE_ITEM-恢复售卖商品
        /// </summary>
        /// <value>操作动作。  CREATE_SHOP-创建门店，  MODIFY_SHOP-修改门店，  CREATE_ITEM-创建商品，  MODIFY_ITEM-修改商品，  EFFECTIVE_ITEM-上架商品，  INVALID_ITEM-下架商品，  RESUME_ITEM-暂停售卖商品，  PAUSE_ITEM-恢复售卖商品</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// 操作模式：NORMAL-普通开店
        /// </summary>
        /// <value>操作模式：NORMAL-普通开店</value>
        [DataMember(Name = "action_mode", EmitDefaultValue = false)]
        public string ActionMode { get; set; }

        /// <summary>
        /// 支付宝流水ID
        /// </summary>
        /// <value>支付宝流水ID</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 流水上下文信息，JSON格式。根据action不同对应的结构也不同，JSON字段与含义可参考各个接口的请求参数。
        /// </summary>
        /// <value>流水上下文信息，JSON格式。根据action不同对应的结构也不同，JSON字段与含义可参考各个接口的请求参数。</value>
        [DataMember(Name = "biz_context_info", EmitDefaultValue = false)]
        public string BizContextInfo { get; set; }

        /// <summary>
        /// 业务主体ID。根据biz_type不同可能对应shop_id或item_id。  特别注意对于门店创建，当流水status&#x3D;SUCCESS时，此字段才为shop_id，其他状态时为0或空。
        /// </summary>
        /// <value>业务主体ID。根据biz_type不同可能对应shop_id或item_id。  特别注意对于门店创建，当流水status&#x3D;SUCCESS时，此字段才为shop_id，其他状态时为0或空。</value>
        [DataMember(Name = "biz_id", EmitDefaultValue = false)]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型：SHOP-店铺，ITEM-商品
        /// </summary>
        /// <value>业务类型：SHOP-店铺，ITEM-商品</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
        /// </summary>
        /// <value>操作用户的支付账号id</value>
        [DataMember(Name = "op_id", EmitDefaultValue = false)]
        public string OpId { get; set; }

        /// <summary>
        /// 注意：此字段并非外部商户请求时传入的request_id，暂时代表支付宝内部字段，请勿用。
        /// </summary>
        /// <value>注意：此字段并非外部商户请求时传入的request_id，暂时代表支付宝内部字段，请勿用。</value>
        [DataMember(Name = "request_id", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 流水处理结果码  &lt;a href&#x3D;\&quot;https://doc.open.alipay.com/doc2/detail.htm?spm&#x3D;a219a.7629140.0.0.lL9hGI&amp;treeId&#x3D;78&amp;articleId&#x3D;103834&amp;docType&#x3D;1#s2\&quot;&gt;点此查看&lt;/a&gt;
        /// </summary>
        /// <value>流水处理结果码  &lt;a href&#x3D;\&quot;https://doc.open.alipay.com/doc2/detail.htm?spm&#x3D;a219a.7629140.0.0.lL9hGI&amp;treeId&#x3D;78&amp;articleId&#x3D;103834&amp;docType&#x3D;1#s2\&quot;&gt;点此查看&lt;/a&gt;</value>
        [DataMember(Name = "result_code", EmitDefaultValue = false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 流水处理结果描述
        /// </summary>
        /// <value>流水处理结果描述</value>
        [DataMember(Name = "result_desc", EmitDefaultValue = false)]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 流水状态：INIT-初始，PROCESS-处理中，SUCCESS-成功，FAIL-失败。
        /// </summary>
        /// <value>流水状态：INIT-初始，PROCESS-处理中，SUCCESS-成功，FAIL-失败。</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 流水子状态：WAIT_CERTIFY-等待认证，LICENSE_AUDITING-证照审核中，RISK_AUDITING-风控审核中，WAIT_SIGN-等待签约，FINISH-终结。
        /// </summary>
        /// <value>流水子状态：WAIT_CERTIFY-等待认证，LICENSE_AUDITING-证照审核中，RISK_AUDITING-风控审核中，WAIT_SIGN-等待签约，FINISH-终结。</value>
        [DataMember(Name = "sub_status", EmitDefaultValue = false)]
        public string SubStatus { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        /// <value>更新时间</value>
        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BizOrderQueryResponse {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionMode: ").Append(ActionMode).Append("\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  BizContextInfo: ").Append(BizContextInfo).Append("\n");
            sb.Append("  BizId: ").Append(BizId).Append("\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  OpId: ").Append(OpId).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  ResultDesc: ").Append(ResultDesc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubStatus: ").Append(SubStatus).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
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
            return this.Equals(input as BizOrderQueryResponse);
        }

        /// <summary>
        /// Returns true if BizOrderQueryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BizOrderQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BizOrderQueryResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ActionMode == input.ActionMode ||
                    (this.ActionMode != null &&
                    this.ActionMode.Equals(input.ActionMode))
                ) && 
                (
                    this.ApplyId == input.ApplyId ||
                    (this.ApplyId != null &&
                    this.ApplyId.Equals(input.ApplyId))
                ) && 
                (
                    this.BizContextInfo == input.BizContextInfo ||
                    (this.BizContextInfo != null &&
                    this.BizContextInfo.Equals(input.BizContextInfo))
                ) && 
                (
                    this.BizId == input.BizId ||
                    (this.BizId != null &&
                    this.BizId.Equals(input.BizId))
                ) && 
                (
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.OpId == input.OpId ||
                    (this.OpId != null &&
                    this.OpId.Equals(input.OpId))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    this.ResultDesc == input.ResultDesc ||
                    (this.ResultDesc != null &&
                    this.ResultDesc.Equals(input.ResultDesc))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubStatus == input.SubStatus ||
                    (this.SubStatus != null &&
                    this.SubStatus.Equals(input.SubStatus))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.ActionMode != null)
                {
                    hashCode = (hashCode * 59) + this.ActionMode.GetHashCode();
                }
                if (this.ApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyId.GetHashCode();
                }
                if (this.BizContextInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BizContextInfo.GetHashCode();
                }
                if (this.BizId != null)
                {
                    hashCode = (hashCode * 59) + this.BizId.GetHashCode();
                }
                if (this.BizType != null)
                {
                    hashCode = (hashCode * 59) + this.BizType.GetHashCode();
                }
                if (this.CreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                }
                if (this.OpId != null)
                {
                    hashCode = (hashCode * 59) + this.OpId.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.ResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                }
                if (this.ResultDesc != null)
                {
                    hashCode = (hashCode * 59) + this.ResultDesc.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.SubStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SubStatus.GetHashCode();
                }
                if (this.UpdateTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateTime.GetHashCode();
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
