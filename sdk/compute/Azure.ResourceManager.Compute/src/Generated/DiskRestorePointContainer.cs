// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of DiskRestorePoint and their operations over a RestorePoint. </summary>
    public partial class DiskRestorePointContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="DiskRestorePointContainer"/> class for mocking. </summary>
        protected DiskRestorePointContainer()
        {
        }

        /// <summary> Initializes a new instance of DiskRestorePointContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DiskRestorePointContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DiskRestorePointRestOperations _restClient => new DiskRestorePointRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => RestorePointOperations.ResourceType;

        // Container level operations.

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DiskRestorePoint> Get(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.Get");
            scope.Start();
            try
            {
                if (diskRestorePointName == null)
                {
                    throw new ArgumentNullException(nameof(diskRestorePointName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, diskRestorePointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskRestorePoint(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DiskRestorePoint>> GetAsync(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.Get");
            scope.Start();
            try
            {
                if (diskRestorePointName == null)
                {
                    throw new ArgumentNullException(nameof(diskRestorePointName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, diskRestorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DiskRestorePoint(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DiskRestorePoint> GetIfExists(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.GetIfExists");
            scope.Start();
            try
            {
                if (diskRestorePointName == null)
                {
                    throw new ArgumentNullException(nameof(diskRestorePointName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, diskRestorePointName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DiskRestorePoint>(null, response.GetRawResponse())
                    : Response.FromValue(new DiskRestorePoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DiskRestorePoint>> GetIfExistsAsync(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.GetIfExists");
            scope.Start();
            try
            {
                if (diskRestorePointName == null)
                {
                    throw new ArgumentNullException(nameof(diskRestorePointName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, diskRestorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DiskRestorePoint>(null, response.GetRawResponse())
                    : Response.FromValue(new DiskRestorePoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (diskRestorePointName == null)
                {
                    throw new ArgumentNullException(nameof(diskRestorePointName));
                }

                var response = GetIfExists(diskRestorePointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskRestorePointName"> The name of the disk restore point created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string diskRestorePointName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (diskRestorePointName == null)
                {
                    throw new ArgumentNullException(nameof(diskRestorePointName));
                }

                var response = await GetIfExistsAsync(diskRestorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists diskRestorePoints under a vmRestorePoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskRestorePoint" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<DiskRestorePoint> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiskRestorePoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByRestorePoint(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskRestorePoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DiskRestorePoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByRestorePointNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskRestorePoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists diskRestorePoints under a vmRestorePoint. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskRestorePoint" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<DiskRestorePoint> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiskRestorePoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByRestorePointAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskRestorePoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DiskRestorePoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByRestorePointNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskRestorePoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="DiskRestorePoint" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DiskRestorePointOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DiskRestorePoint" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DiskRestorePointContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DiskRestorePointOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, DiskRestorePoint, DiskRestorePointData> Construct() { }
    }
}
