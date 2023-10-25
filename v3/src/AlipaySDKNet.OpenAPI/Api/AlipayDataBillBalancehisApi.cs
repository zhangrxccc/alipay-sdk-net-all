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
    public interface IAlipayDataBillBalancehisApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 支付宝商家账户历史余额查询
        /// </summary>
        /// <remarks>
        /// 为支付宝商家提供支付宝账户历史余额信息，供对账使用。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bizDate">查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="bizMonth">查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayDataBillBalancehisQueryResponseModel</returns>
        AlipayDataBillBalancehisQueryResponseModel Query(string bizDate = default(string), string bizMonth = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 支付宝商家账户历史余额查询
        /// </summary>
        /// <remarks>
        /// 为支付宝商家提供支付宝账户历史余额信息，供对账使用。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bizDate">查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="bizMonth">查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayDataBillBalancehisQueryResponseModel</returns>
        ApiResponse<AlipayDataBillBalancehisQueryResponseModel> QueryWithHttpInfo(string bizDate = default(string), string bizMonth = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayDataBillBalancehisApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 支付宝商家账户历史余额查询
        /// </summary>
        /// <remarks>
        /// 为支付宝商家提供支付宝账户历史余额信息，供对账使用。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bizDate">查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="bizMonth">查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayDataBillBalancehisQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayDataBillBalancehisQueryResponseModel> QueryAsync(string bizDate = default(string), string bizMonth = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 支付宝商家账户历史余额查询
        /// </summary>
        /// <remarks>
        /// 为支付宝商家提供支付宝账户历史余额信息，供对账使用。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bizDate">查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="bizMonth">查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayDataBillBalancehisQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayDataBillBalancehisQueryResponseModel>> QueryWithHttpInfoAsync(string bizDate = default(string), string bizMonth = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayDataBillBalancehisApi : IAlipayDataBillBalancehisApiSync, IAlipayDataBillBalancehisApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayDataBillBalancehisApi : IAlipayDataBillBalancehisApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillBalancehisApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayDataBillBalancehisApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillBalancehisApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayDataBillBalancehisApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayDataBillBalancehisApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayDataBillBalancehisApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayDataBillBalancehisApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayDataBillBalancehisApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 支付宝商家账户历史余额查询 为支付宝商家提供支付宝账户历史余额信息，供对账使用。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bizDate">查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="bizMonth">查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayDataBillBalancehisQueryResponseModel</returns>
        public AlipayDataBillBalancehisQueryResponseModel Query(string bizDate = default(string), string bizMonth = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillBalancehisQueryResponseModel> localVarResponse = QueryWithHttpInfo(bizDate, bizMonth, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 支付宝商家账户历史余额查询 为支付宝商家提供支付宝账户历史余额信息，供对账使用。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bizDate">查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="bizMonth">查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayDataBillBalancehisQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillBalancehisQueryResponseModel> QueryWithHttpInfo(string bizDate = default(string), string bizMonth = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (bizDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_date", bizDate));
            }
            if (bizMonth != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_month", bizMonth));
            }

            localVarRequestOptions.Operation = "AlipayDataBillBalancehisApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayDataBillBalancehisQueryResponseModel>("/v3/alipay/data/bill/balancehis/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayDataBillBalancehisQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 支付宝商家账户历史余额查询 为支付宝商家提供支付宝账户历史余额信息，供对账使用。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bizDate">查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="bizMonth">查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayDataBillBalancehisQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayDataBillBalancehisQueryResponseModel> QueryAsync(string bizDate = default(string), string bizMonth = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillBalancehisQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(bizDate, bizMonth, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 支付宝商家账户历史余额查询 为支付宝商家提供支付宝账户历史余额信息，供对账使用。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bizDate">查询指定自然日的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="bizMonth">查询指定自然月的起初余额和期末余额，biz_date与biz_month传入参数互斥 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayDataBillBalancehisQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillBalancehisQueryResponseModel>> QueryWithHttpInfoAsync(string bizDate = default(string), string bizMonth = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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

            if (bizDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_date", bizDate));
            }
            if (bizMonth != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_month", bizMonth));
            }

            localVarRequestOptions.Operation = "AlipayDataBillBalancehisApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayDataBillBalancehisQueryResponseModel>("/v3/alipay/data/bill/balancehis/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
