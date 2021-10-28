using System;
using System.Collections.Generic;
using System.Text;
using MyGameDemo.Entities;
namespace MyGameDemo.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);

    }
}
