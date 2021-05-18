using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConvertRGBApp
{
    class HexData : Observable, Observer
    {
        private string hexString;

        public HexData(UIDelegate del)
        {
            hexString = string.Empty;
            this.del = del;
        }
        public void update(System.Drawing.Color c)
        {
            if (c == Color.Empty)
            {
                updateUI(string.Empty);
                return;
            }
            hexString = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            updateUI(hexString);
        }
        public string getVal()
        {
            return hexString;
        }
        public void setVal(string str)
        {
            if(!str.Contains('#'))
            {
                notify(Color.Empty);
                return;
            }
            try
            {
                Color color = System.Drawing.ColorTranslator.FromHtml(str);
                hexString = str;
                notify(color);
            }
            catch(Exception e)
            {
                notify(Color.Empty);
            }
        }
    }
}
