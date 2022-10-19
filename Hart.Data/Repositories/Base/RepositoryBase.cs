//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hart.Contracts.Repositories.Base;

//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Data.Repositories.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        //------------------------------------------------------------------
        // Protected Properties Section
        //------------------------------------------------------------------
        protected RepositoryDataContext _repositoryContext;

        //------------------------------------------------------------------
        // Constructor Method Section
        //------------------------------------------------------------------
        public RepositoryBase(RepositoryDataContext pRepositoryContext)
        {
            this._repositoryContext = pRepositoryContext;
        }

        //------------------------------------------------------------------
        // Public Methods Section
        //------------------------------------------------------------------
        public IQueryable<T> FindAll(bool trackChanges)
        {
            IQueryable<T> retVal;

            if (!trackChanges)
            {
                retVal = this._repositoryContext.Set<T>().AsNoTracking();
            }
            else
            {
                retVal = this._repositoryContext.Set<T>();
            }

            return retVal;
        }
    }
}
