// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;

namespace Azure.Communication.CallingServer
{
    /// <summary> The RecognizeOptions. </summary>
    internal partial class RecognizeOptionsInternal
    {
        /// <summary> Initializes a new instance of RecognizeOptionsInternal. </summary>
        /// <param name="targetParticipant"> Target participant of DTFM tone recognition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetParticipant"/> is null. </exception>
        public RecognizeOptionsInternal(CommunicationIdentifierModel targetParticipant)
        {
            if (targetParticipant == null)
            {
                throw new ArgumentNullException(nameof(targetParticipant));
            }

            TargetParticipant = targetParticipant;
        }

        /// <summary> Determines if we interrupt the prompt and start recognizing. </summary>
        public bool? InterruptPrompt { get; set; }
        /// <summary> Time to wait for first input after prompt (if any). </summary>
        public int? InitialSilenceTimeoutInSeconds { get; set; }
        /// <summary> Target participant of DTFM tone recognition. </summary>
        public CommunicationIdentifierModel TargetParticipant { get; }
        /// <summary> Defines configurations for DTMF. </summary>
        public DtmfOptions DtmfOptions { get; set; }
    }
}
