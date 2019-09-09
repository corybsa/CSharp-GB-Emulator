using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBEmu
{
    static class RAMInfo
    {
        public class RAMSize
        {
            public static int Kb = 1024;
            public static int Mb = Kb * 1024;

            public byte Code { get; }
            public int Size { get; }
            public byte Banks { get; }

            public RAMSize(byte code, int size, byte banks)
            {
                Code = code;
                Size = size;
                Banks = banks;
            }
        }
        
        private static List<RAMSize> Size = new List<RAMSize>();

        static RAMInfo()
        {
            // Sizes
            Size.Add(new RAMSize(0x00, 0, 0));
            Size.Add(new RAMSize(0x01, RAMSize.Kb * 16, 1));
            Size.Add(new RAMSize(0x02, RAMSize.Kb * 64, 1));
            Size.Add(new RAMSize(0x03, RAMSize.Kb * 256, 4));
            Size.Add(new RAMSize(0x04, RAMSize.Mb * 1, 16));
        }

        public static RAMSize GetSize(byte i)
        {
            RAMSize retval = Size[0];
            try
            {
                foreach(RAMSize rs in Size)
                {
                    if (rs.Code == i) retval = rs;
                    else retval = Size[0];
                }

                return retval;
            }
            catch(KeyNotFoundException)
            {
                return Size[0];
            }
        }
    }
}
