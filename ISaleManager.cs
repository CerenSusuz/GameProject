using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ISaleManager
    {
        void Sell(Person user,ICampaignManager campaignmanager);
    }
}
