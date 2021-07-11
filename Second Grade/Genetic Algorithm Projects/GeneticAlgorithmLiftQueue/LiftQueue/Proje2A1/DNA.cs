using System;
using System.Collections;

namespace Proje2A1
{
    class DNA
    {
        private double süre;
        private int[] numaralar;

        public DNA() { }
        public DNA(double süre, int[] numaralar)
        {
            this.süre = süre;
            this.numaralar = numaralar;
        }

        public double getSüre
        {
            get { return süre; }
        }
        public double setSüre
        {
            set { süre = value; }
        }
        public int[] getNumaralar
        {
            get { return numaralar; }
        }
        public int[] setNumaralar
        {
            set { numaralar = value; }
        }
    }
}
