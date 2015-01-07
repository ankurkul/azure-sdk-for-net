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
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Gallery;
using Microsoft.Azure.Gallery.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Gallery
{
    /// <summary>
    /// Operations for working with gallery items.
    /// </summary>
    internal partial class ItemOperations : IServiceOperations<GalleryClient>, IItemOperations
    {
        /// <summary>
        /// Initializes a new instance of the ItemOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ItemOperations(GalleryClient client)
        {
            this._client = client;
        }
        
        private GalleryClient _client;
        
        /// <summary>
        /// Gets a reference to the Microsoft.Azure.Gallery.GalleryClient.
        /// </summary>
        public GalleryClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Gets a gallery items.
        /// </summary>
        /// <param name='itemIdentity'>
        /// Optional. Gallery item identity.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Gallery item information.
        /// </returns>
        public async Task<ItemGetParameters> GetAsync(string itemIdentity, CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("itemIdentity", itemIdentity);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/Microsoft.Gallery/galleryitems/" + (itemIdentity == null ? "" : Uri.EscapeDataString(itemIdentity));
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ItemGetParameters result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ItemGetParameters();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            GalleryItem itemInstance = new GalleryItem();
                            result.Item = itemInstance;
                            
                            JToken identityValue = responseDoc["identity"];
                            if (identityValue != null && identityValue.Type != JTokenType.Null)
                            {
                                string identityInstance = ((string)identityValue);
                                itemInstance.Identity = identityInstance;
                            }
                            
                            JToken itemNameValue = responseDoc["itemName"];
                            if (itemNameValue != null && itemNameValue.Type != JTokenType.Null)
                            {
                                string itemNameInstance = ((string)itemNameValue);
                                itemInstance.Name = itemNameInstance;
                            }
                            
                            JToken itemDisplayNameValue = responseDoc["itemDisplayName"];
                            if (itemDisplayNameValue != null && itemDisplayNameValue.Type != JTokenType.Null)
                            {
                                string itemDisplayNameInstance = ((string)itemDisplayNameValue);
                                itemInstance.DisplayName = itemDisplayNameInstance;
                            }
                            
                            JToken publisherValue = responseDoc["publisher"];
                            if (publisherValue != null && publisherValue.Type != JTokenType.Null)
                            {
                                string publisherInstance = ((string)publisherValue);
                                itemInstance.Publisher = publisherInstance;
                            }
                            
                            JToken publisherDisplayNameValue = responseDoc["publisherDisplayName"];
                            if (publisherDisplayNameValue != null && publisherDisplayNameValue.Type != JTokenType.Null)
                            {
                                string publisherDisplayNameInstance = ((string)publisherDisplayNameValue);
                                itemInstance.PublisherDisplayName = publisherDisplayNameInstance;
                            }
                            
                            JToken versionValue = responseDoc["version"];
                            if (versionValue != null && versionValue.Type != JTokenType.Null)
                            {
                                string versionInstance = ((string)versionValue);
                                itemInstance.Version = versionInstance;
                            }
                            
                            JToken summaryValue = responseDoc["summary"];
                            if (summaryValue != null && summaryValue.Type != JTokenType.Null)
                            {
                                string summaryInstance = ((string)summaryValue);
                                itemInstance.Summary = summaryInstance;
                            }
                            
                            JToken descriptionValue = responseDoc["description"];
                            if (descriptionValue != null && descriptionValue.Type != JTokenType.Null)
                            {
                                string descriptionInstance = ((string)descriptionValue);
                                itemInstance.Description = descriptionInstance;
                            }
                            
                            JToken resourceGroupNameValue = responseDoc["resourceGroupName"];
                            if (resourceGroupNameValue != null && resourceGroupNameValue.Type != JTokenType.Null)
                            {
                                string resourceGroupNameInstance = ((string)resourceGroupNameValue);
                                itemInstance.ResourceGroupName = resourceGroupNameInstance;
                            }
                            
                            JToken definitionTemplatesValue = responseDoc["definitionTemplates"];
                            if (definitionTemplatesValue != null && definitionTemplatesValue.Type != JTokenType.Null)
                            {
                                DefinitionTemplates definitionTemplatesInstance = new DefinitionTemplates();
                                itemInstance.DefinitionTemplates = definitionTemplatesInstance;
                                
                                JToken uiDefinitionFileUrlValue = definitionTemplatesValue["uiDefinitionFileUrl"];
                                if (uiDefinitionFileUrlValue != null && uiDefinitionFileUrlValue.Type != JTokenType.Null)
                                {
                                    string uiDefinitionFileUrlInstance = ((string)uiDefinitionFileUrlValue);
                                    definitionTemplatesInstance.UiDefinitionFileUrl = uiDefinitionFileUrlInstance;
                                }
                                
                                JToken defaultDeploymentTemplateIdValue = definitionTemplatesValue["defaultDeploymentTemplateId"];
                                if (defaultDeploymentTemplateIdValue != null && defaultDeploymentTemplateIdValue.Type != JTokenType.Null)
                                {
                                    string defaultDeploymentTemplateIdInstance = ((string)defaultDeploymentTemplateIdValue);
                                    definitionTemplatesInstance.DefaultDeploymentTemplateId = defaultDeploymentTemplateIdInstance;
                                }
                                
                                JToken deploymentTemplateFileUrlsSequenceElement = ((JToken)definitionTemplatesValue["deploymentTemplateFileUrls"]);
                                if (deploymentTemplateFileUrlsSequenceElement != null && deploymentTemplateFileUrlsSequenceElement.Type != JTokenType.Null)
                                {
                                    foreach (JProperty property in deploymentTemplateFileUrlsSequenceElement)
                                    {
                                        string deploymentTemplateFileUrlsKey = ((string)property.Name);
                                        string deploymentTemplateFileUrlsValue = ((string)property.Value);
                                        definitionTemplatesInstance.DeploymentTemplateFileUrls.Add(deploymentTemplateFileUrlsKey, deploymentTemplateFileUrlsValue);
                                    }
                                }
                            }
                            
                            JToken categoryIdsArray = responseDoc["categoryIds"];
                            if (categoryIdsArray != null && categoryIdsArray.Type != JTokenType.Null)
                            {
                                foreach (JToken categoryIdsValue in ((JArray)categoryIdsArray))
                                {
                                    itemInstance.CategoryIds.Add(((string)categoryIdsValue));
                                }
                            }
                            
                            JToken screenshotUrlsArray = responseDoc["screenshotUrls"];
                            if (screenshotUrlsArray != null && screenshotUrlsArray.Type != JTokenType.Null)
                            {
                                foreach (JToken screenshotUrlsValue in ((JArray)screenshotUrlsArray))
                                {
                                    itemInstance.ScreenshotUrls.Add(((string)screenshotUrlsValue));
                                }
                            }
                            
                            JToken iconFileUrlsSequenceElement = ((JToken)responseDoc["iconFileUrls"]);
                            if (iconFileUrlsSequenceElement != null && iconFileUrlsSequenceElement.Type != JTokenType.Null)
                            {
                                foreach (JProperty property2 in iconFileUrlsSequenceElement)
                                {
                                    string iconFileUrlsKey = ((string)property2.Name);
                                    string iconFileUrlsValue = ((string)property2.Value);
                                    itemInstance.IconFileUrls.Add(iconFileUrlsKey, iconFileUrlsValue);
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Gets collection of gallery items.
        /// </summary>
        /// <param name='parameters'>
        /// Optional. Query parameters. If null is passed returns all gallery
        /// items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List of gallery items.
        /// </returns>
        public async Task<ItemListResult> ListAsync(ItemListParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/Microsoft.Gallery/galleryitems?";
            bool appendFilter = true;
            if (parameters != null && parameters.Filter != null)
            {
                appendFilter = false;
                url = url + "$filter=" + Uri.EscapeDataString(parameters.Filter);
            }
            if (parameters != null && parameters.Top != null)
            {
                url = url + "&$top=" + Uri.EscapeDataString(parameters.Top.Value.ToString());
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ItemListResult result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ItemListResult();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken itemsArray = responseDoc;
                            if (itemsArray != null && itemsArray.Type != JTokenType.Null)
                            {
                                foreach (JToken itemsValue in ((JArray)itemsArray))
                                {
                                    GalleryItem galleryItemInstance = new GalleryItem();
                                    result.Items.Add(galleryItemInstance);
                                    
                                    JToken identityValue = itemsValue["identity"];
                                    if (identityValue != null && identityValue.Type != JTokenType.Null)
                                    {
                                        string identityInstance = ((string)identityValue);
                                        galleryItemInstance.Identity = identityInstance;
                                    }
                                    
                                    JToken itemNameValue = itemsValue["itemName"];
                                    if (itemNameValue != null && itemNameValue.Type != JTokenType.Null)
                                    {
                                        string itemNameInstance = ((string)itemNameValue);
                                        galleryItemInstance.Name = itemNameInstance;
                                    }
                                    
                                    JToken itemDisplayNameValue = itemsValue["itemDisplayName"];
                                    if (itemDisplayNameValue != null && itemDisplayNameValue.Type != JTokenType.Null)
                                    {
                                        string itemDisplayNameInstance = ((string)itemDisplayNameValue);
                                        galleryItemInstance.DisplayName = itemDisplayNameInstance;
                                    }
                                    
                                    JToken publisherValue = itemsValue["publisher"];
                                    if (publisherValue != null && publisherValue.Type != JTokenType.Null)
                                    {
                                        string publisherInstance = ((string)publisherValue);
                                        galleryItemInstance.Publisher = publisherInstance;
                                    }
                                    
                                    JToken publisherDisplayNameValue = itemsValue["publisherDisplayName"];
                                    if (publisherDisplayNameValue != null && publisherDisplayNameValue.Type != JTokenType.Null)
                                    {
                                        string publisherDisplayNameInstance = ((string)publisherDisplayNameValue);
                                        galleryItemInstance.PublisherDisplayName = publisherDisplayNameInstance;
                                    }
                                    
                                    JToken versionValue = itemsValue["version"];
                                    if (versionValue != null && versionValue.Type != JTokenType.Null)
                                    {
                                        string versionInstance = ((string)versionValue);
                                        galleryItemInstance.Version = versionInstance;
                                    }
                                    
                                    JToken summaryValue = itemsValue["summary"];
                                    if (summaryValue != null && summaryValue.Type != JTokenType.Null)
                                    {
                                        string summaryInstance = ((string)summaryValue);
                                        galleryItemInstance.Summary = summaryInstance;
                                    }
                                    
                                    JToken descriptionValue = itemsValue["description"];
                                    if (descriptionValue != null && descriptionValue.Type != JTokenType.Null)
                                    {
                                        string descriptionInstance = ((string)descriptionValue);
                                        galleryItemInstance.Description = descriptionInstance;
                                    }
                                    
                                    JToken resourceGroupNameValue = itemsValue["resourceGroupName"];
                                    if (resourceGroupNameValue != null && resourceGroupNameValue.Type != JTokenType.Null)
                                    {
                                        string resourceGroupNameInstance = ((string)resourceGroupNameValue);
                                        galleryItemInstance.ResourceGroupName = resourceGroupNameInstance;
                                    }
                                    
                                    JToken definitionTemplatesValue = itemsValue["definitionTemplates"];
                                    if (definitionTemplatesValue != null && definitionTemplatesValue.Type != JTokenType.Null)
                                    {
                                        DefinitionTemplates definitionTemplatesInstance = new DefinitionTemplates();
                                        galleryItemInstance.DefinitionTemplates = definitionTemplatesInstance;
                                        
                                        JToken uiDefinitionFileUrlValue = definitionTemplatesValue["uiDefinitionFileUrl"];
                                        if (uiDefinitionFileUrlValue != null && uiDefinitionFileUrlValue.Type != JTokenType.Null)
                                        {
                                            string uiDefinitionFileUrlInstance = ((string)uiDefinitionFileUrlValue);
                                            definitionTemplatesInstance.UiDefinitionFileUrl = uiDefinitionFileUrlInstance;
                                        }
                                        
                                        JToken defaultDeploymentTemplateIdValue = definitionTemplatesValue["defaultDeploymentTemplateId"];
                                        if (defaultDeploymentTemplateIdValue != null && defaultDeploymentTemplateIdValue.Type != JTokenType.Null)
                                        {
                                            string defaultDeploymentTemplateIdInstance = ((string)defaultDeploymentTemplateIdValue);
                                            definitionTemplatesInstance.DefaultDeploymentTemplateId = defaultDeploymentTemplateIdInstance;
                                        }
                                        
                                        JToken deploymentTemplateFileUrlsSequenceElement = ((JToken)definitionTemplatesValue["deploymentTemplateFileUrls"]);
                                        if (deploymentTemplateFileUrlsSequenceElement != null && deploymentTemplateFileUrlsSequenceElement.Type != JTokenType.Null)
                                        {
                                            foreach (JProperty property in deploymentTemplateFileUrlsSequenceElement)
                                            {
                                                string deploymentTemplateFileUrlsKey = ((string)property.Name);
                                                string deploymentTemplateFileUrlsValue = ((string)property.Value);
                                                definitionTemplatesInstance.DeploymentTemplateFileUrls.Add(deploymentTemplateFileUrlsKey, deploymentTemplateFileUrlsValue);
                                            }
                                        }
                                    }
                                    
                                    JToken categoryIdsArray = itemsValue["categoryIds"];
                                    if (categoryIdsArray != null && categoryIdsArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken categoryIdsValue in ((JArray)categoryIdsArray))
                                        {
                                            galleryItemInstance.CategoryIds.Add(((string)categoryIdsValue));
                                        }
                                    }
                                    
                                    JToken screenshotUrlsArray = itemsValue["screenshotUrls"];
                                    if (screenshotUrlsArray != null && screenshotUrlsArray.Type != JTokenType.Null)
                                    {
                                        foreach (JToken screenshotUrlsValue in ((JArray)screenshotUrlsArray))
                                        {
                                            galleryItemInstance.ScreenshotUrls.Add(((string)screenshotUrlsValue));
                                        }
                                    }
                                    
                                    JToken iconFileUrlsSequenceElement = ((JToken)itemsValue["iconFileUrls"]);
                                    if (iconFileUrlsSequenceElement != null && iconFileUrlsSequenceElement.Type != JTokenType.Null)
                                    {
                                        foreach (JProperty property2 in iconFileUrlsSequenceElement)
                                        {
                                            string iconFileUrlsKey = ((string)property2.Name);
                                            string iconFileUrlsValue = ((string)property2.Value);
                                            galleryItemInstance.IconFileUrls.Add(iconFileUrlsKey, iconFileUrlsValue);
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
