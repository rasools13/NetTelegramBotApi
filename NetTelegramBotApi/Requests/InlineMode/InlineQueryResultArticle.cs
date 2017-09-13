using System;

namespace NetTelegramBotApi.Requests
{
    /// <summary>
    /// Represents a link to an article or web page.
    /// </summary>
    public class InlineQueryResultArticle : InlineQueryResultNew
    {
        /// <summary>
        /// Optional. URL of the result
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Optional. Pass <c>true</c>, if you don't want the URL to be shown in the message
        /// </summary>
        public bool HideUrl { get; set; }

        /// <summary>
        /// Optional. Short description of the result
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Optional. Url of the thumbnail for the result
        /// </summary>
        public string thumb_url { get; set; }

        /// <summary>
        /// Optional. Thumbnail width
        /// </summary>
        public int thumb_width { get; set; }

        /// <summary>
        /// Optional. Thumbnail height
        /// </summary>
        public int thumb_height { get; set; }
    }
}
