// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Protocol;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// How the Batch service should respond if a task exits with a particular
    /// exit code.
    /// </summary>
    public partial class ExitCodeMapping
    {
        /// <summary>
        /// Initializes a new instance of the ExitCodeMapping class.
        /// </summary>
        public ExitCodeMapping()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExitCodeMapping class.
        /// </summary>
        /// <param name="code">A process exit code.</param>
        /// <param name="exitOptions">How the Batch service should respond if
        /// the task exits with this exit code.</param>
        public ExitCodeMapping(int code, ExitOptions exitOptions)
        {
            Code = code;
            ExitOptions = exitOptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a process exit code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond if the task exits
        /// with this exit code.
        /// </summary>
        [JsonProperty(PropertyName = "exitOptions")]
        public ExitOptions ExitOptions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExitOptions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExitOptions");
            }
        }
    }
}