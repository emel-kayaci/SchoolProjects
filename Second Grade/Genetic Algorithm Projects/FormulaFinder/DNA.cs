using System;
using System.Collections.Generic;

namespace FormulaFinder.Properties
{
    public class DNA
    {
        private double score;
        private List<char> infixChars;
        public DNA()
        {

        }
        public double getScore
        {
            get { return score; }
        }
        public double setScore
        {
            set { score = value; }
        }
        public List<char> getInfixChars
        {
            get { return infixChars; }
        }
        public List<char> setInfixChars
        {
            set { infixChars = value; }
        }

    }
}