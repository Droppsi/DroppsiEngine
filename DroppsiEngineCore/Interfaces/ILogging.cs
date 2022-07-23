using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Enums;

namespace DroppsiEngineCore.Interfaces
{
    public interface ILogging
    {
	   public bool Log(string log_message, LogStatus logStatus);
	   public bool Log(string log_message);
	   public void DumpLogs();
    }
}
