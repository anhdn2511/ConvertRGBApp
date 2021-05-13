using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;

namespace ConvertRGBApp
{
    public interface Observer
    {
        void update(System.Drawing.Color c);
        string get();
    }

    public class RGB : Observer
    {
        private string RGBString;
        public RGB()
        {
            RGBString = string.Empty;
        }
        public void update(System.Drawing.Color c)
        {
            //RGBString = "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
            if (c == Color.Empty) return;
            RGBString = c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString();
        }
        public string get()
        {
            return RGBString;
        }
    }
    public class Hex : Observer
    {
        private string hexString;
        public Hex()
        {
            hexString = string.Empty;
        }
        public void update(System.Drawing.Color c)
        {
            if (c == Color.Empty) return;
            hexString = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
        public string get()
        {
            return hexString;
        }
    }
    public class Error : Observer
    {
        private bool checkError;
        public Error()
        {
            checkError = false;
        }
        public void update(System.Drawing.Color c)
        {

            var r = c.R;
            var g = c.G;
            var b = c.B;

            if (c == Color.Empty) checkError = true;
            else checkError = false;
        }
        public string get()
        {
            if (checkError) return "Invalid color! Try Again.";
            else return "Valid color ^^";
        }
    }
}
