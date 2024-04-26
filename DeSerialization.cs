using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serialization_DeSerialization_Program
{
    internal partial class Program
    {
        public class DeSerialization { 
        public void m2()
            {
                //DeSerialization
                String path = @"D:\Nimap\Sample.txt";
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                Student stu = (Student)formatter.Deserialize(fileStream);
                Console.WriteLine(stu.age);
                Console.WriteLine(stu.name);
                fileStream.Close();
                Console.ReadLine();

            }
        }
    }
}
