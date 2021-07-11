using System;
using System.Collections.Generic;
using System.Linq;
using FormulaFinder.Properties;

namespace FormulaFinder
{
    class Program
    {
        static readonly Random rand = new Random();

        static void Main(string[] args)
        {
            string cont = "y";

            while (cont.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("1.Find the cylinder volume formula.");
                Console.WriteLine("2.Find the cylinder area formula.");

                int select = Convert.ToInt16(Console.ReadLine());

                if (select == 1)
                {
                    int[,] dataSet = CreateDataSet(1);
                    List<DNA> population = CreateExperimentSet(dataSet);
                    DNA bestResult = RunGeneticAlgorithm(population, 50, dataSet);

                    while (bestResult.getScore != 0)
                    {
                        population = CreateExperimentSet(dataSet);
                        bestResult = RunGeneticAlgorithm(population, 50, dataSet);
                    }

                    Console.WriteLine("Score of the formula: " + bestResult.getScore);
                    Console.WriteLine("Formula: ");
                    List<char> formula = bestResult.getInfixChars;
                    foreach (char c in formula)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }
                else if (select == 2)
                {
                    int[,] dataSet = CreateDataSet(2);
                    List<DNA> population = CreateExperimentSet(dataSet);
                    DNA bestResult = RunGeneticAlgorithm(population, 50, dataSet);

                    while (bestResult.getScore != 0)
                    {
                        population = CreateExperimentSet(dataSet);
                        bestResult = RunGeneticAlgorithm(population, 50, dataSet);
                    }

                    Console.WriteLine("Score of the formula: " + bestResult.getScore);
                    Console.WriteLine("Formula: ");
                    List<char> formula = bestResult.getInfixChars;
                    foreach (char c in formula)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

        static DNA RunGeneticAlgorithm(List<DNA> population, int  numberOfGenerations, int[,] dataSet)
        {
            for (int i = 0; i < numberOfGenerations; i++)
            {
                List<DNA> populationCopy = population.ToList();

                for (int t = 0; t < populationCopy.Count; t++)
                {
                    Console.Write("\n" + (t + 1) + ".formula score: " + populationCopy.ElementAt(t).getScore);
                    Console.Write("\nFormula: ");
                    List<char> infixChars = populationCopy.ElementAt(t).getInfixChars;
                    foreach (char c in infixChars)
                    {
                        Console.Write(c);
                    }
                }

                populationCopy.Sort((x, y) => x.getScore.CompareTo(y.getScore));
                population.Clear();

                population.Add(populationCopy.ElementAt(0));
                population.Add(populationCopy.ElementAt(1));
                population.Add(populationCopy.ElementAt(2));


                for (int j = 0; j < populationCopy.Count - 3; j++)
                {
                    List<char> childInfixChars = GeneticAlgorithm.SelectParents(populationCopy);
                    int[] results = FindOperationResult(dataSet, childInfixChars);
                    DNA child = new DNA();
                    bool cont = FindScore(child, dataSet, results);
                    while (cont)
                    {
                        childInfixChars = GeneticAlgorithm.SelectParents(populationCopy);
                        results = FindOperationResult(dataSet, childInfixChars);
                        cont = FindScore(child, dataSet, results);
                    }
                    child.setInfixChars = childInfixChars;
                    population.Add(child);
                }
                if (populationCopy.ElementAt(0).getScore == 0)
                {
                    break;
                }
            }
            return population[0];
        }

        static bool FindScore(DNA person, int[,] dataSet, int[] values)
        {
            int distance = 0;
            for (int j = 0; j < 10; j++)
            {
                distance += Math.Abs(dataSet[j, 2] - values[j]);
                if (Math.Abs(distance) >= Int16.MaxValue)
                {
                    return true;
                }
            }
            Console.WriteLine();

            person.setScore = distance;
            return false;
        }

        static int[,] CreateDataSet(int selection)
        {
            int[,] dataSet = new int[10, 3];

            for (int i = 0; i < 10; i++)
            {
                int r = rand.Next(1, 10);
                int h = rand.Next(1, 10);
                if (selection == 1)
                {
                    int volume = (int)(3 * Math.Pow(r, 2) * h);
                    dataSet[i, 2] = volume;
                }
                else
                {
                    int area = 3 * r * r + 3 * r * r + 3 * r * h + 3 * r * h;
                    dataSet[i, 2] = area;
                }
                dataSet[i, 0] = r; dataSet[i, 1] = h;
            }
            return dataSet;
        }

        // Creates trees (population)
        static List<DNA> CreateExperimentSet(int[,] dataSet)
        {
            List<DNA> population = new List<DNA>();
            char[] operators = { '+', '-', '*', '/' }; 
            char[] operands = { 'p', 'r', 'h' };

            // Generates 5 random infix expression 
            for (int i = 0; i < 10; i++)
            {
                List<char> infixChars = GenerateRandomExp(operators, operands);

                string infix = "";
                foreach (char c in infixChars)
                {
                    infix += c;
                }

                DNA person = new DNA();
                person.setInfixChars = infixChars;
                population.Add(person);
            }

            foreach (DNA person in population)
            {
                List<char> infixChars = person.getInfixChars;
                int[] values = FindOperationResult(dataSet, infixChars);
                FindScore(person, dataSet, values);
            }
            return population;
        }

        static int[] FindOperationResult(int[,] dataSet, List<char> infixChars)
        {
            int[] values = new int[10];
            Tree tr = new Tree();
            for (int j = 0; j < 10; j++)
            {
                string postfix = InfixtoPostfix(infixChars);
                List<char> charList = postfix.ToList();
                int data1 = dataSet[j, 0];
                int data2 = dataSet[j, 1];
                TreeNode root = tr.GenerateTree(charList, '3', Convert.ToChar(data2.ToString()), Convert.ToChar(data1.ToString()));
                values[j] = tr.PostOrder(root);
            }
            return values;
        }

        static string InfixtoPostfix(List<char> infixChars)
        {
            Stack<Char> st = new Stack<char>();
            string postfix = "";

            foreach (char ch in infixChars)
            {
                if (Tree.OperatorControl(ch))
                {
                    if (st.Count == 0)
                    {
                        st.Push(ch);
                    }
                    else
                    {
                        char ch1 = st.Pop();
                        postfix += ch1;
                        st.Push(ch);
                    }
                }
                else
                {
                    postfix += ch;
                }
            }
            postfix += st.Pop();

            return postfix;
        }

        static List<char> GenerateRandomExp(char[] operators, char[] operands)
        {
            List<char> charList = new List<char>();

            for (int i = 0; i < 7; i++)
            {
                if (i % 2 == 0)
                {
                    charList.Add(operands.ElementAt(rand.Next(0, 3)));
                }
                else
                {
                    charList.Add(operators.ElementAt(rand.Next(0, 4)));
                }
            }
            return charList;
        }
    }
}