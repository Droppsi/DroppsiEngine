using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroppsiEngine.Engine.Models
{
    public class ProjectSettings
    {
	   private string name;
	   private string description;
	   private string previewPicturePath;
	   private string projectDir;
	   private string projectVersion;
	   private DateTime lastOpened;
	   private DateTime createTime;

	   public string Name { 
		  get => name;
		  set => name = value;
	   }
	   public string Description {
		  get => description; 
		  set => description = value;
	   }
	   public string PreviewPicturePath { 
		  get => previewPicturePath;
		  set => previewPicturePath = value;
	   }
	   public string ProjectDir {
		  get => projectDir; 
		  set => projectDir = value;
	   }
	   public string ProjectVersion {
		  get => projectVersion; 
		  set => projectVersion = value;
	   }
	   public DateTime LastOpened { 
		  get => lastOpened; 
		  set => lastOpened = value;
	   }
	   public DateTime CreateTime { 
		  get => createTime; 
		  set => createTime = value;
	   }
    }
}
