// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Client.Structure.Service;

namespace Client.Structure.MultiClient
{
    public partial class ClientBClient
    {
        protected ClientBClient() => throw null;

        public ClientBClient(Uri endpoint, ClientType client) : this(endpoint, client, new ClientBClientOptions()) => throw null;

        public ClientBClient(Uri endpoint, ClientType client, ClientBClientOptions options) => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual Response RenamedTwo(RequestContext context) => throw null;

        public virtual Task<Response> RenamedTwoAsync(RequestContext context) => throw null;

        public virtual Response RenamedTwo(CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> RenamedTwoAsync(CancellationToken cancellationToken = default) => throw null;

        public virtual Response RenamedFour(RequestContext context) => throw null;

        public virtual Task<Response> RenamedFourAsync(RequestContext context) => throw null;

        public virtual Response RenamedFour(CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> RenamedFourAsync(CancellationToken cancellationToken = default) => throw null;

        public virtual Response RenamedSix(RequestContext context) => throw null;

        public virtual Task<Response> RenamedSixAsync(RequestContext context) => throw null;

        public virtual Response RenamedSix(CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> RenamedSixAsync(CancellationToken cancellationToken = default) => throw null;
    }
}
