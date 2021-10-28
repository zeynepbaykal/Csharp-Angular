using System;
using System.Collections.Generic;
using System.Text;
using MyGameDemo.Entities;


namespace MyGameDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
