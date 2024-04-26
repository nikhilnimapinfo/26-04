using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serialization_DeSerialization_Program
{
    internal partial class Program
    {
        public class Serialization
        {
            public void m1() {
                //Serialization

                String path = @"D:\Nimap\Sample.txt";
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                Student student = new Student("Ram Varma", 22);
                formatter.Serialize(fileStream, student);
                fileStream.Close();
                Console.WriteLine("File Created SucessFully => " + path);
                Console.ReadLine();
            }
        }
    }
}
