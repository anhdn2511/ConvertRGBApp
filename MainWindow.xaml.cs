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
        private Background background;
        public MainWindow()
        {
            InitializeComponent();
            rgbData = new RGBData(setRGBText);
            hexData = new HexData(setHexText);
            background = new Background();

            rgbData.attach(hexData);
            rgbData.attach(background);

            hexData.attach(rgbData);
            hexData.attach(background);

        }

        private void RGB_TextChanged(object sender, RoutedEventArgs e)
        {
            if(!rgbData.IsLocked) rgbData.setVal(RGBText.Text);
            updateBackground();
        }

        private void Hex_TextChanged(object sender, RoutedEventArgs e)
        {
            if(!hexData.IsLocked) hexData.setVal(HexText.Text);
            updateBackground();
        }
        private void updateBackground()
        {
            System.Drawing.Color c = background.getVal();
            System.Windows.Media.Color color = System.Windows.Media.Color.FromRgb(c.R, c.G, c.B);
            this.Background = new SolidColorBrush(color);
        }
        
        public void setRGBText(String str)
        {
            RGBText.Text = str;
        }

        public void setHexText(String str)
        {
            HexText.Text = str;
        }


    }
}
