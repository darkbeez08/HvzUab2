using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace HvZUAB.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        #region Attributes
        private string email;
        private string password;
        #endregion

        #region Properties
        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        #endregion

        #region Commands

        public ICommand LoginCommand
        {

        }
        #endregion

        #region Methods

        #endregion

        #region Constructor

        #endregion
    }
}
