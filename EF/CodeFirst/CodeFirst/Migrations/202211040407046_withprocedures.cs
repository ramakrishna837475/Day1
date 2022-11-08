namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class withprocedures : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.insertbook",
                p => new
                    {
                        BookName = p.String(),
                    },
                body:
                    @"INSERT [dbo].[tbl_Book]([BookName])
                      VALUES (@BookName)
                      
                      DECLARE @BookId int
                      SELECT @BookId = [BookId]
                      FROM [dbo].[tbl_Book]
                      WHERE @@ROWCOUNT > 0 AND [BookId] = scope_identity()
                      
                      SELECT t0.[BookId]
                      FROM [dbo].[tbl_Book] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[BookId] = @BookId"
            );
            
            CreateStoredProcedure(
                "dbo.updatebook",
                p => new
                    {
                        BookId = p.Int(),
                        BookName = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[tbl_Book]
                      SET [BookName] = @BookName
                      WHERE ([BookId] = @BookId)"
            );
            
            CreateStoredProcedure(
                "dbo.deletebook",
                p => new
                    {
                        BookId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[tbl_Book]
                      WHERE ([BookId] = @BookId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.deletebook");
            DropStoredProcedure("dbo.updatebook");
            DropStoredProcedure("dbo.insertbook");
        }
    }
}
