
using MyGameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDemo.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public double GamePrice { get; set; }
        public double NewPrice { get; set; }
    }

   
}
