//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Hart.Contracts;
using Hart.Contracts.Repositories;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Data.Repositories
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public class RepositoryManager : IRepositoryManager
    {
        //------------------------------------------------------------------
        // Private Properties Section
        //------------------------------------------------------------------
        private RepositoryDataContext _repositoryContext;
        private IProductRepository _productRepository;


        //------------------------------------------------------------------
        // Public Properties Section
        //------------------------------------------------------------------
        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_repositoryContext);
                }
                return _productRepository;
            }
        }

        //------------------------------------------------------------------
        // Constructor Method Section
        //------------------------------------------------------------------
        public RepositoryManager(
            RepositoryDataContext pRepositoryContext
        )
        {
            _repositoryContext = pRepositoryContext;
            _productRepository = new ProductRepository(_repositoryContext);
        }

        //------------------------------------------------------------------
        public RepositoryManager(
            RepositoryDataContext pRepositoryContext,
            IProductRepository productRepository
        )
        {
            _repositoryContext = pRepositoryContext;
            _productRepository = productRepository;
        }
    }
}
