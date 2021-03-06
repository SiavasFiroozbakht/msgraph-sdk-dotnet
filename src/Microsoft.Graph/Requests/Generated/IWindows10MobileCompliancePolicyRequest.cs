// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindows10MobileCompliancePolicyRequest.
    /// </summary>
    public partial interface IWindows10MobileCompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10MobileCompliancePolicy using PUT.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToCreate">The Windows10MobileCompliancePolicy to create.</param>
        /// <returns>The created Windows10MobileCompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> CreateAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToCreate);        /// <summary>
        /// Creates the specified Windows10MobileCompliancePolicy using PUT.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToCreate">The Windows10MobileCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10MobileCompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> CreateAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10MobileCompliancePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10MobileCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10MobileCompliancePolicy.
        /// </summary>
        /// <returns>The Windows10MobileCompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> GetAsync();

        /// <summary>
        /// Gets the specified Windows10MobileCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10MobileCompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10MobileCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToUpdate">The Windows10MobileCompliancePolicy to update.</param>
        /// <returns>The updated Windows10MobileCompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> UpdateAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToUpdate);

        /// <summary>
        /// Updates the specified Windows10MobileCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="windows10MobileCompliancePolicyToUpdate">The Windows10MobileCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10MobileCompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10MobileCompliancePolicy> UpdateAsync(Windows10MobileCompliancePolicy windows10MobileCompliancePolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10MobileCompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10MobileCompliancePolicyRequest Expand(Expression<Func<Windows10MobileCompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10MobileCompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10MobileCompliancePolicyRequest Select(Expression<Func<Windows10MobileCompliancePolicy, object>> selectExpression);

    }
}
