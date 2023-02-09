//FileName: CrmDbContext.cs
using Microsoft.EntityFrameworkCore;


public class CrmDbContext : DbContext {
    //constructor

    public CrmDbContext(DbContextOptions opts): base(opts) {}

    //Table Members
    public DbSet<Account> Account {get;set;}    public DbSet<Contact> Contact {get;set;}    public DbSet<Lead> Lead {get;set;}    public DbSet<LeadStatus> LeadStatus {get;set;}    public DbSet<Opportunity> Opportunity {get;set;}    public DbSet<OpportunityStatus> OpportunityStatus {get;set;}    public DbSet<Product> Product {get;set;}    public DbSet<Quote> Quote {get;set;}    public DbSet<QuoteItem> QuoteItem {get;set;}    public DbSet<QuoteStatus> QuoteStatus {get;set;}
    //end Table Members
    
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        SnakeCaseIdentityTableNames(modelBuilder);
    }//ef
    private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder){
        //#slot4#
    }//ef

}//ec

 
