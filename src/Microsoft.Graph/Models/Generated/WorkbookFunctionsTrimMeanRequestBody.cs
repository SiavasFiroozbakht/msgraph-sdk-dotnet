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
    /// The type WorkbookFunctionsTrimMeanRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsTrimMeanRequestBody
    {
    
        /// <summary>
        /// Gets or sets Array.
        /// </summary>
        [DataMember(Name = "array", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Array { get; set; }
    
        /// <summary>
        /// Gets or sets Percent.
        /// </summary>
        [DataMember(Name = "percent", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Percent { get; set; }
    
    }
}
