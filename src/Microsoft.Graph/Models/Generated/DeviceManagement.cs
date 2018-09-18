// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Management.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagement : Entity
    {
    
        /// <summary>
        /// Gets or sets subscription state.
        /// Tenant mobile device management subscription state. Possible values are: pending, active, warning, disabled, deleted, blocked, lockedOut.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptionState", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementSubscriptionState? SubscriptionState { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets intune brand.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intuneBrand", Required = Newtonsoft.Json.Required.Default)]
        public IntuneBrand IntuneBrand { get; set; }
    
        /// <summary>
        /// Gets or sets terms and conditions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsAndConditions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTermsAndConditionsCollectionPage TermsAndConditions { get; set; }
    
        /// <summary>
        /// Gets or sets apple push notification certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applePushNotificationCertificate", Required = Newtonsoft.Json.Required.Default)]
        public ApplePushNotificationCertificate ApplePushNotificationCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets managed device overview.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceOverview", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceOverview ManagedDeviceOverview { get; set; }
    
        /// <summary>
        /// Gets or sets detected apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectedApps", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDetectedAppsCollectionPage DetectedApps { get; set; }
    
        /// <summary>
        /// Gets or sets managed devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDevices", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementManagedDevicesCollectionPage ManagedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets device configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceConfigurationsCollectionPage DeviceConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCompliancePoliciesCollectionPage DeviceCompliancePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets software update status summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "softwareUpdateStatusSummary", Required = Newtonsoft.Json.Required.Default)]
        public SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy device state summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicyDeviceStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device compliance policy setting state summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCompliancePolicySettingStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCompliancePolicySettingStateSummariesCollectionPage DeviceCompliancePolicySettingStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration device state summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationDeviceStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets ios update statuses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iosUpdateStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementIosUpdateStatusesCollectionPage IosUpdateStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets device categories.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCategories", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceCategoriesCollectionPage DeviceCategories { get; set; }
    
        /// <summary>
        /// Gets or sets exchange connectors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementExchangeConnectorsCollectionPage ExchangeConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets device enrollment configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceEnrollmentConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceEnrollmentConfigurationsCollectionPage DeviceEnrollmentConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccessSettings", Required = Newtonsoft.Json.Required.Default)]
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings { get; set; }
    
        /// <summary>
        /// Gets or sets mobile threat defense connectors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileThreatDefenseConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementMobileThreatDefenseConnectorsCollectionPage MobileThreatDefenseConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets device management partners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceManagementPartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementDeviceManagementPartnersCollectionPage DeviceManagementPartners { get; set; }
    
        /// <summary>
        /// Gets or sets notification message templates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationMessageTemplates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementNotificationMessageTemplatesCollectionPage NotificationMessageTemplates { get; set; }
    
        /// <summary>
        /// Gets or sets role definitions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRoleDefinitionsCollectionPage RoleDefinitions { get; set; }
    
        /// <summary>
        /// Gets or sets role assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRoleAssignmentsCollectionPage RoleAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets resource operations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceOperations", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementResourceOperationsCollectionPage ResourceOperations { get; set; }
    
        /// <summary>
        /// Gets or sets telecom expense management partners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "telecomExpenseManagementPartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTelecomExpenseManagementPartnersCollectionPage TelecomExpenseManagementPartners { get; set; }
    
        /// <summary>
        /// Gets or sets remote assistance partners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteAssistancePartners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementRemoteAssistancePartnersCollectionPage RemoteAssistancePartners { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection app learning summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionAppLearningSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionPage WindowsInformationProtectionAppLearningSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection network learning summaries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionNetworkLearningSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionPage WindowsInformationProtectionNetworkLearningSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets troubleshooting events.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "troubleshootingEvents", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTroubleshootingEventsCollectionPage TroubleshootingEvents { get; set; }
    
    }
}
