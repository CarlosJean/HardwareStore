using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Models {
    public class Item {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        
        public float Availability { get; set; }
        public int UnitOfMeasurementId { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
