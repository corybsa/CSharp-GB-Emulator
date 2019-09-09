using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBEmu
{
    static class ROMInfo
    {
        public class ROMSize
        {
            public static int Kb = 1;
            public static int Mb = Kb * 1024;

            public byte Code { get; }
            public int Size { get; }
            public byte Banks { get; }

            public ROMSize(byte code, int size, byte banks)
            {
                Code = code;
                Size = size / 8;
                Banks = banks;
            }
        }

        public class ROMType
        {
            public byte Code { get; }
            public string Text { get; }

            public ROMType(byte code, string text)
            {
                Code = code;
                Text = text;
            }
        }

        private static List<ROMType> Type = new List<ROMType>();
        private static List<ROMSize> Size = new List<ROMSize>();

        static ROMInfo()
        {
            // Types
            Type.Add(new ROMType(0x00, "ROM_PLAIN"));
            Type.Add(new ROMType(0x01, "ROM_MBC1"));
            Type.Add(new ROMType(0x02, "ROM_MBC1"));
            Type.Add(new ROMType(0x03, "ROM_MBC1_RAM_BATT"));
            Type.Add(new ROMType(0x05, "ROM_MBC2"));
            Type.Add(new ROMType(0x06, "ROM_MBC2_BATTERY"));
            Type.Add(new ROMType(0x08, "ROM_RAM"));
            Type.Add(new ROMType(0x09, "ROM_RAM_BATTERY"));
            Type.Add(new ROMType(0x0B, "ROM_MMM01"));
            Type.Add(new ROMType(0x0C, "ROM_MMM01_SRAM"));
            Type.Add(new ROMType(0x0D, "ROM_MMM01_SRAM_BATT"));
            Type.Add(new ROMType(0x0F, "ROM_MBC3_TIMER_BATT"));
            Type.Add(new ROMType(0x10, "ROM_MBC3_TIMER_RAM_BATT"));
            Type.Add(new ROMType(0x11, "ROM_MBC3"));
            Type.Add(new ROMType(0x12, "ROM_MBC3_RAM"));
            Type.Add(new ROMType(0x13, "ROM_MBC3_RAM_BATT"));
            Type.Add(new ROMType(0x19, "ROM_MBC5"));
            Type.Add(new ROMType(0x1A, "ROM_MBC5_RAM"));
            Type.Add(new ROMType(0x1B, "ROM_MBC5_RAM_BATT"));
            Type.Add(new ROMType(0x1C, "ROM_MBC5_RUMBLE"));
            Type.Add(new ROMType(0x1D, "ROM_MBC5_RUMBLE_SRAM"));
            Type.Add(new ROMType(0x1E, "ROM_MBC5_RUMBLE_SRAM_BATT"));
            Type.Add(new ROMType(0x1F, "ROM_POCKET_CAMERA"));
            Type.Add(new ROMType(0xFD, "ROM_BANDAI_TAMA5"));
            Type.Add(new ROMType(0xFE, "ROM_HUDSON_HUC3"));
            Type.Add(new ROMType(0xFF, "ROM_HUDSON_HUC1"));

            // Sizes
            Size.Add(new ROMSize(0x00, ROMSize.Kb * 256, 2));
            Size.Add(new ROMSize(0x01, ROMSize.Kb * 512, 2));
            Size.Add(new ROMSize(0x02, ROMSize.Mb * 1, 2));
            Size.Add(new ROMSize(0x03, ROMSize.Mb * 2, 2));
            Size.Add(new ROMSize(0x04, ROMSize.Mb * 4, 2));
            Size.Add(new ROMSize(0x05, ROMSize.Mb * 8, 2));
            Size.Add(new ROMSize(0x06, ROMSize.Mb * 16, 2));
            Size.Add(new ROMSize(0x52, ROMSize.Mb * 9, 2));
            Size.Add(new ROMSize(0x53, ROMSize.Mb * 10, 2));
            Size.Add(new ROMSize(0x54, ROMSize.Mb * 12, 2));
        }

        public static ROMType GetType(byte i)
        {
            ROMType retval = new ROMType(i, "ERROR");
            try
            {
                foreach (ROMType rt in Type)
                {
                    if (rt.Code == i) retval = rt;
                }

                return retval;
            }
            catch (Exception)
            {
                return Type[26];
            }
        }

        public static ROMSize GetSize(byte i)
        {
            ROMSize retval = Size[0];
            try
            {
                foreach(ROMSize rs in Size)
                {
                    if (rs.Code == i) retval = rs;
                }

                return retval;
            }
            catch(Exception)
            {
                return Size[0];
            }
        }
    }
}
