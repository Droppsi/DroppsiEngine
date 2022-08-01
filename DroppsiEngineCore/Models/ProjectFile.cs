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
    public class ProjectSettings
    {
	   public string Name { get; set; }
	   public string Description { get; set; }
	   public string PreviewPicturePath { get; set; }
	   public string ProjectDir { get; set; }
	   public string ProjectVersion { get; set; }
	   public DateTime LastOpened { get; set; }
	   public DateTime CreateTime { get; set; }

	   public ProjectSettings()
	   {
            Name = "DefaultName";
            Description = "New DroppsiEngine Project";
            PreviewPicturePath = "D:/dev/TESTS/";
            ProjectDir = "D:/dev/TESTS/";
            ProjectVersion = "0.0.1";
            CreateTime = DateTime.Now;
            LastOpened = DateTime.Now;
	   }
    }
}
