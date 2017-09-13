using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net;

namespace NetTelegramBotApi.Requests
{
    /// <summary>
    /// Represents the content of a <see cref="Venue"/> message to be sent as the result of an <see cref="InlineQuery"/>.
    /// </summary>
    public class InputVenueMessageContent : InputMessageContent
    {
        /// <summary>
        /// Latitude of the location in degrees
        /// </summary>
        public float Latitude { get; set; }

        /// <summary>
        /// Longitude of the location in degrees
        /// </summary>
        public float Longitude { get; set; }

        /// <summary>
        /// Name of the venue
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address of the venue
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Optional. Foursquare identifier of the venue, if known
        /// </summary>
        public string FoursquareId { get; set; }
    }
}
