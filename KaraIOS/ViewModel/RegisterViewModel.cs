using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using KaraIOS.ViewModel;

namespace KaraIOS
{
    public class RegisterViewModel : ViewModelBase
    {
        private INavigationService navigationService;

        public RegisterViewModel(INavigationService navigationServie)
        {
            this.navigationService = navigationServie;
        }

        /// <summary>
        /// Navigate to LoginActivity
        /// </summary>
        public void AlreadyHasAccount()
        {
			navigationService.GoBack();
        }

        /// <summary>
        /// Registers the complete.
        /// Navigate to LoginActivity with username
        /// </summary>
        /// <param name="newUserName">New user.</param>
        public void RegisterComplete(string newUserName)
        {
			navigationService.GoBack();
        }
    }
}