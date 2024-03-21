using GFDataApi.Config.DBTypesConfiguration;
using GFDataApi.Data;
using GFDataApi.DataTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFDataApi.DataContext
{
    public class PgSqlDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("UserID=postgres;Password=root;Host=localhost;Port=5432;Database=IniFiles;Pooling=true;");
        }

        public DbSet<ItemData> Item { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemData>(ItemConfiguration.Configure);
            base.OnModelCreating(modelBuilder);
        }

        private void ConfigureItem(EntityTypeBuilder<ItemData> builder)
        {
            builder.Property(i => i.RestrictClass)
                .HasConversion(
                    v => v.AsLong(),
                    v => new RestrictClass(v)
                    );
        }
    }
}
