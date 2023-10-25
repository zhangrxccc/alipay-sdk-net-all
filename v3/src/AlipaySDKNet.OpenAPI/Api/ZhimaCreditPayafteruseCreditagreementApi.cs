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
    public interface IZhimaCreditPayafteruseCreditagreementApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 查询服务开通/授权信息
        /// </summary>
        /// <remarks>
        /// 使用商户外部协议号或开通/授权协议号，查询服务开通/授权信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outAgreementNo">商户外部协议号 (optional)</param>
        /// <param name="creditAgreementId">芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCreditPayafteruseCreditagreementQueryResponseModel</returns>
        ZhimaCreditPayafteruseCreditagreementQueryResponseModel Query(string outAgreementNo = default(string), string creditAgreementId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询服务开通/授权信息
        /// </summary>
        /// <remarks>
        /// 使用商户外部协议号或开通/授权协议号，查询服务开通/授权信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outAgreementNo">商户外部协议号 (optional)</param>
        /// <param name="creditAgreementId">芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCreditPayafteruseCreditagreementQueryResponseModel</returns>
        ApiResponse<ZhimaCreditPayafteruseCreditagreementQueryResponseModel> QueryWithHttpInfo(string outAgreementNo = default(string), string creditAgreementId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 芝麻信用服务授权
        /// </summary>
        /// <remarks>
        /// 其他产品功能（例如信用代扣），通过该接口，可以转换为芝麻产品（芝麻先享产品，芝麻风险评估产品），完成信用服务授权
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPayafteruseCreditagreementTransferModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCreditPayafteruseCreditagreementTransferResponseModel</returns>
        ZhimaCreditPayafteruseCreditagreementTransferResponseModel Transfer(ZhimaCreditPayafteruseCreditagreementTransferModel zhimaCreditPayafteruseCreditagreementTransferModel = default(ZhimaCreditPayafteruseCreditagreementTransferModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 芝麻信用服务授权
        /// </summary>
        /// <remarks>
        /// 其他产品功能（例如信用代扣），通过该接口，可以转换为芝麻产品（芝麻先享产品，芝麻风险评估产品），完成信用服务授权
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPayafteruseCreditagreementTransferModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCreditPayafteruseCreditagreementTransferResponseModel</returns>
        ApiResponse<ZhimaCreditPayafteruseCreditagreementTransferResponseModel> TransferWithHttpInfo(ZhimaCreditPayafteruseCreditagreementTransferModel zhimaCreditPayafteruseCreditagreementTransferModel = default(ZhimaCreditPayafteruseCreditagreementTransferModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZhimaCreditPayafteruseCreditagreementApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 查询服务开通/授权信息
        /// </summary>
        /// <remarks>
        /// 使用商户外部协议号或开通/授权协议号，查询服务开通/授权信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outAgreementNo">商户外部协议号 (optional)</param>
        /// <param name="creditAgreementId">芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ZhimaCreditPayafteruseCreditagreementQueryResponseModel</returns>
        System.Threading.Tasks.Task<ZhimaCreditPayafteruseCreditagreementQueryResponseModel> QueryAsync(string outAgreementNo = default(string), string creditAgreementId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询服务开通/授权信息
        /// </summary>
        /// <remarks>
        /// 使用商户外部协议号或开通/授权协议号，查询服务开通/授权信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outAgreementNo">商户外部协议号 (optional)</param>
        /// <param name="creditAgreementId">芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (ZhimaCreditPayafteruseCreditagreementQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<ZhimaCreditPayafteruseCreditagreementQueryResponseModel>> QueryWithHttpInfoAsync(string outAgreementNo = default(string), string creditAgreementId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        /// <summary>
        /// 芝麻信用服务授权
        /// </summary>
        /// <remarks>
        /// 其他产品功能（例如信用代扣），通过该接口，可以转换为芝麻产品（芝麻先享产品，芝麻风险评估产品），完成信用服务授权
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPayafteruseCreditagreementTransferModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ZhimaCreditPayafteruseCreditagreementTransferResponseModel</returns>
        System.Threading.Tasks.Task<ZhimaCreditPayafteruseCreditagreementTransferResponseModel> TransferAsync(ZhimaCreditPayafteruseCreditagreementTransferModel zhimaCreditPayafteruseCreditagreementTransferModel = default(ZhimaCreditPayafteruseCreditagreementTransferModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 芝麻信用服务授权
        /// </summary>
        /// <remarks>
        /// 其他产品功能（例如信用代扣），通过该接口，可以转换为芝麻产品（芝麻先享产品，芝麻风险评估产品），完成信用服务授权
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPayafteruseCreditagreementTransferModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (ZhimaCreditPayafteruseCreditagreementTransferResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<ZhimaCreditPayafteruseCreditagreementTransferResponseModel>> TransferWithHttpInfoAsync(ZhimaCreditPayafteruseCreditagreementTransferModel zhimaCreditPayafteruseCreditagreementTransferModel = default(ZhimaCreditPayafteruseCreditagreementTransferModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZhimaCreditPayafteruseCreditagreementApi : IZhimaCreditPayafteruseCreditagreementApiSync, IZhimaCreditPayafteruseCreditagreementApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ZhimaCreditPayafteruseCreditagreementApi : IZhimaCreditPayafteruseCreditagreementApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPayafteruseCreditagreementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaCreditPayafteruseCreditagreementApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPayafteruseCreditagreementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaCreditPayafteruseCreditagreementApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ZhimaCreditPayafteruseCreditagreementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZhimaCreditPayafteruseCreditagreementApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ZhimaCreditPayafteruseCreditagreementApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ZhimaCreditPayafteruseCreditagreementApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 查询服务开通/授权信息 使用商户外部协议号或开通/授权协议号，查询服务开通/授权信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outAgreementNo">商户外部协议号 (optional)</param>
        /// <param name="creditAgreementId">芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCreditPayafteruseCreditagreementQueryResponseModel</returns>
        public ZhimaCreditPayafteruseCreditagreementQueryResponseModel Query(string outAgreementNo = default(string), string creditAgreementId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPayafteruseCreditagreementQueryResponseModel> localVarResponse = QueryWithHttpInfo(outAgreementNo, creditAgreementId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询服务开通/授权信息 使用商户外部协议号或开通/授权协议号，查询服务开通/授权信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outAgreementNo">商户外部协议号 (optional)</param>
        /// <param name="creditAgreementId">芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCreditPayafteruseCreditagreementQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPayafteruseCreditagreementQueryResponseModel> QueryWithHttpInfo(string outAgreementNo = default(string), string creditAgreementId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (outAgreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_agreement_no", outAgreementNo));
            }
            if (creditAgreementId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "credit_agreement_id", creditAgreementId));
            }

            localVarRequestOptions.Operation = "ZhimaCreditPayafteruseCreditagreementApi.Query";
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
            var localVarResponse = this.Client.Get<ZhimaCreditPayafteruseCreditagreementQueryResponseModel>("/v3/zhima/credit/payafteruse/creditagreement/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = ZhimaCreditPayafteruseCreditagreementQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询服务开通/授权信息 使用商户外部协议号或开通/授权协议号，查询服务开通/授权信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outAgreementNo">商户外部协议号 (optional)</param>
        /// <param name="creditAgreementId">芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ZhimaCreditPayafteruseCreditagreementQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<ZhimaCreditPayafteruseCreditagreementQueryResponseModel> QueryAsync(string outAgreementNo = default(string), string creditAgreementId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPayafteruseCreditagreementQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(outAgreementNo, creditAgreementId, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询服务开通/授权信息 使用商户外部协议号或开通/授权协议号，查询服务开通/授权信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outAgreementNo">商户外部协议号 (optional)</param>
        /// <param name="creditAgreementId">芝麻开通/授权协议号，out_agreement_no与credit_agreement_id必填一个，推荐使用credit_agreement_id。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (ZhimaCreditPayafteruseCreditagreementQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPayafteruseCreditagreementQueryResponseModel>> QueryWithHttpInfoAsync(string outAgreementNo = default(string), string creditAgreementId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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

            if (outAgreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_agreement_no", outAgreementNo));
            }
            if (creditAgreementId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "credit_agreement_id", creditAgreementId));
            }

            localVarRequestOptions.Operation = "ZhimaCreditPayafteruseCreditagreementApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<ZhimaCreditPayafteruseCreditagreementQueryResponseModel>("/v3/zhima/credit/payafteruse/creditagreement/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
        /// 芝麻信用服务授权 其他产品功能（例如信用代扣），通过该接口，可以转换为芝麻产品（芝麻先享产品，芝麻风险评估产品），完成信用服务授权
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPayafteruseCreditagreementTransferModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCreditPayafteruseCreditagreementTransferResponseModel</returns>
        public ZhimaCreditPayafteruseCreditagreementTransferResponseModel Transfer(ZhimaCreditPayafteruseCreditagreementTransferModel zhimaCreditPayafteruseCreditagreementTransferModel = default(ZhimaCreditPayafteruseCreditagreementTransferModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPayafteruseCreditagreementTransferResponseModel> localVarResponse = TransferWithHttpInfo(zhimaCreditPayafteruseCreditagreementTransferModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 芝麻信用服务授权 其他产品功能（例如信用代扣），通过该接口，可以转换为芝麻产品（芝麻先享产品，芝麻风险评估产品），完成信用服务授权
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPayafteruseCreditagreementTransferModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCreditPayafteruseCreditagreementTransferResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPayafteruseCreditagreementTransferResponseModel> TransferWithHttpInfo(ZhimaCreditPayafteruseCreditagreementTransferModel zhimaCreditPayafteruseCreditagreementTransferModel = default(ZhimaCreditPayafteruseCreditagreementTransferModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = zhimaCreditPayafteruseCreditagreementTransferModel;
            }

            localVarRequestOptions.Operation = "ZhimaCreditPayafteruseCreditagreementApi.Transfer";
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
            var localVarResponse = this.Client.Post<ZhimaCreditPayafteruseCreditagreementTransferResponseModel>("/v3/zhima/credit/payafteruse/creditagreement/transfer", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Transfer", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = ZhimaCreditPayafteruseCreditagreementTransferDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 芝麻信用服务授权 其他产品功能（例如信用代扣），通过该接口，可以转换为芝麻产品（芝麻先享产品，芝麻风险评估产品），完成信用服务授权
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPayafteruseCreditagreementTransferModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ZhimaCreditPayafteruseCreditagreementTransferResponseModel</returns>
        public async System.Threading.Tasks.Task<ZhimaCreditPayafteruseCreditagreementTransferResponseModel> TransferAsync(ZhimaCreditPayafteruseCreditagreementTransferModel zhimaCreditPayafteruseCreditagreementTransferModel = default(ZhimaCreditPayafteruseCreditagreementTransferModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPayafteruseCreditagreementTransferResponseModel> localVarResponse = await TransferWithHttpInfoAsync(zhimaCreditPayafteruseCreditagreementTransferModel, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 芝麻信用服务授权 其他产品功能（例如信用代扣），通过该接口，可以转换为芝麻产品（芝麻先享产品，芝麻风险评估产品），完成信用服务授权
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="zhimaCreditPayafteruseCreditagreementTransferModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (ZhimaCreditPayafteruseCreditagreementTransferResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCreditPayafteruseCreditagreementTransferResponseModel>> TransferWithHttpInfoAsync(ZhimaCreditPayafteruseCreditagreementTransferModel zhimaCreditPayafteruseCreditagreementTransferModel = default(ZhimaCreditPayafteruseCreditagreementTransferModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = zhimaCreditPayafteruseCreditagreementTransferModel;
            }

            localVarRequestOptions.Operation = "ZhimaCreditPayafteruseCreditagreementApi.Transfer";
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<ZhimaCreditPayafteruseCreditagreementTransferResponseModel>("/v3/zhima/credit/payafteruse/creditagreement/transfer", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Transfer", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
