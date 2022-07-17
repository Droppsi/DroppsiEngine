using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroppsiEngine.Engine.Models
{
    public class ProjectSettings
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PreviewPicturePath { get; set; }
        public string ProjectDir { get; set; }
        public string ProjectVersion { get; set; }
        public DateTime LastOpened { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
