using System;
using System.Collections.Generic;
using NetTelegramBotApi.Types;
using System.Net.Http;
using System.Net;

namespace NetTelegramBotApi.Requests
{
    /// <summary>
    /// Base Class for inline results send in response to an <see cref="InlineQuery"/>
    /// </summary>
    public class InlineQueryResult
    {
        /// <summary>
        /// Unique identifier of this result
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Type of the result
        /// </summary>
        //public InlineQueryResultType


        /// <summary>
        /// Title of the result
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Content of the message to be sent
        /// </summary>
        public InputMessageContent InputMessageContent { get; set; }

        /// <summary>
        /// Inline keyboard attached to the message
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Base Class for inline results send in response to an <see cref="InlineQuery"/>
        /// </summary>
        private static readonly Dictionary<Type, InlineQueryResultType> TypeMap =
            new Dictionary<Type, InlineQueryResultType>
            {
                {typeof(InlineQueryResultArticle), InlineQueryResultType.Article},
            };
    }
}
