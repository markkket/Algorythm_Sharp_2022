using System;

namespace CourseApp
{
    public class Platypus
    {
        private static int count;

        private string name;
        private int age;

        public Platypus()
        : this("Untitled", 1)
        {
        }

        public Platypus(string name, int age)
        {
            count += 1;
            this.Age = age;
            if (age <= 0)
            {
                this.Age = 1;
            }

                this.name = name;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.age = value;
                }
            }
        }

        public void Hello()
        {
            Console.WriteLine($"Hello platypus {name} {Age}");
        }
    }
}