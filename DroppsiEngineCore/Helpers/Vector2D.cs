using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Mathematics;

namespace DroppsiEngineCore.Helpers
{
    public struct Vector2D
    {
	   public float X { get; set; }
	   public float Y { get; set; }
	   public Guid? ID { get; set; }

	   public Vector2D()
	   {
		  this.X = 0;
		  this.Y = 0;
		  this.ID = Guid.NewGuid();
	   }

	   public Vector2D(float x, float y, Guid? iD)
	   {
		  this.X = x;
		  this.Y = y;
		  this.ID = iD;
	   }

	   public Vector2D(float x, float y)
	   {
		  this.X = x;
		  this.Y = y;
		  this.ID = Guid.NewGuid();
	   }

	   public Vector2D(Vector2D vector2D)
	   {
		  this.X = vector2D.X;
		  this.Y = vector2D.Y;
		  this.ID = vector2D.ID;
	   }

	   public override string ToString()
	   {
		  return $"[{this.X}, {this.Y}] {this.ID}";
	   }

	   // operators
	   public static implicit operator Vector2i(Vector2D v)
	   {
		  return new Vector2i((int)v.X, (int)v.Y);
	   }
    }
}
