﻿using System.Collections.Generic;

namespace CloudFlare.Client.Api.Result
{
    public class CloudFlareResult<T>
    {
        /// <summary>
        /// Generic result property
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// Additional pagination info
        /// </summary>
        public ResultInfo ResultInfo { get; set; }

        /// <summary>
        /// Success flag
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Additional messages
        /// </summary>
        public IReadOnlyList<ErrorDetails> Messages { get; set; }

        /// <summary>
        /// Array of potential errors
        /// </summary>
        public IReadOnlyList<ApiError> Errors { get; set; }

        /// <summary>
        /// Time info of procession
        /// </summary>
        public TimingInfo Timing { get; set; }
    }
}
