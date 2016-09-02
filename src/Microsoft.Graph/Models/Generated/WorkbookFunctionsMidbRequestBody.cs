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

    /// <summary>
    /// The type WorkbookFunctionsMidbRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsMidbRequestBody
    {
    
        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Text { get; set; }
    
        /// <summary>
        /// Gets or sets StartNum.
        /// </summary>
        [DataMember(Name = "startNum", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken StartNum { get; set; }
    
        /// <summary>
        /// Gets or sets NumBytes.
        /// </summary>
        [DataMember(Name = "numBytes", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken NumBytes { get; set; }
    
    }
}
