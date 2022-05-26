using ChatApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChatApp.ViewModels
{
    public class SignupViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public Action DisplayEmailPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Username"));
            }
        }
        private string email_forgotpass;
        public string Email_ForgotPass
        {
            get { return email_forgotpass; }
            set
            {
                email_forgotpass = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email_ForgotPass"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public ICommand ForgotPassCommand { protected set; get; }
        public SignupViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
            ForgotPassCommand = new Command(ForgotPass);
        }
        public async void OnSubmit()
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
            {
                DisplayInvalidLoginPrompt();
            }
            else
            {
                await Shell.Current.GoToAsync($"//{nameof(ProfilePage)}");
            }
        }
        public void ForgotPass()
        {
            if (string.IsNullOrEmpty(email_forgotpass))
            {
                DisplayInvalidLoginPrompt();
            }
            else
            {
                DisplayEmailPrompt();
            }
        }
    }
}
