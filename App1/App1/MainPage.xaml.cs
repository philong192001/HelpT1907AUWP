using App1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CBImage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.CBImage.Items.Clear();
            string[] imgs = Directory.GetFiles(@"D:\C# ApTech\UWP\App1\App1\Assets\");
            foreach(string file in imgs)
            {
                CBImage.Text = " ----Select Images-----";
                CBImage.Items.Add(file);
            }
            string s = CBImage.SelectedItem.ToString();
            //picture.Image = new Bitmap(s);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Order od = new Order(TBProduct.Text, TBDes.Text,CBImage.Text);
            LV.Items.Add(od);
        }

        private void LV_Loaded(object sender, RoutedEventArgs e)
        {
            LV.Items.Add(new Order("ABC", "123", "anh 1"));
            LV.Items.Add(new Order("aAA", "32532", "anh 34"));
        }
    }
}
