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
    /// The type WorkbookFunctionsMinuteRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsMinuteRequestBody
    {
    
        /// <summary>
        /// Gets or sets SerialNumber.
        /// </summary>
        [DataMember(Name = "serialNumber", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken SerialNumber { get; set; }
    
    }
}
