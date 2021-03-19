using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Lastnames { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int BusinessId { get; set; }
        public Business Business { get; set; }
    }
}
