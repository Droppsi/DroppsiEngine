using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.ScriptingEngine;

namespace DroppsiEngineCore.Models
{
    public class GameComponent
    {
	   public Entity? Entity { get; set; }
	   public Transform Transform { get; set; }
	   public virtual void Update() { }
	   public virtual void UpdateMouse() { }
	   public virtual void Close() { }
    }
}
