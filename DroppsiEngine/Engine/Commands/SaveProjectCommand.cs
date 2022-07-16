using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DroppsiEngine.Engine.Models;


namespace DroppsiEngine.Engine.Commands
{
    public class SaveProjectCommand
    {
        public bool Save(ProjectFile projectFile)
        {
            var xmlWriter = new XmlSerializer(typeof(ProjectFile));
            using (var writer = new StreamWriter(@$"{projectFile.ProjectDir}"))
            {
                xmlWriter.Serialize(writer, projectFile);
            }
            return true;
        }
    }
}
