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
        public void ChangeProjectDescription(string description, ProjectFile existingfile)
        {
            existingfile.Description = description;
            existingfile.SaveProject();
        }

        public void ChangeProjectName(string name, ProjectFile existingfile)
        {
            existingfile.Name = name;
            existingfile.SaveProject();
        }

        public void ChangeProjectPath(string path, ProjectFile existingfile)
        {
            existingfile.PreviewPicturePath = path;
            existingfile.SaveProject();
        }

        public void ChangeProjectSettings(ProjectSettings settings, ProjectFile existingfile)
        {
            existingfile.ProjectSettings = settings;
            existingfile.SaveProject();
        }

        public void ChangeProjectVersion(string version, ProjectFile existingfile)
        {
            existingfile.ProjectVersion = version;
            existingfile.SaveProject();
        }
    }
}
