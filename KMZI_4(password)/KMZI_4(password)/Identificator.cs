﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KMZI_4_password_
{
    class Identificator
    {
        public int X { get; set; }
        private int A = 5;
        private int B = 7;
        public int N;    //19823=43 *461 //43*3=129
        public int[] V { get; set; }
        private int[] S { get; set; }
        private int[] V_obr { get; set; }
        public int[] Bool { get; set; } //private
        public int Y { get; set; } //private
        public bool Flag { get; set; }
        public Identificator(int count)
        {
            V = new int[count];
            S = new int[count];
            V_obr = new int[count];
            Bool = new int[count];
            //Flag = true;
            metod_N();

        }
        public void writer(int count)
        {
            FileStream file_output = new FileStream("output.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file_output); //создаем «потоковый писатель» и связываем его с файловым потоком 
                                                                 //for (int i = 0; i < count; i++)
                                                                 //{
                                                                 // writer.Write(S[i]);
                                                                 // }
            writer.Write(Y);
            writer.WriteLine();
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 

        }
        public void ending(int new_Y, int count)
        {
            int temp = new_Y * new_Y;
            for (int i = 0; i < count; i++)
            {
                temp *= ((int)Math.Pow(V[i], Bool[i]));
            }
            temp = temp % N;
            if (temp == X)//temp == X
			{
                Console.WriteLine("Проверка пройдена");
                Flag = true;
            }
            else { Console.WriteLine("Проверка не пройдена"); Flag = false; }
        }
        public void secret_Y(int R, int count)
        {
            Y = R;
            for (int i = 0; i < count; i++)
            {
                Y *= ((int)Math.Pow(S[i], Bool[i]));
            }
            Y = Y % N;
        }
        public void metod_X(int R)
        {
            X = (R * R) % N;
        }
        private void metod_N()
        {
            N = A * B;
        }
        private void value_VObr(int count)
        {
            for (int i = 0; i < count; i++)
            {
                V_obr[i] = 1;
                while (V[i] * V_obr[i] % N != 1)
                {
                    V_obr[i]++;
                }
            }
        }
        public void Generate_S(int count)
        {
            value_VObr(count);

            for (int i = 0; i < count; i++)

                S[i] = (int)Math.Sqrt(V_obr[i]) % N;


        }
        public void generate_V(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Random rnd = new Random();//(DateTime.Now.Millisecond);
                //int temp = rnd.Next(1, N);
                V[i] = rnd.Next(2, N + 1);
                bool flag = true;
                while (!control_V(V[i]) && flag)
                {
                    //rnd.Next(1, N);
                    V[i] = rnd.Next(2, N + 1);
                    //V[i] = temp;
                    try
                    {
                        flag = !(V[i] == V[i - 1]);
                    }
                    catch (System.IndexOutOfRangeException) { flag = false; }
                }

            }
        }
        private bool control_V(int V)
        {
            bool b = false;

            {
                if (V < N)
                {
                    if (V % A != 0 && V % B != 0) b = true;
                    else b = false;
                }
                else b = false;
            }
            return b;
        }

        /*public void Generate_bool(int count)
        {
            Console.WriteLine("Последовательность для проверки");
            for (int i = 0; i < count; i++)
            {
                random_bits(i);
            }
            Console.WriteLine("");
        }*/
        public void random_bits(int count)
        {
			Console.WriteLine("Последовательность для проверки");
			Random rnd = new Random();
			for (int i = 0; i < count; i++)
			{
				//(DateTime.Now.Millisecond);
				Bool[i] = rnd.Next(0, 2);
				Console.Write(Bool[i] + " ");
				//int temp = rnd.Next();
				//bool b;
				/*if (rnd.Next(0, 2) % 2 == 0) b = true;
				else b = false;
				if (b)
				{
					Console.Write('1' + " ");
					Bool[i] = 1;


				}
				else
				{
					Console.Write('0' + " ");
					Bool[i] = 0;

				}*/
			}
			Console.WriteLine("");
			//Console.WriteLine("");
		}
        public int durak()
        {
            bool flag = false;
            int R = 0;
            // Console.WriteLine("Введите число");
            string str;
            str = Console.ReadLine();
            try
            {
                R = Convert.ToInt32(str);
                flag = true;
            }
            catch (Exception) { flag = false; Console.WriteLine("Неверный ввод"); }
            if (flag) { return R; }
            else { durak(); return 0; }
        }
        public void V_b_Click(int count)
        {
            for (int i = 0; i < count; i++)
            {
                int V_temp = V[i];


                if (V_temp % A == 0 || V_temp % B == 0 || V_temp > N) { Console.WriteLine("Ошибка в массиве V"); }
                else
                {
                    int VI = 0;
                    for (int j = 1; j < N * 2; j++)
                    {
                        if ((V_temp * j) % N == 1)
                        { VI = j; break; }


                    }

                    V_obr[i] = VI;

                    int k = VI;
                    int S_temp = 0;
                    int m = 1;
                    while ((m * m) % N != k) m++;
                    S_temp = m;
                    S[i] = S_temp;

                }
            }

        }
    }
}


