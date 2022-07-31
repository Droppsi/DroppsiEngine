using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using DroppsiEngineCore.Models;

namespace DroppsiEngineCore.Commands
{
    public class LoadProjectCommand
    {
	   public LoadProjectCommand()
	   {
	   }

	   public ProjectFile Load(string filePath)
	   {
		  var xmlSerializer = new XmlSerializer(typeof(ProjectFile));
		  using var reader = new StreamReader(filePath);
		  if (reader is not null)
		  {
			 if (xmlSerializer.Deserialize(reader) is ProjectFile projectFile)
			 {
				return projectFile;
			 }
			 else
			 {
				return new ProjectFile();
			 }
		  }
		  else
		  {
			 return new ProjectFile();
		  }
	   }
    }
}
