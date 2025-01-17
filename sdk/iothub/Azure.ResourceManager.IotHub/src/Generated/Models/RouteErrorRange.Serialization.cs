// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RouteErrorRange
    {
        internal static RouteErrorRange DeserializeRouteErrorRange(JsonElement element)
        {
            Optional<RouteErrorPosition> start = default;
            Optional<RouteErrorPosition> end = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    start = RouteErrorPosition.DeserializeRouteErrorPosition(property.Value);
                    continue;
                }
                if (property.NameEquals("end"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    end = RouteErrorPosition.DeserializeRouteErrorPosition(property.Value);
                    continue;
                }
            }
            return new RouteErrorRange(start.Value, end.Value);
        }
    }
}
