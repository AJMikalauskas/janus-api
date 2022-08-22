using Microsoft.EntityFrameworkCore;
using Janus_API.Models;

namespace Janus_API.Data
{
    public class Janus_APIContext : DbContext
    {
        public Janus_APIContext(DbContextOptions<Janus_APIContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder
        //    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFDataSeeding;Trusted_Connection=True");
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //modelBuilder.Entity<Blog>(entity => { entity.Property(e => e.Url).IsRequired(); });
            //#region BlogSeed
            //modelBuilder.Entity<Blog>().HasData(new Blog { BlogId = 1, Url = "http://sample.com" });
            //#endregion
          /*  builder.Entity<Asset>().Property(x => x.UnitPrice).HasPrecision(38, 8);*/
            builder.Entity<Transaction>().Property(x => x.UnitPrice).HasPrecision(38, 8);
            builder.Entity<Transaction>().Property(x => x.Quantity).HasPrecision(38, 8);
            builder.Entity<Transaction>().Property(x => x.Fee1).HasPrecision(38, 8);
            builder.Entity<Transaction>().Property(x => x.Fee2).HasPrecision(38, 8);
            builder.Entity<Transaction>().Property(x => x.Total).HasPrecision(38, 8);

            base.OnModelCreating(builder);
            new DbInitializer(builder).Seed();
        }
    }
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;
        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void Seed()
        {
            modelBuilder.Entity<Transaction>()
                .HasOne(x => x.Asset)
                .WithMany(x=> x.Transactions)
                .HasForeignKey(x=> x.AssetId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            /*            modelBuilder.Entity<Transaction>()
                            .HasRequired(c => c.Stage)
                            .WithMany()
                            .WillCascadeOnDelete(false);*/
            /*            modelBuilder.Entity<AssetType>().HasData(
                               new User() { Id = 1 },
                               new User() { Id = 2 }
                        );*/
            modelBuilder.Entity<AssetType>().HasData(
                   new AssetType() { Id = 1, Name = "Stock", Description = "Stock" },
                   new AssetType() { Id = 2, Name = "Crypto", Description = "Crypto Currency" },
                   new AssetType() { Id = 3, Name = "Options", Description = "Stock Options" },
                   new AssetType() { Id = 4, Name = "Cash", Description = "US Dollars" },
                   new AssetType() { Id = 5, Name = "NFT", Description = "Non-fungible tokens" }
            );
            modelBuilder.Entity<TransactionType>().HasData(
                   new TransactionType() { Id = 1, Name = "Buy", Description = "Purchase Asset" },
                   new TransactionType() { Id = 2, Name = "Sell", Description = "Sell Asset" },
                   new TransactionType() { Id = 3, Name = "Deposit", Description = "Deposit" },
                   new TransactionType() { Id = 4, Name = "Withdraw", Description = "Withdraw" }
             );
        }
    }
}

