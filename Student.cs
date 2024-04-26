using System;

namespace Serialization_DeSerialization_Program
{
    [Serializable]
    public class Student {
        public int age;
        public String name;
       
        public Student(String name,int age)
        {
            this.age = age;
            this.name = name;
        }
    } 
}
