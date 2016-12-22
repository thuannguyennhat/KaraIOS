using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using KaraIOS.ViewModel;

namespace KaraIOS
{
    public class LoginViewModel : ViewModelBase
    {
        private INavigationService navigationService;

        public LoginViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        /// <summary>
        /// Navigate to Register Page
        /// </summary>
        public void Register()
        {
            navigationService.NavigateTo(ViewModelLocator.RegisterPageKey);
        }

        /// <summary>
        /// Login the with user from View
        /// Auto navigate to MainActivity if user is valid
        /// </summary>
        /// <returns><c>true</c>, if with user is valid, <c>false</c> otherwise.</returns>
        /// <param name="user">User.</param>
        public bool LoginWithUser(User user)
        {
            if (ValidateUser(user))
            {
                navigationService.NavigateTo(ViewModelLocator.MainPageKey);
                return true;
            }
            return false;
        }

        private bool ValidateUser(User user)
        {
            //TODO: Execute check user from services

            if (user.Username == "duy" && user.Password == "duy") return true;
            return false;
        }


    }
}