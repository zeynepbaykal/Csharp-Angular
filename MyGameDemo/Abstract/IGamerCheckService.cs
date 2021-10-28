using System;
using System.Collections.Generic;
using System.Text;
using MyGameDemo.Entities;
using MyGameDemo.Concrete;
namespace MyGameDemo.Abstract
{
    public interface IGamerCheckService
    {
       bool CheckIfRealGamer(Gamer gamer);
    }
}
