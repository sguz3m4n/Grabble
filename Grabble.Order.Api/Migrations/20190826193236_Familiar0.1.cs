using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Grabble.Order.Api.Migrations
{
    public partial class Familiar01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.CreateTable(
                name: "Familiar",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    FamiliarGuid = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    EmailToRevalidate = table.Column<string>(nullable: false),
                    FlightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familiar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Familiar");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttributeDescription = table.Column<string>(nullable: true),
                    AttributesXml = table.Column<string>(nullable: true),
                    BarcodeNumber = table.Column<string>(nullable: false),
                    Calcium = table.Column<decimal>(nullable: false),
                    Calories = table.Column<decimal>(nullable: false),
                    Cholesterol = table.Column<decimal>(nullable: false),
                    ContentCode = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DietaryFiber = table.Column<decimal>(nullable: false),
                    DiscountAmountExclTax = table.Column<decimal>(nullable: false),
                    DiscountAmountInclTax = table.Column<decimal>(nullable: false),
                    DownloadCount = table.Column<int>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    Iron = table.Column<decimal>(nullable: false),
                    IsDownloadActivated = table.Column<bool>(nullable: false),
                    ItemGuid = table.Column<Guid>(nullable: false),
                    ItemHeight = table.Column<decimal>(nullable: false),
                    ItemVolume = table.Column<decimal>(nullable: false),
                    ItemWeight = table.Column<decimal>(nullable: false),
                    ItemWidht = table.Column<decimal>(nullable: false),
                    LicenseDownloadId = table.Column<int>(nullable: true),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    OriginalProductCost = table.Column<decimal>(nullable: false),
                    Potassium = table.Column<decimal>(nullable: false),
                    PriceExclTax = table.Column<decimal>(nullable: false),
                    PriceInclTax = table.Column<decimal>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Protein = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    SaturatedFat = table.Column<decimal>(nullable: false),
                    ServingSize = table.Column<decimal>(nullable: false),
                    Sodium = table.Column<decimal>(nullable: false),
                    Sugars = table.Column<decimal>(nullable: false),
                    TotalCarbohydrate = table.Column<decimal>(nullable: false),
                    TotalFat = table.Column<decimal>(nullable: false),
                    TransFat = table.Column<decimal>(nullable: false),
                    UnitPriceExclTax = table.Column<decimal>(nullable: false),
                    UnitPriceInclTax = table.Column<decimal>(nullable: false),
                    VitaminA = table.Column<decimal>(nullable: false),
                    VitaminB = table.Column<decimal>(nullable: false),
                    VitaminC = table.Column<decimal>(nullable: false),
                    VitaminD = table.Column<decimal>(nullable: false),
                    itemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });
        }
    }
}
