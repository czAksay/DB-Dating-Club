using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public class LoginPresenter
    {
        LoginForm lf;
        LoginModel model;

        public String Role {  get { return model.Role; } }
        public String Login { get { return model.Login; } }
        public LoginPresenter(LoginForm _lf, LoginModel _lm)
        {
            lf = _lf;
            model = _lm;
        }

        public bool CheckPassEmpty()
        {
            return model.IsPassEmpty(lf.Login, lf.Password);
        }

        public void ConnectToUserDB()
        {

        }

        public bool IsPassInDB()
        {
            return model.IsPassInDB(lf.Login, lf.Password);
        }
    }
}
