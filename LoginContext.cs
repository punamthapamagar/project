using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public class LoginContext: ApplicationContext
    {
        #region Private fields
        // here we can declare the all forms application and manage it directly
        //(show, close, set as Minform and so on)
        private FormSplash _formSplash;
        private Login _fLogin;
        private FrmMain _fMain;

        #endregion
        #region Initialization

        public LoginContext()
        {
            CreateSplashForm();

            // CreateLoginForm();
        }

        #endregion
        #region Private Methods

        /// <summary>
        /// The Splash form
        /// initialization, show and close
        /// </summary>
        private void CreateSplashForm()
        {
            _formSplash = new FormSplash();
            _formSplash.Closed += new EventHandler(FormSplash_Closed);
            MainForm = _formSplash;
            _formSplash.Show();

        }
        private void FormSplash_Closed(object sender, EventArgs e)
        {
            if (_formSplash.ShowLoginForm)
            {
                CreateLoginForm();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// The Login form 
        /// initilization and show
        /// </summary> 
        private void CreateLoginForm()
        {
            _fLogin = new Login();
            _fLogin.Closed += new EventHandler(fLogin_Closed);
            this.MainForm = _fLogin;
            _fLogin.Show();

        }
        /// If the login procedure done sucessfully 
        /// We'll see the Main Form 
        /// else the application will close 
        /// </summary>
        /// <param name="sender"></param>
        ///  <param name= "e"></param>
        void fLogin_Closed(object sender, EventArgs e)
        {
            // if (LWork.LoginWork.Logged) // if the user is logged
            
            if (CommonInfo.StaffID!=0)
            {
                _fMain = new FrmMain();
                //_fMain._UserDetailModel = _fLogin.UserDetailModel;
                this.MainForm = _fMain; //set the main message loop application in this form 
                _fMain.Closed += new EventHandler(FrmMain_Closed);
                _fMain.Show();
            }
            else
            {
                ExitThread();
            }
        }
        private void FrmMain_Closed(object sender, EventArgs e)
        {
            if (_fMain.IsLogOut)
            {
                CreateLoginForm();
            }
            else
            {
                Application.Exit();
            }
        }





        #endregion
    }
}
