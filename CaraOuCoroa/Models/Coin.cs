using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraOuCoroa.Models
{
    class Coin
    {
        public Coin()
        {

        }

        public string Girar()
        {
            return new Random().Next(2) == 0 ? CoinType.CARA.ToString() : CoinType.COROA.ToString();
        }

    }
}
