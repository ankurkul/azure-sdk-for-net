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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Management.Resources
{
    public static partial class ProviderOperationsExtensions
    {
        /// <summary>
        /// Gets a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <returns>
        /// Resource provider information.
        /// </returns>
        public static ProviderGetResult Get(this IProviderOperations operations, string resourceProviderNamespace)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderOperations)s).GetAsync(resourceProviderNamespace);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a resource provider.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <returns>
        /// Resource provider information.
        /// </returns>
        public static Task<ProviderGetResult> GetAsync(this IProviderOperations operations, string resourceProviderNamespace)
        {
            return operations.GetAsync(resourceProviderNamespace, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a list of resource providers.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If null is passed returns all
        /// deployments.
        /// </param>
        /// <returns>
        /// List of resource providers.
        /// </returns>
        public static ProviderListResult List(this IProviderOperations operations, ProviderListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderOperations)s).ListAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a list of resource providers.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If null is passed returns all
        /// deployments.
        /// </param>
        /// <returns>
        /// List of resource providers.
        /// </returns>
        public static Task<ProviderListResult> ListAsync(this IProviderOperations operations, ProviderListParameters parameters)
        {
            return operations.ListAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a list of deployments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of resource providers.
        /// </returns>
        public static ProviderListResult ListNext(this IProviderOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a list of deployments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of resource providers.
        /// </returns>
        public static Task<ProviderListResult> ListNextAsync(this IProviderOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Registers provider to be used with a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Register(this IProviderOperations operations, string resourceProviderNamespace)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderOperations)s).RegisterAsync(resourceProviderNamespace);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Registers provider to be used with a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> RegisterAsync(this IProviderOperations operations, string resourceProviderNamespace)
        {
            return operations.RegisterAsync(resourceProviderNamespace, CancellationToken.None);
        }
        
        /// <summary>
        /// Unregisters provider from a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Unregister(this IProviderOperations operations, string resourceProviderNamespace)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderOperations)s).UnregisterAsync(resourceProviderNamespace);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unregisters provider from a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> UnregisterAsync(this IProviderOperations operations, string resourceProviderNamespace)
        {
            return operations.UnregisterAsync(resourceProviderNamespace, CancellationToken.None);
        }
    }
}
