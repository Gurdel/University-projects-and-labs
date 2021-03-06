﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mmsLab4
{
    class Chanel
    {
        public bool Enabled;//false - якщо пристрій зайнятий або заблокований
        double dt;//час обробки вимоги
        public int id;
        public double timeNext;//час, коли пристрій має стати вільним

        public Chanel(double m, int _id)
        {
            Enabled = true;
            dt = m;
            id = _id;
        }

        public double GetTime()
        {
            Random rand = new Random();
            double z = (rand.NextDouble() - 0.5) * dt;
            double t = dt + z;
            return t;
        }
    }
}
