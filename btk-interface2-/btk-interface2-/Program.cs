using System;

internal class Program
{
    static void Main(string[] args)
    {
        IWorker[] workers = new IWorker[3]
        {
                new Manager(),
                new Worker(),
                new Robot()

            //3 çalışan grubuna da çalış emri verdik
        };
        foreach (var worker in workers)
        {
            worker.Work();
        }


        IEat[] eats = new IEat[2]
        {
                new Manager(),
                new Worker()

            //robotlar hariç diğer çalışan gruplarına yemek izni verdik.
        };
        foreach (var eat in eats)
        {
            eat.Eat();
        }
        Console.ReadLine();
    }

    interface IWorker
    {
        void Work();
    }
    interface ISalary
    {
        void GetSalary();

    }
    interface IEat
    {
        void Eat();
    }
    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("MANAGER SINIFI YEMEKTE");
        }

        public void GetSalary()
        {
            Console.WriteLine("MANAGER SINIFI ÖDEME ALDI");
        }

        public void Work()
        {
            Console.WriteLine("MANAGER SINIFI ÇALIŞIYOR");
        }
    }
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("ÇALIŞAN SINIFI YEMEKTE");
        }


        public void GetSalary()
        {
            Console.WriteLine("ÇALIŞAN SINIFI ODEME ALDI");
        }

        public void Work()
        {
            Console.WriteLine("ÇALIŞAN SINIFI ÇALIŞIYOR");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("ROBOT SINIFI ÇALIŞIYOR");
        }

    }

}


//ihtiyaca göre birden fazla interface oluşturabiliriz.
//bir classta birden fazla interface kullanabiliriz.
