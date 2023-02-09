//FileName: CrmDbContext.cs
using Microsoft.EntityFrameworkCore;


public class CrmDbContext : DbContext {
    //constructor

    public CrmDbContext(DbContextOptions opts): base(opts) {}

    //Table Members
    public DbSet<Account> Account {get;set;}
    //end Table Members
    
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        SnakeCaseIdentityTableNames(modelBuilder);
    }//ef
    private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder){
        //#slot4#
    }//ef

}//ec

 