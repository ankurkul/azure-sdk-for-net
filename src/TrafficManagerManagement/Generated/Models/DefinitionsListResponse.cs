// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure.Management.TrafficManager.Models
{
    /// <summary>
    /// The List Definitions operation response.
    /// </summary>
    public partial class DefinitionsListResponse : AzureOperationResponse, IEnumerable<Definition>
    {
        private IList<Definition> _definitions;
        
        /// <summary>
        /// Optional. All definitions of a profile.
        /// </summary>
        public IList<Definition> Definitions
        {
            get { return this._definitions; }
            set { this._definitions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DefinitionsListResponse class.
        /// </summary>
        public DefinitionsListResponse()
        {
            this.Definitions = new LazyList<Definition>();
        }
        
        /// <summary>
        /// Gets the sequence of Definitions.
        /// </summary>
        public IEnumerator<Definition> GetEnumerator()
        {
            return this.Definitions.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Definitions.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
