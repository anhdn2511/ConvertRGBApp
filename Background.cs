using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConvertRGBApp
{
    class Background : Observer
    {
        private Color backgroundColor;
        

        public Background()
        {
            backgroundColor = Color.Empty;
        }
        public void update(System.Drawing.Color c)
        {
            if (c == Color.Empty) return;
            backgroundColor = c;
        }
        public Color getVal()
        {
            return backgroundColor;
        }
    }
}
