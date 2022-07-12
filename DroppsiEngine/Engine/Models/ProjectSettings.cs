using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroppsiEngine.Engine.Models
{
    public class ProjectSettings
    {
        public string ProjectName { get; set; }
        public string ProjectVersion { get; set; }
        public string ProjectPreviewPath { get; set; }
        public string OutputFile { get; set; }
        public HashCode ProjectHash { get; set; }
    }
}
