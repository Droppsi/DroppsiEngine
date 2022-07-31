using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Helpers;

namespace DroppsiEngineCore.Infrastructure.Rendering
{
    public class AssimpLoader
    {
        public struct MeshStruct
        {
            public List<Vector3D> points;
            public List<Vector3D> normal;
            public List<Vector3D> tangents;
            public List<Vector2D> uvs;
            public List<Vector3D> faces;
            public int MaterialIndex;
        }
    }
}
