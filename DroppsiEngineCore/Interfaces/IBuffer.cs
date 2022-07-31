using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroppsiEngineCore.Interfaces
{
    public interface IBuffer
    {
	   public void FrameBuffer();
	   public void Render();
	   public void Bind();
	   public void Delete();
    }
}
