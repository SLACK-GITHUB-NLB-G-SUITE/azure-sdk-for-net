// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property. </summary>
    public partial class ServerAzureADOnlyAuthenticationsCreateOrUpdateOperation : Operation<ServerAzureADOnlyAuthentication>, IOperationSource<ServerAzureADOnlyAuthentication>
    {
        private readonly ArmOperationHelpers<ServerAzureADOnlyAuthentication> _operation;
        internal ServerAzureADOnlyAuthenticationsCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<ServerAzureADOnlyAuthentication>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ServerAzureADOnlyAuthenticationsCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServerAzureADOnlyAuthentication Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerAzureADOnlyAuthentication>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerAzureADOnlyAuthentication>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ServerAzureADOnlyAuthentication IOperationSource<ServerAzureADOnlyAuthentication>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ServerAzureADOnlyAuthentication.DeserializeServerAzureADOnlyAuthentication(document.RootElement);
        }

        async ValueTask<ServerAzureADOnlyAuthentication> IOperationSource<ServerAzureADOnlyAuthentication>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ServerAzureADOnlyAuthentication.DeserializeServerAzureADOnlyAuthentication(document.RootElement);
        }
    }
}
