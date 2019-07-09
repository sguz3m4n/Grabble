using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Grabble.Data.Domain.Product
{
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
        /// Name of manufactured item displayed on item packaging
        /// </summary>
        /// <value>
        /// Value should be a string 
        /// </value>
        [JsonRequired]
        [JsonProperty("ItemName")]
        public string ItemName { get; set; }

        /// <summary>
        /// Description of manufactured item displayed on item packaging
        /// </summary>
        /// <value>
        /// Value should be a string 
        /// </value>
        [JsonProperty("ItemDescription")]
        public string ItemDescription { get; set; }

        /// <summary>
        /// Collection of physical item properties such as weight, height width etc 
        /// </summary>
        /// <value>
        /// Value should be a string 
        /// </value>
        [JsonProperty("Dimensions")]
        public ICollection<object> Dimensions { get; set; }

        /// <summary>
        /// Unit cost of item 
        /// </summary>
        /// <value>
        /// Value should be a string 
        /// </value>
        [JsonRequired]
        [JsonProperty("Cost")]
        public decimal Cost { get; set; }
        #endregion

        #region Methods
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void Patch()
        {
            throw new NotImplementedException();
        }

        public void Put()
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}
