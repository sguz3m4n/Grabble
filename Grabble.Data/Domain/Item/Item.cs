using Grabble.Data.Domain;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grabble.Data.Domain
{
    [JsonObject("Item")]
    [Table("Item")]
    public class Item : BaseEntity
    {
        //private ICollection<GiftCard> _associatedGiftCards;

        #region Constructor

        public Item()
        {

        }

        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the order item identifier
        /// </summary>
        [JsonRequired]
        public Guid ItemGuid { get; set; }

        /// <summary>
        /// Gets or sets the order identifier
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the item name identifier
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// Gets or sets the product Barcode number
        /// </summary>
        [JsonRequired]
        public string BarcodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price in primary store currency (include tax)
        /// </summary>
        [JsonRequired]
        public decimal UnitPriceInclTax { get; set; }

        /// <summary>
        /// Gets or sets the unit price in primary store currency (exclude tax)
        /// </summary>
        [JsonRequired]
        public decimal UnitPriceExclTax { get; set; }

        /// <summary>
        /// Gets or sets the price in primary store currency (include tax)
        /// </summary>
        [JsonRequired]
        public decimal PriceInclTax { get; set; }

        /// <summary>
        /// Gets or sets the price in primary store currency (exclude tax)
        /// </summary>
        [JsonRequired]
        public decimal PriceExclTax { get; set; }

        /// <summary>
        /// Gets or sets the discount amount (include tax)
        /// </summary>
        public decimal DiscountAmountInclTax { get; set; }

        /// <summary>
        /// Gets or sets the discount amount (exclude tax)
        /// </summary>
        public decimal DiscountAmountExclTax { get; set; }

        /// <summary>
        /// Gets or sets the original cost of this order item (when an order was placed), qty 1
        /// </summary>
        [JsonRequired]
        public decimal OriginalProductCost { get; set; }

        /// <summary>
        /// Gets or sets the attribute description
        /// </summary>
        public string AttributeDescription { get; set; }

        /// <summary>
        /// Gets or sets the product attributes in XML format
        /// </summary>
        public string AttributesXml { get; set; }

        /// <summary>
        /// Gets or sets the download count
        /// </summary>
        public int DownloadCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether download is activated
        /// </summary>
        public bool IsDownloadActivated { get; set; }

        /// <summary>
        /// Gets or sets a license download identifier (in case this is a downloadable product)
        /// </summary>
        public int? LicenseDownloadId { get; set; }

        /// <summary>
        /// Gets or sets the total weight of one item
        /// 
        /// </summary>
        [JsonRequired]
        public decimal? ItemWeight { get; set; }

        /// <summary>
        /// Gets or sets the total height of one item
        /// 
        /// </summary>
        [JsonRequired]
        public decimal ItemHeight { get; set; }

        /// <summary>
        /// Gets or sets the total width of one item
        /// 
        /// </summary>
        [JsonRequired]
        public decimal ItemWidht { get; set; }

        /// <summary>
        /// Gets or sets the total volume of one item
        /// 
        /// </summary>
        [JsonRequired]
        public decimal ItemVolume { get; set; }

        public string ContentCode { get; set; }

        public decimal Sodium { get; set; }

        public decimal Cholesterol { get; set; }

        public decimal SaturatedFat { get; set; }

        public decimal TransFat { get; set; }

        public decimal TotalFat { get; set; }

        public decimal Calories { get; set; }

        public decimal TotalCarbohydrate { get; set; }

        public decimal DietaryFiber { get; set; }

        public decimal Sugars { get; set; }

        public decimal Protein { get; set; }

        public decimal Iron { get; set; }

        public decimal Calcium { get; set; }

        public decimal Potassium { get; set; }

        public decimal VitaminA { get; set; }

        public decimal VitaminB { get; set; }

        public decimal VitaminC { get; set; }

        public decimal VitaminD { get; set; }

        public decimal ServingSize { get; set; }



        ///// <summary>
        ///// Gets or sets the rental product start date (null if it's not a rental product)
        ///// </summary>
        //public DateTime? RentalStartDateUtc { get; set; }

        ///// <summary>
        ///// Gets or sets the rental product end date (null if it's not a rental product)
        ///// </summary>
        //public DateTime? RentalEndDateUtc { get; set; }

        ///// <summary>
        ///// Gets the order
        ///// </summary>
        //public virtual Order Order { get; set; }

        ///// <summary>
        ///// Gets the product
        ///// </summary>
        //public virtual Product Product { get; set; }

        ///// <summary>
        ///// Gets or sets the associated gift card
        ///// </summary>
        //public virtual ICollection<GiftCard> AssociatedGiftCards
        //{
        //    get => _associatedGiftCards ?? (_associatedGiftCards = new List<GiftCard>());
        //    protected set => _associatedGiftCards = value;
        //}
        #endregion

    }
}
