using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroppsiEngineCore.Models
{
    public class Entity
    {
	   public Guid Id { get; set; }
	   public List<GameComponent> GameComponents { get; set; }

	   public GameComponent GetComponent<T>() where T : GameComponent
	   {
		  foreach (T gameComponent in GameComponents)
		  {
			 if (gameComponent.GetType() == typeof(T))
			 {
				return (T)gameComponent;
			 }
		  }
		  return null;
	   }
    }
}
