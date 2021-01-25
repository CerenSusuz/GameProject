using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ICampaignManager
    {
        // need admin for do this situations
        void CreateCampaign();
        void UpdateCampaign();
        void DeleteCampaign();
    }
}
