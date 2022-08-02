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
	   public GameWindow GWindow { get; set; }
	   public List<GameComponent>? GameComponents { get; set; }
	   private GameWindowSettings GWSettings { get; set; }
	   private NativeWindowSettings NativeWindowSettings { get; set; }
	   public EntryPoint()
	   {
		  this.GWSettings = GameWindowSettings.Default;
		  this.NativeWindowSettings = NativeWindowSettings.Default;
		  this.NativeWindowSettings = new()
		  {
			 Title = "DroppsiEngine Default Game",
			 Size = new Vector2D(500, 750),
		  };
		  this.GWindow = new(GWSettings, NativeWindowSettings)
		  {};
	   }

	   public EntryPoint(Vector2D vector)
	   {
		  this.GWSettings = GameWindowSettings.Default;
		  this.NativeWindowSettings = new()
		  {
			 Title = "DroppsiEngine Default Game",
			 Size = vector,
		  };
		  this.GWindow = new(GWSettings, NativeWindowSettings);
		  this.GameComponents = new List<GameComponent>();
	   }

	   public void Run()
	   {
	   }

	   public void AddGameComponent(GameComponent component)
	   {
		  if (this.GameComponents.Contains(component))
		  {
			 throw new EngineErrors($"GameComponent with ID {component.Entity.Id} already exists");
		  }
		  GameComponents.Add(component);
		  component.Update();
	   }
    }
}