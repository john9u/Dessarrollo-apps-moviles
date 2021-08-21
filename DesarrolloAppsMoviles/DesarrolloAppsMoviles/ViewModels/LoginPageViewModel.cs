using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DesarrolloAppsMoviles.ViewModels
{
    class LoginPageViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidPasswordLoginPrompt;
        public Action DisplayInvalidUserLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
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
        public ICommand SubmitCommand { protected set; get; }
        public LoginPageViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (username == null)
            {
                DisplayInvalidUserLoginPrompt();
            }
            else if (password == null)
            {
                DisplayInvalidPasswordLoginPrompt();
            }
        }
    }
}
