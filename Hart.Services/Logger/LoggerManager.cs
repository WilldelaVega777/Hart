//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using NLog;
using Hart.Contracts.Services;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Services
{
    //----------------------------------------------------------------------
    // Class Section
    //----------------------------------------------------------------------
    public class LoggerManager : ILoggerManager
    {
        //------------------------------------------------------------------
        // Private Fields Section
        //------------------------------------------------------------------
        private static ILogger logger = LogManager.GetCurrentClassLogger();


        //------------------------------------------------------------------
        // Constructor Method Section
        //------------------------------------------------------------------
        public LoggerManager()
        {

        }


        //------------------------------------------------------------------
        // Public Methods Section (Implements ILoggerManager)
        //------------------------------------------------------------------
        public void LogDebug(string pMessage)
        {
            logger.Debug(pMessage);
        }

        public void LogError(string pMessage)
        {
            logger.Error(pMessage);
        }

        public void LogInfo(string pMessage)
        {
            logger.Error(pMessage);
        }

        public void LogWarn(string pMessage)
        {
            logger.Warn(pMessage);
        }
    }
}