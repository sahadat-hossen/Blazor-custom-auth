using BlazorCustomAuth.Common;
using BlazorCustomAuth.Entities;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCustomAuth.Repo.Migrations
{
    public partial class migForUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into dbo.UserRoles(RoleName,Status) Values('SuperAdmin',1)");
            migrationBuilder.Sql("Insert into dbo.RoleTasks(Task,UserRoleId,Status) Values(0,(Select Id from dbo.UserRoles where RoleName='SuperAdmin'),1)");
            migrationBuilder.Sql("Insert Into dbo.Users(FullName,UserName,Password,Status,RoleId) Values('Developer','dev','p@ssword',1,(Select Id from dbo.UserRoles where RoleName='SuperAdmin'))");
          
        }
        
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
