using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DroppsiEngine.Engine.Models;

namespace DroppsiEngine.Engine.Commands
{
    public class DeleteProjectCommand
    {
        public bool DeleteProject(ProjectFile projectFile)
        {
            if (projectFile == null)
            {
                return false;
            }
            string[] fileList = Directory.GetFiles(projectFile.ProjectDir, ".droppsiproject");
            foreach (string file in fileList)
            {
                File.Delete(file);
            }
            return true;
        }
    }
}
