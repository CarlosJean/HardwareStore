using HardwareStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore
{
    public class Employee
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Lastnames { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhoneNumber { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Identification { get; set; }
        public string IdentificationImage { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int ChargeId { get; set; }
        public Charge Charge { get; set; }
        public int Salary { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
