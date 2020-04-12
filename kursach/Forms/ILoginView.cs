using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    interface ILoginView
    {
        String Login { get; }
        String Password { get; }
        String Role { set ; }
    }
}
