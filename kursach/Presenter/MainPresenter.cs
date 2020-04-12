using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    class MainPresenter
    {
        MainForm mf;
        MainModel mm;
        public MainPresenter(MainForm _mf, MainModel _mm)
        {
            mf = _mf;
            mm = _mm;
        }
    }
}
