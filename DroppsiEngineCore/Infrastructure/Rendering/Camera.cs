using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Helpers;
using DroppsiEngineCore.Infrastructure.Systems;
using DroppsiEngineCore.Models;

namespace DroppsiEngineCore.Infrastructure.Rendering
{
    public class Camera : GameComponent
    {
	   public float FieldOfView { get; set; } = 90;
	   private Vector3D _LastPosition = new();
	   private float _CameraSpeed = 25;
	   private float _Sensitivity = 1f;
	   public Camera(float sensitivity, float cameraspeed)
	   {
		  _Sensitivity = sensitivity * 0.1f;
		  _CameraSpeed = cameraspeed;

		  CameraSystem.RegisterNew(this);
	   }

	   public void SetCamera()
	   {
		  CameraSystem.ActiveCamera = this.Entity;
	   }

	   public override void Update()
	   {
		  _EntityTransform = this.Entity.GetComponent<Transform>();
	   }
    }
}
