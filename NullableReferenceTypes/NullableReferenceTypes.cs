using System;

namespace NullableReferenceTypes
{

    class NullableReferenceTypes
    {
        class MyClass
        {
            public void SayHello()
            {
                Console.WriteLine("Hello");
            }
        }

        static void Main(string[] args)
        {
            var myClass = new MyClass();

            ////100 lines of code.
            //if (true) //Some condition. 
            //{
            //    myClass = null;
            //}

            ////100 lines of code. 
            //if (myClass == null)
            //{
            //    //Do something special here. 
            //}

            //100 lines of code. 
            myClass.SayHello();
        }
    }
}
