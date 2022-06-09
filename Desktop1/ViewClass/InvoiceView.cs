using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop1.ViewClass
{
    class InvoiceView
    {
        public long ID { set; get; }
        public String Student { set; get; }
        public String Subject { set; get; }

        public String Class { set; get; }
        public double Price { set; get; }
        public DateTime Deadline { set; get; }
    }
}
