using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grabble.Data.Domain.Inventory
{

    [Table("Stock")]
    [JsonObject("Stock")]
    public class Stock : BaseEntity
    {
        /// <summary>
        /// Gets or sets the item guid
        /// </summary>
        [JsonRequired]
        public Guid ItemGuid { get; set; }

        /// <summary>
        /// Gets or sets the item name
        /// </summary>
        [JsonRequired]
        public String ItemName { get; set; }

        /// <summary>
        /// Gets or sets the internal item  count
        /// </summary>
        [JsonRequired]
        public int ItemCount { get; set; }

        /// <summary>
        /// Gets or sets the external item count
        /// </summary>
        [JsonRequired]
        public int ExternalCount { get; set; }
    }
}
