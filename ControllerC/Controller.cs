using Domen;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.AdminSO;

namespace ControllerC
{
    public class Controller
    {
        private IGenericRepository repository;

        #region singlton
        private static Controller instance;
        private Controller()
        {
            repository=new GenericRepository();
        }
        public static Controller Instance
        {
            get
            {
                if(instance==null) instance=new Controller();
                return instance;
            }
        }
        #endregion

        public Administrator Login(Administrator admin)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(admin);
            return so.Result;
        } 

    }
}
