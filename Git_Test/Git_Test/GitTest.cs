﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    public class GitTest
    {
        public int a=1;
        public int b=2;

        private int mult = 3;

        
        public int l = 5;

        public int c ;

        public int Addx(int x, int y)
        {
            c = a + (b * mult);
            c = c / 5;
            return c;
        }
        public int multi()
        {
            return mult;
        }
        public bool EqualNumber(int x, int x1)
        {
            if (x < x1)
                return false;
            else return true;
        }

        public int lol(int x)
        {
            if (x >= 10)
                return 2;
            else return 1;
        }
        
    }
    
}
