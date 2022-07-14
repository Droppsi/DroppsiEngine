using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DroppsiEngine.Engine.Interfaces;

namespace DroppsiEngine.Engine.Commands
{
    public class CloseWindowCommand : ICloseable
    {
        public Window Window { get; set; }
        public void Close()
        {
            Window.Close();
        }
    }
}
