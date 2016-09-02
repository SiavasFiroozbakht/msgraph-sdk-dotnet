// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookChartAxisTitleFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartAxisTitleFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartAxisTitleFormat using PUT.
        /// </summary>
        /// <param name="workbookChartAxisTitleFormatToCreate">The WorkbookChartAxisTitleFormat to create.</param>
        /// <returns>The created WorkbookChartAxisTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> CreateAsync(WorkbookChartAxisTitleFormat workbookChartAxisTitleFormatToCreate);        /// <summary>
        /// Creates the specified WorkbookChartAxisTitleFormat using PUT.
        /// </summary>
        /// <param name="workbookChartAxisTitleFormatToCreate">The WorkbookChartAxisTitleFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAxisTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> CreateAsync(WorkbookChartAxisTitleFormat workbookChartAxisTitleFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartAxisTitleFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartAxisTitleFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartAxisTitleFormat.
        /// </summary>
        /// <returns>The WorkbookChartAxisTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartAxisTitleFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAxisTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartAxisTitleFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisTitleFormatToUpdate">The WorkbookChartAxisTitleFormat to update.</param>
        /// <returns>The updated WorkbookChartAxisTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> UpdateAsync(WorkbookChartAxisTitleFormat workbookChartAxisTitleFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartAxisTitleFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisTitleFormatToUpdate">The WorkbookChartAxisTitleFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartAxisTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxisTitleFormat> UpdateAsync(WorkbookChartAxisTitleFormat workbookChartAxisTitleFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisTitleFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisTitleFormatRequest Select(string value);

    }
}
