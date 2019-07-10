using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grabble.Data.Domain.Order
{
    [Table("Order")]
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
        [JsonProperty("OrderNumber")]
        public Guid OrderNumber { get; set; }

        /// <summary>
        /// Collection of Items placed on an order
        /// </summary>
        /// <value>
        /// Value should be a unique id
        /// </value>
        [NotMapped]
        [JsonRequired]
        [JsonProperty("Products")]
        public ICollection<object> Products { get; set; }

        [JsonRequired]
        [JsonProperty("BillingDetails")]
        public ICollection<object> BillingDetails { get; set; }

        [JsonRequired]
        [JsonProperty("ShippingDetails")]
        public ICollection<object> ShippingDetails { get; set; }

        [JsonRequired]
        [JsonProperty("OrderDate")]
        public DateTime OrderDate { get; set; }

        [JsonRequired]
        [JsonProperty("DeliveryDate")]
        public DateTime DeliveryDate { get; set; }

        [JsonProperty("Instructions")]
        public String Instructions { get; set; }

        [JsonProperty("PaymentType")]
        public String PaymentType { get; set; }

        [JsonProperty("CreateDate")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("ModifyDate")]
        public DateTime ModifyDate { get; set; }

        [JsonProperty("IPAddress")]
        public String IPAddress { get; set; }
        #endregion

    }
}
