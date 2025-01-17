// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Support
{
    internal class CommunicationDetailOperationSource : IOperationSource<CommunicationDetailResource>
    {
        private readonly ArmClient _client;

        internal CommunicationDetailOperationSource(ArmClient client)
        {
            _client = client;
        }

        CommunicationDetailResource IOperationSource<CommunicationDetailResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CommunicationDetailData.DeserializeCommunicationDetailData(document.RootElement);
            return new CommunicationDetailResource(_client, data);
        }

        async ValueTask<CommunicationDetailResource> IOperationSource<CommunicationDetailResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CommunicationDetailData.DeserializeCommunicationDetailData(document.RootElement);
            return new CommunicationDetailResource(_client, data);
        }
    }
}
