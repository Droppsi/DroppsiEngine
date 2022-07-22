using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Models;

namespace DroppsiEngineCore.Commands
{
    public class DeleteProjectCommand
    {
        public bool DeleteProject(ProjectFile projectFile)
        {
            if (projectFile == null)
            {
                return false;
            }
            string[] fileList = Directory.GetFiles(projectFile.ProjectSettings.ProjectDir, ".droppsiproject");
            foreach (string file in fileList)
            {
                File.Delete(file);
            }
            return true;
        }
    }
}
