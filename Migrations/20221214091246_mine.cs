using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Example.Migrations
{
    /// <inheritdoc />
    public partial class mine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Doctors_DoctorsDoctorId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ElifeSaverManagements_ElifeSaverManagementId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_NonMedicalStaffs_NonMedicalStaffStaffId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Nurses_NursesNurseId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DoctorsDoctorId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ElifeSaverManagementId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_NonMedicalStaffStaffId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_NursesNurseId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DoctorsDoctorId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ElifeSaverManagementId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NonMedicalStaffStaffId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NursesNurseId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Nurses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "NonMedicalStaffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ElifeSaverManagements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_UserId",
                table: "Nurses",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NonMedicalStaffs_UserId",
                table: "NonMedicalStaffs",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElifeSaverManagements_UserId",
                table: "ElifeSaverManagements",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Users_UserId",
                table: "Doctors",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElifeSaverManagements_Users_UserId",
                table: "ElifeSaverManagements",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NonMedicalStaffs_Users_UserId",
                table: "NonMedicalStaffs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Users_UserId",
                table: "Nurses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Users_UserId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_ElifeSaverManagements_Users_UserId",
                table: "ElifeSaverManagements");

            migrationBuilder.DropForeignKey(
                name: "FK_NonMedicalStaffs_Users_UserId",
                table: "NonMedicalStaffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_Users_UserId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_UserId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_NonMedicalStaffs_UserId",
                table: "NonMedicalStaffs");

            migrationBuilder.DropIndex(
                name: "IX_ElifeSaverManagements_UserId",
                table: "ElifeSaverManagements");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "NonMedicalStaffs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ElifeSaverManagements");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Doctors");

            migrationBuilder.AddColumn<string>(
                name: "DoctorsDoctorId",
                table: "Users",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ElifeSaverManagementId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NonMedicalStaffStaffId",
                table: "Users",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NursesNurseId",
                table: "Users",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DoctorsDoctorId",
                table: "Users",
                column: "DoctorsDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ElifeSaverManagementId",
                table: "Users",
                column: "ElifeSaverManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NonMedicalStaffStaffId",
                table: "Users",
                column: "NonMedicalStaffStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NursesNurseId",
                table: "Users",
                column: "NursesNurseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Doctors_DoctorsDoctorId",
                table: "Users",
                column: "DoctorsDoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ElifeSaverManagements_ElifeSaverManagementId",
                table: "Users",
                column: "ElifeSaverManagementId",
                principalTable: "ElifeSaverManagements",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_NonMedicalStaffs_NonMedicalStaffStaffId",
                table: "Users",
                column: "NonMedicalStaffStaffId",
                principalTable: "NonMedicalStaffs",
                principalColumn: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Nurses_NursesNurseId",
                table: "Users",
                column: "NursesNurseId",
                principalTable: "Nurses",
                principalColumn: "NurseId");
        }
    }
}
