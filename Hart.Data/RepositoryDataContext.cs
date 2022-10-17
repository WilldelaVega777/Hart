//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Hart.Contracts;
using Hart.Data.Configuration;
using Hart.Entities.Models;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Data
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public class RepositoryDataContext : DbContext
    {
        //------------------------------------------------------------------
        // Private Fields Section
        //------------------------------------------------------------------
        private string? _connectionString;


        //------------------------------------------------------------------
        // Public Properties Section
        //------------------------------------------------------------------
        public DbSet<Product>? Products { get; set; }


        //------------------------------------------------------------------
        public string ConnectionString
        {
            get
            {
                if (!string.IsNullOrEmpty(this._connectionString))
                {
                    return this._connectionString;
                }
                else
                {
                    return "server=localhost;database=Hart;port=3306;user id=Hart;password=Hart1234567";
                }
            }

            set
            {
                this._connectionString = value;
            }
        }


        //------------------------------------------------------------------
        // Constructor Methods Section
        //------------------------------------------------------------------
        public RepositoryDataContext()
        {

        }
        //------------------------------------------------------------------
        public RepositoryDataContext(IConnectionStringProvider pCSProvider)
        {
            this.ConnectionString = pCSProvider.ConnectionString;
        }


        //------------------------------------------------------------------
        // DBContext Overrides Section
        //------------------------------------------------------------------
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseMySql(
                    this.ConnectionString, 
                    new Microsoft.EntityFrameworkCore.MySqlServerVersion(
                        new System.Version("8.0")
                    ), 
                    null
                 );
            }
        }


        //------------------------------------------------------------------
        // Development Data Loading Section
        //------------------------------------------------------------------
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}