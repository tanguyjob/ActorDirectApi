using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActorDirectApi.Migrations
{
    /// <inheritdoc />
    public partial class Initialization2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_candidates",
                table: "candidates");

            migrationBuilder.RenameTable(
                name: "candidates",
                newName: "Candidate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidate",
                table: "Candidate",
                column: "CandidateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidate",
                table: "Candidate");

            migrationBuilder.RenameTable(
                name: "Candidate",
                newName: "candidates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_candidates",
                table: "candidates",
                column: "CandidateId");
        }
    }
}
