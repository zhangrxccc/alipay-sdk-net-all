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
    /// AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse
    /// </summary>
    [JsonConverter(typeof(AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponseJsonConverter))]
    [DataContract(Name = "alipay_iservice_ccm_sw_treecategory_batchquery_default_response")]
    public partial class AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse : AbstractOpenAPISchema, IEquatable<AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse" /> class
        /// with the <see cref="AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel.</param>
        public AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse(AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse" /> class
        /// with the <see cref="CommonErrorType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CommonErrorType.</param>
        public AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse(CommonErrorType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CommonErrorType))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel, CommonErrorType");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel`. If the actual instance is not `AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel</returns>
        public AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel GetAlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel()
        {
            return (AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CommonErrorType`. If the actual instance is not `CommonErrorType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CommonErrorType</returns>
        public CommonErrorType GetCommonErrorType()
        {
            return (CommonErrorType)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse</returns>
        public static AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse FromJson(string jsonString)
        {
            AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse newAlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse;
            }

            try
            {
                newAlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse = new AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse(JsonConvert.DeserializeObject<AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel>(jsonString, AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AlipayIserviceCcmSwTreecategoryBatchqueryErrorResponseModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse = new AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse(JsonConvert.DeserializeObject<CommonErrorType>(jsonString, AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CommonErrorType: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse
    /// </summary>
    public class AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return AlipayIserviceCcmSwTreecategoryBatchqueryDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
