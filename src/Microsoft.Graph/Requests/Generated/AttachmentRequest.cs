// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type AttachmentRequest.
    /// </summary>
    public partial class AttachmentRequest : BaseRequest, IAttachmentRequest
    {
        /// <summary>
        /// Constructs a new AttachmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AttachmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Attachment using POST.
        /// </summary>
        /// <param name="attachmentToCreate">The Attachment to create.</param>
        /// <returns>The created Attachment.</returns>
        public System.Threading.Tasks.Task<Attachment> CreateAsync(Attachment attachmentToCreate)
        {
            return this.CreateAsync(attachmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Attachment using POST.
        /// </summary>
        /// <param name="attachmentToCreate">The Attachment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Attachment.</returns>
        public async System.Threading.Tasks.Task<Attachment> CreateAsync(Attachment attachmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Attachment>(attachmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Attachment.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Attachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Attachment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Attachment.
        /// </summary>
        /// <returns>The Attachment.</returns>
        public System.Threading.Tasks.Task<Attachment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Attachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Attachment.</returns>
        public async System.Threading.Tasks.Task<Attachment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Attachment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Attachment using PATCH.
        /// </summary>
        /// <param name="attachmentToUpdate">The Attachment to update.</param>
        /// <returns>The updated Attachment.</returns>
        public System.Threading.Tasks.Task<Attachment> UpdateAsync(Attachment attachmentToUpdate)
        {
            return this.UpdateAsync(attachmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Attachment using PATCH.
        /// </summary>
        /// <param name="attachmentToUpdate">The Attachment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Attachment.</returns>
        public async System.Threading.Tasks.Task<Attachment> UpdateAsync(Attachment attachmentToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Attachment>(attachmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAttachmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IAttachmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="attachmentToInitialize">The <see cref="Attachment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Attachment attachmentToInitialize)
        {

        }
    }
}
