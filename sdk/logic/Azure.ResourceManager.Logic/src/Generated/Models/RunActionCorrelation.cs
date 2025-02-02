// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The workflow run action correlation properties. </summary>
    public partial class RunActionCorrelation : RunCorrelation
    {
        /// <summary> Initializes a new instance of RunActionCorrelation. </summary>
        public RunActionCorrelation()
        {
        }

        /// <summary> Initializes a new instance of RunActionCorrelation. </summary>
        /// <param name="clientTrackingId"> The client tracking identifier. </param>
        /// <param name="clientKeywords"> The client keywords. </param>
        /// <param name="actionTrackingId"> The action tracking identifier. </param>
        internal RunActionCorrelation(string clientTrackingId, IList<string> clientKeywords, string actionTrackingId) : base(clientTrackingId, clientKeywords)
        {
            ActionTrackingId = actionTrackingId;
        }

        /// <summary> The action tracking identifier. </summary>
        public string ActionTrackingId { get; set; }
    }
}
