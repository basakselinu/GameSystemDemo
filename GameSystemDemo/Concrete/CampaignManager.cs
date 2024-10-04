using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystemDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" eklendi.");
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " silindi.");

        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " güncellendi.");

        }
    }
}
