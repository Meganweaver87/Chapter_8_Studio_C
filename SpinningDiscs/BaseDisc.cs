using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int TotalGigaBytes { get; set; }
        public int AvailableGigaBytes { get; set; }
        public int UsedGigaBytes { get; set; }
        public string DiscType { get; set; }
        public List<string> DataStored { get; set; }

        public BaseDisc(string name, int totalGigaBytes, string discType, int dataSize)
        {
            Name = name;
            TotalGigaBytes = totalGigaBytes;
            DiscType = discType;
            UsedGigaBytes = CheckDiscCapacity(dataSize);
            AvailableGigaBytes = SpaceLeft();
        } // close constructor

        public int CheckDiscCapacity(int dataSize)
        {
            if (TotalGigaBytes < dataSize)
            {
                return TotalGigaBytes;
            }
            else
            {
                return dataSize;
            }
        } // close checkdisc

        public int SpaceLeft()
        {
            return TotalGigaBytes - UsedGigaBytes;
        } // close spaceleft

        public string DiscInfo()
        {
            string output = "Disc name: " + Name + "\nMax Capacity: " + TotalGigaBytes + "\nSpace Used: " + UsedGigaBytes + "\nAvailable Space: " + AvailableGigaBytes;
            return output;
        } // close discinfo

        public string WriteData(int discSize)
        {
            if (discSize > AvailableGigaBytes)
            {
                return "Not enough disc space!";
            }
        UsedGigaBytes += discSize;
        AvailableGigaBytes -= discSize;

            return "Data written to disc. Remaining space = " + AvailableGigaBytes;
        } // close writedata
        
    } // close class
} // close namespace