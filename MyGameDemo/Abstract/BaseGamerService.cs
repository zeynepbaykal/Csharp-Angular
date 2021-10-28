using MyGameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Abstract
{
   public abstract class BaseGamerService : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Üyeliğiniz eklendi! " + gamer.FirstName + " " + gamer.LastName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Üyeliğiniz silindi! " + gamer.FirstName + " " + gamer.LastName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Üyeliğiniz güncellendi! " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
