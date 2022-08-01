using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroppsiEngineCore.Models;

namespace DroppsiEngineCore.Infrastructure.Systems
{
    public class BaseSystem<T> where T : GameComponent
    {
        public static List<T> Components = new List<T>();

        public static void RegisterNew(T component)
        {
            Components.Add(component);
        }

        public static void Update()
        {
            foreach (T component in Components)
            {
                component.Update();
            }
        }

        public static void UpdateMouse()
        {
            foreach (T component in Components)
            {
                component.UpdateMouse();
            }
        }
    }
}
