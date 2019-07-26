using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Grabble.Data.Domain
{
    [NotMapped]
    public class BaseEntity
    {
        #region Construtor

        #endregion

        #region Properties

        [Key]
        [JsonIgnore]
        public Int64 Id { get; set; }

        [JsonProperty("CreateDate")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("CreateBy")]
        public String CreateBy { get; set; }

        [JsonProperty("ModifyDate")]
        public DateTime ModifyDate { get; set; }

        [JsonProperty("ModifyBy")]
        public String ModifyBy { get; set; }

        [JsonProperty("IPAddress")]
        public String IPAddress { get; set; }

        #endregion

    }
}
