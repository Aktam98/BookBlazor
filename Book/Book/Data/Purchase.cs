using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Data
{
    public class Purchase
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public DateTime Date { get; set; }
    }
}
