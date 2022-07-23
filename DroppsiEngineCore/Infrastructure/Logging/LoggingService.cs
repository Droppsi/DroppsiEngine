using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Enums;
using DroppsiEngineCore.Interfaces;

namespace DroppsiEngineCore.Infrastructure.Logging
{
    public class LoggingService : ILogging
    {
	   public string LogPath { get; set; }
	   public List<string> Logs { get; set; }

	   public LoggingService()
	   {
		  LogPath = "D:/dev/TESTS/LogFiles";
		  Logs = new List<string>
		  {
			 $"[{DateTime.Now}-{LogStatus.Info}] 'LoggingService Initalized'"
		  };
		  DumpLogs();
	   }
	   public bool Log(string log_message, LogStatus logStatus)
	   {
		  Logs.Add($"[{DateTime.Now}-{logStatus}] '{log_message}'");
		  return true;
	   }
	   public bool Log(string log_message)
	   {
		  Logs.Add($"[{DateTime.Now}-{LogStatus.Info}] '{log_message}'");
		  return true;
	   }
	   public void DumpLogs()
	   {
		  if (Directory.Exists(LogPath))
		  {
			 using StreamWriter sw = new($"{LogPath}/log.droppsilog");
			 foreach (var log in Logs)
			 {
				sw.WriteLine(log);
			 }
		  }
	   }
    }
}
