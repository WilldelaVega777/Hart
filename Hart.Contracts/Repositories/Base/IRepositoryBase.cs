//--------------------------------------------------------------------------
// Class Section
//--------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Contracts.Repositories.Base
{
    //----------------------------------------------------------------------
    // Interface Section
    //----------------------------------------------------------------------
    public interface IRepositoryBase<T>
    {
        //------------------------------------------------------------------
        // Interface Implementation Section
        //------------------------------------------------------------------
        IQueryable<T> FindAll(bool trackChanges);
    }
}
