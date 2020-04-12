using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.Forms
{
    interface IDataView
    {
        Presenter.DataPresenter DataPresenter { get; set; }
        ContractFilter ContractFilter { get; set; }
        DepartmentFilter DepartmentFilter { get; set; }
        MeetingFilter MeetingFilter { get; set; }
        EmployeeFilter EmployeeFilter { get; set; }
        ClientFilter ClientFilter { get; set; }
        MeetingAction MeetingAction { get; set; }
        DepartmentAction DepartmentAction { get; set; }
        ContractAction ContractAction { get; set; }
        PareAction PareAction { get; set; }
        EmployeeAction EmployeeAction { get; set; }
        MeetingPlaceAction MeetingPlaceAction { get; set; }
        ClientAction ClientAction { get; set; }
    }
}
