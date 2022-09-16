using System;
namespace SpinningDiscs
{
    public class DVD: BaseDisc, IOpticalDisc
    {
        public DVD(string name, int totalGigaBytes, string discType, int dataSize) : base(name, totalGigaBytes, discType, dataSize)
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