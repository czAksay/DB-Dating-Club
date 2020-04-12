using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    public class MainModel : IMainModel
    {
        int chosenId;
        CurrentTable currTable = CurrentTable.None;
        String currTableStringName;
        String filterString;
        String login, role, role_password;
    }
}
