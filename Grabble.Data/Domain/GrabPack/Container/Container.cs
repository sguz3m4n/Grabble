using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grabble.Data.Domain
{
    [JsonObject("Container")]
    [Table("Container")]
    public class Container : BaseEntity
    {
        //Enum grabble pack sizes
        private enum ContainerSize
        {
            Small, Medium, Large
        }

        private enum ContainerType
        {
            Box, Bag
        }

        public Container()
        {

        }


        /// <summary>
        /// Gets or sets the height of grabble container
        /// </summary>
        [JsonRequired]
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the width of grabble container
        /// </summary>
        [JsonRequired]
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or sets the depth of grabble container
        /// </summary>
        [JsonRequired]
        public decimal Depth { get; set; }

        /// <summary>
        /// Gets or sets the volume of grabble container
        /// </summary>
        [JsonRequired]
        public decimal Volume { get; set; }

        /// <summary>
        /// Gets or sets the size of grabble container
        /// </summary>
        [JsonRequired]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the type of grabble container
        /// </summary>
        [JsonRequired]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the order identifier
        /// </summary>
        public Guid OrderGuid { get; set; }
    }
}
