using GameManagementDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaigns campaigns);
        void Delete(Campaigns campaigns);
        void Update(Campaigns campaigns);
    }
}
