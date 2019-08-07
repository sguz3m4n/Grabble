using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Grabble.Repository.Migrations.Order
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Order");
        }
    }
}
