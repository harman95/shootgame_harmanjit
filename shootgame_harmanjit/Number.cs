using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shootgame_harmanjit
{
    public class Number
    {
        //object of the random class to generate the random no
        Random obj = new Random();
       //method of the class
        public int rnd() {

            return obj.Next(1, 5);
        }
        //method of the shootaway button
        public int Shootrnd()
        {
            return obj.Next(1, 3);
        }


    }
}
