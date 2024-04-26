using System;


namespace String_Interpolution_Program
{
    public class Basic {
        public void m1() {
            String s = "Nimap";
            String s1 = "Infotech";
            String s2 = "Mumbai";

            Console.WriteLine(s + "" + s1 + "" + s2);
            Console.WriteLine("Hello  {0} {1}, Hello I am Present In {2}", s, s1, s2);
            Console.WriteLine($"Hello {s} {s1}, Hello I am Present In {s2}");

            int i = 10;
            int j = 20;

            Console.WriteLine(i + j);
            Console.WriteLine("The Sum Of " + i + " And " + j + " IS " + i + j);
            Console.WriteLine("The Sum Of " + i + " And " + j + " IS " + (i + j));
            Console.WriteLine("The Sum Of  {0} And  {1}  IS {2}", i, j, i + j);
            Console.WriteLine($"The Sum OF {i} And {j} Is {i + j}");

        }
    }
}
