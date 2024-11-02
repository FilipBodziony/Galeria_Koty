using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KOTEK
{
    public partial class MainPage : ContentPage
    {
        bool isToggeledColor = false;
        int photoNumber = 1;
        public MainPage()
        {
            InitializeComponent();
            changePicture(1);
        }

        private void changePicture(int n)
        {
            string link = "KOTEK.assets.kot" + n + ".jpg";
            img.Source = ImageSource.FromResource(link);
        }

        private void btnPREV_Clicked(object sender, EventArgs e)
        {
            photoNumber--;
            changeNumberPic();
        }

        private void checkNumber()
        {
            if (photoNumber <= 0)
            {
                photoNumber = 4;
            }
            else if (photoNumber > 4)
            {
                photoNumber = 1;
            }
        }

        private void btnNEXT_Clicked(object sender, EventArgs e)
        {
            photoNumber++;
            changeNumberPic();

        }

        private void changeNumberPic()
        {
            checkNumber();
            changePicture(photoNumber);
        }

        private void changeColor()
        {
            if (isToggeledColor)
            {
                slWindow.BackgroundColor = Color.FromHex("#1565C0");
            }
            else
            {
                slWindow.BackgroundColor = Color.FromHex("#00796B");

            }
        }

        private void swBackground_Toggled(object sender, ToggledEventArgs e)
        {
            if (swBackground.IsToggled)
            {
                isToggeledColor = true;
            }
            else
            {
                isToggeledColor = false;
            }
            changeColor();
        }

        private void nrImg_TextChanged(object sender, TextChangedEventArgs e)
        {
            string liczba = nrImg.Text.ToString();
            string link = "KOTEK.assets.kot" + liczba + ".jpg";
            img.Source = ImageSource.FromResource(link);
        }
    }
}
