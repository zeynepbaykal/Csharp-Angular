using MyGameDemo.Entities;
using System;
using MyGameDemo.Abstract;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Concrete
{
    public class GameManager
    { 

        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun kütüphaneye eklendi!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "isimli oyun kütüphaneden silindi!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "isimli oyun güncelleştirildi!");
        }
    }
}
