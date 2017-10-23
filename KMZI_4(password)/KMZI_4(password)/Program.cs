using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KMZI_4_password_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int temp = rnd.Next(4,4);
            Identificator game = new Identificator(temp);
            game.generate_V(temp);
            /*game.V[0] = 4;
            game.V[1] = 11;
            game.V[2] = 16;
            game.V[3] = 29;
    */        
            Console.WriteLine("Введите число R меньшее " + game.N);
            int R = game.durak();
            while(R>=game.N)
            {
                Console.WriteLine("Введите число R меньшее " + game.N);
                R = game.durak();
            }
            game.metod_X(R);
            game.Generate_S(temp);
            game.writer(temp);
            game.Generate_bool(temp);
            game.secret_Y(R, temp);
            Console.WriteLine("Введите число Y");
            int new_Y = game.durak();
           
            game.ending(new_Y,temp);
            //game.ending(game.Y, temp);
            Console.ReadLine();

        }
    }
}
