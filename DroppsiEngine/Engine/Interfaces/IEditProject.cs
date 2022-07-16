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
        public void ChangeProjectPath(string path, ProjectFile existingfile);

        public void ChangeProjectName(string name, ProjectFile existingfile);

        public void ChangeProjectDescription(string description, ProjectFile existingfile);

        public void ChangeProjectVersion(string version, ProjectFile existingfile);

        public void ChangeProjectSettings(ProjectSettings settings, ProjectFile existingfile);

    }
}
