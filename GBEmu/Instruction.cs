using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBEmu
{
    class Instruction8bit
    {
        public byte code { get; set; }
        public string optxt { get; set; }
        public int size { get; set; }
        public int cycles { get; set; }

        public Instruction8bit(byte code, string optxt, int size, int cycles)
        {
            this.code = code;
            this.optxt = optxt;
            this.size = size;
            this.cycles = cycles;
        }

        public byte GetCode()
        {
            return code;
        }

        public string GetOperation()
        {
            return optxt;
        }

        public int GetByteSize()
        {
            return size;
        }

        public int GetCycles()
        {
            return cycles;
        }

        public void Exec(byte x, byte y)
        {
            
            if(x > 0)
            {
                
            }

            if(y > 0)
            {
                
            }
        }
    }

    class Instruction16bit
    {
        public ushort code { get; set; }
        public string optxt { get; set; }
        public int size { get; set; }
        public int cycles { get; set; }

        public Instruction16bit(ushort code, string optxt, int size, int cycles)
        {
            this.code = code;
            this.optxt = optxt;
            this.size = size;
            this.cycles = cycles;
        }

        public ushort GetCode()
        {
            return code;
        }

        public string GetOperation()
        {
            return optxt;
        }

        public int GetByteSize()
        {
            return size;
        }

        public int GetCycles()
        {
            return cycles;
        }

        public void Exec(byte x, byte y)
        {

            if(x > 0)
            {

            }

            if(y > 0)
            {

            }
        }
    }
}
