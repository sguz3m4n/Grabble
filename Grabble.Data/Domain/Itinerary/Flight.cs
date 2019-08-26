using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grabble.Data.Domain
{
    [Table("Flight")]
    [JsonObject("Flight")]
    public class Flight : BaseEntity
    {
        /// <summary>
        /// Gets or sets the grabbler departure date
        /// </summary>
        [JsonRequired]
        public DateTime DepartureDate { get; set; }

        /// <summary>
        /// Gets or sets the airline
        /// </summary>
        [JsonRequired]
        public String Airline { get; set; }

        /// <summary>
        /// Gets or sets the grabbler departure time
        /// </summary>
        [JsonRequired]
        public TimeSpan DepartureTime { get; set; }

        /// <summary>
        /// Gets or sets the departure destination
        /// </summary>
        [JsonRequired]
        public String Destination { get; set; }
    }
}
