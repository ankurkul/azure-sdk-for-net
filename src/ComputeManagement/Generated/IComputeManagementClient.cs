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
using Microsoft.WindowsAzure.Management.Compute;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL, and are mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public partial interface IComputeManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// deployments in your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460812.aspx
        /// for more information)
        /// </summary>
        IDeploymentOperations Deployments
        {
            get; 
        }
        
        /// <summary>
        /// The Compute Management API includes operations for managing the dns
        /// servers for your subscription.
        /// </summary>
        IDNSServerOperations DnsServer
        {
            get; 
        }
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// service and virtual machine extension images in your publisher
        /// subscription.
        /// </summary>
        IExtensionImageOperations ExtensionImages
        {
            get; 
        }
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// hosted services beneath your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460812.aspx
        /// for more information)
        /// </summary>
        IHostedServiceOperations HostedServices
        {
            get; 
        }
        
        /// <summary>
        /// The Compute Management API includes operations for managing the
        /// load balancers for your subscription.
        /// </summary>
        ILoadBalancerOperations LoadBalancers
        {
            get; 
        }
        
        /// <summary>
        /// Operations for determining the version of the Azure Guest Operating
        /// System on which your service is running.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ff684169.aspx
        /// for more information)
        /// </summary>
        IOperatingSystemOperations OperatingSystems
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing service certificates for your subscription.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee795178.aspx
        /// for more information)
        /// </summary>
        IServiceCertificateOperations ServiceCertificates
        {
            get; 
        }
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// disks in your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157188.aspx
        /// for more information)
        /// </summary>
        IVirtualMachineDiskOperations VirtualMachineDisks
        {
            get; 
        }
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// virtual machine extensions in your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157206.aspx
        /// for more information)
        /// </summary>
        IVirtualMachineExtensionOperations VirtualMachineExtensions
        {
            get; 
        }
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// virtual machines in your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157206.aspx
        /// for more information)
        /// </summary>
        IVirtualMachineOperations VirtualMachines
        {
            get; 
        }
        
        /// <summary>
        /// The Service Management API includes operations for managing the OS
        /// images in your subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157175.aspx
        /// for more information)
        /// </summary>
        IVirtualMachineOSImageOperations VirtualMachineOSImages
        {
            get; 
        }
        
        /// <summary>
        /// The Service Management API includes operations for managing the
        /// virtual machine templates in your subscription.
        /// </summary>
        IVirtualMachineVMImageOperations VirtualMachineVMImages
        {
            get; 
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460783.aspx
        /// for more information)
        /// </summary>
        /// <param name='requestId'>
        /// The request ID for the request you wish to track. The request ID is
        /// returned in the x-ms-request-id response header for every request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> GetOperationStatusAsync(string requestId, CancellationToken cancellationToken);
    }
}
