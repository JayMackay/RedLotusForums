using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LotusForums.Data.Migrations
{
    public partial class UpdateApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostReplies_Posts_PostID",
                table: "PostReplies");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Forums_ForumID",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "ForumID",
                table: "Posts",
                newName: "ForumId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Posts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_ForumID",
                table: "Posts",
                newName: "IX_Posts_ForumId");

            migrationBuilder.RenameColumn(
                name: "PostID",
                table: "PostReplies",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PostReplies",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_PostReplies_PostID",
                table: "PostReplies",
                newName: "IX_PostReplies_PostId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Forums",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Membersince",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageUrl",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReplies_Posts_PostId",
                table: "PostReplies",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Forums_ForumId",
                table: "Posts",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostReplies_Posts_PostId",
                table: "PostReplies");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Forums_ForumId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Membersince",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileImageUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ForumId",
                table: "Posts",
                newName: "ForumID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_ForumId",
                table: "Posts",
                newName: "IX_Posts_ForumID");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "PostReplies",
                newName: "PostID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PostReplies",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_PostReplies_PostId",
                table: "PostReplies",
                newName: "IX_PostReplies_PostID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Forums",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PostReplies_Posts_PostID",
                table: "PostReplies",
                column: "PostID",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Forums_ForumID",
                table: "Posts",
                column: "ForumID",
                principalTable: "Forums",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
