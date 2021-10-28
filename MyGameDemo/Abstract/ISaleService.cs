using System;
using System.Collections.Generic;
using System.Text;
using MyGameDemo.Entities;
using MyGameDemo.Abstract;

namespace MyGameDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
       
            
       
    }
}
