using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Commands;
using DroppsiEngineCore.ScriptingEngine;

namespace DroppsiEngineCore.Models
{
    [Serializable]
    public class ProjectFile
    {
        public ProjectSettings ProjectSettings { get; set; }
        public List<Entity> ProjectEntities { get; set; }

	   public ProjectFile()
	   {
            ProjectEntities = new List<Entity> { };
            ProjectSettings = new ProjectSettings();
	   }

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

        public bool IsNullOrOnDefault()
	   {
            ProjectSettings DefaultSettings = new()
            {
                Name = "DefaultName",
                Description = "New DroppsiEngine Project",
                PreviewPicturePath = "D:/dev/TESTS/",
                ProjectDir = "D:/dev/TESTS/",
                ProjectVersion = "0.0.1",
                CreateTime = ProjectSettings.CreateTime,
                LastOpened = ProjectSettings.LastOpened,
            };
            if (ProjectSettings == null)
            {
                return true;
            }
            else if (DefaultSettings == ProjectSettings)
		  {
                return true;
		  }
            else
		  {
                return false;
		  }
	   }
    }
}
