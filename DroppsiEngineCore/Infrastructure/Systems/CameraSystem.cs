using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Infrastructure.Rendering;
using DroppsiEngineCore.Models;

namespace DroppsiEngineCore.Infrastructure.Systems
{
    public class CameraSystem : BaseSystem<Camera>
    {
	   public static Entity ActiveCamera { get; set; }
    }
}
