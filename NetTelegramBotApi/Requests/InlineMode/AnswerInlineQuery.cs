using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net;

namespace NetTelegramBotApi.Requests
{
    /// <summary>
    /// Use this method to send answers to an inline query. On success, True is returned.
    /// No more than 50 results per query are allowed.
    /// </summary>
    public class AnswerInlineQuery : RequestBase<bool>
    {
        public AnswerInlineQuery(string inlineQueryId, InlineQueryResult InlineResult)
            : base("answerInlineQuery")
        {
            inline_query_id = inlineQueryId;
            Inline_results = InlineResult;
        }

        /// <summary>
        /// Unique identifier for the answered query
        /// </summary>
        public string inline_query_id { get; protected set; }

        /// <summary>
        /// A JSON-serialized array of results for the inline query
        /// </summary>
        public InlineQueryResult Inline_results { set; get; }

        /// <summary>
        /// The maximum amount of time in seconds that the result of the inline query 
        /// may be cached on the server. Defaults to 300.
        /// </summary>
        public int cache_time { get; set; }

        /// <summary>
        /// Pass True, if results may be cached on the server side only for the user that sent the query. 
        /// By default, results may be returned to any user who sends the same query
        /// </summary>
        public bool? is_personal { get; set; }

        /// <summary>
        /// TPass the offset that a client should send in the next query with the same text to receive more results.
        /// Pass an empty string if there are no more results or if you don‘t support pagination.
        /// Offset length can’t exceed 64 bytes.
        /// </summary>
        public string next_offset { get; set; }

        /// <summary>
        /// If passed, clients will display a button with specified text that switches the user to a private chat
        /// with the bot and sends the bot a start message with the parameter switch_pm_parameter
        /// </summary>
        public string switch_pm_text { get; set; }

        /// <summary>
        /// Deep-linking parameter for the /start message sent to the bot when user presses the switch button.
        /// 1-64 characters, only A-Z, a-z, 0-9, _ and - are allowed.
        /// </summary>
        public string switch_pm_parameter { get; set; }

        public override HttpContent CreateHttpContent()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("inline_query_id", inline_query_id);
            dic.Add("Inline_results", Inline_results.ToString());

            if (is_personal.HasValue)
            {
                dic.Add("show_alert", is_personal.Value.ToString());
            }

            if (!string.IsNullOrEmpty(next_offset))
            {
                dic.Add("url", next_offset);
            }

            if (!string.IsNullOrEmpty(switch_pm_text))
            {
                dic.Add("url", switch_pm_text);
            }

            dic.Add("cache_time", cache_time.ToString(CultureInfo.InvariantCulture));

            return new FormUrlEncodedContent(dic);
        }
    }
}
