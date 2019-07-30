using System;

namespace standardLib
{
    public class Class1<Typeofinputs>
    {
        public Typeofinputs add(Typeofinputs a, Typeofinputs b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            return (n1 + n2);
        }
        public Typeofinputs sub(Typeofinputs a, Typeofinputs b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            return (n1 - n2);
        }
        public Typeofinputs multiply(Typeofinputs a, Typeofinputs b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            return (n1 * n2);
        }
        public Typeofinputs division(Typeofinputs a, Typeofinputs b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            return (n1 / n2);
        }
        public int sumofnums(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            return sum;
        }
    }
}
