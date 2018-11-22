using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PuzzlePicz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            setUpImage();
        }

        private void setUpImage()
        {
            
            var assemble = typeof(MainPage);

            // added change

            string filename = "PuzzlePicz.Assets.Images.Picz.PNG";

            MainImage.Source = ImageSource.FromResource(filename , assemble);

         
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = MainEntry.Text;

            MainLabel.Text = "Hello " + text;

 
        }

    }
}
