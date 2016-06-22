﻿namespace AnimalHierarchy.Models
{
    using System;

    internal class Cat : Animal
    {
        private char sex;

        public override char Sex
        {
            get { return sex; }
            set
            {
                if (value != 'F' && value != 'f')
                {
                    throw new ArgumentException("Invalid sex!");
                }
                sex = value;
            }
        }

        public Cat(int age, string name, char sex) : base(age, name)
        {
            this.Sex = sex;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miao miao female miao.");
        }
    }
}
