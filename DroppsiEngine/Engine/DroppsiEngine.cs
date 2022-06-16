using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Layout;


namespace DroppsiEngine.Engine
{
    class ScreenCanvas : Form
    {
        public ScreenCanvas()
        {
            this.DoubleBuffered = true;

        }
    }
    public abstract class DroppsiEngine
    {
        public Vector2D ScreenResolution = new Vector2D(512, 512);
        private string Title = "DroppsiEngine (unstable/dev)";
        private ScreenCanvas window = null;

        public DroppsiEngine(Vector2D ScreenResolution, string Title)
        {
            this.ScreenResolution = ScreenResolution;
            this.Title = Title;
            window = new ScreenCanvas();
            window.Size = new Size((int)this.ScreenResolution.X, (int)this.ScreenResolution.Y);
            window.Text = this.Title;
            window.Paint += Renderer;


            OnInitalize();

            Application.Run(window);
        }
        public void Renderer(object sender, PaintEventArgs e)
        {

        }

        public abstract void OnInitalize();
    }

}
