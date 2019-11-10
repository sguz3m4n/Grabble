﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Grabble.Order.Api.Migrations
{
    public partial class Order01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderStagingId",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStagingId",
                table: "Order");
        }
    }
}
