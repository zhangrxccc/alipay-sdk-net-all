/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-06-06
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
    public interface IZhimaCreditPeZmgoAgreementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 芝麻Go协议查询接口
        /// </summary>
        /// <remarks>
        /// 用户已经开通芝麻GO后，通过此接口查询协议。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional)</param>
        /// <param name="alipayUserId">买家在支付宝的用户id (optional)</param>
        /// <param name="openId">买家在支付宝的用户id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCreditPeZmgoAgreementQueryResponseModel</returns>
        ZhimaCreditPeZmgoAgreementQueryResponseModel Query(string agreementId = default(string), string alipayUserId = default(string), string openId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 芝麻Go协议查询接口
        /// </summary>
        /// <remarks>
        /// 用户已经开通芝麻GO后，通过此接口查询协议。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional)</param>
        /// <param name="alipayUserId">买家在支付宝的用户id (optional)</param>
        /// <param name="openId">买家在支付宝的用户id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCreditPeZmgoAgreementQueryResponseModel</returns>
        ApiResponse<ZhimaCreditPeZmgoAgreementQueryResponseModel> QueryWithHttpInfo(string agreementId = default(string), string alipayUserId = default(string), string openId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 芝麻GO协议解约
        /// </summary>
        /// <remarks>
        /// 芝麻GO协议解约
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPeZmgoAgreementUnsignModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCreditPeZmgoAgreementUnsignResponseModel</returns>
        ZhimaCreditPeZmgoAgreementUnsignResponseModel Unsign(ZhimaCreditPeZmgoAgreementUnsignModel zhimaCreditPeZmgoAgreementUnsignModel = default(ZhimaCreditPeZmgoAgreementUnsignModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 芝麻GO协议解约
        /// </summary>
        /// <remarks>
        /// 芝麻GO协议解约
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPeZmgoAgreementUnsignModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCreditPeZmgoAgreementUnsignResponseModel</returns>
        ApiResponse<ZhimaCreditPeZmgoAgreementUnsignResponseModel> UnsignWithHttpInfo(ZhimaCreditPeZmgoAgreementUnsignModel zhimaCreditPeZmgoAgreementUnsignModel = default(ZhimaCreditPeZmgoAgreementUnsignModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZhimaCreditPeZmgoAgreementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 芝麻Go协议查询接口
        /// </summary>
        /// <remarks>
        /// 用户已经开通芝麻GO后，通过此接口查询协议。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional)</param>
        /// <param name="alipayUserId">买家在支付宝的用户id (optional)</param>
        /// <param name="openId">买家在支付宝的用户id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ZhimaCreditPeZmgoAgreementQueryResponseModel</returns>
        System.Threading.Tasks.Task<ZhimaCreditPeZmgoAgreementQueryResponseModel> QueryAsync(string agreementId = default(string), string alipayUserId = default(string), string openId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 芝麻Go协议查询接口
        /// </summary>
        /// <remarks>
        /// 用户已经开通芝麻GO后，通过此接口查询协议。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional)</param>
        /// <param name="alipayUserId">买家在支付宝的用户id (optional)</param>
        /// <param name="openId">买家在支付宝的用户id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (ZhimaCreditPeZmgoAgreementQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<ZhimaCreditPeZmgoAgreementQueryResponseModel>> QueryWithHttpInfoAsync(string agreementId = default(string), string alipayUserId = default(string), string openId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        /// <summary>
        /// 芝麻GO协议解约
        /// </summary>
        /// <remarks>
        /// 芝麻GO协议解约
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPeZmgoAgreementUnsignModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ZhimaCreditPeZmgoAgreementUnsignResponseModel</returns>
        System.Threading.Tasks.Task<ZhimaCreditPeZmgoAgreementUnsignResponseModel> UnsignAsync(ZhimaCreditPeZmgoAgreementUnsignModel zhimaCreditPeZmgoAgreementUnsignModel = default(ZhimaCreditPeZmgoAgreementUnsignModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 芝麻GO协议解约
        /// </summary>
        /// <remarks>
        /// 芝麻GO协议解约
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPeZmgoAgreementUnsignModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (ZhimaCreditPeZmgoAgreementUnsignResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<ZhimaCreditPeZmgoAgreementUnsignResponseModel>> UnsignWithHttpInfoAsync(ZhimaCreditPeZmgoAgreementUnsignModel zhimaCreditPeZmgoAgreementUnsignModel = default(ZhimaCreditPeZmgoAgreementUnsignModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZhimaCreditPeZmgoAgreementApi : IZhimaCreditPeZmgoAgreementApiSync, IZhimaCreditPeZmgoAgreementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ZhimaCreditPeZmgoAgreementApi : IZhimaCreditPeZmgoAgreementApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoAgreementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaCreditPeZmgoAgreementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoAgreementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaCreditPeZmgoAgreementApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoAgreementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZhimaCreditPeZmgoAgreementApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoAgreementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ZhimaCreditPeZmgoAgreementApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 芝麻Go协议查询接口 用户已经开通芝麻GO后，通过此接口查询协议。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional)</param>
        /// <param name="alipayUserId">买家在支付宝的用户id (optional)</param>
        /// <param name="openId">买家在支付宝的用户id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCreditPeZmgoAgreementQueryResponseModel</returns>
        public ZhimaCreditPeZmgoAgreementQueryResponseModel Query(string agreementId = default(string), string alipayUserId = default(string), string openId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPeZmgoAgreementQueryResponseModel> localVarResponse = QueryWithHttpInfo(agreementId, alipayUserId, openId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 芝麻Go协议查询接口 用户已经开通芝麻GO后，通过此接口查询协议。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional)</param>
        /// <param name="alipayUserId">买家在支付宝的用户id (optional)</param>
        /// <param name="openId">买家在支付宝的用户id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCreditPeZmgoAgreementQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPeZmgoAgreementQueryResponseModel> QueryWithHttpInfo(string agreementId = default(string), string alipayUserId = default(string), string openId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (agreementId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_id", agreementId));
            }
            if (alipayUserId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "alipay_user_id", alipayUserId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }

            localVarRequestOptions.Operation = "ZhimaCreditPeZmgoAgreementApi.Query";
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
            var localVarResponse = this.Client.Get<ZhimaCreditPeZmgoAgreementQueryResponseModel>("/v3/zhima/credit/pe/zmgo/agreement/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = ZhimaCreditPeZmgoAgreementQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 芝麻Go协议查询接口 用户已经开通芝麻GO后，通过此接口查询协议。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional)</param>
        /// <param name="alipayUserId">买家在支付宝的用户id (optional)</param>
        /// <param name="openId">买家在支付宝的用户id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ZhimaCreditPeZmgoAgreementQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<ZhimaCreditPeZmgoAgreementQueryResponseModel> QueryAsync(string agreementId = default(string), string alipayUserId = default(string), string openId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPeZmgoAgreementQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(agreementId, alipayUserId, openId, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 芝麻Go协议查询接口 用户已经开通芝麻GO后，通过此接口查询协议。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员。传入该参数，会忽略其它所有参数。 (optional)</param>
        /// <param name="alipayUserId">买家在支付宝的用户id (optional)</param>
        /// <param name="openId">买家在支付宝的用户id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (ZhimaCreditPeZmgoAgreementQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPeZmgoAgreementQueryResponseModel>> QueryWithHttpInfoAsync(string agreementId = default(string), string alipayUserId = default(string), string openId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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

            if (agreementId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_id", agreementId));
            }
            if (alipayUserId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "alipay_user_id", alipayUserId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }

            localVarRequestOptions.Operation = "ZhimaCreditPeZmgoAgreementApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<ZhimaCreditPeZmgoAgreementQueryResponseModel>("/v3/zhima/credit/pe/zmgo/agreement/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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

        /// <summary>
        /// 芝麻GO协议解约 芝麻GO协议解约
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPeZmgoAgreementUnsignModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCreditPeZmgoAgreementUnsignResponseModel</returns>
        public ZhimaCreditPeZmgoAgreementUnsignResponseModel Unsign(ZhimaCreditPeZmgoAgreementUnsignModel zhimaCreditPeZmgoAgreementUnsignModel = default(ZhimaCreditPeZmgoAgreementUnsignModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPeZmgoAgreementUnsignResponseModel> localVarResponse = UnsignWithHttpInfo(zhimaCreditPeZmgoAgreementUnsignModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 芝麻GO协议解约 芝麻GO协议解约
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPeZmgoAgreementUnsignModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCreditPeZmgoAgreementUnsignResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPeZmgoAgreementUnsignResponseModel> UnsignWithHttpInfo(ZhimaCreditPeZmgoAgreementUnsignModel zhimaCreditPeZmgoAgreementUnsignModel = default(ZhimaCreditPeZmgoAgreementUnsignModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = zhimaCreditPeZmgoAgreementUnsignModel;
            }

            localVarRequestOptions.Operation = "ZhimaCreditPeZmgoAgreementApi.Unsign";
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
            var localVarResponse = this.Client.Post<ZhimaCreditPeZmgoAgreementUnsignResponseModel>("/v3/zhima/credit/pe/zmgo/agreement/unsign", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Unsign", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = ZhimaCreditPeZmgoAgreementUnsignDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 芝麻GO协议解约 芝麻GO协议解约
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPeZmgoAgreementUnsignModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ZhimaCreditPeZmgoAgreementUnsignResponseModel</returns>
        public async System.Threading.Tasks.Task<ZhimaCreditPeZmgoAgreementUnsignResponseModel> UnsignAsync(ZhimaCreditPeZmgoAgreementUnsignModel zhimaCreditPeZmgoAgreementUnsignModel = default(ZhimaCreditPeZmgoAgreementUnsignModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPeZmgoAgreementUnsignResponseModel> localVarResponse = await UnsignWithHttpInfoAsync(zhimaCreditPeZmgoAgreementUnsignModel, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 芝麻GO协议解约 芝麻GO协议解约
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPeZmgoAgreementUnsignModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (ZhimaCreditPeZmgoAgreementUnsignResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPeZmgoAgreementUnsignResponseModel>> UnsignWithHttpInfoAsync(ZhimaCreditPeZmgoAgreementUnsignModel zhimaCreditPeZmgoAgreementUnsignModel = default(ZhimaCreditPeZmgoAgreementUnsignModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = zhimaCreditPeZmgoAgreementUnsignModel;
            }

            localVarRequestOptions.Operation = "ZhimaCreditPeZmgoAgreementApi.Unsign";
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<ZhimaCreditPeZmgoAgreementUnsignResponseModel>("/v3/zhima/credit/pe/zmgo/agreement/unsign", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Unsign", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
