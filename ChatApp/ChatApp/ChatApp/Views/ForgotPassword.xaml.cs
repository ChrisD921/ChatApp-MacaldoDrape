using ChatApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChatApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPassword : ContentPage
    {
        public ForgotPassword()
        {
            var vm = new SignupViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Missing fields, try again", "OK");
            vm.DisplayEmailPrompt += () => DisplayAlert("Success", "Email has been sent to your Email address", "OK");
            InitializeComponent();
        }

        private void FPBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }
    }
    
}