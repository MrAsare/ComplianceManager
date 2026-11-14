using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceManager.Api.Migrations;

/// <inheritdoc />
public partial class _20261114145144_AddIsComplete : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<bool>(
            name: "IsComplete",
            table: "Obligations",
            type: "bit",
            nullable: false,
            defaultValue: false);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "IsComplete",
            table: "Obligations");
    }
}
