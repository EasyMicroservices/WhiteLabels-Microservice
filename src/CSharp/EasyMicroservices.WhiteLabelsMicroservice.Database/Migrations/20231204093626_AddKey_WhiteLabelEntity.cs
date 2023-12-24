using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyMicroservices.WhiteLabelsMicroservice.Migrations
{
    public partial class AddKey_WhiteLabelEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                table: "WhiteLabels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "WhiteLabels",
                columns: new[] { "Id", "Description", "Key", "Name", "ParentId" },
                values: new object[] { 1L, null, new Guid("bc53b7f6-8f59-41af-b3d8-45dd1c4f57e7"), "ProjectName", null });

            migrationBuilder.InsertData(
                table: "WhiteLabels",
                columns: new[] { "Id", "Description", "Key", "Name", "ParentId" },
                values: new object[] { 2L, null, new Guid("89d6f81c-091c-4124-8447-6ec7ecaf11bb"), "TenantName", 1L });

            migrationBuilder.CreateIndex(
                name: "IX_ContextTables_ContextName_TableName",
                table: "ContextTables",
                columns: new[] { "ContextName", "TableName" },
                unique: true,
                filter: "[ContextName] IS NOT NULL AND [TableName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ContextTables_ContextName_TableName",
                table: "ContextTables");

            migrationBuilder.DeleteData(
                table: "WhiteLabels",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "WhiteLabels",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DropColumn(
                name: "Key",
                table: "WhiteLabels");
        }
    }
}
