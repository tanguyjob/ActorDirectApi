using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActorDirectApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCandidateSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateSkill_Skill_SkillsSkillId",
                table: "CandidateSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateSkill",
                table: "CandidateSkill");

            migrationBuilder.DropIndex(
                name: "IX_CandidateSkill_SkillsSkillId",
                table: "CandidateSkill");

            migrationBuilder.RenameColumn(
                name: "SkillsSkillId",
                table: "CandidateSkill",
                newName: "SkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateSkill",
                table: "CandidateSkill",
                columns: new[] { "SkillId", "CandidateId" });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateSkill_CandidateId",
                table: "CandidateSkill",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateSkill_Skill_SkillId",
                table: "CandidateSkill",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateSkill_Skill_SkillId",
                table: "CandidateSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateSkill",
                table: "CandidateSkill");

            migrationBuilder.DropIndex(
                name: "IX_CandidateSkill_CandidateId",
                table: "CandidateSkill");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "CandidateSkill",
                newName: "SkillsSkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateSkill",
                table: "CandidateSkill",
                columns: new[] { "CandidateId", "SkillsSkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateSkill_SkillsSkillId",
                table: "CandidateSkill",
                column: "SkillsSkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateSkill_Skill_SkillsSkillId",
                table: "CandidateSkill",
                column: "SkillsSkillId",
                principalTable: "Skill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
