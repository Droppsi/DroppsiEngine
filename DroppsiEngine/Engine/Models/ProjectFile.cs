using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngine.Engine.Commands;

namespace DroppsiEngine.Engine.Models
{
    public class ProjectFile
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PreviewPicturePath { get; set; }
        public string ProjectDir { get; set; }
        public string ProjectVersion { get; set; }
        public DateTime LastOpened { get; set; }
        public ProjectSettings ProjectSettings { get; set; }
        public bool SaveProject()
        {
            throw new NotImplementedException();   
        }
        public bool DeleteProject()
        {
            throw new NotImplementedException();
        }
    }
}
