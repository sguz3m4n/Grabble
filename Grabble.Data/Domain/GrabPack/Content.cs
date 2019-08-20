using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Grabble.Data.Domain.GrabPack
{
    [Table("Content")]
    [JsonObject("Content")]
    public  class Content:BaseEntity
    {
        /// <summary>
        /// Gets or sets the order identifier
        /// </summary>
        public Guid OrderGuid { get; set; }
    }
}
