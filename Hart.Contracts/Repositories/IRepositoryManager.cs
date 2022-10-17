﻿//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Contracts.Repositories
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public interface IRepositoryManager
    {
        //------------------------------------------------------------------
        // Interface Definition Section
        //------------------------------------------------------------------
        IProductRepository Product { get; }
    }
}
