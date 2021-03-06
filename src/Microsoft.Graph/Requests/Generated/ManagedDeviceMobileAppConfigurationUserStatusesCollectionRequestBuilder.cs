// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder : BaseRequestBuilder, IManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedDeviceMobileAppConfigurationUserStatusesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedDeviceMobileAppConfigurationUserStatusesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ManagedDeviceMobileAppConfigurationUserStatusesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedDeviceMobileAppConfigurationUserStatusRequestBuilder"/> for the specified ManagedDeviceMobileAppConfigurationManagedDeviceMobileAppConfigurationUserStatus.
        /// </summary>
        /// <param name="id">The ID for the ManagedDeviceMobileAppConfigurationManagedDeviceMobileAppConfigurationUserStatus.</param>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationUserStatusRequestBuilder"/>.</returns>
        public IManagedDeviceMobileAppConfigurationUserStatusRequestBuilder this[string id]
        {
            get
            {
                return new ManagedDeviceMobileAppConfigurationUserStatusRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
