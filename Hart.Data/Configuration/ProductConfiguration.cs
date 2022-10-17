//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using Hart.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Data.Configuration
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        //------------------------------------------------------------------
        // Public Methods Section
        //------------------------------------------------------------------
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
                new Product
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Description = "Chair",
                    Count = 30,
                },
                new Product
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"),
                    Description = "Table",
                    Count = 10,
                }
            );
        }
    }
}
