using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyMicroservices.WhiteLabelsMicroservice.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContextTables",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ContextName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContextTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Microservices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstanceIndex = table.Column<int>(type: "int", nullable: false),
                    ServerDestinationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Microservices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WhiteLabels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhiteLabels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhiteLabels_WhiteLabels_ParentId",
                        column: x => x.ParentId,
                        principalTable: "WhiteLabels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MicroserviceContextTables",
                columns: table => new
                {
                    ContextTableId = table.Column<long>(type: "bigint", nullable: false),
                    MicroserviceId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicroserviceContextTables", x => new { x.MicroserviceId, x.ContextTableId });
                    table.ForeignKey(
                        name: "FK_MicroserviceContextTables_ContextTables_ContextTableId",
                        column: x => x.ContextTableId,
                        principalTable: "ContextTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MicroserviceContextTables_Microservices_MicroserviceId",
                        column: x => x.MicroserviceId,
                        principalTable: "Microservices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ContextTables",
                columns: new[] { "Id", "ContextName", "TableName" },
                values: new object[,]
                {
                    { 1L, "TemplateGeneratorContext", "Forms" },
                    { 2L, "TemplateGeneratorContext", "FormDetails" },
                    { 3L, "TemplateGeneratorContext", "FormFills" },
                    { 4L, "TemplateGeneratorContext", "FormItems" },
                    { 5L, "TemplateGeneratorContext", "FormItemValues" },
                    { 6L, "TemplateGeneratorContext", "ItemTypes" }
                });

            migrationBuilder.InsertData(
                table: "Microservices",
                columns: new[] { "Id", "Description", "InstanceIndex", "Name", "ServerDestinationAddress" },
                values: new object[,]
                {
                    { 1L, null, 1, "TemplateGenerator", null },
                    { 2L, null, 1, "Email", null },
                    { 3L, null, 1, "Storage", null }
                });

            migrationBuilder.InsertData(
                table: "MicroserviceContextTables",
                columns: new[] { "ContextTableId", "MicroserviceId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 2L, 1L },
                    { 3L, 1L },
                    { 4L, 1L },
                    { 5L, 1L },
                    { 6L, 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContextTables_ContextName",
                table: "ContextTables",
                column: "ContextName");

            migrationBuilder.CreateIndex(
                name: "IX_ContextTables_TableName",
                table: "ContextTables",
                column: "TableName");

            migrationBuilder.CreateIndex(
                name: "IX_MicroserviceContextTables_ContextTableId",
                table: "MicroserviceContextTables",
                column: "ContextTableId");

            migrationBuilder.CreateIndex(
                name: "IX_Microservices_Name",
                table: "Microservices",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Microservices_Name_InstanceIndex",
                table: "Microservices",
                columns: new[] { "Name", "InstanceIndex" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_WhiteLabels_ParentId",
                table: "WhiteLabels",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MicroserviceContextTables");

            migrationBuilder.DropTable(
                name: "WhiteLabels");

            migrationBuilder.DropTable(
                name: "ContextTables");

            migrationBuilder.DropTable(
                name: "Microservices");
        }
    }
}
