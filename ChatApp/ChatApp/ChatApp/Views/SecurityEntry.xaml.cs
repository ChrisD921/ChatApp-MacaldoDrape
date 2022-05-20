using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecurityEntry : ContentView
    {
        internal Action<object, EventArgs> Completed;

        public SecurityEntry()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var imageButton = sender as ImageButton;
            if (MyEntry.IsPassword)
            {
                imageButton.Source = ImageSource.FromFile("openedEye.png");
                MyEntry.IsPassword = false;
            }
            else
            {
                imageButton.Source = ImageSource.FromFile("closedEye.png");
                MyEntry.IsPassword = true;
            }
        }
    }
}