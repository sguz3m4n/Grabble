using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grabble.Data.Domain
{
    [Table("Content")]
    [JsonObject("Content")]
    public class Content : BaseEntity
    {
        /// <summary>
        /// Gets or sets the order identifier
        /// </summary>
        [JsonRequired]
        public Guid OrderGuid { get; set; }

        /// <summary>
        /// Gets or sets the item identifier
        /// </summary>
        [JsonRequired]
        public Guid ItemId { get; set; }
    }
}
