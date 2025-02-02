// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The RecordingStatusResponse. </summary>
    public partial class RecordingStatusResult
    {
        /// <summary> Initializes a new instance of RecordingStatusResult. </summary>
        internal RecordingStatusResult()
        {
        }

        /// <summary> Initializes a new instance of RecordingStatusResult. </summary>
        /// <param name="recordingId"></param>
        /// <param name="recordingStatus"></param>
        internal RecordingStatusResult(string recordingId, RecordingStatus? recordingStatus)
        {
            RecordingId = recordingId;
            RecordingStatus = recordingStatus;
        }

        /// <summary> Gets the recording id. </summary>
        public string RecordingId { get; }
        /// <summary> Gets the recording status. </summary>
        public RecordingStatus? RecordingStatus { get; }
    }
}
