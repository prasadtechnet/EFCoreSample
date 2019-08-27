using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CAEFCoreApp1.Migrations
{
    public partial class UserCliamIdIdentifier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropPrimaryKey(name: "PK_UserClaim", table: "UserClaim");
            migrationBuilder.DropColumn(name: "UserClaimID", table: "UserClaim");


            migrationBuilder.AddColumn<int>( name: "UserClaimID",table:"UserClaim",type:"int")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(name: "PK_UserClaim", table: "UserClaim", column: "UserClaimID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
