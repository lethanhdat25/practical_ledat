using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ledat_baitapnhom.Pages.practical
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent(); 
            var item1=new Models.Categories_prac() { Description = "des1", Name = "name1", Image = "https://zicxa.com/vi/uploads/news/hinh-nen-4k-dep-cho-may-tinh-lap-top-dien-thoai-(11).jpg" };
            GV.Items.Add(item1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (nameProduct.Text != "" && desProduct.Text != "" && imageProduct.Text != "") {
                var name = nameProduct.Text;
                var des = desProduct.Text;
                var image = imageProduct.Text;
                var item = new Models.Categories_prac() { Description = des, Name = name, Image = image };
                GV.Items.Add(item);
                nameProduct.Text = "";
                desProduct.Text = "";
                imageProduct.Text = "";
            }
        }
    }
}
