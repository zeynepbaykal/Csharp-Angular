using MyGameDemo.Entities;
using System;
using MyGameDemo.Abstract;

namespace MyGameDemo.Concrete
{
   public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " isimli kampanya eklendi. İndirim oranı: " + campaign.CampaingDiscount);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " isimli kampanya sistemden silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " isimli kampanya güncellendi. Güncel indirim oranı bu şekilde hesaplanmıştır : " + campaign.CampaingDiscount);
        }
    }
}
