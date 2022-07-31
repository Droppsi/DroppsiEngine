using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Mathematics;

namespace DroppsiEngineCore.Helpers
{
    public class Vector3D
    {
	   public float X { get; set; }
	   public float Y { get; set; }
	   public float Z { get; set; }
	   public Guid? ID { get; set; }

	   public Vector3D()
	   {
		  this.X = 0;
		  this.Y = 0;
		  this.Z = 0;
		  this.ID = Guid.NewGuid();
	   }

	   public Vector3D(float x, float y, float z, Guid? iD)
	   {
		  this.X = x;
		  this.Y = y;
		  this.Z = z;
		  this.ID = iD;
	   }

	   public Vector3D(float x, float y, float z)
	   {
		  this.X = x;
		  this.Y = y;
		  this.Z = z;
		  this.ID = Guid.NewGuid();
	   }

	   public Vector3D(Vector3D vector3D)
	   {
		  this.X = vector3D.X;
		  this.Y = vector3D.Y;
		  this.Z = vector3D.Z;
		  this.ID = vector3D.ID;
	   }

	   public override string ToString()
	   {
		  return $"[{this.X}, {this.Y}, {this.Z}] {this.ID}";
	   }

	   // operators
	   public static implicit operator Vector3i(Vector3D v)
	   {
		  return new Vector3i((int)v.X, (int)v.Y, (int)v.Z);
	   }
    }
}
