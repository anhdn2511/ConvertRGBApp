using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Globalization;

namespace ConvertRGBApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RGBData rgbData;
        private HexData hexData;
        public MainWindow()
        {
            InitializeComponent();
            rgbData = new RGBData(setRGBText);
            hexData = new HexData(setHexText);
            rgbData.attach(hexData);
            hexData.attach(rgbData);
        }
        private void RGB_Click(object sender, RoutedEventArgs e)
        {
            //var str = RGBText.Text;
            //int firstComma = str.IndexOf(',');
            //int secComma = str.LastIndexOf(',');
            //var r = int.Parse(str.Substring(0, firstComma));
            //var g = int.Parse(str.Substring(firstComma + 1, secComma - firstComma - 1));
            //var b = int.Parse(str.Substring(secComma + 1, str.Length - secComma - 1));

            //if (r > 255 || r < 0 || g > 255 || g < 0 || b > 255 || b < 0)
            //{
            //    System.Drawing.Color col = System.Drawing.Color.Empty;
            //    subject.notify(col);
            //    int index = 0;
            //    foreach (var obs in subject.observersList)
            //    {
            //        if (index == 2) Error.Text = obs.get();
            //        index++;
            //    }
            //}
            //else
            //{
            //    string hex = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
            //    System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml(hex);
            //    subject.notify(col);
            //    int index = 0;
            //    foreach (var obs in subject.observersList)
            //    {
            //        if (index == 1) HexText.Text = obs.get();
            //        else if (index == 2) Error.Text = obs.get();
            //        index++;
            //    }
            //}
            //MessageBox.Show(Error.Text);
        }
        private void Hex_Click(object sender, RoutedEventArgs e)
        {
            //string str = HexText.Text;
            //if (str.Length > 7)
            //{
            //    System.Drawing.Color col = System.Drawing.Color.Empty;
            //    subject.notify(col);
            //    int index = 0;
            //    foreach (var obs in subject.observersList)
            //    {
            //        if (index == 2) Error.Text = obs.get();
            //        index++;
            //    }
            //}
            //else
            //{
            //    System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml(str);
            //    subject.notify(col);
            //    int index = 0;
            //    foreach (var obs in subject.observersList)
            //    {
            //        if (index == 0) RGBText.Text = obs.get();
            //        else if (index == 2) Error.Text = obs.get();
            //        break;
            //    }
            //}
            //MessageBox.Show(Error.Text);
        }

        private void RGB_TextChanged(object sender, RoutedEventArgs e)
        {
            if(!rgbData.IsLocked) rgbData.setVal(RGBText.Text);
        }

        private void Hex_TextChanged(object sender, RoutedEventArgs e)
        {
            if(!hexData.IsLocked) hexData.setVal(HexText.Text);
        }

        public void setRGBText(String str)
        {
            RGBText.Text = str;
        }

        public void setHexText(String str)
        {
            HexText.Text = str;
        }
        //private void Divide_Click(object sender, RoutedEventArgs e)
        //{
        //    double num1 = double.Parse(Number1.Text);
        //    double num2 = double.Parse(Number2.Text);
        //    if (num2 != 0)
        //    {
        //        Result.Text = (num1 / num2).ToString();
        //        MessageBox.Show("The Result is: " + Result.Text);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Enter a value greater than Zero");
        //    }
        //}

    }
}
