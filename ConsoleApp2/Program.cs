using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //callMethod();
            var existingDateStart = new DateTime(2020, 02, 01);
            //var existingDateEnd = new DateTime(2020, 02, 28);
            DateTime? existingDateEnd = null;


            List<Tuple<DateTime, DateTime?>> dates = new List<Tuple<DateTime, DateTime?>>();


            dates.Add(new Tuple<DateTime, DateTime?>( new DateTime(2020, 01, 21), DateTime.MaxValue));
            dates.Add(new Tuple<DateTime, DateTime?>( new DateTime(2020, 01, 21), new DateTime(2020, 02, 01)));
            dates.Add(new Tuple<DateTime, DateTime?>( new DateTime(2020, 01, 21), new DateTime(2020, 02, 28)));
            dates.Add(new Tuple<DateTime, DateTime?>( new DateTime(2020, 01, 21), new DateTime(2020, 02, 29)));

            dates.Add(new Tuple<DateTime, DateTime?>( new DateTime(2020, 02, 28), DateTime.MaxValue));
            dates.Add(new Tuple<DateTime, DateTime?>( new DateTime(2020, 02, 03), new DateTime(2020, 02, 27)));
            dates.Add(new Tuple<DateTime, DateTime?>( new DateTime(2020, 02, 05), new DateTime(2020, 03, 01)));
            dates.Add(new Tuple<DateTime, DateTime?>(new DateTime(2020, 02, 01), new DateTime(2020, 02, 28)));

            foreach (var item in dates)
            {
                Console.WriteLine("AStart: " + existingDateStart);
                Console.WriteLine("AEnd: " + existingDateEnd);
                Console.WriteLine("BStart: " + item.Item1);
                Console.WriteLine("BENd: " + item.Item2);
                if (existingDateStart <= item.Item2 && (item.Item1 <= existingDateEnd || existingDateEnd == null))
                {
                    Console.WriteLine("Yo");
                }
                Console.ReadKey();
            }

            Console.ReadLine();
        }


        static async void callMethod()
        {

            var count = counter2();

            Console.WriteLine(count);
        }



        static int counter2()
        {
            Console.WriteLine("in baaarrrrrrrrrr");
            int i;
            for (i = 0; i < 2500; i++)
            {
                Console.WriteLine("bar -" + i);

            }
            return i;
        }
    }


}

