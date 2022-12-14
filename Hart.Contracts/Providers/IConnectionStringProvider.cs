//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using System;

//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Contracts
{
    //----------------------------------------------------------------------
    // Interface Section
    //----------------------------------------------------------------------
    public interface IConnectionStringProvider
    {
        //------------------------------------------------------------------
        // Public Properties Section
        //------------------------------------------------------------------
        public string ConnectionString { get; set; }
    }
}
