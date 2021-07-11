using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace FormulaFinder.Properties
{
    public class TreeNode
    {
        public char data;
        public TreeNode leftChild, rightChild;
        public TreeNode(char data)
        {
            this.data = data;
            leftChild = rightChild = null;
        }
    }

    public class Tree
    {
        public static bool OperatorControl(char c)
        {
            char[] operators = { '+', '-', '*', '/' };
            if (operators.Contains(c))
            {
                return true;
            }

            return false;
        }

        public TreeNode GenerateTree(List<char> postfix, char PI, char height, char radius)
        {
            Stack st = new Stack();
            TreeNode t, t1, t2;

            for (int i = 0; i < postfix.Count; i++)
            {
                // if operand adds to stack
                if (!OperatorControl(postfix[i]))
                {
                    t = new TreeNode(postfix[i]);
                    sendOperandValue(t, PI, height, radius);
                    st.Push(t);
                }
                else
                {
                    t = new TreeNode(postfix[i]);

                    t1 = (TreeNode)st.Pop();
                    t2 = (TreeNode)st.Pop();

                    t.rightChild = t1;
                    t.leftChild = t2;

                    st.Push(t);
                }
            }
            t = (TreeNode)st.Peek();
            return t;
        }

        public void sendOperandValue(TreeNode t, int PI, int height, int radius)
        {
            if (t.data.Equals('h'))
            {
                t.data = (char)height;
            }
            else if (t.data.Equals('r'))
            {
                t.data = (char)radius;
            }
            else
            {
                t.data = (char)PI;
            }
        }

        public int PostOrder(TreeNode t)
        {
            if (t.leftChild == null && t.rightChild == null)
            {
                return t.data - '0'; //converting char->int 
            }
            int var1 = PostOrder(t.leftChild);
            int var2 = PostOrder(t.rightChild);
            return calculateExpression(var1, var2, t.data);
        }

        static int calculateExpression(int var1, int var2, char operationType)
        {
            if (operationType.Equals('+'))
            {
                return var1 + var2;
            }
            else if (operationType.Equals('*'))
            {
                return var1 * var2;
            }
            else if (operationType.Equals('-'))
            {
                return var1 - var2;
            }
            else
            {
                return var1 / var2;
            }
        }

        string infix;
        public string InOrder(TreeNode t)
        {
            if (t != null)
            {
                InOrder(t.leftChild);
                infix += t.data;
                InOrder(t.rightChild);
            }
            return infix;
        }
    }
}