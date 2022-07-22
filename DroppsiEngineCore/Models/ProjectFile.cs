using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Commands;

namespace DroppsiEngineCore.Models
{
    [Serializable]
    public class ProjectFile
    {

        public ProjectSettings ProjectSettings { get; set; }


        public bool SaveProject()
	   {
            SaveProjectCommand saveProjectCommand = new();
            if (saveProjectCommand.Save(this))
            {
                return true;
            }
            return false;

        }
        public bool DeleteProject()
        {
            DeleteProjectCommand deleteProjectCommand = new();
            deleteProjectCommand.DeleteProject(this);
            return true;
        }
    }
}
