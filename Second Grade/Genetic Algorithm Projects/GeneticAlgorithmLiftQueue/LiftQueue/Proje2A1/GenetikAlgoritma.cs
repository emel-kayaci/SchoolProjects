using System;
using System.Collections.Generic;

namespace Proje2A1
{
    class GenetikAlgoritma
    {
        static readonly Random rd = new Random();

        static int[] ÇocukBelirle(int[] parent1, int[] parent2)
        {
            int[] çocuk = Crossover(parent1, parent2);
            return çocuk;
        }


        static int RouletteWheelSelection(List<DNA> popülasyon)
        {
            double totalSumPopulation = 0;

            for (int i = 0; i < popülasyon.Count; i++)
            {
                totalSumPopulation += popülasyon[i].getSüre;
            }
            int rand = rd.Next(0, 100);
            double partialSum = 0;
            for (int i = 0; i < popülasyon.Count; i++)
            {
                partialSum += (popülasyon[i].getSüre) / totalSumPopulation * 100;
                if (partialSum >= rand)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] Crossover(int[] parent1, int[] parent2)
        {
            int[] child = new int[parent1.Length];

            int midpoint = rd.Next(1, parent1.Length - 1);
            for (int i = 0; i < child.Length; i++)
            {
                if (i < midpoint)
                {
                    child[i] = parent1[i];
                }
                else
                {
                    child[i] = parent2[i];
                }
            }
            Mutate(child, 0.08);
            return child;
        }

        static void Mutate(int[] child, double mutation_rate)
        {
            for (int i = 0; i < child.Length; i++)
            {
                int rd_sayi = rd.Next(0, 2);
                double rd_double = rd.NextDouble();

                if ((rd_double) < mutation_rate)
                {
                    child[i] = rd_sayi;
                }
            }
        }

        public static int[] ParentBelirle(List<DNA> popülasyon)
        {
            int[] parent1 = popülasyon[RouletteWheelSelection(popülasyon)].getNumaralar;
            int[] parent2 = popülasyon[RouletteWheelSelection(popülasyon)].getNumaralar;

            int[] çocuk = ÇocukBelirle(parent1, parent2);
            return çocuk;
        }
    }
}