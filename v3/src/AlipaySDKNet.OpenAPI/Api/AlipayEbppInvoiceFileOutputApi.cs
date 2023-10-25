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
    public interface IAlipayEbppInvoiceFileOutputApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取电子发票原文件
        /// </summary>
        /// <remarks>
        /// 根据发票代码，发票号码获取用户的普通增值税电子发票pdf文件  查询权限要求： 发票属于当前isv报销单据进行状态（支持的状态有 EXPENSE_APPLY－用户已提交申请 EXPENSE_APPROVAL_PASS －报销审核通过 EXPENSE_FINISHED－报销完结）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="invoiceCode">发票代码 字段长度（10-12位），全电票时为空 (optional)</param>
        /// <param name="invoiceNo">发票号码 字段长度（8-10位），全电票时为20位 (optional)</param>
        /// <param name="scene">发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 (optional)</param>
        /// <param name="skipExpenseProgressSync">是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceFileOutputQueryResponseModel</returns>
        AlipayEbppInvoiceFileOutputQueryResponseModel Query(string userId = default(string), string openId = default(string), string invoiceCode = default(string), string invoiceNo = default(string), string scene = default(string), bool? skipExpenseProgressSync = default(bool?), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 获取电子发票原文件
        /// </summary>
        /// <remarks>
        /// 根据发票代码，发票号码获取用户的普通增值税电子发票pdf文件  查询权限要求： 发票属于当前isv报销单据进行状态（支持的状态有 EXPENSE_APPLY－用户已提交申请 EXPENSE_APPROVAL_PASS －报销审核通过 EXPENSE_FINISHED－报销完结）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="invoiceCode">发票代码 字段长度（10-12位），全电票时为空 (optional)</param>
        /// <param name="invoiceNo">发票号码 字段长度（8-10位），全电票时为20位 (optional)</param>
        /// <param name="scene">发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 (optional)</param>
        /// <param name="skipExpenseProgressSync">是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceFileOutputQueryResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceFileOutputQueryResponseModel> QueryWithHttpInfo(string userId = default(string), string openId = default(string), string invoiceCode = default(string), string invoiceNo = default(string), string scene = default(string), bool? skipExpenseProgressSync = default(bool?), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceFileOutputApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 获取电子发票原文件
        /// </summary>
        /// <remarks>
        /// 根据发票代码，发票号码获取用户的普通增值税电子发票pdf文件  查询权限要求： 发票属于当前isv报销单据进行状态（支持的状态有 EXPENSE_APPLY－用户已提交申请 EXPENSE_APPROVAL_PASS －报销审核通过 EXPENSE_FINISHED－报销完结）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="invoiceCode">发票代码 字段长度（10-12位），全电票时为空 (optional)</param>
        /// <param name="invoiceNo">发票号码 字段长度（8-10位），全电票时为20位 (optional)</param>
        /// <param name="scene">发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 (optional)</param>
        /// <param name="skipExpenseProgressSync">是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayEbppInvoiceFileOutputQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayEbppInvoiceFileOutputQueryResponseModel> QueryAsync(string userId = default(string), string openId = default(string), string invoiceCode = default(string), string invoiceNo = default(string), string scene = default(string), bool? skipExpenseProgressSync = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 获取电子发票原文件
        /// </summary>
        /// <remarks>
        /// 根据发票代码，发票号码获取用户的普通增值税电子发票pdf文件  查询权限要求： 发票属于当前isv报销单据进行状态（支持的状态有 EXPENSE_APPLY－用户已提交申请 EXPENSE_APPROVAL_PASS －报销审核通过 EXPENSE_FINISHED－报销完结）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="invoiceCode">发票代码 字段长度（10-12位），全电票时为空 (optional)</param>
        /// <param name="invoiceNo">发票号码 字段长度（8-10位），全电票时为20位 (optional)</param>
        /// <param name="scene">发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 (optional)</param>
        /// <param name="skipExpenseProgressSync">是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayEbppInvoiceFileOutputQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayEbppInvoiceFileOutputQueryResponseModel>> QueryWithHttpInfoAsync(string userId = default(string), string openId = default(string), string invoiceCode = default(string), string invoiceNo = default(string), string scene = default(string), bool? skipExpenseProgressSync = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceFileOutputApi : IAlipayEbppInvoiceFileOutputApiSync, IAlipayEbppInvoiceFileOutputApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayEbppInvoiceFileOutputApi : IAlipayEbppInvoiceFileOutputApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceFileOutputApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceFileOutputApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceFileOutputApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceFileOutputApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceFileOutputApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayEbppInvoiceFileOutputApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceFileOutputApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayEbppInvoiceFileOutputApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 获取电子发票原文件 根据发票代码，发票号码获取用户的普通增值税电子发票pdf文件  查询权限要求： 发票属于当前isv报销单据进行状态（支持的状态有 EXPENSE_APPLY－用户已提交申请 EXPENSE_APPROVAL_PASS －报销审核通过 EXPENSE_FINISHED－报销完结）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="invoiceCode">发票代码 字段长度（10-12位），全电票时为空 (optional)</param>
        /// <param name="invoiceNo">发票号码 字段长度（8-10位），全电票时为20位 (optional)</param>
        /// <param name="scene">发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 (optional)</param>
        /// <param name="skipExpenseProgressSync">是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceFileOutputQueryResponseModel</returns>
        public AlipayEbppInvoiceFileOutputQueryResponseModel Query(string userId = default(string), string openId = default(string), string invoiceCode = default(string), string invoiceNo = default(string), string scene = default(string), bool? skipExpenseProgressSync = default(bool?), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceFileOutputQueryResponseModel> localVarResponse = QueryWithHttpInfo(userId, openId, invoiceCode, invoiceNo, scene, skipExpenseProgressSync, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 获取电子发票原文件 根据发票代码，发票号码获取用户的普通增值税电子发票pdf文件  查询权限要求： 发票属于当前isv报销单据进行状态（支持的状态有 EXPENSE_APPLY－用户已提交申请 EXPENSE_APPROVAL_PASS －报销审核通过 EXPENSE_FINISHED－报销完结）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="invoiceCode">发票代码 字段长度（10-12位），全电票时为空 (optional)</param>
        /// <param name="invoiceNo">发票号码 字段长度（8-10位），全电票时为20位 (optional)</param>
        /// <param name="scene">发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 (optional)</param>
        /// <param name="skipExpenseProgressSync">是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceFileOutputQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceFileOutputQueryResponseModel> QueryWithHttpInfo(string userId = default(string), string openId = default(string), string invoiceCode = default(string), string invoiceNo = default(string), string scene = default(string), bool? skipExpenseProgressSync = default(bool?), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (invoiceCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "invoice_code", invoiceCode));
            }
            if (invoiceNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "invoice_no", invoiceNo));
            }
            if (scene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "scene", scene));
            }
            if (skipExpenseProgressSync != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "skip_expense_progress_sync", skipExpenseProgressSync));
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceFileOutputApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayEbppInvoiceFileOutputQueryResponseModel>("/v3/alipay/ebpp/invoice/file/output/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceFileOutputQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 获取电子发票原文件 根据发票代码，发票号码获取用户的普通增值税电子发票pdf文件  查询权限要求： 发票属于当前isv报销单据进行状态（支持的状态有 EXPENSE_APPLY－用户已提交申请 EXPENSE_APPROVAL_PASS －报销审核通过 EXPENSE_FINISHED－报销完结）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="invoiceCode">发票代码 字段长度（10-12位），全电票时为空 (optional)</param>
        /// <param name="invoiceNo">发票号码 字段长度（8-10位），全电票时为20位 (optional)</param>
        /// <param name="scene">发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 (optional)</param>
        /// <param name="skipExpenseProgressSync">是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayEbppInvoiceFileOutputQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayEbppInvoiceFileOutputQueryResponseModel> QueryAsync(string userId = default(string), string openId = default(string), string invoiceCode = default(string), string invoiceNo = default(string), string scene = default(string), bool? skipExpenseProgressSync = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceFileOutputQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(userId, openId, invoiceCode, invoiceNo, scene, skipExpenseProgressSync, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 获取电子发票原文件 根据发票代码，发票号码获取用户的普通增值税电子发票pdf文件  查询权限要求： 发票属于当前isv报销单据进行状态（支持的状态有 EXPENSE_APPLY－用户已提交申请 EXPENSE_APPROVAL_PASS －报销审核通过 EXPENSE_FINISHED－报销完结）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="openId">发票归属用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 (optional)</param>
        /// <param name="invoiceCode">发票代码 字段长度（10-12位），全电票时为空 (optional)</param>
        /// <param name="invoiceNo">发票号码 字段长度（8-10位），全电票时为20位 (optional)</param>
        /// <param name="scene">发票pdf文件下载应用场景。固定为 INVOICE_EXPENSE  表示发票报销。 (optional)</param>
        /// <param name="skipExpenseProgressSync">是否跳过发票报销状态同步；当为true时，跳过报销状态同步校验。默认为false，需要先做报销状态同步 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayEbppInvoiceFileOutputQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceFileOutputQueryResponseModel>> QueryWithHttpInfoAsync(string userId = default(string), string openId = default(string), string invoiceCode = default(string), string invoiceNo = default(string), string scene = default(string), bool? skipExpenseProgressSync = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (invoiceCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "invoice_code", invoiceCode));
            }
            if (invoiceNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "invoice_no", invoiceNo));
            }
            if (scene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "scene", scene));
            }
            if (skipExpenseProgressSync != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "skip_expense_progress_sync", skipExpenseProgressSync));
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceFileOutputApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayEbppInvoiceFileOutputQueryResponseModel>("/v3/alipay/ebpp/invoice/file/output/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
