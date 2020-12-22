using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Notes { get; set; }
        public string DateCreated { get; set; }
    }
}
