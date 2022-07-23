using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Models;
using DroppsiEngineCore.Enums;
using DroppsiEngineCore.Infrastructure.Logging;

namespace DroppsiEngineCore.Commands
{
    public class DeleteProjectCommand
    {
        public bool DeleteProject(ProjectFile projectFile)
        {
            if (projectFile == null)
            {
                LoggingService _loggingService = new();
                _loggingService.Log($"Project could not been found", LogStatus.Warning);
                return false;
            }
            string[] fileList = Directory.GetFiles(projectFile.ProjectSettings.ProjectDir, ".droppsiproject");
            foreach (string file in fileList)
            {
                File.Delete(file);
            }
            LoggingService loggingService = new();
            loggingService.Log($"Project {projectFile.ProjectSettings.Name} has been deleted", LogStatus.Warning);
            return true;
        }
    }
}
