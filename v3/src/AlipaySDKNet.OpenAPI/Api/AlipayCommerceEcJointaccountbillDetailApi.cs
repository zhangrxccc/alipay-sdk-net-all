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
    public interface IAlipayCommerceEcJointaccountbillDetailApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 企业账单批量分页查询
        /// </summary>
        /// <remarks>
        /// 分页查询企业账单
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="bizScene">业务场景。不传默认为ISV_DEFAULT (optional)</param>
        /// <param name="userId">员工支付宝UID (optional)</param>
        /// <param name="openId">员工支付宝UID (optional)</param>
        /// <param name="employeeId">员工id (optional)</param>
        /// <param name="pageNum">页码 (optional)</param>
        /// <param name="pageSize">每页大小 (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel</returns>
        AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel Batchquery(string enterpriseId = default(string), string bizScene = default(string), string userId = default(string), string openId = default(string), string employeeId = default(string), string pageNum = default(string), string pageSize = default(string), string startDate = default(string), string endDate = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 企业账单批量分页查询
        /// </summary>
        /// <remarks>
        /// 分页查询企业账单
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="bizScene">业务场景。不传默认为ISV_DEFAULT (optional)</param>
        /// <param name="userId">员工支付宝UID (optional)</param>
        /// <param name="openId">员工支付宝UID (optional)</param>
        /// <param name="employeeId">员工id (optional)</param>
        /// <param name="pageNum">页码 (optional)</param>
        /// <param name="pageSize">每页大小 (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel</returns>
        ApiResponse<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel> BatchqueryWithHttpInfo(string enterpriseId = default(string), string bizScene = default(string), string userId = default(string), string openId = default(string), string employeeId = default(string), string pageNum = default(string), string pageSize = default(string), string startDate = default(string), string endDate = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayCommerceEcJointaccountbillDetailApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 企业账单批量分页查询
        /// </summary>
        /// <remarks>
        /// 分页查询企业账单
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="bizScene">业务场景。不传默认为ISV_DEFAULT (optional)</param>
        /// <param name="userId">员工支付宝UID (optional)</param>
        /// <param name="openId">员工支付宝UID (optional)</param>
        /// <param name="employeeId">员工id (optional)</param>
        /// <param name="pageNum">页码 (optional)</param>
        /// <param name="pageSize">每页大小 (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel> BatchqueryAsync(string enterpriseId = default(string), string bizScene = default(string), string userId = default(string), string openId = default(string), string employeeId = default(string), string pageNum = default(string), string pageSize = default(string), string startDate = default(string), string endDate = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 企业账单批量分页查询
        /// </summary>
        /// <remarks>
        /// 分页查询企业账单
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="bizScene">业务场景。不传默认为ISV_DEFAULT (optional)</param>
        /// <param name="userId">员工支付宝UID (optional)</param>
        /// <param name="openId">员工支付宝UID (optional)</param>
        /// <param name="employeeId">员工id (optional)</param>
        /// <param name="pageNum">页码 (optional)</param>
        /// <param name="pageSize">每页大小 (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel>> BatchqueryWithHttpInfoAsync(string enterpriseId = default(string), string bizScene = default(string), string userId = default(string), string openId = default(string), string employeeId = default(string), string pageNum = default(string), string pageSize = default(string), string startDate = default(string), string endDate = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayCommerceEcJointaccountbillDetailApi : IAlipayCommerceEcJointaccountbillDetailApiSync, IAlipayCommerceEcJointaccountbillDetailApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayCommerceEcJointaccountbillDetailApi : IAlipayCommerceEcJointaccountbillDetailApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcJointaccountbillDetailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayCommerceEcJointaccountbillDetailApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcJointaccountbillDetailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayCommerceEcJointaccountbillDetailApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayCommerceEcJointaccountbillDetailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayCommerceEcJointaccountbillDetailApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayCommerceEcJointaccountbillDetailApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayCommerceEcJointaccountbillDetailApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 企业账单批量分页查询 分页查询企业账单
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="bizScene">业务场景。不传默认为ISV_DEFAULT (optional)</param>
        /// <param name="userId">员工支付宝UID (optional)</param>
        /// <param name="openId">员工支付宝UID (optional)</param>
        /// <param name="employeeId">员工id (optional)</param>
        /// <param name="pageNum">页码 (optional)</param>
        /// <param name="pageSize">每页大小 (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel</returns>
        public AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel Batchquery(string enterpriseId = default(string), string bizScene = default(string), string userId = default(string), string openId = default(string), string employeeId = default(string), string pageNum = default(string), string pageSize = default(string), string startDate = default(string), string endDate = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel> localVarResponse = BatchqueryWithHttpInfo(enterpriseId, bizScene, userId, openId, employeeId, pageNum, pageSize, startDate, endDate, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 企业账单批量分页查询 分页查询企业账单
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="bizScene">业务场景。不传默认为ISV_DEFAULT (optional)</param>
        /// <param name="userId">员工支付宝UID (optional)</param>
        /// <param name="openId">员工支付宝UID (optional)</param>
        /// <param name="employeeId">员工id (optional)</param>
        /// <param name="pageNum">页码 (optional)</param>
        /// <param name="pageSize">每页大小 (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel> BatchqueryWithHttpInfo(string enterpriseId = default(string), string bizScene = default(string), string userId = default(string), string openId = default(string), string employeeId = default(string), string pageNum = default(string), string pageSize = default(string), string startDate = default(string), string endDate = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (enterpriseId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "enterprise_id", enterpriseId));
            }
            if (bizScene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_scene", bizScene));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (employeeId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "employee_id", employeeId));
            }
            if (pageNum != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_num", pageNum));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "start_date", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "end_date", endDate));
            }

            localVarRequestOptions.Operation = "AlipayCommerceEcJointaccountbillDetailApi.Batchquery";
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
            var localVarResponse = this.Client.Get<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel>("/v3/alipay/commerce/ec/jointaccountbill/detail/batchquery", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Batchquery", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayCommerceEcJointaccountbillDetailBatchqueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 企业账单批量分页查询 分页查询企业账单
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="bizScene">业务场景。不传默认为ISV_DEFAULT (optional)</param>
        /// <param name="userId">员工支付宝UID (optional)</param>
        /// <param name="openId">员工支付宝UID (optional)</param>
        /// <param name="employeeId">员工id (optional)</param>
        /// <param name="pageNum">页码 (optional)</param>
        /// <param name="pageSize">每页大小 (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel> BatchqueryAsync(string enterpriseId = default(string), string bizScene = default(string), string userId = default(string), string openId = default(string), string employeeId = default(string), string pageNum = default(string), string pageSize = default(string), string startDate = default(string), string endDate = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel> localVarResponse = await BatchqueryWithHttpInfoAsync(enterpriseId, bizScene, userId, openId, employeeId, pageNum, pageSize, startDate, endDate, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 企业账单批量分页查询 分页查询企业账单
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="bizScene">业务场景。不传默认为ISV_DEFAULT (optional)</param>
        /// <param name="userId">员工支付宝UID (optional)</param>
        /// <param name="openId">员工支付宝UID (optional)</param>
        /// <param name="employeeId">员工id (optional)</param>
        /// <param name="pageNum">页码 (optional)</param>
        /// <param name="pageSize">每页大小 (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel>> BatchqueryWithHttpInfoAsync(string enterpriseId = default(string), string bizScene = default(string), string userId = default(string), string openId = default(string), string employeeId = default(string), string pageNum = default(string), string pageSize = default(string), string startDate = default(string), string endDate = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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

            if (enterpriseId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "enterprise_id", enterpriseId));
            }
            if (bizScene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_scene", bizScene));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (employeeId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "employee_id", employeeId));
            }
            if (pageNum != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_num", pageNum));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "start_date", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "end_date", endDate));
            }

            localVarRequestOptions.Operation = "AlipayCommerceEcJointaccountbillDetailApi.Batchquery";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayCommerceEcJointaccountbillDetailBatchqueryResponseModel>("/v3/alipay/commerce/ec/jointaccountbill/detail/batchquery", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Batchquery", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
