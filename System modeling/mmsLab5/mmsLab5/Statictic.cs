using System;
using System.Collections.Generic;
using System.Text;

namespace mmsLab5
{
    class Statistic
    {
        double timePrev;//час попереднього збору статистики
        int Nunserv;//к-сть необслугованих вимог
        int Nserv;//к-сть обслугованих вимог
        double Laver;//середня довжина черги
        double Qaver;//середнє очікування вимог у черзі
        double Tnet;//середній час обслуговування
        double Raver1;//середнє завантаження пристрою К11
        double Raver2;//середнє завантаження пристрою К2
        double Daver1;//середня к-сть зайнятих пристроїв у СМО1
        double Daver2;//середня к-сть зайнятих пристроїв у СМО2
        double Daver;//середня к-сть зайнятих пристроїв у ММО

        public Statistic()
        {
            timePrev = 0;
            Nunserv = 0;
            Nserv = 0;
            Laver = 0;
            Qaver = 0;
            Tnet = 0;
            Raver1 = 0;
            Raver2 = 0;
            Daver1 = 0;
            Daver2 = 0;
            Daver = 0;
        }

        public void Next(double time, int Li, int R1,  int R2)
        {
            double dt = time - timePrev;
            timePrev = time;
            Laver += Li * dt;
            Qaver += Li * dt;
            int d1 = 0;//к-сть зайнятих пристроїв у СМО1
            int d2 = 0;//к-сть зайнятих пристроїв у СМО2
            if (R1 > 0) //якщо зайнятий пристрій К1
            {
                Raver1 += dt * R1;
                ++d1;
            }
            if (R2 > 0) //якщо зайнятий пристрій К2
            {
                Raver2 += dt;
                ++d2;
            }
            Daver1 += d1 * dt;
            Daver2 += d2 * dt;
            Daver += (d1 + d2) * dt;
        }

        public void Results(double Tmod, int nserv, int nunserv)
        {
            Nserv = nserv;
            Nunserv = nunserv;
            double P = (double)Nunserv / (Nserv + Nunserv);
            Laver /= Tmod;
            Qaver /= Nserv;
            Tnet /= Nserv;
            Raver1 /= Tmod;
            Raver2 /= Tmod;
            Daver /= Tmod;
            Daver1 /= Tmod;
            Daver2 /= Tmod;

            Console.WriteLine("Час моделювання: \t" + Tmod);
            Console.WriteLine("Вимог оброблено: \t" + Nserv);
            Console.WriteLine("Вимог не оброблено: \t" + Nunserv);
            Console.WriteLine("Iмовiрнiсть вiдмови: \t" + P);
            Console.WriteLine("Середня довжина черги: \t" + Laver);
            Console.WriteLine("Середнє очiкування вимог у черзi: \t" + Qaver);
            Console.WriteLine("Середнiй час обслуговування: \t" + Tnet);
            Console.WriteLine("Середнє завантаження пристроїв");
            Console.WriteLine("\t\t К1:\t" + Raver1);
            Console.WriteLine("\t\t К2:\t" + Raver2);
            Console.WriteLine("Середня кiлькiсть зайнятих пристроїв");
            Console.WriteLine("\t\t СМО1:\t" + Daver1);
            Console.WriteLine("\t\t СМО2:\t" + Daver2);
            Console.WriteLine("\t\t ММО:\t" + Daver);
        }

        public void Serv(double dt)//аргументом є час перебування вимоги в ММО
        {
            ++Nserv;
            Tnet += dt;
        }

        public void UnServ()
        {
            ++Nunserv;
        }
    }
}
