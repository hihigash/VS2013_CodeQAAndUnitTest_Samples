using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _4_UnitTestDemo
{
    public class ColorCordinator : _4_UnitTestDemo.IColorCordinator
    {
        public Color SuggestMyShirtColor(Color pantsColor)
        {
            Color result;
            if (pantsColor == Color.Red)
            {
                result = Color.Pink;
            }
            else if (pantsColor == Color.Blue)
            {
                result = Color.Orange;
            }
            else if (pantsColor == Color.Yellow)
            {
                result = Color.Green;
            }
            else if (pantsColor == Color.Green)
            {
                result = Color.Yellow;
            }
            else if (pantsColor == Color.Pink)
            {
                result = Color.Red;
            }
            else if (pantsColor == Color.Orange)
            {
                result = Color.Blue;
            }
            else
            {
                throw new ArgumentOutOfRangeException("pantsColor", pantsColor, null);
            }

            return result;
        }
    }
}
