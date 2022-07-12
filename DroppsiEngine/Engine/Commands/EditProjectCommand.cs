using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngine.Engine;
using DroppsiEngine.Engine.Interfaces;
using DroppsiEngine.Engine.Models;
using DroppsiEngine.Engine.Enums;


namespace DroppsiEngine.Engine.Commands
{
    public class EditProjectCommand : IEditProject
    {
        public void ChangeProjectDescription(string description)
        {
            ProjectFile project = new ProjectFile();
            project.Description = description;
            project.SaveProject();
        }

        public void ChangeProjectName(string name)
        {
            ProjectFile project = new ProjectFile();
            project.Name = name;
            project.SaveProject();
        }

        public void ChangeProjectPath(string path)
        {
            ProjectFile project = new ProjectFile();
            project.ProjectDir = path;
            project.SaveProject();
        }

        public void ChangeProjectSettings(ProjectSettings settings)
        {
            ProjectFile project = new ProjectFile();
            project.ProjectSettings = settings;
            project.SaveProject();
        }

        public void ChangeProjectVersion(string version)
        {
            ProjectFile project = new ProjectFile();
            project.ProjectVersion = version;
            project.SaveProject();
        }

        public void DeleteProject()
        {
            ProjectFile project = new ProjectFile();
            project.DeleteProject();
        }

        public void SaveProject(ProjectSettings projectSettings, ProjectFile existingfile)
        {
            ProjectFile project = new ProjectFile();
            project.SaveProject();
        }
    }
}
