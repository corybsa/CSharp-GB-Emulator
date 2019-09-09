using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBEmu
{
    class ROM
    {
        // offsets
        private ushort RomOffsetName = 0x134;
        private ushort RomOffsetGameboyColor = 0x143;
        private ushort RomOffsetSuperGameboy = 0x146;
        private ushort RomOffsetType = 0x147;
        private ushort RomOffsetRomSize = 0x148;
        private ushort RomOffsetRamSize = 0x149;

        // internal stuff
        private byte[] Header { get; set; }
        private string InternalName { get; set; }
        private ROMInfo.ROMSize InternalROMSize { get; set; }
        private ROMInfo.ROMType InternalROMType { get; set; }
        private RAMInfo.RAMSize InternalRAMSize { get; set; }

        // other stuff
        private FileStream File;
        private TextBox Log { get; set; }

        public ROM(TextBox log)
        {
            Log = log;
        }

        public bool Load(string filepath)
        {
            bool retval;

            try
            {
                File = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                
                if(File.Length < 0x180)
                {
                    throw new Exception("ROM is too small.");
                }

                Header = new byte[0x180];
                File.Read(Header, 0, 0x180);
                StringBuilder name = new StringBuilder();

                for(int i = 0; i < 16; i++)
                {
                    if(Header[i + RomOffsetName] == 0x80 || Header[i + RomOffsetName] == 0xC0)
                    {
                        name.Append('\0');
                    }
                    else
                    {
                        name.Append((char)Header[i + RomOffsetName]);
                    }
                }

                // Get name of ROM
                InternalName = name.ToString().Replace("\0", "");
                Log.AppendText($"Internal ROM name: {InternalName}\n");

                // Check for Gameboy Color
                if(Header[RomOffsetGameboyColor] == 0x80) {
                    throw new Exception("Gameboy Color ROMs are not supported.\n");
                }

                // Check for Super Gameboy
                if(Header[RomOffsetSuperGameboy] == 0x03)
                {
                    throw new Exception("Super Gameboy ROMs are not supported.\n");
                }

                // Get type of ROM
                InternalROMType = ROMInfo.GetType(Header[RomOffsetType]);

                if(InternalROMType.Text == "")
                {
                    throw new Exception($"Unknown ROM type: {InternalROMType.Text}.\n");
                }

                Log.AppendText($"ROM type: {InternalROMType.Text}\n");

                if(InternalROMType.Code != ROMInfo.GetType(0x00).Code)
                {
                    throw new Exception("Only 32KB games with no mappers are supported.\n");
                }

                // Get ROM size
                InternalROMSize = ROMInfo.GetSize(Header[RomOffsetRomSize]);
                Log.AppendText($"ROM size: {InternalROMSize.Size}KB\n");

                if(InternalROMSize.Size != 32)
                {
                    throw new Exception("Only 32KB games with no mappers are supported.\n");
                }

                if(File.Length != (InternalROMSize.Size * 1024))
                {
                    throw new Exception("ROM filesize does not equal ROM size.\n");
                }

                // Get ROM's RAM size
                InternalRAMSize = RAMInfo.GetSize(Header[RomOffsetRamSize]);
                Log.AppendText($"RAM size: {InternalRAMSize.Size}\n");

                // Load ROM into Gameboy memory
                File.Read(Memory.Cartridge, 0, InternalROMSize.Size * 1024);

                retval = true;
            }
            catch(Exception ex)
            {
                Log.AppendText($"{ex.Message}\n");
                retval = false;
            }
            finally
            {
                File.Dispose();
            }

            return retval;
        }
    }
}
