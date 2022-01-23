using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Dtos
{
    public class LineItems
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProductType { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }
        public ICollection<LineItemDetails> LineItemDetails { get; set; }
        
    }
}
