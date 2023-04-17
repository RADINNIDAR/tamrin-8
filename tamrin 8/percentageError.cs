using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class percentageerror
    {

        public static decimal Calculate(decimal currentPrice, decimal lastPrice)
        {
            decimal percentagEerror = Math.Abs((currentPrice - lastPrice) / lastPrice) * 100;
            return percentagEerror;
        }

    }

