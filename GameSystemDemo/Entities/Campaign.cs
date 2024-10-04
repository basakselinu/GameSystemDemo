using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemDemo.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public float Discount { get; set; }

        public DateTime CampaignStart { get; set; }
        public DateTime CampaignEnd { get; set; }
    }
}
