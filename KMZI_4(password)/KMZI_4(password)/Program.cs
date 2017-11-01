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
            int temp = rnd.Next(2, 4);
            Identificator game = new Identificator(temp);
            game.Flag = true;
            int i = 0;
            int R_old = 0;
            while (game.Flag && i < 3)
            {



                temp = rnd.Next(4, 4);
                game = new Identificator(temp);
               // game.generate_V(temp);
                      game.V[0] = 4;
                      game.V[1] = 9;
                      game.V[2] = 16;
                      game.V[3] = 29;
                game.V_b_Click(temp);
                Console.WriteLine("Введите число R меньшее " + game.N);
                int R = game.durak();
                while (R >= game.N)
                {
                    Console.WriteLine("Введите число R меньшее " + game.N);
                    R = game.durak();
                }
                if (R_old != R)
                {
                    game.metod_X(R);
                   // game.Generate_S(temp);

                    game.Generate_bool(temp);
                    game.secret_Y(R, temp);
                    game.writer(temp);
                    Console.WriteLine("Введите число Y");
                    int new_Y = game.durak();

                    game.ending(new_Y, temp);
                    R_old = R;
                   // game.ending(game.Y, temp);

                    i++;
                }
                else { R_old = R; game.Flag = false; i++; Console.WriteLine("Проверка не пройдена"); }
            }
            Console.ReadLine();

        }
    }
}
