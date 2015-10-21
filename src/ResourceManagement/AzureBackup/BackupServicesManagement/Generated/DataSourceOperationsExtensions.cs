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
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices
{
    public static partial class DataSourceOperationsExtensions
    {
        /// <summary>
        /// Disable protection for given item
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IDataSourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Required. containerName.
        /// </param>
        /// <param name='itemName'>
        /// Required. itemName.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static OperationResponse DisableProtectionCSM(this IDataSourceOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataSourceOperations)s).DisableProtectionCSMAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Disable protection for given item
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IDataSourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Required. containerName.
        /// </param>
        /// <param name='itemName'>
        /// Required. itemName.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static Task<OperationResponse> DisableProtectionCSMAsync(this IDataSourceOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName)
        {
            return operations.DisableProtectionCSMAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName, CancellationToken.None);
        }
        
        /// <summary>
        /// Enable protection for given item.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IDataSourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Required. containerName.
        /// </param>
        /// <param name='itemName'>
        /// Required. itemName.
        /// </param>
        /// <param name='csmparameters'>
        /// Required. Set protection request input.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static OperationResponse EnableProtectionCSM(this IDataSourceOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName, CSMSetProtectionRequest csmparameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataSourceOperations)s).EnableProtectionCSMAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName, csmparameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Enable protection for given item.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IDataSourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Required. containerName.
        /// </param>
        /// <param name='itemName'>
        /// Required. itemName.
        /// </param>
        /// <param name='csmparameters'>
        /// Required. Set protection request input.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static Task<OperationResponse> EnableProtectionCSMAsync(this IDataSourceOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName, CSMSetProtectionRequest csmparameters)
        {
            return operations.EnableProtectionCSMAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName, csmparameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all Datasources.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IDataSourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='csmparameters'>
        /// Optional. DataSource query parameter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a CSMProtectedItemListOperationResponse.
        /// </returns>
        public static CSMProtectedItemListOperationResponse ListCSM(this IDataSourceOperations operations, string resourceGroupName, string resourceName, CSMProtectedItemQueryObject csmparameters, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataSourceOperations)s).ListCSMAsync(resourceGroupName, resourceName, csmparameters, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all Datasources.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IDataSourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='csmparameters'>
        /// Optional. DataSource query parameter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a CSMProtectedItemListOperationResponse.
        /// </returns>
        public static Task<CSMProtectedItemListOperationResponse> ListCSMAsync(this IDataSourceOperations operations, string resourceGroupName, string resourceName, CSMProtectedItemQueryObject csmparameters, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListCSMAsync(resourceGroupName, resourceName, csmparameters, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Enable protection for given item.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IDataSourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Required. containerName.
        /// </param>
        /// <param name='itemName'>
        /// Required. itemName.
        /// </param>
        /// <param name='csmparameters'>
        /// Required. Set protection request input.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static OperationResponse UpdateProtectionCSM(this IDataSourceOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName, CSMUpdateProtectionRequest csmparameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDataSourceOperations)s).UpdateProtectionCSMAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName, csmparameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Enable protection for given item.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IDataSourceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Required. containerName.
        /// </param>
        /// <param name='itemName'>
        /// Required. itemName.
        /// </param>
        /// <param name='csmparameters'>
        /// Required. Set protection request input.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static Task<OperationResponse> UpdateProtectionCSMAsync(this IDataSourceOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName, CSMUpdateProtectionRequest csmparameters)
        {
            return operations.UpdateProtectionCSMAsync(resourceGroupName, resourceName, customRequestHeaders, containerName, itemName, csmparameters, CancellationToken.None);
        }
    }
}