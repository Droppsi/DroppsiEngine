using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Infrastructure.Rendering;
using DroppsiEngineCore.Models;

namespace DroppsiEngineCore.Infrastructure.Managers
{
    public class AssetManager<T> where T : Asset
    {
	   private static List<T> Components = new();

	   public static void RegisterComponent(T asset)
	   {
		  Components.Add(asset);
	   }
	   public static void DeleteComponents()
	   {
		  foreach (var component in Components)
		  {
			 component.Delete();
		  }
	   }
    }

    class VertexArrayManager : AssetManager<VertexArray>
    {

    }
}
