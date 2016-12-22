// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace KaraIOS.iOS
{
    [Register ("RegisterViewController")]
    partial class RegisterViewController
    {
        [Outlet]
        UIKit.UIButton btnBackToLogin { get; set; }


        [Outlet]
        UIKit.UIButton btnRegister { get; set; }


        [Outlet]
        UIKit.UITextField txtConfirmPassword { get; set; }


        [Outlet]
        UIKit.UITextField txtPassword { get; set; }


        [Outlet]
        UIKit.UITextField txtUsername { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnBackToLogin != null) {
                btnBackToLogin.Dispose ();
                btnBackToLogin = null;
            }

            if (btnRegister != null) {
                btnRegister.Dispose ();
                btnRegister = null;
            }

            if (txtConfirmPassword != null) {
                txtConfirmPassword.Dispose ();
                txtConfirmPassword = null;
            }

            if (txtPassword != null) {
                txtPassword.Dispose ();
                txtPassword = null;
            }

            if (txtUsername != null) {
                txtUsername.Dispose ();
                txtUsername = null;
            }
        }
    }
}