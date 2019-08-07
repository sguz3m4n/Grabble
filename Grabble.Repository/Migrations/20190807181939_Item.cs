using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Grabble.Repository.Migrations
{
    public partial class Item : Migration
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
                    ContentCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
