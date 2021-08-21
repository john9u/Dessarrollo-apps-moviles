using DesarrolloAppsMoviles.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesarrolloAppsMoviles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            var vm = new LoginPageViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidUserLoginPrompt += () => DisplayAlert("Error", "Campo Usuario no puede estar vacio", "OK");
            vm.DisplayInvalidPasswordLoginPrompt += () => DisplayAlert("Error", "Campo Contraseña no puede estar vacio","OK");
            InitializeComponent();

            UsernameEntry.Completed += (sender, args) => { PasswordEntry.Focus(); };
            PasswordEntry.Completed += (sender, args) => { vm.AuthenticateCommand.Execute(null); };
        }
    }
}