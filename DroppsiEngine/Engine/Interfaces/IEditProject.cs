using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngine.Engine.Models;

namespace DroppsiEngine.Engine.Interfaces
{
    public interface IEditProject
    {
        public void ChangeProjectPath(string path);
        public void ChangeProjectName(string name);
        public void ChangeProjectDescription(string description);
        public void ChangeProjectVersion(string version);
        public void ChangeProjectSettings(ProjectSettings settings);
        public void DeleteProject();
        public void SaveProject(ProjectSettings settings, ProjectFile existingfile);
    }
}
