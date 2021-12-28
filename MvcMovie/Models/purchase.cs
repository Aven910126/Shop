using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Purchase
    {

        public int Id { get; set; }

        public String Name { get; set; }
        public String Quantity { get; set; }
        public String Price { get; set; }

    }
}
