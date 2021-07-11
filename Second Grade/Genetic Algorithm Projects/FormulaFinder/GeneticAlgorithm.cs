using System;
using System.Collections.Generic;
using System.Linq;

namespace FormulaFinder.Properties
{
    public class GeneticAlgorithm
    {
        static readonly Random rd = new Random();

        static int RouletteWheelSelection(List<DNA> population)
        {
            double totalSumPopulation = 0;

            for (int i = 0; i < population.Count; i++)
            {
                totalSumPopulation += population[i].getScore;

            }
            int rand = rd.Next(0, 100);
            double partialSum = 0;
            for (int i = 0; i < population.Count; i++)
            {
                partialSum += 100 - (population[i].getScore / totalSumPopulation * 100);
                if (partialSum >= rand)
                {
                    return i;
                }
            }
            return -1;
        }

        public static List<char> SelectParents(List<DNA> population)
        {
            List<char> parent1 = population[RouletteWheelSelection(population)].getInfixChars;
            List<char> parent2 = population[RouletteWheelSelection(population)].getInfixChars;

            List<char> child = GenerateChild(parent1, parent2);
            return child;
        }

        static List<char> GenerateChild(List<char> parent1, List<char> parent2)
        {
            List<char> child = Crossover(parent1, parent2);
            return child;
        }

        static List<char> Crossover(List<char> parent1, List<char> parent2)
        {
            List<char> child = null;

            int midpoint1 = rd.Next(1, parent1.Count);
            char value1 = parent1.ElementAt(midpoint1);

            int midpoint2 = rd.Next(1, parent2.Count);
            char value2 = parent2.ElementAt(midpoint2);

            if (Tree.OperatorControl(value1) ^ Tree.OperatorControl(value2)) //XOR
            {
                child = new List<char>();
                for (int i = 0; i <= midpoint1; i++)
                {
                    child.Add(parent1.ElementAt(i));
                }
                for (int j = midpoint2; j < parent2.Count; j++)
                {
                    child.Add(parent2.ElementAt(j));
                }
            }
            else
            {
                child = new List<char>();
                for (int i = 0; i <= midpoint1; i++)
                {
                    child.Add(parent1.ElementAt(i));
                }
                for (int j = midpoint2 - 1; j < parent2.Count; j++)
                {
                    child.Add(parent2.ElementAt(j));
                }
            }

            Mutate(child, 0.095);
            return child;
        }

        static void Mutate(List<char> child, double mutation_rate)
        {
            char[] operators = { '+', '-', '*', '/' }; 
            char[] operands = { 'p', 'r', 'h' };

            for (int i = 0; i < child.Count; i++)
            {
                double rd_double = rd.NextDouble();

                if ((rd_double) < mutation_rate)
                {
                    int mutationIndex = rd.Next(1, child.Count);

                    if (Tree.OperatorControl(child.ElementAt(mutationIndex)))
                    {
                        int randomOperator = rd.Next(0, 4);
                        child[mutationIndex] = operators[randomOperator];
                    }
                    else
                    {
                        int randomOperand = rd.Next(0, 2);
                        child[mutationIndex] = operands[randomOperand];
                    }
                }
            }
        }
    }
}