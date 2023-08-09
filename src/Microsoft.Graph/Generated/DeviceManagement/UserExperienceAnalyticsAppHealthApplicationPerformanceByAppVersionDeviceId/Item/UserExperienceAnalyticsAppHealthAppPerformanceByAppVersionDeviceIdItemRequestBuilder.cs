// <auto-generated/>
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId.Item {
    /// <summary>
    /// Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId/{userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId/{userExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId for deviceManagement
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// User experience analytics appHealth Application Performance by App Version Device Id
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId?> GetAsync(Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId> GetAsync(Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>(requestInfo, UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId?> PatchAsync(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId body, Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId> PatchAsync(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId body, Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>(requestInfo, UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId for deviceManagement
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// User experience analytics appHealth Application Performance by App Version Device Id
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId in deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId body, Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId body, Action<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// User experience analytics appHealth Application Performance by App Version Device Id
        /// </summary>
        public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceIdItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
