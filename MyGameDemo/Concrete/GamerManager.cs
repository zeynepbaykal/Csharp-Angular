using System;
using System.Collections.Generic;
using System.Text;
using MyGameDemo.Entities;
using MyGameDemo.Abstract;
using MyGameDemo.Adapters;



namespace MyGameDemo.Concrete
{
    public class GamerManager : BaseGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Delete(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Delete(gamer);
            }
            else
            {
                Console.WriteLine("Eksik veya Hatalı İşlem Yaptınız Lütfen Bilgilerinizi Kontrol Ediniz.");
            }

        }

        public override void Add(Gamer gamer)
        {

            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                Console.WriteLine("Eksik veya Hatalı İşlem Yaptınız Lütfen Bilgilerinizi Kontrol Ediniz.");
            }

        }

        public override void Update(Gamer gamer)
        {

            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Update(gamer);
            }
            else
            {
                Console.WriteLine(" Eksik veya Hatalı İşlem Yaptınız Lütfen Bilgilerinizi Kontrol Ediniz.");
            }

        }
    }
}
