using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grabble.Data.Domain
{
    public class BaseDetails
    {
        #region Construtor

        #endregion

        #region Properties

        public Int64 Id { get; set; }

        [JsonProperty("CreateDate")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("CreateBy")]
        public String CreateBy { get; set; }

        [JsonProperty("ModifyDate")]
        public DateTime ModifyDate { get; set; }

        [JsonProperty("ModifyBy")]
        public String ModifyBy { get; set; }

        #endregion
    }
}
