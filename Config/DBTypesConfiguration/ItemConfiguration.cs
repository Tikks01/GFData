using GFDataApi.Data;
using GFDataApi.DataTypes;
using GFDataApi.DataTypes.BaseClasses;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFDataApi.Config.DBTypesConfiguration
{
    public static class ItemConfiguration
    {
        public static void Configure(EntityTypeBuilder<ItemData> builder)
        {
            builder.Property(i => i.RestrictClass)
                .HasConversion(
                    v => v.AsLong(),
                    v => new RestrictClass(v)
                    );

            builder.Property(i => i.Name)
                .HasConversion(
                    v => v.Get(ELanguages.Chinese),
                    v => new TranslatableString(v)
                    );

            builder.Property(i => i.Tip)
                .HasConversion(
                    v => v.Get(ELanguages.Chinese),
                    v => new TranslatableString(v)
                    );

            //builder.Property(i => i.TreasureBuffs)
            //    .HasColumnType("integer[]").HasConversion(
            //    v => v.asArray(),
            //    v => new TreasureBuffs(v));
        }

    }
}
