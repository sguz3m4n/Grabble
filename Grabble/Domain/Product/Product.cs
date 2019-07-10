using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grabble.Data.Domain.Detail
{
    [Table("Product")]
    public class Product
    {
        #region Constructor

        public void Item()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// A stock keeping unit (SKU) is an alphanumeric code that identifies a product and helps you track
        /// inventory for your retail business. You can create SKU numbers manually or using inventory
        /// management or point-of-sale (POS) software
        /// </summary>
        /// <value>
        /// Value should be a unique id
        /// </value>
        [Key]
        [JsonRequired]
        [JsonProperty("Sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Name of manufactured product displayed on product packaging
        /// </summary>
        /// <value>
        /// Value should be a string 
        /// </value>
        [JsonRequired]
        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        /// <summary>
        /// Description of manufactured product displayed on product packaging
        /// </summary>
        /// <value>
        /// Value should be a string 
        /// </value>
        [JsonProperty("ProductDescription")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Weight of physical product etc 
        /// </summary>
        /// <value>
        /// Value should be a decimal 
        /// </value>
        [JsonProperty("Weight")]
        public decimal Weight { get; set; }

        /// <summary>
        /// Height of physical product etc 
        /// </summary>
        /// <value>
        /// Value should be a decimal 
        /// </value>
        [JsonProperty("Height")]
        public decimal Height { get; set; }

        /// <summary>
        /// Volume of physical product etc 
        /// </summary>
        /// <value>
        /// Value should be a decimal 
        /// </value>
        [JsonProperty("Volume")]
        public decimal Volume { get; set; }

        /// <summary>
        /// Collection of physical item properties such as weight, height width etc 
        /// </summary>
        /// <value>
        /// Value should be a string 
        /// </value>
        [JsonProperty("Details")]
        [NotMapped]
        public ICollection<object> Details { get; set; }

        /// <summary>
        /// Unit cost of product 
        /// </summary>
        /// <value>
        /// Value should be a string 
        /// </value>
        [JsonRequired]
        [JsonProperty("Cost")]
        public decimal Cost { get; set; }
        #endregion

    }
}
