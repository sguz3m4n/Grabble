using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Grabble.Domain.Order
{
    public class Order
    {
        #region Constructor

        public Order()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// Order Number should come from external entity and be a unique value. This 
        /// is represented as base class object since we may no know data type
        /// </summary>
        /// <value>
        /// Value should be a unique id
        /// </value>
        [Key]
        [JsonRequired]
        [JsonProperty("Ordernumber")]
        public object Ordernumber { get; set; }

        /// <summary>
        /// Collection of Items placed on an order
        /// </summary>
        /// <value>
        /// Value should be a unique id
        /// </value>
        public List<object> Items { get; set; }

        #endregion

        #region Methods

        #endregion
    }
}
