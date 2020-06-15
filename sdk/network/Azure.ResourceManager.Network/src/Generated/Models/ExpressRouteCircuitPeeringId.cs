// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> ExpressRoute circuit peering identifier. </summary>
    public partial class ExpressRouteCircuitPeeringId
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringId. </summary>
        public ExpressRouteCircuitPeeringId()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitPeeringId. </summary>
        /// <param name="id"> The ID of the ExpressRoute circuit peering. </param>
        internal ExpressRouteCircuitPeeringId(string id)
        {
            Id = id;
        }

        /// <summary> The ID of the ExpressRoute circuit peering. </summary>
        public string Id { get; set; }
    }
}