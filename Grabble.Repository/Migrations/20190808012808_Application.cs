using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Grabble.Repository.Migrations
{
    public partial class Application : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consumer",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    CustomerGuid = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    EmailToRevalidate = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    AdminComment = table.Column<string>(nullable: true),
                    IsTaxExempt = table.Column<bool>(nullable: false),
                    AffiliateId = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false),
                    HasShoppingCartItems = table.Column<bool>(nullable: false),
                    RequireReLogin = table.Column<bool>(nullable: false),
                    FailedLoginAttempts = table.Column<int>(nullable: false),
                    CannotLoginUntilDateUtc = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    IsSystemAccount = table.Column<bool>(nullable: false),
                    SystemName = table.Column<string>(nullable: true),
                    LastIpAddress = table.Column<string>(nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(nullable: false),
                    LastLoginDateUtc = table.Column<DateTime>(nullable: true),
                    LastActivityDateUtc = table.Column<DateTime>(nullable: false),
                    RegisteredInStoreId = table.Column<int>(nullable: false),
                    BillingAddressId = table.Column<int>(nullable: false),
                    ShippingAddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    ItemGuid = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    itemName = table.Column<string>(nullable: true),
                    BarcodeNumber = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPriceInclTax = table.Column<decimal>(nullable: false),
                    UnitPriceExclTax = table.Column<decimal>(nullable: false),
                    PriceInclTax = table.Column<decimal>(nullable: false),
                    PriceExclTax = table.Column<decimal>(nullable: false),
                    DiscountAmountInclTax = table.Column<decimal>(nullable: false),
                    DiscountAmountExclTax = table.Column<decimal>(nullable: false),
                    OriginalProductCost = table.Column<decimal>(nullable: false),
                    AttributeDescription = table.Column<string>(nullable: true),
                    AttributesXml = table.Column<string>(nullable: true),
                    DownloadCount = table.Column<int>(nullable: false),
                    IsDownloadActivated = table.Column<bool>(nullable: false),
                    LicenseDownloadId = table.Column<int>(nullable: true),
                    ItemWeight = table.Column<decimal>(nullable: false),
                    ItemHeight = table.Column<decimal>(nullable: false),
                    ItemWidht = table.Column<decimal>(nullable: false),
                    ItemVolume = table.Column<decimal>(nullable: false),
                    ContentCode = table.Column<string>(nullable: true),
                    Sodium = table.Column<decimal>(nullable: false),
                    Cholesterol = table.Column<decimal>(nullable: false),
                    SaturatedFat = table.Column<decimal>(nullable: false),
                    TransFat = table.Column<decimal>(nullable: false),
                    TotalFat = table.Column<decimal>(nullable: false),
                    Calories = table.Column<decimal>(nullable: false),
                    TotalCarbohydrate = table.Column<decimal>(nullable: false),
                    DietaryFiber = table.Column<decimal>(nullable: false),
                    Sugars = table.Column<decimal>(nullable: false),
                    Protein = table.Column<decimal>(nullable: false),
                    Iron = table.Column<decimal>(nullable: false),
                    Calcium = table.Column<decimal>(nullable: false),
                    Potassium = table.Column<decimal>(nullable: false),
                    VitaminA = table.Column<decimal>(nullable: false),
                    VitaminB = table.Column<decimal>(nullable: false),
                    VitaminC = table.Column<decimal>(nullable: false),
                    VitaminD = table.Column<decimal>(nullable: false),
                    ServingSize = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    OrderGuid = table.Column<Guid>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    ConsumerId = table.Column<int>(nullable: false),
                    BillingAddressId = table.Column<int>(nullable: false),
                    ShippingAddressId = table.Column<int>(nullable: false),
                    PickupAddressId = table.Column<int>(nullable: false),
                    PickupInStore = table.Column<bool>(nullable: false),
                    OrderStatusId = table.Column<int>(nullable: false),
                    ShippingStatusId = table.Column<int>(nullable: false),
                    PaymentStatusId = table.Column<int>(nullable: false),
                    PaymentMethodSystemName = table.Column<string>(nullable: true),
                    CustomerCurrencyCode = table.Column<string>(nullable: false),
                    CurrencyRate = table.Column<decimal>(nullable: false),
                    CustomerTaxDisplayTypeId = table.Column<int>(nullable: false),
                    VatNumber = table.Column<string>(nullable: true),
                    OrderSubtotalInclTax = table.Column<decimal>(nullable: false),
                    OrderSubtotalExclTax = table.Column<decimal>(nullable: false),
                    OrderSubTotalDiscountInclTax = table.Column<decimal>(nullable: false),
                    OrderSubTotalDiscountExclTax = table.Column<decimal>(nullable: false),
                    OrderShippingInclTax = table.Column<decimal>(nullable: false),
                    OrderShippingExclTax = table.Column<decimal>(nullable: false),
                    PaymentMethodAdditionalFeeInclTax = table.Column<decimal>(nullable: false),
                    PaymentMethodAdditionalFeeExclTax = table.Column<decimal>(nullable: false),
                    TaxRates = table.Column<string>(nullable: true),
                    OrderTax = table.Column<decimal>(nullable: false),
                    OrderDiscount = table.Column<decimal>(nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    RefundedAmount = table.Column<decimal>(nullable: false),
                    RewardPointsHistoryEntryId = table.Column<int>(nullable: true),
                    CheckoutAttributeDescription = table.Column<string>(nullable: true),
                    CheckoutAttributesXml = table.Column<string>(nullable: true),
                    CustomerLanguageId = table.Column<int>(nullable: false),
                    AffiliateId = table.Column<int>(nullable: false),
                    CustomerIp = table.Column<string>(nullable: true),
                    AllowStoringCreditCardNumber = table.Column<bool>(nullable: false),
                    CardType = table.Column<string>(nullable: false),
                    CardName = table.Column<string>(nullable: false),
                    CardNumber = table.Column<string>(nullable: true),
                    MaskedCreditCardNumber = table.Column<string>(nullable: true),
                    CardCvv2 = table.Column<string>(nullable: false),
                    CardExpirationMonth = table.Column<string>(nullable: false),
                    CardExpirationYear = table.Column<string>(nullable: true),
                    AuthorizationTransactionId = table.Column<string>(nullable: false),
                    AuthorizationTransactionCode = table.Column<string>(nullable: true),
                    AuthorizationTransactionResult = table.Column<string>(nullable: true),
                    CaptureTransactionId = table.Column<string>(nullable: false),
                    CaptureTransactionResult = table.Column<string>(nullable: true),
                    SubscriptionTransactionId = table.Column<string>(nullable: true),
                    PaidDateUtc = table.Column<DateTime>(nullable: true),
                    ShippingMethod = table.Column<string>(nullable: true),
                    ShippingRateComputationMethodSystemName = table.Column<string>(nullable: true),
                    CustomValuesXml = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(nullable: false),
                    CustomOrderNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consumer");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
