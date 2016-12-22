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
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        UIKit.UIButton btnLinkToRegister { get; set; }


        [Outlet]
        UIKit.UIButton btnLogin { get; set; }


        [Outlet]
        UIKit.UITextField txtPassword { get; set; }


        [Outlet]
        UIKit.UITextField txtUsername { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnLinkToRegister != null) {
                btnLinkToRegister.Dispose ();
                btnLinkToRegister = null;
            }

            if (btnLogin != null) {
                btnLogin.Dispose ();
                btnLogin = null;
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