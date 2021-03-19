using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Models {
    public class User {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Module> Modules { get; set; }
    }
}
