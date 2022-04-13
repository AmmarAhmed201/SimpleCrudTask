using System.Collections.Generic;

namespace EmployeeCRUDTask.Domain
{
    public class Departement : BaseEntity
    {
        public List<Employee> Employees { get; set; }
    }
}