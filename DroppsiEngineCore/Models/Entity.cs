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
	   public RenderOptions? RenderOptions { get; set; }
	   public List<Entity>? SubEntities { get; set; }
	   public Transform Transform { get; set; }
    }
}
