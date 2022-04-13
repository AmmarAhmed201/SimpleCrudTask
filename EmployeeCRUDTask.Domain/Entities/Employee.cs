using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUDTask.Domain
{
    public class Employee : BaseEntity
    {
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public DateTime HiringDate { get; set; }
        public int DepartementId { get; set; }
        public Departement Departement { get; set; }
    }
}
