using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Dtos
{
    public class LineItems : BaseLineItems
    {
        public WebSiteDetails WebSiteDetails { get; set; }
        public AdwordCampaign AdwordCampaign { get; set; }
        //public ICollection<LineItemDetails> LineItemDetails { get; set; }

    }
}
