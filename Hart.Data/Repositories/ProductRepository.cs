//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hart.Entities.Models;
using Hart.Contracts;
using Hart.Data.Repositories.Base;



//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Data.Repositories
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        //------------------------------------------------------------------
        // Constructor Method Section
        //------------------------------------------------------------------
        public ProductRepository(RepositoryDataContext pRepositoryContext)
            : base(pRepositoryContext)
        {

        }

        //------------------------------------------------------------------
        // Public Methods Section
        //------------------------------------------------------------------
        public async Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges)
        {
            return await base.FindAll(trackChanges)
                .OrderBy(product => product.Description)
                .ToListAsync();
        }
    }
}
