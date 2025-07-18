// <auto-generated/>

using Azure.ResourceManager.IotOperations;
using Azure.ResourceManager.IotOperations.Models;
using System.ClientModel.Primitives;

namespace Azure.ResourceManager.IotOperations;

[ModelReaderWriterBuildable(typeof(IotOperationsBrokerAuthenticationData))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerAuthenticationResource))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerAuthorizationData))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerAuthorizationResource))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerData))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerListenerData))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerListenerResource))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerResource))]
[ModelReaderWriterBuildable(typeof(IotOperationsDataflowData))]
[ModelReaderWriterBuildable(typeof(IotOperationsDataflowEndpointData))]
[ModelReaderWriterBuildable(typeof(IotOperationsDataflowEndpointResource))]
[ModelReaderWriterBuildable(typeof(IotOperationsDataflowProfileData))]
[ModelReaderWriterBuildable(typeof(IotOperationsDataflowProfileResource))]
[ModelReaderWriterBuildable(typeof(IotOperationsDataflowResource))]
[ModelReaderWriterBuildable(typeof(IotOperationsInstanceData))]
[ModelReaderWriterBuildable(typeof(IotOperationsInstanceResource))]
[ModelReaderWriterBuildable(typeof(BrokerAuthenticatorCustomAuth))]
[ModelReaderWriterBuildable(typeof(BrokerAdvancedSettings))]
[ModelReaderWriterBuildable(typeof(BrokerAuthenticationResourceListResult))]
[ModelReaderWriterBuildable(typeof(BrokerAuthenticatorMethodCustom))]
[ModelReaderWriterBuildable(typeof(BrokerAuthenticatorMethods))]
[ModelReaderWriterBuildable(typeof(BrokerAuthenticatorMethodSat))]
[ModelReaderWriterBuildable(typeof(BrokerAuthenticatorMethodX509))]
[ModelReaderWriterBuildable(typeof(BrokerAuthenticatorMethodX509Attributes))]
[ModelReaderWriterBuildable(typeof(BrokerAuthorizationConfig))]
[ModelReaderWriterBuildable(typeof(BrokerAuthorizationResourceListResult))]
[ModelReaderWriterBuildable(typeof(BrokerAuthorizationRule))]
[ModelReaderWriterBuildable(typeof(BrokerBackendChain))]
[ModelReaderWriterBuildable(typeof(BrokerCardinality))]
[ModelReaderWriterBuildable(typeof(BrokerClientConfig))]
[ModelReaderWriterBuildable(typeof(BrokerDiagnostics))]
[ModelReaderWriterBuildable(typeof(BrokerDiagnosticSelfCheck))]
[ModelReaderWriterBuildable(typeof(BrokerDiagnosticTraces))]
[ModelReaderWriterBuildable(typeof(BrokerFrontend))]
[ModelReaderWriterBuildable(typeof(BrokerListenerPort))]
[ModelReaderWriterBuildable(typeof(BrokerListenerResourceListResult))]
[ModelReaderWriterBuildable(typeof(BrokerResourceListResult))]
[ModelReaderWriterBuildable(typeof(BrokerResourceRule))]
[ModelReaderWriterBuildable(typeof(CertManagerCertConfig))]
[ModelReaderWriterBuildable(typeof(CertManagerCertificateSpec))]
[ModelReaderWriterBuildable(typeof(CertManagerIssuerRef))]
[ModelReaderWriterBuildable(typeof(CertManagerPrivateKey))]
[ModelReaderWriterBuildable(typeof(DataflowBuiltInTransformationDataset))]
[ModelReaderWriterBuildable(typeof(DataflowBuiltInTransformationFilter))]
[ModelReaderWriterBuildable(typeof(DataflowBuiltInTransformationMap))]
[ModelReaderWriterBuildable(typeof(DataflowBuiltInTransformationSettings))]
[ModelReaderWriterBuildable(typeof(DataflowDestinationOperationSettings))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointAuthenticationAccessToken))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointAuthenticationSasl))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointAuthenticationServiceAccountToken))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointAuthenticationSystemAssignedManagedIdentity))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointAuthenticationUserAssignedManagedIdentity))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointAuthenticationX509))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointDataExplorer))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointDataExplorerAuthentication))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointDataLakeStorage))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointDataLakeStorageAuthentication))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointFabricOneLake))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointFabricOneLakeAuthentication))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointFabricOneLakeNames))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointKafka))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointKafkaAuthentication))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointKafkaBatching))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointLocalStorage))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointMqtt))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointMqttAuthentication))]
[ModelReaderWriterBuildable(typeof(DataflowEndpointResourceListResult))]
[ModelReaderWriterBuildable(typeof(DataflowOperationProperties))]
[ModelReaderWriterBuildable(typeof(DataflowProfileDiagnostics))]
[ModelReaderWriterBuildable(typeof(DataflowProfileResourceListResult))]
[ModelReaderWriterBuildable(typeof(DataflowResourceListResult))]
[ModelReaderWriterBuildable(typeof(DataflowSourceOperationSettings))]
[ModelReaderWriterBuildable(typeof(DiagnosticSelfTracing))]
[ModelReaderWriterBuildable(typeof(DiagnosticsLogs))]
[ModelReaderWriterBuildable(typeof(DiskBackedMessageBuffer))]
[ModelReaderWriterBuildable(typeof(GenerateResourceLimits))]
[ModelReaderWriterBuildable(typeof(InstanceResourceListResult))]
[ModelReaderWriterBuildable(typeof(IotOperationsBatchingConfig))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerAuthenticationProperties))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerAuthorizationProperties))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerListenerProperties))]
[ModelReaderWriterBuildable(typeof(IotOperationsBrokerProperties))]
[ModelReaderWriterBuildable(typeof(IotOperationsDataflowEndpointProperties))]
[ModelReaderWriterBuildable(typeof(IotOperationsDataflowProfileProperties))]
[ModelReaderWriterBuildable(typeof(IotOperationsDataflowProperties))]
[ModelReaderWriterBuildable(typeof(IotOperationsExtendedLocation))]
[ModelReaderWriterBuildable(typeof(IotOperationsInstancePatch))]
[ModelReaderWriterBuildable(typeof(IotOperationsInstanceProperties))]
[ModelReaderWriterBuildable(typeof(IotOperationsMetrics))]
[ModelReaderWriterBuildable(typeof(IotOperationsTlsProperties))]
[ModelReaderWriterBuildable(typeof(KubernetesReference))]
[ModelReaderWriterBuildable(typeof(ListenerPortTlsCertMethod))]
[ModelReaderWriterBuildable(typeof(LocalKubernetesReference))]
[ModelReaderWriterBuildable(typeof(PrincipalConfig))]
[ModelReaderWriterBuildable(typeof(SanForCert))]
[ModelReaderWriterBuildable(typeof(SchemaRegistryRef))]
[ModelReaderWriterBuildable(typeof(StateStoreResourceRule))]
[ModelReaderWriterBuildable(typeof(SubscriberQueueLimit))]
[ModelReaderWriterBuildable(typeof(VolumeClaimResourceRequirements))]
[ModelReaderWriterBuildable(typeof(VolumeClaimSpec))]
[ModelReaderWriterBuildable(typeof(VolumeClaimSpecSelector))]
[ModelReaderWriterBuildable(typeof(VolumeClaimSpecSelectorMatchExpressions))]
[ModelReaderWriterBuildable(typeof(X509ManualCertificate))]
public partial class AzureResourceManagerIotOperationsContext
{
}
