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
        public Action DisplayValidLogin;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string username;
        public string UserName
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
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
            if (username == null|| username=="")
            {
                DisplayInvalidUserLoginPrompt();
            }
            else if (password == null|| password=="")
            {
                DisplayInvalidPasswordLoginPrompt();
            }
            else if(password != null && password != "" && username != null && username != "")
            {
                DisplayValidLogin();
            }            
        }
    }
}
