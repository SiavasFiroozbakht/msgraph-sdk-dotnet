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
    /// The type Workbook Table.
    /// </summary>
    [DataContract]
    public partial class WorkbookTable : Entity
    {
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets show headers.
        /// </summary>
        [DataMember(Name = "showHeaders", EmitDefaultValue = false, IsRequired = false)]
        public bool? ShowHeaders { get; set; }
    
        /// <summary>
        /// Gets or sets show totals.
        /// </summary>
        [DataMember(Name = "showTotals", EmitDefaultValue = false, IsRequired = false)]
        public bool? ShowTotals { get; set; }
    
        /// <summary>
        /// Gets or sets style.
        /// </summary>
        [DataMember(Name = "style", EmitDefaultValue = false, IsRequired = false)]
        public string Style { get; set; }
    
        /// <summary>
        /// Gets or sets columns.
        /// </summary>
        [DataMember(Name = "columns", EmitDefaultValue = false, IsRequired = false)]
        public IWorkbookTableColumnsCollectionPage Columns { get; set; }
    
        /// <summary>
        /// Gets or sets rows.
        /// </summary>
        [DataMember(Name = "rows", EmitDefaultValue = false, IsRequired = false)]
        public IWorkbookTableRowsCollectionPage Rows { get; set; }
    
        /// <summary>
        /// Gets or sets sort.
        /// </summary>
        [DataMember(Name = "sort", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookTableSort Sort { get; set; }
    
        /// <summary>
        /// Gets or sets worksheet.
        /// </summary>
        [DataMember(Name = "worksheet", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookWorksheet Worksheet { get; set; }
    
    }
}

