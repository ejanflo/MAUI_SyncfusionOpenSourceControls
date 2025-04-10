using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FirstMAUIProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMAUIProject.ViewModels
{
    public partial class LoginPageViewModel : ObservableObject
    {
        public LoginPageViewModel()
        {
            
        }

        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string passWord;

        [ObservableProperty]
        public bool isBusy;

        [RelayCommand]
        public async Task Login()
        {
            try
            {
                //Authentication
                if (IsBusy)
                    return;

                isBusy = true;

                var login = new LoginVM
                {
                    UserName = userName,
                    PassWord = passWord
                };

                isBusy = false;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
