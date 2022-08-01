using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Helpers;
using DroppsiEngineCore.Infrastructure.Systems;

namespace DroppsiEngineCore.Models
{
    public class Transform : GameComponent
    {
	   public Vector3D Position { get; set; } = new Vector3D(1, 1, 1);
	   public Vector3D Scale { get; set; } = new Vector3D(1, 1, 1);
	   public Vector3D Rotation { get; set; } = new Vector3D(1, 1, 1);

	   public Transform()
	   {
		  TransformSystem.RegisterNew(this);
	   }
    }
}
