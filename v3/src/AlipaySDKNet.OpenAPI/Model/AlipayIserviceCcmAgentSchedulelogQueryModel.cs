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
    /// AlipayIserviceCcmAgentSchedulelogQueryModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmAgentSchedulelogQueryModel")]
    public partial class AlipayIserviceCcmAgentSchedulelogQueryModel : IEquatable<AlipayIserviceCcmAgentSchedulelogQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmAgentSchedulelogQueryModel" /> class.
        /// </summary>
        /// <param name="agentIds">客服id集合,限制最多100个id,不传查询部门下所有客服的状态变更流水日志.</param>
        /// <param name="ccsInstanceId">部门id（即租户实例ID、数据权限ID）.</param>
        /// <param name="endTime">客服状态变更结束时间,开始时间与结束时间间隔不能超过1天,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;.</param>
        /// <param name="limit">查询条数,最大100, 不传默认100.</param>
        /// <param name="pageNum">查询结果的页码，起始值为 1，默认值为 1.</param>
        /// <param name="pageSize">分页查询时设置的每页记录数，最大值 100 行，默认为 100.</param>
        /// <param name="startId">起始id,分页导出的起始客服状态变更流水id,第一页传0,翻页时传上一页结果的最大id.</param>
        /// <param name="startTime">客服状态变更开始时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;.</param>
        public AlipayIserviceCcmAgentSchedulelogQueryModel(List<string> agentIds = default(List<string>), string ccsInstanceId = default(string), string endTime = default(string), int limit = default(int), int pageNum = default(int), int pageSize = default(int), int startId = default(int), string startTime = default(string))
        {
            this.AgentIds = agentIds;
            this.CcsInstanceId = ccsInstanceId;
            this.EndTime = endTime;
            this.Limit = limit;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.StartId = startId;
            this.StartTime = startTime;
        }

        /// <summary>
        /// 客服id集合,限制最多100个id,不传查询部门下所有客服的状态变更流水日志
        /// </summary>
        /// <value>客服id集合,限制最多100个id,不传查询部门下所有客服的状态变更流水日志</value>
        [DataMember(Name = "agent_ids", EmitDefaultValue = false)]
        public List<string> AgentIds { get; set; }

        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        /// <value>部门id（即租户实例ID、数据权限ID）</value>
        [DataMember(Name = "ccs_instance_id", EmitDefaultValue = false)]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 客服状态变更结束时间,开始时间与结束时间间隔不能超过1天,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        /// <value>客服状态变更结束时间,开始时间与结束时间间隔不能超过1天,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询条数,最大100, 不传默认100
        /// </summary>
        /// <value>查询条数,最大100, 不传默认100</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// 查询结果的页码，起始值为 1，默认值为 1
        /// </summary>
        /// <value>查询结果的页码，起始值为 1，默认值为 1</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数，最大值 100 行，默认为 100
        /// </summary>
        /// <value>分页查询时设置的每页记录数，最大值 100 行，默认为 100</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 起始id,分页导出的起始客服状态变更流水id,第一页传0,翻页时传上一页结果的最大id
        /// </summary>
        /// <value>起始id,分页导出的起始客服状态变更流水id,第一页传0,翻页时传上一页结果的最大id</value>
        [DataMember(Name = "start_id", EmitDefaultValue = false)]
        public int StartId { get; set; }

        /// <summary>
        /// 客服状态变更开始时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// </summary>
        /// <value>客服状态变更开始时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmAgentSchedulelogQueryModel {\n");
            sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
            sb.Append("  CcsInstanceId: ").Append(CcsInstanceId).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  StartId: ").Append(StartId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmAgentSchedulelogQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmAgentSchedulelogQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmAgentSchedulelogQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmAgentSchedulelogQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgentIds == input.AgentIds ||
                    this.AgentIds != null &&
                    input.AgentIds != null &&
                    this.AgentIds.SequenceEqual(input.AgentIds)
                ) && 
                (
                    this.CcsInstanceId == input.CcsInstanceId ||
                    (this.CcsInstanceId != null &&
                    this.CcsInstanceId.Equals(input.CcsInstanceId))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.StartId == input.StartId ||
                    this.StartId.Equals(input.StartId)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.AgentIds != null)
                {
                    hashCode = (hashCode * 59) + this.AgentIds.GetHashCode();
                }
                if (this.CcsInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.CcsInstanceId.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.StartId.GetHashCode();
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
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
