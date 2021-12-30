using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.ControllerV;

namespace View
{
    public class MainCoordinator
    {
        private MainController mainController = new MainController();
        private LoginController loginController = new LoginController();

        private FrmLogin frmLogin;
        private FrmMain frmMain;

        #region singlton
        private static MainCoordinator instance;
        private MainCoordinator()
        {

        }
        public static MainCoordinator Instance
        {
            get
            {
                if(instance == null)
                {
                    instance=new MainCoordinator();
                }
                return instance;
            }
        }
        #endregion

        public Administrator Administrator { get; internal set; }

        public void OpenLoginForm()
        {
            frmLogin=new FrmLogin(loginController);
            frmLogin.Show();
        }

        public void OpenMainForm()
        {
            frmMain = new FrmMain(mainController);
            frmMain.Show();
        }
    }
}
