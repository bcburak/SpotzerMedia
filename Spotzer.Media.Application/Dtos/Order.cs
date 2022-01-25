using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Dtos
{
    public class Order
    {
        public string Partner { get; set; }
        public string OrderID { get; set; }
        public string TypeOfOrder { get; set; }
        public string SubmittedBy { get; set; }
        public string CompanyID { get; set; }
        public string CompanyName { get; set; }
        public ICollection<LineItems> LineItems { get; set; }


        
    }
}
