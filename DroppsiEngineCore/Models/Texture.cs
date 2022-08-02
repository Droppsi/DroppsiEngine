using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Infrastructure.Managers;
using OpenTK.Graphics.OpenGL;

namespace DroppsiEngineCore.Models
{
    public class Texture : Asset
    {
	   public int GLBindedTexture;
	   private BitmapData _BitmapData;

	   public Texture(string path, System.Drawing.Imaging.PixelFormat format = System.Drawing.Imaging.PixelFormat.Format32bppArgb)
	   {
		  TextureManager.RegisterComponent(this);
		  Bitmap bitmap = new(path);
		  bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
		  GLBindedTexture = GL.GenTexture();
		  GL.BindTexture(TextureTarget.Texture2D, GLBindedTexture);
		  _BitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, format);
		  GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, bitmap.Width, bitmap.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, _BitmapData.Scan0);
		  GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);
		  GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
		  GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);
		  GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.LinearMipmapLinear);
		  GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
		  bitmap.UnlockBits(_BitmapData);
		  bitmap.Dispose();
	   }

	   public override void Delete()
	   {
		  GL.DeleteTexture(GLBindedTexture);
		  GLBindedTexture = -1;
	   }
    }
}
