using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Helpers;
using DroppsiEngineCore.Infrastructure.Systems;
using DroppsiEngineCore.Models;
using OpenTK.Mathematics;

namespace DroppsiEngineCore.Infrastructure.Rendering
{
    public class Camera : GameComponent
    {
	   private Vector3D _LastPosition = new();
	   private float _CameraSpeed = 25;
	   private float _Sensitivity = 1f;
	   private float _Pitch;
	   private float _Yaw;
	   private float _Roll;
	   private float _FieldOfView;
	   private Transform _EntityTransform;
	   public Camera(float sensitivity, float cameraspeed)
	   {
		  _Sensitivity = sensitivity * 0.1f;
		  _CameraSpeed = cameraspeed;

		  CameraSystem.RegisterNew(this);
	   }

	   public void SetCamera()
	   {
		  CameraSystem.RegisterNew(this);
	   }

	   public float Pitch
	   {
		  get => MathHelper.RadiansToDegrees(_Pitch);
		  set
		  {
			 var angle = MathHelper.Clamp(value, -89f, 89f);
			 _Pitch = MathHelper.DegreesToRadians(angle);
		  }
	   }

	   public float Yaw
	   {
		  get => MathHelper.RadiansToDegrees(_Yaw);
		  set
		  {
			 _Yaw = MathHelper.DegreesToRadians(value);
		  }
	   }

	   public float Roll
	   {
		  get => MathHelper.DegreesToRadians(_Roll);
		  set
		  {
			 _Yaw -= MathHelper.RadiansToDegrees(value);
		  }
	   }

	   public float FieldOfView
	   {
		  get => MathHelper.RadiansToDegrees(_FieldOfView);
		  set
		  {
			 var angle = MathHelper.Clamp(value, 1f, 45f);
			 _FieldOfView = MathHelper.DegreesToRadians(angle);
		  }
	   }

	   public override void Update()
	   {
		  var _EntityTransform = this.Entity.GetComponent<Transform>();
	   }
    }
}
