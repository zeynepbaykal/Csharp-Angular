using System;
using MyGameDemo.Abstract;
using MyGameDemo.Concrete;
using MyGameDemo.Entities;
using MyGameDemo.Adapters;

namespace MyGameDemo
{
    class Program
    {


        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 8;
            gamer1.FirstName = "Zeynep";
            gamer1.LastName = " Baykal";
            gamer1.NationalityId = 123456789; //kendi kimlik bilgilerinizi girerek deneme yapabilirsiniz.

            MernisAdapterService ms = new MernisAdapterService();
            BaseGamerService baseGamerService = new GamerManager(new MernisAdapterService());
            baseGamerService.Add(gamer1);
            


            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "-----";
            game1.GameCategory = "-----";
            game1.GamePrice = 190;

            Console.WriteLine("                        ");
            Console.WriteLine("          "+" Oyun Ekleme - Güncelleme - Silme ");
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);

            Console.WriteLine("                        ");
            Console.WriteLine("          "+ " KAMPANYA Ekleme - Güncelleme - Silme ");

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaingName = "Bugune özel";
            campaign1.CampaingDiscount = 10;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);




            SaleManager salesManager = new SaleManager();
            salesManager.Sale(gamer1, game1, campaign1);

        }
    }
}


//      Gereksinimler

//1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

//2.Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

//3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

//4.     Satışlarda kampanya entegrasyonunu simule ediniz.