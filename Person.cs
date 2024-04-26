using System;

namespace String_Interpolution_Program
{
    public class Person
    {
        string s;
        public void m2()
        {
            int i = 10;
            int j = 20;

            s = "The Sum Of " + i + " And " + j + " IS " + i + j;
            Console.WriteLine(s);
            s = "The Sum Of " + i + " And " + j + " IS " + (i + j);
            Console.WriteLine(s);
            s = string.Format("The Sum Of  {0} And  {1}  IS {2}", i, j, i + j);
            Console.WriteLine(s);
            s = $"The Sum OF {i} And {j} Is {i + j}";
            Console.WriteLine(s);

        }
    }
}
