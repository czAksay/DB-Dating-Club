using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace kursach
{
    public class LoginModel : ILoginModel
    {
        String reg_login = "reg", reg_pass = "reg";
        String role;
        String login;
        public String Role { get { return role; } }
        public String Login { get { return login; } }

        public bool IsPassEmpty(String Login, String Pass)
        {
            return (Login == "" || Pass == "");
        }


        public bool IsPassInDB(String Login, String Pass)
        {
            login = Login;
            PgSql.ConnectToUsersDB("reg", "reg");
            NpgsqlDataReader dataReader = PgSql.SelectRoleFromUsers(Login, Pass);
            if (dataReader.Read())
            {
                role = dataReader[0].ToString();
                return true;
            }
            return false;
        }
    }
}
