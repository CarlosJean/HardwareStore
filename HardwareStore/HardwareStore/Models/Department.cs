using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
