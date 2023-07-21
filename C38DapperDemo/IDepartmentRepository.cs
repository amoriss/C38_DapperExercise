using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C38DapperDemo;
internal interface IDepartmentRepository
{
    public IEnumerable<Department> GetAllDepartments(); //Stubbed out method
    public void InsertDepartment(string newDepartmentName);
}
