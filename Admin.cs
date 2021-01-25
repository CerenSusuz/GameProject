using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Admin : Person , ICampaignManager, ISaleManager
    {
        public string Role { get; set; }

        public void CreateCampaign()
        {
            throw new NotImplementedException();
        }

        public void DeleteCampaign()
        {
            throw new NotImplementedException();
        }

        public void Sell(Person user, ICampaignManager campaignmanager)
        {
            throw new NotImplementedException();
        }

        public void UpdateCampaign()
        {
            throw new NotImplementedException();
        }
    }
}
