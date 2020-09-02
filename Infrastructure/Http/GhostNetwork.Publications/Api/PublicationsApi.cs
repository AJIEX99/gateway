/* 
 * GhostNetwork/Publications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using GhostNetwork.Publications.Client;
using GhostNetwork.Publications.Model;

namespace GhostNetwork.Publications.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip"> (optional)</param>
        /// <param name="take"> (optional)</param>
        /// <param name="tags"> (optional)</param>
        /// <returns>List&lt;Publication&gt;</returns>
        List<Publication> PublicationsGet (int? skip = default(int?), int? take = default(int?), List<string> tags = default(List<string>));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip"> (optional)</param>
        /// <param name="take"> (optional)</param>
        /// <param name="tags"> (optional)</param>
        /// <returns>ApiResponse of List&lt;Publication&gt;</returns>
        ApiResponse<List<Publication>> PublicationsGetWithHttpInfo (int? skip = default(int?), int? take = default(int?), List<string> tags = default(List<string>));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Publication</returns>
        Publication PublicationsIdGet (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Publication</returns>
        ApiResponse<Publication> PublicationsIdGetWithHttpInfo (string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPublicationModel"> (optional)</param>
        /// <returns></returns>
        void PublicationsPost (CreatePublicationModel createPublicationModel = default(CreatePublicationModel));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPublicationModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PublicationsPostWithHttpInfo (CreatePublicationModel createPublicationModel = default(CreatePublicationModel));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip"> (optional)</param>
        /// <param name="take"> (optional)</param>
        /// <param name="tags"> (optional)</param>
        /// <returns>Task of List&lt;Publication&gt;</returns>
        System.Threading.Tasks.Task<List<Publication>> PublicationsGetAsync (int? skip = default(int?), int? take = default(int?), List<string> tags = default(List<string>));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip"> (optional)</param>
        /// <param name="take"> (optional)</param>
        /// <param name="tags"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Publication&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Publication>>> PublicationsGetAsyncWithHttpInfo (int? skip = default(int?), int? take = default(int?), List<string> tags = default(List<string>));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of Publication</returns>
        System.Threading.Tasks.Task<Publication> PublicationsIdGetAsync (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        System.Threading.Tasks.Task<ApiResponse<Publication>> PublicationsIdGetAsyncWithHttpInfo (string id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPublicationModel"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PublicationsPostAsync (CreatePublicationModel createPublicationModel = default(CreatePublicationModel));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPublicationModel"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PublicationsPostAsyncWithHttpInfo (CreatePublicationModel createPublicationModel = default(CreatePublicationModel));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicationsApi : IPublicationsApiSync, IPublicationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicationsApi : IPublicationsApi
    {
        private GhostNetwork.Publications.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicationsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicationsApi(String basePath)
        {
            this.Configuration = GhostNetwork.Publications.Client.Configuration.MergeConfigurations(
                GhostNetwork.Publications.Client.GlobalConfiguration.Instance,
                new GhostNetwork.Publications.Client.Configuration { BasePath = basePath }
            );
            this.Client = new GhostNetwork.Publications.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GhostNetwork.Publications.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = GhostNetwork.Publications.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicationsApi(GhostNetwork.Publications.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = GhostNetwork.Publications.Client.Configuration.MergeConfigurations(
                GhostNetwork.Publications.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new GhostNetwork.Publications.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GhostNetwork.Publications.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = GhostNetwork.Publications.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PublicationsApi(GhostNetwork.Publications.Client.ISynchronousClient client,GhostNetwork.Publications.Client.IAsynchronousClient asyncClient, GhostNetwork.Publications.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = GhostNetwork.Publications.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public GhostNetwork.Publications.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public GhostNetwork.Publications.Client.ISynchronousClient Client { get; set; }

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
        public GhostNetwork.Publications.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public GhostNetwork.Publications.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip"> (optional)</param>
        /// <param name="take"> (optional)</param>
        /// <param name="tags"> (optional)</param>
        /// <returns>List&lt;Publication&gt;</returns>
        public List<Publication> PublicationsGet (int? skip = default(int?), int? take = default(int?), List<string> tags = default(List<string>))
        {
             GhostNetwork.Publications.Client.ApiResponse<List<Publication>> localVarResponse = PublicationsGetWithHttpInfo(skip, take, tags);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip"> (optional)</param>
        /// <param name="take"> (optional)</param>
        /// <param name="tags"> (optional)</param>
        /// <returns>ApiResponse of List&lt;Publication&gt;</returns>
        public GhostNetwork.Publications.Client.ApiResponse< List<Publication> > PublicationsGetWithHttpInfo (int? skip = default(int?), int? take = default(int?), List<string> tags = default(List<string>))
        {
            GhostNetwork.Publications.Client.RequestOptions localVarRequestOptions = new GhostNetwork.Publications.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = GhostNetwork.Publications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = GhostNetwork.Publications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(GhostNetwork.Publications.Client.ClientUtils.ParameterToMultiMap("", "skip", skip));
            }
            if (take != null)
            {
                localVarRequestOptions.QueryParameters.Add(GhostNetwork.Publications.Client.ClientUtils.ParameterToMultiMap("", "take", take));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(GhostNetwork.Publications.Client.ClientUtils.ParameterToMultiMap("multi", "tags", tags));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get< List<Publication> >("/Publications", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PublicationsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip"> (optional)</param>
        /// <param name="take"> (optional)</param>
        /// <param name="tags"> (optional)</param>
        /// <returns>Task of List&lt;Publication&gt;</returns>
        public async System.Threading.Tasks.Task<List<Publication>> PublicationsGetAsync (int? skip = default(int?), int? take = default(int?), List<string> tags = default(List<string>))
        {
             GhostNetwork.Publications.Client.ApiResponse<List<Publication>> localVarResponse = await PublicationsGetAsyncWithHttpInfo(skip, take, tags);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="skip"> (optional)</param>
        /// <param name="take"> (optional)</param>
        /// <param name="tags"> (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Publication&gt;)</returns>
        public async System.Threading.Tasks.Task<GhostNetwork.Publications.Client.ApiResponse<List<Publication>>> PublicationsGetAsyncWithHttpInfo (int? skip = default(int?), int? take = default(int?), List<string> tags = default(List<string>))
        {

            GhostNetwork.Publications.Client.RequestOptions localVarRequestOptions = new GhostNetwork.Publications.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(GhostNetwork.Publications.Client.ClientUtils.ParameterToMultiMap("", "skip", skip));
            }
            if (take != null)
            {
                localVarRequestOptions.QueryParameters.Add(GhostNetwork.Publications.Client.ClientUtils.ParameterToMultiMap("", "take", take));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(GhostNetwork.Publications.Client.ClientUtils.ParameterToMultiMap("multi", "tags", tags));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Publication>>("/Publications", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PublicationsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Publication</returns>
        public Publication PublicationsIdGet (string id)
        {
             GhostNetwork.Publications.Client.ApiResponse<Publication> localVarResponse = PublicationsIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>ApiResponse of Publication</returns>
        public GhostNetwork.Publications.Client.ApiResponse< Publication > PublicationsIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new GhostNetwork.Publications.Client.ApiException(400, "Missing required parameter 'id' when calling PublicationsApi->PublicationsIdGet");

            GhostNetwork.Publications.Client.RequestOptions localVarRequestOptions = new GhostNetwork.Publications.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = GhostNetwork.Publications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = GhostNetwork.Publications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", GhostNetwork.Publications.Client.ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get< Publication >("/Publications/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PublicationsIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of Publication</returns>
        public async System.Threading.Tasks.Task<Publication> PublicationsIdGetAsync (string id)
        {
             GhostNetwork.Publications.Client.ApiResponse<Publication> localVarResponse = await PublicationsIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <returns>Task of ApiResponse (Publication)</returns>
        public async System.Threading.Tasks.Task<GhostNetwork.Publications.Client.ApiResponse<Publication>> PublicationsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new GhostNetwork.Publications.Client.ApiException(400, "Missing required parameter 'id' when calling PublicationsApi->PublicationsIdGet");


            GhostNetwork.Publications.Client.RequestOptions localVarRequestOptions = new GhostNetwork.Publications.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("id", GhostNetwork.Publications.Client.ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Publication>("/Publications/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PublicationsIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPublicationModel"> (optional)</param>
        /// <returns></returns>
        public void PublicationsPost (CreatePublicationModel createPublicationModel = default(CreatePublicationModel))
        {
             PublicationsPostWithHttpInfo(createPublicationModel);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPublicationModel"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public GhostNetwork.Publications.Client.ApiResponse<Object> PublicationsPostWithHttpInfo (CreatePublicationModel createPublicationModel = default(CreatePublicationModel))
        {
            GhostNetwork.Publications.Client.RequestOptions localVarRequestOptions = new GhostNetwork.Publications.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = GhostNetwork.Publications.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = GhostNetwork.Publications.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createPublicationModel;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/Publications", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PublicationsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPublicationModel"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PublicationsPostAsync (CreatePublicationModel createPublicationModel = default(CreatePublicationModel))
        {
             await PublicationsPostAsyncWithHttpInfo(createPublicationModel);

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="GhostNetwork.Publications.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPublicationModel"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<GhostNetwork.Publications.Client.ApiResponse<Object>> PublicationsPostAsyncWithHttpInfo (CreatePublicationModel createPublicationModel = default(CreatePublicationModel))
        {

            GhostNetwork.Publications.Client.RequestOptions localVarRequestOptions = new GhostNetwork.Publications.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = createPublicationModel;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/Publications", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PublicationsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
