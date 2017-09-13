using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net;

namespace NetTelegramBotApi.Requests
{
    /// <summary>
    /// Base class for uncached
    /// </summary>
    public class InlineQueryResultNew : InlineQueryResult
    {
        /// <summary>
        /// Optional. Url of the thumbnail for the result
        /// </summary>
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Optional. Thumbnail width
        /// </summary>
        public int ThumbWidth { get; set; }

        /// <summary>
        /// Optional. Thumbnail height
        /// </summary>
        public int ThumbHeight { get; set; }
    }
}
