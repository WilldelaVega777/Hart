//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hart.Entities.Models;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Contracts
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public interface IProductRepository
    {
        //------------------------------------------------------------------
        // Interface Implementation Section
        //------------------------------------------------------------------
        Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges);
    }
}