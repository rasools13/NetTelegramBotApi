using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net;

namespace NetTelegramBotApi.Requests
{
    /// <summary>
    /// Represents the content of a contact message to be sent as the result of an <see cref="InlineQuery"/>.
    /// </summary>
    public class InputContactMessageContent : InputMessageContent
    {
        /// <summary>
        /// Contact's phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Contact's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Optional. Contact's last name
        /// </summary>
        public string LastName { get; set; }
    }
}
