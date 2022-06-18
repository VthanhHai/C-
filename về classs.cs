using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace game
{
    /*class User
    {
        private int age;
        private int bod;
        public int Bod
        {
            get { return bod; }
            set { bod = value; age = 2022 - bod; }
        }
        public Age()
        {
            return age;
        }
    }
    */
    class Player
    {
        private int n;
        public int N
        {
            get { return n; }
            set
            {
                n = value;
                if (value < 3)
                    n = 3;
                else if (value > 5)
                    n = 5;
                else
                    n = value;
            }
        }


        public Player()
        {
            n = 10;
        }

    }
    internal class Board
    {
        static void Main(string[] args)
        {
            Player b = new Player();
            b.N = -100;
            Console.WriteLine(b.N);
            //b.print(); //print là một hàm tự định nghĩa;
        }
    }    
}