using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting,boxing,implicit
            //Shark shark = new Shark();
            //Bird bird = new Eagle();
            //Eagle eagle = new Eagle();
            //Fork fork = new Fork();

            //object o1 = eagle;
            //object a = 5;

            //object[] arr = { shark, a1, eagle, o1, a };
            //Print(eagle);
            //Print(shark);
            //Print(fork);
            #endregion

            #region Downcasting,unboxing,explicit
            //Animal a1 = new Shark();
            //Animal a2 = new Eagle();

            //object[] arr = { 1, "adasf", a1, true, a2 };

            //foreach (var item in arr)
            //{
            //    if (item is Shark shark)
            //    {
            //        shark.VTest();
            //    }
            //}

            //bool isShark = a2 is Shark;
            //Console.WriteLine(isShark);
            //if(a1 is Shark)
            //{
            //    Shark shark = (Shark)a1;
            //}

            //if(a1 is Shark shark)
            //{
            //    Console.WriteLine(shark);
            //}


            //Shark isShark = a1 as Shark;
            //if (isShark != null)
            //{
            //    Console.WriteLine(isShark);
            //}
            #endregion

            #region Casting buildintypes

            //int a = 2100000000;
            //long l = a;
            //Console.WriteLine(l);
            //long l = 3000000000;
            //int i = (int)l;
            //Console.WriteLine(i);
            //double d = 3.2132;
            //int i = (int)d;
            //Console.WriteLine(i);
            #endregion

            #region Implicit,Explicit operators
            Manat manat = new Manat(340);
            Dollar dollar = (Dollar)manat;
            Console.WriteLine(dollar.Usd);
            #endregion
        }

        static void Print(Animal animal)
        {
            animal.VTest();
        }
    }

    #region Implicit,Explicit operators
    class Manat
    {
        public double Azn { get; set; }
        public Manat(double azn)
        {
            Azn = azn;
        }

        //public static implicit operator Dollar(Manat manat)
        //{
        //    return new Dollar(manat.Azn / 1.7);
        //} 
        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }

    }

    class Dollar
    {
        public double Usd { get; set; }
        public Dollar(double usd)
        {
            Usd = usd;
        }
    }
    #endregion

    #region Upcasting
    abstract class Animal
    {
        public abstract void Eat();
        public virtual void VTest()
        {
            Console.WriteLine("Animal body");
        }
    }

    abstract class Bird:Animal
    {
        public abstract void Fly();
        public override void VTest()
        {
            Console.WriteLine("Bird body");
        }
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
        public override void VTest()
        {
            Console.WriteLine("Fish body");
        }
    }

    class Eagle : Bird
    {
        public int Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }

        public override void VTest()
        {
            Console.WriteLine("Eagle body");
        }
    }

    class Fork : Fish
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Swim()
        {
            throw new NotImplementedException();
        }

        public override void VTest()
        {
            Console.WriteLine("Fork body");
        }
    }

    class Shark : Fish
    {
        public int TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }

        public override void VTest()
        {
            Console.WriteLine("Shark body");
        }
    }
    #endregion
}
