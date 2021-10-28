using System;
using System.Collections.Generic;
using System.Text;
using MyGameDemo.Abstract;
using MyGameDemo.Entities;

namespace MyGameDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            game.NewPrice = game.GamePrice - (game.GamePrice * (campaign.CampaingDiscount / 100));
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " ve" + gamer.Id + " isimli oyuncu " + game.GameName + " isimli oyunu sepetine ekledi. \n" + "Sepete eklenen ürün için " + campaign.CampaingName + " isimli kampanyadan faydalanılmıştır. \n" + "Kampanya sonrası güncel sepet tutarı :" + game.NewPrice + " şeklindedir.");



        }
    }
}

        