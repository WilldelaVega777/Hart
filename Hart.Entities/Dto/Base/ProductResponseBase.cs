//--------------------------------------------------------------------------
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
namespace Hart.Entities.Dto.Base
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public class ProductResponseBase
    {
        //------------------------------------------------------------------
        // Public Properties Section
        //------------------------------------------------------------------
        public string? Description { get; set; }
        public int Count { get; set; }
    }
}
