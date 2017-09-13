using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net;

namespace NetTelegramBotApi.Requests
{
    /// <summary>
    /// Represents the content of a text message to be sent as the result of an <see cref="InlineQuery"/>.
    /// </summary>
    public class InputTextMessageContent : InputMessageContent
    {
        /// <summary>
        /// Text of the message to be sent, 1-4096 characters
        /// </summary>
        public string MessageText { get; set; }

        /// <summary>
        /// Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.
        /// </summary>
        public SendMessage.ParseModeEnum ParseMode { get; set; }

        /// <summary>
        /// Optional. Disables link previews for links in the sent message
        /// </summary>
        public bool DisableWebPagePreview { get; set; }
    }
}

