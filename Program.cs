using System;
using System.Collections.Generic;

namespace lv4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 i 2 zadatak
            //Dataset data = new Dataset("CSV.txt");
            //Analyzer3rdParty analyze = new Analyzer3rdParty();
            //Adapter adapter = new Adapter(analyze);
            //double[] re = adapter.CalculateAveragePerRow(data);
            //foreach (double rez in re)
            //{
            //    Console.WriteLine(rez);
            //}

            //double[] res = adapter.CalculateAveragePerColumn(data);

            //foreach (double rez in res)
            //{
            //    Console.WriteLine(rez);
            //}
            List<IRentable> list = new List<IRentable>();
            Video video = new Video("Juzni vetar");
            Book book = new Book("Gomora");
            list.Add(video);
            list.Add(book);
            RentingConsolePrinter rent = new RentingConsolePrinter();
            rent.DisplayItems(list);
            rent.PrintTotalPrice(list);


            List<IRentable> List2 = new List<IRentable>();
            HotItem War = new HotItem(new Book("broj55"));
            List2.Add(War);
            HotItem Domaci = new HotItem(new Video("Maratonci"));
            List2.Add(Domaci);
            RentingConsolePrinter Out2 = new RentingConsolePrinter();
            Out2.DisplayItems(List2);
            Out2.PrintTotalPrice(List2);

            List<IRentable> flashsale = new List<IRentable>();
            DiscountedItem low1 = new DiscountedItem(video);
            DiscountedItem low2 = new DiscountedItem(book);
            flashsale.Add(low1);
            flashsale.Add(low2);
            RentingConsolePrinter Out3 = new RentingConsolePrinter();
            Out3.DisplayItems(flashsale);
            Out3.PrintTotalPrice(flashsale);

        }
    }
}
