/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-25
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

namespace AlipaySDKNet.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDatadigitalFincloudGeneralsaasFaceVerificationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 人脸核身初始化
        /// </summary>
        /// <remarks>
        /// 人脸核身初始化接口
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datadigitalFincloudGeneralsaasFaceVerificationInitializeModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel</returns>
        DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel Initialize(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = default(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 人脸核身初始化
        /// </summary>
        /// <remarks>
        /// 人脸核身初始化接口
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datadigitalFincloudGeneralsaasFaceVerificationInitializeModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel</returns>
        ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel> InitializeWithHttpInfo(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = default(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 人脸核身结果查询
        /// </summary>
        /// <remarks>
        /// 查询核身结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certifyId">填入人脸核身初始化阶段获取到的certify_id (optional)</param>
        /// <param name="needAlivePhoto">是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图），默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel</returns>
        DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel Query(string certifyId = default(string), string needAlivePhoto = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 人脸核身结果查询
        /// </summary>
        /// <remarks>
        /// 查询核身结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certifyId">填入人脸核身初始化阶段获取到的certify_id (optional)</param>
        /// <param name="needAlivePhoto">是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图），默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel</returns>
        ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel> QueryWithHttpInfo(string certifyId = default(string), string needAlivePhoto = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDatadigitalFincloudGeneralsaasFaceVerificationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 人脸核身初始化
        /// </summary>
        /// <remarks>
        /// 人脸核身初始化接口
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datadigitalFincloudGeneralsaasFaceVerificationInitializeModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel</returns>
        System.Threading.Tasks.Task<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel> InitializeAsync(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = default(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 人脸核身初始化
        /// </summary>
        /// <remarks>
        /// 人脸核身初始化接口
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datadigitalFincloudGeneralsaasFaceVerificationInitializeModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel>> InitializeWithHttpInfoAsync(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = default(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        /// <summary>
        /// 人脸核身结果查询
        /// </summary>
        /// <remarks>
        /// 查询核身结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certifyId">填入人脸核身初始化阶段获取到的certify_id (optional)</param>
        /// <param name="needAlivePhoto">是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图），默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel</returns>
        System.Threading.Tasks.Task<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel> QueryAsync(string certifyId = default(string), string needAlivePhoto = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 人脸核身结果查询
        /// </summary>
        /// <remarks>
        /// 查询核身结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certifyId">填入人脸核身初始化阶段获取到的certify_id (optional)</param>
        /// <param name="needAlivePhoto">是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图），默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel>> QueryWithHttpInfoAsync(string certifyId = default(string), string needAlivePhoto = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDatadigitalFincloudGeneralsaasFaceVerificationApi : IDatadigitalFincloudGeneralsaasFaceVerificationApiSync, IDatadigitalFincloudGeneralsaasFaceVerificationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DatadigitalFincloudGeneralsaasFaceVerificationApi : IDatadigitalFincloudGeneralsaasFaceVerificationApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceVerificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DatadigitalFincloudGeneralsaasFaceVerificationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceVerificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DatadigitalFincloudGeneralsaasFaceVerificationApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceVerificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DatadigitalFincloudGeneralsaasFaceVerificationApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceVerificationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DatadigitalFincloudGeneralsaasFaceVerificationApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AlipaySDKNet.OpenAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// 人脸核身初始化 人脸核身初始化接口
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datadigitalFincloudGeneralsaasFaceVerificationInitializeModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel</returns>
        public DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel Initialize(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = default(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel> localVarResponse = InitializeWithHttpInfo(datadigitalFincloudGeneralsaasFaceVerificationInitializeModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 人脸核身初始化 人脸核身初始化接口
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datadigitalFincloudGeneralsaasFaceVerificationInitializeModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel> InitializeWithHttpInfo(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = default(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = datadigitalFincloudGeneralsaasFaceVerificationInitializeModel;
            }

            localVarRequestOptions.Operation = "DatadigitalFincloudGeneralsaasFaceVerificationApi.Initialize";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel>("/v3/datadigital/fincloud/generalsaas/face/verification/initialize", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Initialize", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = DatadigitalFincloudGeneralsaasFaceVerificationInitializeDefaultResponse.FromJson(exception.ErrorContent.ToString());
                        }
                        catch (Exception e)
                        {
                            AlipayLogger.logBizWarn("解析default body内容失败", e);
                        }
                    }
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 人脸核身初始化 人脸核身初始化接口
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datadigitalFincloudGeneralsaasFaceVerificationInitializeModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel</returns>
        public async System.Threading.Tasks.Task<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel> InitializeAsync(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = default(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel> localVarResponse = await InitializeWithHttpInfoAsync(datadigitalFincloudGeneralsaasFaceVerificationInitializeModel, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 人脸核身初始化 人脸核身初始化接口
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datadigitalFincloudGeneralsaasFaceVerificationInitializeModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel>> InitializeWithHttpInfoAsync(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel datadigitalFincloudGeneralsaasFaceVerificationInitializeModel = default(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {

            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = datadigitalFincloudGeneralsaasFaceVerificationInitializeModel;
            }

            localVarRequestOptions.Operation = "DatadigitalFincloudGeneralsaasFaceVerificationApi.Initialize";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<DatadigitalFincloudGeneralsaasFaceVerificationInitializeResponseModel>("/v3/datadigital/fincloud/generalsaas/face/verification/initialize", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Initialize", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 人脸核身结果查询 查询核身结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certifyId">填入人脸核身初始化阶段获取到的certify_id (optional)</param>
        /// <param name="needAlivePhoto">是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图），默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel</returns>
        public DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel Query(string certifyId = default(string), string needAlivePhoto = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel> localVarResponse = QueryWithHttpInfo(certifyId, needAlivePhoto, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 人脸核身结果查询 查询核身结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certifyId">填入人脸核身初始化阶段获取到的certify_id (optional)</param>
        /// <param name="needAlivePhoto">是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图），默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel> QueryWithHttpInfo(string certifyId = default(string), string needAlivePhoto = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (certifyId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "certify_id", certifyId));
            }
            if (needAlivePhoto != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "need_alive_photo", needAlivePhoto));
            }

            localVarRequestOptions.Operation = "DatadigitalFincloudGeneralsaasFaceVerificationApi.Query";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel>("/v3/datadigital/fincloud/generalsaas/face/verification/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = DatadigitalFincloudGeneralsaasFaceVerificationQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
                        }
                        catch (Exception e)
                        {
                            AlipayLogger.logBizWarn("解析default body内容失败", e);
                        }
                    }
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 人脸核身结果查询 查询核身结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certifyId">填入人脸核身初始化阶段获取到的certify_id (optional)</param>
        /// <param name="needAlivePhoto">是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图），默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel> QueryAsync(string certifyId = default(string), string needAlivePhoto = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(certifyId, needAlivePhoto, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 人脸核身结果查询 查询核身结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="certifyId">填入人脸核身初始化阶段获取到的certify_id (optional)</param>
        /// <param name="needAlivePhoto">是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图），默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel>> QueryWithHttpInfoAsync(string certifyId = default(string), string needAlivePhoto = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {

            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (certifyId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "certify_id", certifyId));
            }
            if (needAlivePhoto != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "need_alive_photo", needAlivePhoto));
            }

            localVarRequestOptions.Operation = "DatadigitalFincloudGeneralsaasFaceVerificationApi.Query";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<DatadigitalFincloudGeneralsaasFaceVerificationQueryResponseModel>("/v3/datadigital/fincloud/generalsaas/face/verification/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
