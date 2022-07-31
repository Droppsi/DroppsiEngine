using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Windowing.Desktop;
using DroppsiEngineCore.Models;
using DroppsiEngineCore.Helpers;

namespace DroppsiEngineCore.ScriptingEngine
{
    public class EntryPoint
    {
	   public Vector2D? GWSize { get; set; }
	   private GameWindow GWindow { get; set; }
	   private GameWindowSettings GWSettings { get; set; }
	   private NativeWindowSettings NativeWindowSettings { get; set; }
	   public EntryPoint()
	   {
		  this.GWSettings = GameWindowSettings.Default;
		  this.NativeWindowSettings = NativeWindowSettings.Default;
		  this.GWindow = new(GWSettings, NativeWindowSettings)
		  {
			 Size = new Vector2D(500, 500)
		  };
	   }

	   public EntryPoint(Vector2D vector)
	   {
		  this.GWSettings = GameWindowSettings.Default;
		  this.NativeWindowSettings = NativeWindowSettings.Default;
		  this.GWindow = new(GWSettings, NativeWindowSettings)
		  {
			 Size = vector
		  };
	   }

    }
}