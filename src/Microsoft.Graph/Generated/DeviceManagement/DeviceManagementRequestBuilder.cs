using Microsoft.Graph.DeviceManagement.ApplePushNotificationCertificate;
using Microsoft.Graph.DeviceManagement.AuditEvents;
using Microsoft.Graph.DeviceManagement.ComplianceManagementPartners;
using Microsoft.Graph.DeviceManagement.ConditionalAccessSettings;
using Microsoft.Graph.DeviceManagement.DetectedApps;
using Microsoft.Graph.DeviceManagement.DeviceCategories;
using Microsoft.Graph.DeviceManagement.DeviceCompliancePolicies;
using Microsoft.Graph.DeviceManagement.DeviceCompliancePolicyDeviceStateSummary;
using Microsoft.Graph.DeviceManagement.DeviceCompliancePolicySettingStateSummaries;
using Microsoft.Graph.DeviceManagement.DeviceConfigurationDeviceStateSummaries;
using Microsoft.Graph.DeviceManagement.DeviceConfigurations;
using Microsoft.Graph.DeviceManagement.DeviceEnrollmentConfigurations;
using Microsoft.Graph.DeviceManagement.DeviceManagementPartners;
using Microsoft.Graph.DeviceManagement.ExchangeConnectors;
using Microsoft.Graph.DeviceManagement.GetEffectivePermissionsWithScope;
using Microsoft.Graph.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities;
using Microsoft.Graph.DeviceManagement.IosUpdateStatuses;
using Microsoft.Graph.DeviceManagement.ManagedDeviceOverview;
using Microsoft.Graph.DeviceManagement.ManagedDevices;
using Microsoft.Graph.DeviceManagement.MobileAppTroubleshootingEvents;
using Microsoft.Graph.DeviceManagement.MobileThreatDefenseConnectors;
using Microsoft.Graph.DeviceManagement.NotificationMessageTemplates;
using Microsoft.Graph.DeviceManagement.RemoteAssistancePartners;
using Microsoft.Graph.DeviceManagement.Reports;
using Microsoft.Graph.DeviceManagement.ResourceOperations;
using Microsoft.Graph.DeviceManagement.RoleAssignments;
using Microsoft.Graph.DeviceManagement.RoleDefinitions;
using Microsoft.Graph.DeviceManagement.SoftwareUpdateStatusSummary;
using Microsoft.Graph.DeviceManagement.TelecomExpenseManagementPartners;
using Microsoft.Graph.DeviceManagement.TermsAndConditions;
using Microsoft.Graph.DeviceManagement.TroubleshootingEvents;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformance;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthDeviceModelPerformance;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthDevicePerformance;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthDevicePerformanceDetails;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthOSVersionPerformance;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsAppHealthOverview;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsBaselines;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsCategories;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsDevicePerformance;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsDeviceScores;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsDeviceStartupHistory;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsDeviceStartupProcesses;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsMetricHistory;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsModelScores;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsOverview;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsScoreHistory;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsSummarizeWorkFromAnywhereDevices;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsWorkFromAnywhereMetrics;
using Microsoft.Graph.DeviceManagement.UserExperienceAnalyticsWorkFromAnywhereModelPerformance;
using Microsoft.Graph.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName;
using Microsoft.Graph.DeviceManagement.WindowsAutopilotDeviceIdentities;
using Microsoft.Graph.DeviceManagement.WindowsInformationProtectionAppLearningSummaries;
using Microsoft.Graph.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries;
using Microsoft.Graph.DeviceManagement.WindowsMalwareInformation;
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
namespace Microsoft.Graph.DeviceManagement {
    /// <summary>
    /// Provides operations to manage the deviceManagement singleton.
    /// </summary>
    public class DeviceManagementRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the applePushNotificationCertificate property of the microsoft.graph.deviceManagement entity.</summary>
        public ApplePushNotificationCertificateRequestBuilder ApplePushNotificationCertificate { get =>
            new ApplePushNotificationCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the auditEvents property of the microsoft.graph.deviceManagement entity.</summary>
        public AuditEventsRequestBuilder AuditEvents { get =>
            new AuditEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the complianceManagementPartners property of the microsoft.graph.deviceManagement entity.</summary>
        public ComplianceManagementPartnersRequestBuilder ComplianceManagementPartners { get =>
            new ComplianceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the conditionalAccessSettings property of the microsoft.graph.deviceManagement entity.</summary>
        public ConditionalAccessSettingsRequestBuilder ConditionalAccessSettings { get =>
            new ConditionalAccessSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the detectedApps property of the microsoft.graph.deviceManagement entity.</summary>
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCategories property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceCategoriesRequestBuilder DeviceCategories { get =>
            new DeviceCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicies property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceCompliancePoliciesRequestBuilder DeviceCompliancePolicies { get =>
            new DeviceCompliancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicyDeviceStateSummary property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceCompliancePolicyDeviceStateSummaryRequestBuilder DeviceCompliancePolicyDeviceStateSummary { get =>
            new DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicySettingStateSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurationDeviceStateSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceConfigurationDeviceStateSummariesRequestBuilder DeviceConfigurationDeviceStateSummaries { get =>
            new DeviceConfigurationDeviceStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurations property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceConfigurationsRequestBuilder DeviceConfigurations { get =>
            new DeviceConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceEnrollmentConfigurations property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceManagementPartners property of the microsoft.graph.deviceManagement entity.</summary>
        public DeviceManagementPartnersRequestBuilder DeviceManagementPartners { get =>
            new DeviceManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the exchangeConnectors property of the microsoft.graph.deviceManagement entity.</summary>
        public ExchangeConnectorsRequestBuilder ExchangeConnectors { get =>
            new ExchangeConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the importedWindowsAutopilotDeviceIdentities property of the microsoft.graph.deviceManagement entity.</summary>
        public ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder ImportedWindowsAutopilotDeviceIdentities { get =>
            new ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the iosUpdateStatuses property of the microsoft.graph.deviceManagement entity.</summary>
        public IosUpdateStatusesRequestBuilder IosUpdateStatuses { get =>
            new IosUpdateStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDeviceOverview property of the microsoft.graph.deviceManagement entity.</summary>
        public ManagedDeviceOverviewRequestBuilder ManagedDeviceOverview { get =>
            new ManagedDeviceOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDevices property of the microsoft.graph.deviceManagement entity.</summary>
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileAppTroubleshootingEvents property of the microsoft.graph.deviceManagement entity.</summary>
        public MobileAppTroubleshootingEventsRequestBuilder MobileAppTroubleshootingEvents { get =>
            new MobileAppTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mobileThreatDefenseConnectors property of the microsoft.graph.deviceManagement entity.</summary>
        public MobileThreatDefenseConnectorsRequestBuilder MobileThreatDefenseConnectors { get =>
            new MobileThreatDefenseConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the notificationMessageTemplates property of the microsoft.graph.deviceManagement entity.</summary>
        public NotificationMessageTemplatesRequestBuilder NotificationMessageTemplates { get =>
            new NotificationMessageTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the remoteAssistancePartners property of the microsoft.graph.deviceManagement entity.</summary>
        public RemoteAssistancePartnersRequestBuilder RemoteAssistancePartners { get =>
            new RemoteAssistancePartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reports property of the microsoft.graph.deviceManagement entity.</summary>
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the resourceOperations property of the microsoft.graph.deviceManagement entity.</summary>
        public ResourceOperationsRequestBuilder ResourceOperations { get =>
            new ResourceOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignments property of the microsoft.graph.deviceManagement entity.</summary>
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleDefinitions property of the microsoft.graph.deviceManagement entity.</summary>
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the softwareUpdateStatusSummary property of the microsoft.graph.deviceManagement entity.</summary>
        public SoftwareUpdateStatusSummaryRequestBuilder SoftwareUpdateStatusSummary { get =>
            new SoftwareUpdateStatusSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the telecomExpenseManagementPartners property of the microsoft.graph.deviceManagement entity.</summary>
        public TelecomExpenseManagementPartnersRequestBuilder TelecomExpenseManagementPartners { get =>
            new TelecomExpenseManagementPartnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the termsAndConditions property of the microsoft.graph.deviceManagement entity.</summary>
        public TermsAndConditionsRequestBuilder TermsAndConditions { get =>
            new TermsAndConditionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the troubleshootingEvents property of the microsoft.graph.deviceManagement entity.</summary>
        public TroubleshootingEventsRequestBuilder TroubleshootingEvents { get =>
            new TroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformance { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetailsRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionRequestBuilder UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion { get =>
            new UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthDeviceModelPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthDeviceModelPerformanceRequestBuilder UserExperienceAnalyticsAppHealthDeviceModelPerformance { get =>
            new UserExperienceAnalyticsAppHealthDeviceModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthDevicePerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthDevicePerformanceRequestBuilder UserExperienceAnalyticsAppHealthDevicePerformance { get =>
            new UserExperienceAnalyticsAppHealthDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthDevicePerformanceDetails property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthDevicePerformanceDetailsRequestBuilder UserExperienceAnalyticsAppHealthDevicePerformanceDetails { get =>
            new UserExperienceAnalyticsAppHealthDevicePerformanceDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthOSVersionPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthOSVersionPerformanceRequestBuilder UserExperienceAnalyticsAppHealthOSVersionPerformance { get =>
            new UserExperienceAnalyticsAppHealthOSVersionPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthOverview property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsAppHealthOverviewRequestBuilder UserExperienceAnalyticsAppHealthOverview { get =>
            new UserExperienceAnalyticsAppHealthOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsBaselines property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsBaselinesRequestBuilder UserExperienceAnalyticsBaselines { get =>
            new UserExperienceAnalyticsBaselinesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsCategories property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsCategoriesRequestBuilder UserExperienceAnalyticsCategories { get =>
            new UserExperienceAnalyticsCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDevicePerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDevicePerformanceRequestBuilder UserExperienceAnalyticsDevicePerformance { get =>
            new UserExperienceAnalyticsDevicePerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceScores property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceScoresRequestBuilder UserExperienceAnalyticsDeviceScores { get =>
            new UserExperienceAnalyticsDeviceScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceStartupHistory property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceStartupHistoryRequestBuilder UserExperienceAnalyticsDeviceStartupHistory { get =>
            new UserExperienceAnalyticsDeviceStartupHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsDeviceStartupProcesses property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsDeviceStartupProcessesRequestBuilder UserExperienceAnalyticsDeviceStartupProcesses { get =>
            new UserExperienceAnalyticsDeviceStartupProcessesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsMetricHistory property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsMetricHistoryRequestBuilder UserExperienceAnalyticsMetricHistory { get =>
            new UserExperienceAnalyticsMetricHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsModelScores property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsModelScoresRequestBuilder UserExperienceAnalyticsModelScores { get =>
            new UserExperienceAnalyticsModelScoresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsOverview property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsOverviewRequestBuilder UserExperienceAnalyticsOverview { get =>
            new UserExperienceAnalyticsOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsScoreHistory property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsScoreHistoryRequestBuilder UserExperienceAnalyticsScoreHistory { get =>
            new UserExperienceAnalyticsScoreHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the userExperienceAnalyticsSummarizeWorkFromAnywhereDevices method.</summary>
        public UserExperienceAnalyticsSummarizeWorkFromAnywhereDevicesRequestBuilder UserExperienceAnalyticsSummarizeWorkFromAnywhereDevices { get =>
            new UserExperienceAnalyticsSummarizeWorkFromAnywhereDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetricRequestBuilder UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric { get =>
            new UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetricRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsWorkFromAnywhereMetrics property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsWorkFromAnywhereMetricsRequestBuilder UserExperienceAnalyticsWorkFromAnywhereMetrics { get =>
            new UserExperienceAnalyticsWorkFromAnywhereMetricsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userExperienceAnalyticsWorkFromAnywhereModelPerformance property of the microsoft.graph.deviceManagement entity.</summary>
        public UserExperienceAnalyticsWorkFromAnywhereModelPerformanceRequestBuilder UserExperienceAnalyticsWorkFromAnywhereModelPerformance { get =>
            new UserExperienceAnalyticsWorkFromAnywhereModelPerformanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsAutopilotDeviceIdentities property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsAutopilotDeviceIdentitiesRequestBuilder WindowsAutopilotDeviceIdentities { get =>
            new WindowsAutopilotDeviceIdentitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsInformationProtectionAppLearningSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsInformationProtectionAppLearningSummariesRequestBuilder WindowsInformationProtectionAppLearningSummaries { get =>
            new WindowsInformationProtectionAppLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsInformationProtectionNetworkLearningSummaries property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsInformationProtectionNetworkLearningSummariesRequestBuilder WindowsInformationProtectionNetworkLearningSummaries { get =>
            new WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsMalwareInformation property of the microsoft.graph.deviceManagement entity.</summary>
        public WindowsMalwareInformationRequestBuilder WindowsMalwareInformation { get =>
            new WindowsMalwareInformationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Read properties and relationships of the deviceManagement object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/intune-raimportcerts-devicemanagement-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.DeviceManagement?> GetAsync(Action<DeviceManagementRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.DeviceManagement> GetAsync(Action<DeviceManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.DeviceManagement>(requestInfo, Microsoft.Graph.Models.DeviceManagement.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getEffectivePermissions method.
        /// </summary>
        /// <param name="scope">Usage: scope=&apos;{scope}&apos;</param>
        public GetEffectivePermissionsWithScopeRequestBuilder GetEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(PathParameters, RequestAdapter, scope);
        }
        /// <summary>
        /// Update the properties of a deviceManagement object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/intune-androidforwork-devicemanagement-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.DeviceManagement?> PatchAsync(Microsoft.Graph.Models.DeviceManagement body, Action<DeviceManagementRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.DeviceManagement> PatchAsync(Microsoft.Graph.Models.DeviceManagement body, Action<DeviceManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.DeviceManagement>(requestInfo, Microsoft.Graph.Models.DeviceManagement.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Read properties and relationships of the deviceManagement object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<DeviceManagementRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<DeviceManagementRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new DeviceManagementRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a deviceManagement object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.DeviceManagement body, Action<DeviceManagementRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Models.DeviceManagement body, Action<DeviceManagementRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new DeviceManagementRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the verifyWindowsEnrollmentAutoDiscovery method.
        /// </summary>
        /// <param name="domainName">Usage: domainName=&apos;{domainName}&apos;</param>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder VerifyWindowsEnrollmentAutoDiscoveryWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(PathParameters, RequestAdapter, domainName);
        }
        /// <summary>
        /// Read properties and relationships of the deviceManagement object.
        /// </summary>
        public class DeviceManagementRequestBuilderGetQueryParameters {
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
        public class DeviceManagementRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeviceManagementRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeviceManagementRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new deviceManagementRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceManagementRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deviceManagementRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceManagementRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
