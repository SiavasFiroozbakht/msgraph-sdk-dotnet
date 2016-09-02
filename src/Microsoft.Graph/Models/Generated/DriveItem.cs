// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Drive Item.
    /// </summary>
    [DataContract]
    public partial class DriveItem : Entity
    {
    
        /// <summary>
        /// Gets or sets content.
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false, IsRequired = false)]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false, IsRequired = false)]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [DataMember(Name = "createdDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets c tag.
        /// </summary>
        [DataMember(Name = "cTag", EmitDefaultValue = false, IsRequired = false)]
        public string CTag { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets e tag.
        /// </summary>
        [DataMember(Name = "eTag", EmitDefaultValue = false, IsRequired = false)]
        public string ETag { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// </summary>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = false, IsRequired = false)]
        public IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [DataMember(Name = "lastModifiedDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets parent reference.
        /// </summary>
        [DataMember(Name = "parentReference", EmitDefaultValue = false, IsRequired = false)]
        public ItemReference ParentReference { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false, IsRequired = false)]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets web dav url.
        /// </summary>
        [DataMember(Name = "webDavUrl", EmitDefaultValue = false, IsRequired = false)]
        public string WebDavUrl { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// </summary>
        [DataMember(Name = "webUrl", EmitDefaultValue = false, IsRequired = false)]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets audio.
        /// </summary>
        [DataMember(Name = "audio", EmitDefaultValue = false, IsRequired = false)]
        public Audio Audio { get; set; }
    
        /// <summary>
        /// Gets or sets deleted.
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = false, IsRequired = false)]
        public Deleted Deleted { get; set; }
    
        /// <summary>
        /// Gets or sets file.
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false, IsRequired = false)]
        public File File { get; set; }
    
        /// <summary>
        /// Gets or sets file system info.
        /// </summary>
        [DataMember(Name = "fileSystemInfo", EmitDefaultValue = false, IsRequired = false)]
        public FileSystemInfo FileSystemInfo { get; set; }
    
        /// <summary>
        /// Gets or sets folder.
        /// </summary>
        [DataMember(Name = "folder", EmitDefaultValue = false, IsRequired = false)]
        public Folder Folder { get; set; }
    
        /// <summary>
        /// Gets or sets image.
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false, IsRequired = false)]
        public Image Image { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false, IsRequired = false)]
        public GeoCoordinates Location { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// </summary>
        [DataMember(Name = "photo", EmitDefaultValue = false, IsRequired = false)]
        public Photo Photo { get; set; }
    
        /// <summary>
        /// Gets or sets remote item.
        /// </summary>
        [DataMember(Name = "remoteItem", EmitDefaultValue = false, IsRequired = false)]
        public RemoteItem RemoteItem { get; set; }
    
        /// <summary>
        /// Gets or sets search result.
        /// </summary>
        [DataMember(Name = "searchResult", EmitDefaultValue = false, IsRequired = false)]
        public SearchResult SearchResult { get; set; }
    
        /// <summary>
        /// Gets or sets shared.
        /// </summary>
        [DataMember(Name = "shared", EmitDefaultValue = false, IsRequired = false)]
        public Shared Shared { get; set; }
    
        /// <summary>
        /// Gets or sets special folder.
        /// </summary>
        [DataMember(Name = "specialFolder", EmitDefaultValue = false, IsRequired = false)]
        public SpecialFolder SpecialFolder { get; set; }
    
        /// <summary>
        /// Gets or sets video.
        /// </summary>
        [DataMember(Name = "video", EmitDefaultValue = false, IsRequired = false)]
        public Video Video { get; set; }
    
        /// <summary>
        /// Gets or sets package.
        /// </summary>
        [DataMember(Name = "package", EmitDefaultValue = false, IsRequired = false)]
        public Package Package { get; set; }
    
        /// <summary>
        /// Gets or sets created by user.
        /// </summary>
        [DataMember(Name = "createdByUser", EmitDefaultValue = false, IsRequired = false)]
        public User CreatedByUser { get; set; }
    
        /// <summary>
        /// Gets or sets workbook.
        /// </summary>
        [DataMember(Name = "workbook", EmitDefaultValue = false, IsRequired = false)]
        public Workbook Workbook { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by user.
        /// </summary>
        [DataMember(Name = "lastModifiedByUser", EmitDefaultValue = false, IsRequired = false)]
        public User LastModifiedByUser { get; set; }
    
        /// <summary>
        /// Gets or sets permissions.
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false, IsRequired = false)]
        public IDriveItemPermissionsCollectionPage Permissions { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = false, IsRequired = false)]
        public IDriveItemChildrenCollectionPage Children { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnails.
        /// </summary>
        [DataMember(Name = "thumbnails", EmitDefaultValue = false, IsRequired = false)]
        public IDriveItemThumbnailsCollectionPage Thumbnails { get; set; }
    
    }
}

