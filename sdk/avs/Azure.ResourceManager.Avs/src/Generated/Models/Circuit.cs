// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> An ExpressRoute Circuit. </summary>
    public partial class Circuit
    {
        /// <summary> Initializes a new instance of Circuit. </summary>
        public Circuit()
        {
        }

        /// <summary> Initializes a new instance of Circuit. </summary>
        /// <param name="primarySubnet"> CIDR of primary subnet. </param>
        /// <param name="secondarySubnet"> CIDR of secondary subnet. </param>
        /// <param name="expressRouteId"> Identifier of the ExpressRoute Circuit (Microsoft Colo only). </param>
        /// <param name="expressRoutePrivatePeeringId"> ExpressRoute Circuit private peering identifier. </param>
        internal Circuit(string primarySubnet, string secondarySubnet, string expressRouteId, string expressRoutePrivatePeeringId)
        {
            PrimarySubnet = primarySubnet;
            SecondarySubnet = secondarySubnet;
            ExpressRouteId = expressRouteId;
            ExpressRoutePrivatePeeringId = expressRoutePrivatePeeringId;
        }

        /// <summary> CIDR of primary subnet. </summary>
        public string PrimarySubnet { get; }
        /// <summary> CIDR of secondary subnet. </summary>
        public string SecondarySubnet { get; }
        /// <summary> Identifier of the ExpressRoute Circuit (Microsoft Colo only). </summary>
        public string ExpressRouteId { get; }
        /// <summary> ExpressRoute Circuit private peering identifier. </summary>
        public string ExpressRoutePrivatePeeringId { get; }
    }
}
