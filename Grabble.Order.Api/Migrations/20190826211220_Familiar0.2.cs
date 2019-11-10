using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Grabble.Order.Api.Migrations
{
    public partial class Familiar02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    ItemGuid = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
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
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    ItemGuid = table.Column<Guid>(nullable: false),
                    ItemName = table.Column<string>(nullable: false),
                    ItemCount = table.Column<int>(nullable: false),
                    ExternalCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
