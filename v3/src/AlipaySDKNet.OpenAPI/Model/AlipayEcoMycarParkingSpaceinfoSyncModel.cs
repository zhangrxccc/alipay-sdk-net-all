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
    /// AlipayEcoMycarParkingSpaceinfoSyncModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingSpaceinfoSyncModel")]
    public partial class AlipayEcoMycarParkingSpaceinfoSyncModel : IEquatable<AlipayEcoMycarParkingSpaceinfoSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingSpaceinfoSyncModel" /> class.
        /// </summary>
        /// <param name="freeChargingPile">空闲充电桩车位数.</param>
        /// <param name="freeParkingSpace">车场空闲可用的车位数.</param>
        /// <param name="parkingId">停车场ID.</param>
        /// <param name="parkingSpaceStatus">停车场实时状态: 0 拥堵,1 正常，2 空闲.</param>
        public AlipayEcoMycarParkingSpaceinfoSyncModel(int freeChargingPile = default(int), int freeParkingSpace = default(int), string parkingId = default(string), string parkingSpaceStatus = default(string))
        {
            this.FreeChargingPile = freeChargingPile;
            this.FreeParkingSpace = freeParkingSpace;
            this.ParkingId = parkingId;
            this.ParkingSpaceStatus = parkingSpaceStatus;
        }

        /// <summary>
        /// 空闲充电桩车位数
        /// </summary>
        /// <value>空闲充电桩车位数</value>
        [DataMember(Name = "free_charging_pile", EmitDefaultValue = false)]
        public int FreeChargingPile { get; set; }

        /// <summary>
        /// 车场空闲可用的车位数
        /// </summary>
        /// <value>车场空闲可用的车位数</value>
        [DataMember(Name = "free_parking_space", EmitDefaultValue = false)]
        public int FreeParkingSpace { get; set; }

        /// <summary>
        /// 停车场ID
        /// </summary>
        /// <value>停车场ID</value>
        [DataMember(Name = "parking_id", EmitDefaultValue = false)]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场实时状态: 0 拥堵,1 正常，2 空闲
        /// </summary>
        /// <value>停车场实时状态: 0 拥堵,1 正常，2 空闲</value>
        [DataMember(Name = "parking_space_status", EmitDefaultValue = false)]
        public string ParkingSpaceStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingSpaceinfoSyncModel {\n");
            sb.Append("  FreeChargingPile: ").Append(FreeChargingPile).Append("\n");
            sb.Append("  FreeParkingSpace: ").Append(FreeParkingSpace).Append("\n");
            sb.Append("  ParkingId: ").Append(ParkingId).Append("\n");
            sb.Append("  ParkingSpaceStatus: ").Append(ParkingSpaceStatus).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingSpaceinfoSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingSpaceinfoSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingSpaceinfoSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingSpaceinfoSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FreeChargingPile == input.FreeChargingPile ||
                    this.FreeChargingPile.Equals(input.FreeChargingPile)
                ) && 
                (
                    this.FreeParkingSpace == input.FreeParkingSpace ||
                    this.FreeParkingSpace.Equals(input.FreeParkingSpace)
                ) && 
                (
                    this.ParkingId == input.ParkingId ||
                    (this.ParkingId != null &&
                    this.ParkingId.Equals(input.ParkingId))
                ) && 
                (
                    this.ParkingSpaceStatus == input.ParkingSpaceStatus ||
                    (this.ParkingSpaceStatus != null &&
                    this.ParkingSpaceStatus.Equals(input.ParkingSpaceStatus))
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
                hashCode = (hashCode * 59) + this.FreeChargingPile.GetHashCode();
                hashCode = (hashCode * 59) + this.FreeParkingSpace.GetHashCode();
                if (this.ParkingId != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingId.GetHashCode();
                }
                if (this.ParkingSpaceStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingSpaceStatus.GetHashCode();
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
