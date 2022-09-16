using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            CD bananasInPajamas = new CD("Bananas in Pajamas: It's Fun Time", 700, "CD-ROM", 500);
            DVD barbieBootleg = new DVD("Barbie in the 12 Dancing Princesses", 4700, "DVD-ROM", 3000);

            bananasInPajamas.SpinDisc();
            bananasInPajamas.ReadData();
            Console.WriteLine(bananasInPajamas.WriteData(200));
            Console.WriteLine(bananasInPajamas.DiscInfo());

            barbieBootleg.SpinDisc();
            barbieBootleg.ReadData();
            Console.WriteLine(barbieBootleg.WriteData(5000));
            Console.WriteLine(barbieBootleg.DiscInfo());
        }

    } // close class
} // close namespace