﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DroppsiEngineCore.Enums;
using DroppsiEngineCore.Models;
using DroppsiEngineCore.Infrastructure.Logging;

namespace DroppsiEngineCore.Commands
{
    public class SaveProjectCommand
    {
	   public bool Save(ProjectSettings projectSettings)
	   {
		  ProjectFile projectFile = new()
		  {
			 ProjectSettings = projectSettings
		  };
		  this.Save(projectFile);

		  LoggingService loggingService = new();
		  loggingService.Log($"Project {projectFile.ProjectSettings.Name} has been saved", LogStatus.Info);
		  return true;
	   }
	   public bool Save(ProjectFile projectFile)
	   {
		  var xmlWriter = new XmlSerializer(typeof(ProjectFile));
		  if (Directory.Exists(@$"{projectFile.ProjectSettings.ProjectDir}"))
		  {
			 using var writer = new StreamWriter(@$"{projectFile.ProjectSettings.ProjectDir}{projectFile.ProjectSettings.Name}.droppsiproject");
			 xmlWriter.Serialize(writer, projectFile);
		  }
		  else
		  {
			 Directory.CreateDirectory(projectFile.ProjectSettings.ProjectDir);
			 using var writer = new StreamWriter(@$"{projectFile.ProjectSettings.ProjectDir}{projectFile.ProjectSettings.Name}.droppsiproject");
			 xmlWriter.Serialize(writer, projectFile);
		  }

		  LoggingService loggingService = new();
		  loggingService.Log($"Project {projectFile.ProjectSettings.Name} has been saved", LogStatus.Info);
		  return true;
	   }
    }
}