using System;

namespace NullableReferenceTypes
{
    class Dog
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Dog(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }

    class NullableReferenceTypes
    {
        public static Dog? DogFactory(int age, string? name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return new Dog(age, name);
            }

            return null;
        }

        static void Main(string[] args)
        {
            Dog dogRex = new Dog(2, "Rex");
            //Dog nullDog = null;
            Dog? dogWithNullName = DogFactory(5, null);

            Console.WriteLine("First dog is {0} and it is {1} years old", dogRex.Name, dogRex.Age);
            // Console.WriteLine("Second dog is {0} and it is {1} years old", dogWithNullName.Name, dogWithNullName.Age + 1);

#nullable disable
            string text = null;
            string? anotherText = null;

            //nullDog = null;
#nullable enable

            Console.WriteLine(text);
            Console.WriteLine(anotherText);
        }
    }
}
