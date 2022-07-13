using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroppsiEngine.Engine.Misc
{
    public class DroppsiColor
    {
        public DroppsiColor(string value)
        {
            if (value.StartsWith("#"))
            {
                value = value[1..];
            }
            else
            {
                throw new NotImplementedException("Only hex Values are allowed");
            }


            switch (value.Length)
            {
                case 3:
                    value = new string(new char[8] { value[0], value[0], value[1], value[1], value[2], value[2], 'F', 'F' });
                    break;

                case 4:
                    value = new string(new char[8] { value[0], value[0], value[1], value[1], value[2], value[2], value[3], value[3] });
                    break;
                case 6:
                    value += "FF";
                    break;
                case 8:
                    break;
                default:
                    throw new ArgumentException("not a valid color", nameof(value));

            }

        }
    }
}
