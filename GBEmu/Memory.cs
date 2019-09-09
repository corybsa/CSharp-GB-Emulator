using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBEmu
{
    static class Memory
    {
        public static byte[] Cartridge = new byte[0x8000];
        public static byte[] SRAM = new byte[0x2000];
        public static byte[] IO = new byte[0x100];
        public static byte[] VideoRAM = new byte[0x2000];
        public static byte[] OAM = new byte[0x100];
        public static byte[] WorkRAM = new byte[0x2000];
        public static byte[] HRAM = new byte[0x80];
    }
}
