﻿// <auto-generated />
using System;
using Grabble.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Grabble.Repository.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Grabble.Data.Domain.Consumer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("AdminComment");

                    b.Property<int>("AffiliateId");

                    b.Property<int>("Age");

                    b.Property<int?>("BillingAddressId")
                        .IsRequired();

                    b.Property<DateTime?>("CannotLoginUntilDateUtc");

                    b.Property<string>("CreateBy");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("CreatedOnUtc");

                    b.Property<Guid>("CustomerGuid");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EmailToRevalidate")
                        .IsRequired();

                    b.Property<int>("FailedLoginAttempts");

                    b.Property<string>("Firstname")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<bool>("HasShoppingCartItems");

                    b.Property<string>("IPAddress");

                    b.Property<bool>("IsSystemAccount");

                    b.Property<bool>("IsTaxExempt");

                    b.Property<DateTime>("LastActivityDateUtc");

                    b.Property<string>("LastIpAddress");

                    b.Property<DateTime?>("LastLoginDateUtc");

                    b.Property<string>("Lastname")
                        .IsRequired();

                    b.Property<string>("ModifyBy");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<int>("RegisteredInStoreId");

                    b.Property<bool>("RequireReLogin");

                    b.Property<int?>("ShippingAddressId")
                        .IsRequired();

                    b.Property<string>("SystemName");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.Property<int>("VendorId");

                    b.HasKey("Id");

                    b.ToTable("Consumer");
                });

            modelBuilder.Entity("Grabble.Data.Domain.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttributeDescription");

                    b.Property<string>("AttributesXml");

                    b.Property<string>("BarcodeNumber")
                        .IsRequired();

                    b.Property<decimal>("Calcium");

                    b.Property<decimal>("Calories");

                    b.Property<decimal>("Cholesterol");

                    b.Property<string>("ContentCode");

                    b.Property<string>("CreateBy");

                    b.Property<DateTime>("CreateDate");

                    b.Property<decimal>("DietaryFiber");

                    b.Property<decimal>("DiscountAmountExclTax");

                    b.Property<decimal>("DiscountAmountInclTax");

                    b.Property<int>("DownloadCount");

                    b.Property<string>("IPAddress");

                    b.Property<decimal>("Iron");

                    b.Property<bool>("IsDownloadActivated");

                    b.Property<Guid>("ItemGuid");

                    b.Property<decimal>("ItemHeight");

                    b.Property<decimal>("ItemVolume");

                    b.Property<decimal?>("ItemWeight")
                        .IsRequired();

                    b.Property<decimal>("ItemWidht");

                    b.Property<int?>("LicenseDownloadId");

                    b.Property<string>("ModifyBy");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("OriginalProductCost");

                    b.Property<decimal>("Potassium");

                    b.Property<decimal>("PriceExclTax");

                    b.Property<decimal>("PriceInclTax");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("Protein");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("SaturatedFat");

                    b.Property<decimal>("ServingSize");

                    b.Property<decimal>("Sodium");

                    b.Property<decimal>("Sugars");

                    b.Property<decimal>("TotalCarbohydrate");

                    b.Property<decimal>("TotalFat");

                    b.Property<decimal>("TransFat");

                    b.Property<decimal>("UnitPriceExclTax");

                    b.Property<decimal>("UnitPriceInclTax");

                    b.Property<decimal>("VitaminA");

                    b.Property<decimal>("VitaminB");

                    b.Property<decimal>("VitaminC");

                    b.Property<decimal>("VitaminD");

                    b.Property<string>("itemName");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Grabble.Data.Domain.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AffiliateId");

                    b.Property<bool>("AllowStoringCreditCardNumber");

                    b.Property<string>("AuthorizationTransactionCode");

                    b.Property<string>("AuthorizationTransactionId")
                        .IsRequired();

                    b.Property<string>("AuthorizationTransactionResult");

                    b.Property<int>("BillingAddressId");

                    b.Property<string>("CaptureTransactionId")
                        .IsRequired();

                    b.Property<string>("CaptureTransactionResult");

                    b.Property<string>("CardCvv2")
                        .IsRequired();

                    b.Property<string>("CardExpirationMonth")
                        .IsRequired();

                    b.Property<string>("CardExpirationYear");

                    b.Property<string>("CardName")
                        .IsRequired();

                    b.Property<string>("CardNumber");

                    b.Property<string>("CardType")
                        .IsRequired();

                    b.Property<string>("CheckoutAttributeDescription");

                    b.Property<string>("CheckoutAttributesXml");

                    b.Property<int>("ConsumerId");

                    b.Property<string>("CreateBy");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("CreatedOnUtc");

                    b.Property<decimal>("CurrencyRate");

                    b.Property<string>("CustomOrderNumber");

                    b.Property<string>("CustomValuesXml");

                    b.Property<string>("CustomerCurrencyCode")
                        .IsRequired();

                    b.Property<string>("CustomerIp");

                    b.Property<int>("CustomerLanguageId");

                    b.Property<int>("CustomerTaxDisplayTypeId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("IPAddress");

                    b.Property<string>("MaskedCreditCardNumber");

                    b.Property<string>("ModifyBy");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<decimal>("OrderDiscount");

                    b.Property<Guid>("OrderGuid");

                    b.Property<decimal>("OrderShippingExclTax");

                    b.Property<decimal>("OrderShippingInclTax");

                    b.Property<int>("OrderStatusId");

                    b.Property<decimal>("OrderSubTotalDiscountExclTax");

                    b.Property<decimal>("OrderSubTotalDiscountInclTax");

                    b.Property<decimal>("OrderSubtotalExclTax");

                    b.Property<decimal>("OrderSubtotalInclTax");

                    b.Property<decimal>("OrderTax");

                    b.Property<decimal>("OrderTotal");

                    b.Property<DateTime?>("PaidDateUtc");

                    b.Property<decimal>("PaymentMethodAdditionalFeeExclTax");

                    b.Property<decimal>("PaymentMethodAdditionalFeeInclTax");

                    b.Property<string>("PaymentMethodSystemName");

                    b.Property<int>("PaymentStatusId");

                    b.Property<int?>("PickupAddressId")
                        .IsRequired();

                    b.Property<bool>("PickupInStore");

                    b.Property<decimal>("RefundedAmount");

                    b.Property<int?>("RewardPointsHistoryEntryId");

                    b.Property<int?>("ShippingAddressId")
                        .IsRequired();

                    b.Property<string>("ShippingMethod");

                    b.Property<string>("ShippingRateComputationMethodSystemName");

                    b.Property<int>("ShippingStatusId");

                    b.Property<int>("StoreId");

                    b.Property<string>("SubscriptionTransactionId");

                    b.Property<string>("TaxRates");

                    b.Property<string>("VatNumber");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
