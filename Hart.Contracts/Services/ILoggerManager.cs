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
namespace Hart.Contracts.Services
{
    //----------------------------------------------------------------------
    // Interface Section
    //----------------------------------------------------------------------
    public interface ILoggerManager
    {
        void LogInfo(string pMessage);
        void LogWarn(string pMessage);
        void LogDebug(string pMessage);
        void LogError(string pMessage);
    }
}
