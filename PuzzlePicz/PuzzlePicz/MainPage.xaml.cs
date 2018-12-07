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
            SetUpImage();
        }

        //method for image
        private void SetUpImage()
        {
            
            var assemble = typeof(MainPage);

            // added change

            string filename = "PuzzlePicz.Assets.Images.Picz.PNG";

            MainImage.Source = ImageSource.FromResource(filename , assemble);
            string tester = "Hello World";
         
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = MainEntry.Text;

            MainLabel.Text = "Hello " + text;

 
        }

    }
}
