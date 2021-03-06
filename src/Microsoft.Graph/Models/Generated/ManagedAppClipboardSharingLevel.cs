// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ManagedAppClipboardSharingLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ManagedAppClipboardSharingLevel
    {
    
        /// <summary>
        /// All Apps
        /// </summary>
        AllApps = 0,
	
        /// <summary>
        /// Managed Apps With Paste In
        /// </summary>
        ManagedAppsWithPasteIn = 1,
	
        /// <summary>
        /// Managed Apps
        /// </summary>
        ManagedApps = 2,
	
        /// <summary>
        /// Blocked
        /// </summary>
        Blocked = 3,
	
    }
}
