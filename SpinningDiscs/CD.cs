using System;
namespace SpinningDiscs
{
    public class CD: BaseDisc, IOpticalDisc
    {
        public CD(string name, int totalGigaBytes, string discType, int dataSize) : base(name, totalGigaBytes, discType, dataSize)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("ReadCD");
        }

        public void SpinDisc()
        {
            Console.WriteLine("WriteCD");
        }

    } // close class
} // close namespace