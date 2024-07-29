/* 
 * Xero AppStore API
 *
 * These endpoints are for Xero Partners to interact with the App Store Billing platform
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

// The version of the OpenAPI document: 6.0.1


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Xero.NetStandard.OAuth2.Client;
using Xero.NetStandard.OAuth2.Model.Appstore;
using System.Threading;

namespace Xero.NetStandard.OAuth2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppStoreApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves a subscription for a given subscriptionId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of Subscription</returns>
        System.Threading.Tasks.Task<Subscription> GetSubscriptionAsync (string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a subscription for a given subscriptionId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        System.Threading.Tasks.Task<ApiResponse<Subscription>> GetSubscriptionAsyncWithHttpInfo (string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets all usage records related to the subscription
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of UsageRecordsList</returns>
        System.Threading.Tasks.Task<UsageRecordsList> GetUsageRecordsAsync (string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets all usage records related to the subscription
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of ApiResponse (UsageRecordsList)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsageRecordsList>> GetUsageRecordsAsyncWithHttpInfo (string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send metered usage belonging to this subscription and subscription item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="subscriptionItemId">The unique identifier of the subscriptionItem</param>
        /// <param name="createUsageRecord">Contains the quantity for the usage record to create</param>
        /// <param name="idempotencyKey">This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional)</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of UsageRecord</returns>
        System.Threading.Tasks.Task<UsageRecord> PostUsageRecordsAsync (string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send metered usage belonging to this subscription and subscription item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="subscriptionItemId">The unique identifier of the subscriptionItem</param>
        /// <param name="createUsageRecord">Contains the quantity for the usage record to create</param>
        /// <param name="idempotencyKey">This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional)</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of ApiResponse (UsageRecord)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsageRecord>> PostUsageRecordsAsyncWithHttpInfo (string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update and existing metered usage belonging to this subscription and subscription item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="subscriptionItemId">The unique identifier of the subscriptionItem</param>
        /// <param name="usageRecordId">The unique identifier of the usage record</param>
        /// <param name="updateUsageRecord">Contains the quantity for the usage record to update</param>
        /// <param name="idempotencyKey">This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional)</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of UsageRecord</returns>
        System.Threading.Tasks.Task<UsageRecord> PutUsageRecordsAsync (string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update and existing metered usage belonging to this subscription and subscription item
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="subscriptionItemId">The unique identifier of the subscriptionItem</param>
        /// <param name="usageRecordId">The unique identifier of the usage record</param>
        /// <param name="updateUsageRecord">Contains the quantity for the usage record to update</param>
        /// <param name="idempotencyKey">This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional)</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of ApiResponse (UsageRecord)</returns>
        System.Threading.Tasks.Task<ApiResponse<UsageRecord>> PutUsageRecordsAsyncWithHttpInfo (string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppStoreApi : IAppStoreApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AppStoreApi : IAppStoreApi
    {
        private Xero.NetStandard.OAuth2.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppStoreApi() : this((string) null)
        {
            this.Configuration = Xero.NetStandard.OAuth2.Client.Configuration.MergeConfigurations(
                Xero.NetStandard.OAuth2.Client.GlobalConfiguration.Instance,
                new Xero.NetStandard.OAuth2.Client.Configuration { BasePath = "https://api.xero.com/appstore/2.0" }
            );
            this.AsynchronousClient = new Xero.NetStandard.OAuth2.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppStoreApi(String basePath)
        {
            this.Configuration = Xero.NetStandard.OAuth2.Client.Configuration.MergeConfigurations(
                Xero.NetStandard.OAuth2.Client.GlobalConfiguration.Instance,
                new Xero.NetStandard.OAuth2.Client.Configuration { BasePath = basePath }
            );
            this.AsynchronousClient = new Xero.NetStandard.OAuth2.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AppStoreApi(Xero.NetStandard.OAuth2.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Xero.NetStandard.OAuth2.Client.Configuration.MergeConfigurations(
                Xero.NetStandard.OAuth2.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.AsynchronousClient = new Xero.NetStandard.OAuth2.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AppStoreApi(Xero.NetStandard.OAuth2.Client.ISynchronousClient client,Xero.NetStandard.OAuth2.Client.IAsynchronousClient asyncClient, Xero.NetStandard.OAuth2.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Xero.NetStandard.OAuth2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Xero.NetStandard.OAuth2.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Xero.NetStandard.OAuth2.Client.IReadableConfiguration Configuration {get; set;}


        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Xero.NetStandard.OAuth2.Client.ExceptionFactory ExceptionFactory
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
        /// Retrieves a subscription for a given subscriptionId 
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of Subscription</returns>
        public async System.Threading.Tasks.Task<Subscription> GetSubscriptionAsync (string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<Subscription> localVarResponse = await GetSubscriptionAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves a subscription for a given subscriptionId 
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of ApiResponse (Subscription)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<Subscription>> GetSubscriptionAsyncWithHttpInfo (string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'subscriptionId' when calling AppStoreApi->GetSubscription");


            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (subscriptionId != null)
                requestOptions.PathParameters.Add("subscriptionId", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(subscriptionId)); // path parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.GetAsync<Subscription>("/subscriptions/{subscriptionId}", requestOptions, this.Configuration, cancellationToken);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetSubscription", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        /// Gets all usage records related to the subscription 
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of UsageRecordsList</returns>
        public async System.Threading.Tasks.Task<UsageRecordsList> GetUsageRecordsAsync (string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<UsageRecordsList> localVarResponse = await GetUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all usage records related to the subscription 
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of ApiResponse (UsageRecordsList)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<UsageRecordsList>> GetUsageRecordsAsyncWithHttpInfo (string accessToken, Guid subscriptionId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'subscriptionId' when calling AppStoreApi->GetUsageRecords");


            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (subscriptionId != null)
                requestOptions.PathParameters.Add("subscriptionId", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(subscriptionId)); // path parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.GetAsync<UsageRecordsList>("/subscriptions/{subscriptionId}/usage-records", requestOptions, this.Configuration, cancellationToken);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GetUsageRecords", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        /// Send metered usage belonging to this subscription and subscription item 
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="subscriptionItemId">The unique identifier of the subscriptionItem</param>
        /// <param name="createUsageRecord">Contains the quantity for the usage record to create</param>
        /// <param name="idempotencyKey">This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional)</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of UsageRecord</returns>
        public async System.Threading.Tasks.Task<UsageRecord> PostUsageRecordsAsync (string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<UsageRecord> localVarResponse = await PostUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, createUsageRecord, idempotencyKey, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send metered usage belonging to this subscription and subscription item 
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="subscriptionItemId">The unique identifier of the subscriptionItem</param>
        /// <param name="createUsageRecord">Contains the quantity for the usage record to create</param>
        /// <param name="idempotencyKey">This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional)</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of ApiResponse (UsageRecord)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<UsageRecord>> PostUsageRecordsAsyncWithHttpInfo (string accessToken, Guid subscriptionId, Guid subscriptionItemId, CreateUsageRecord createUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'subscriptionId' when calling AppStoreApi->PostUsageRecords");

            // verify the required parameter 'subscriptionItemId' is set
            if (subscriptionItemId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'subscriptionItemId' when calling AppStoreApi->PostUsageRecords");

            // verify the required parameter 'createUsageRecord' is set
            if (createUsageRecord == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'createUsageRecord' when calling AppStoreApi->PostUsageRecords");


            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (subscriptionId != null)
                requestOptions.PathParameters.Add("subscriptionId", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(subscriptionId)); // path parameter
            if (subscriptionItemId != null)
                requestOptions.PathParameters.Add("subscriptionItemId", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(subscriptionItemId)); // path parameter
            if (idempotencyKey != null)
                requestOptions.HeaderParameters.Add("Idempotency-Key", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(idempotencyKey)); // header parameter
            requestOptions.Data = createUsageRecord;

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.PostAsync<UsageRecord>("/subscriptions/{subscriptionId}/items/{subscriptionItemId}/usage-records", requestOptions, this.Configuration, cancellationToken);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PostUsageRecords", response);
                if (exception != null) throw exception;
            }

            return response;
        }


        /// <summary>
        /// Update and existing metered usage belonging to this subscription and subscription item 
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="subscriptionItemId">The unique identifier of the subscriptionItem</param>
        /// <param name="usageRecordId">The unique identifier of the usage record</param>
        /// <param name="updateUsageRecord">Contains the quantity for the usage record to update</param>
        /// <param name="idempotencyKey">This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional)</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of UsageRecord</returns>
        public async System.Threading.Tasks.Task<UsageRecord> PutUsageRecordsAsync (string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default)
        {
             Xero.NetStandard.OAuth2.Client.ApiResponse<UsageRecord> localVarResponse = await PutUsageRecordsAsyncWithHttpInfo(accessToken, subscriptionId, subscriptionItemId, usageRecordId, updateUsageRecord, idempotencyKey, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update and existing metered usage belonging to this subscription and subscription item 
        /// </summary>
        /// <exception cref="Xero.NetStandard.OAuth2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accessToken">Xero API OAuth 2.0 accessToken</param>
        /// <param name="subscriptionId">Unique identifier for Subscription object</param>
        /// <param name="subscriptionItemId">The unique identifier of the subscriptionItem</param>
        /// <param name="usageRecordId">The unique identifier of the usage record</param>
        /// <param name="updateUsageRecord">Contains the quantity for the usage record to update</param>
        /// <param name="idempotencyKey">This allows you to safely retry requests without the risk of duplicate processing. 128 character max. (optional)</param>
        /// <param name="cancellationToken">Cancellation token enables cancellation between threads. Defaults to CancellationToken.None</param>
        /// <returns>Task of ApiResponse (UsageRecord)</returns>
        public async System.Threading.Tasks.Task<Xero.NetStandard.OAuth2.Client.ApiResponse<UsageRecord>> PutUsageRecordsAsyncWithHttpInfo (string accessToken, Guid subscriptionId, Guid subscriptionItemId, Guid usageRecordId, UpdateUsageRecord updateUsageRecord, string idempotencyKey = null, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'subscriptionId' when calling AppStoreApi->PutUsageRecords");

            // verify the required parameter 'subscriptionItemId' is set
            if (subscriptionItemId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'subscriptionItemId' when calling AppStoreApi->PutUsageRecords");

            // verify the required parameter 'usageRecordId' is set
            if (usageRecordId == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'usageRecordId' when calling AppStoreApi->PutUsageRecords");

            // verify the required parameter 'updateUsageRecord' is set
            if (updateUsageRecord == null)
                throw new Xero.NetStandard.OAuth2.Client.ApiException(400, "Missing required parameter 'updateUsageRecord' when calling AppStoreApi->PutUsageRecords");


            Xero.NetStandard.OAuth2.Client.RequestOptions requestOptions = new Xero.NetStandard.OAuth2.Client.RequestOptions();

            String[] @contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var cType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", cType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (subscriptionId != null)
                requestOptions.PathParameters.Add("subscriptionId", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(subscriptionId)); // path parameter
            if (subscriptionItemId != null)
                requestOptions.PathParameters.Add("subscriptionItemId", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(subscriptionItemId)); // path parameter
            if (usageRecordId != null)
                requestOptions.PathParameters.Add("usageRecordId", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(usageRecordId)); // path parameter
            if (idempotencyKey != null)
                requestOptions.HeaderParameters.Add("Idempotency-Key", Xero.NetStandard.OAuth2.Client.ClientUtils.ParameterToString(idempotencyKey)); // header parameter
            requestOptions.Data = updateUsageRecord;

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(accessToken))
            {
                requestOptions.HeaderParameters.Add("Authorization", "Bearer " + accessToken);
            }
            // make the HTTP request

      

            var response = await this.AsynchronousClient.PutAsync<UsageRecord>("/subscriptions/{subscriptionId}/items/{subscriptionItemId}/usage-records/{usageRecordId}", requestOptions, this.Configuration, cancellationToken);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PutUsageRecords", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
