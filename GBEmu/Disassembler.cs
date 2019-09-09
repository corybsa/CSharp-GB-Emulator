using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBEmu
{
    class Disassembler
    {
        public byte[] file { get; set; }
        public int pc { get; set; }
        public StringBuilder sb = new StringBuilder();

        public void Disassemble()
        {
            try
            {
                Instruction8bit instruction8bit;
                Instruction16bit instruction16bit;
                byte code8bit;
                ushort code16bit;

                while(pc < file.Length)
                {
                    if(pc < 0) break;

                    if(file[pc] != 0xCB)
                    {
                        code8bit = file[pc];
                        instruction8bit = Get8bitInstruction(code8bit);
                        pc += instruction8bit.size;
                        sb.AppendLine($"{BitConverter.ToString(new[] { code8bit })}\t\t{instruction8bit.optxt}");
                    }
                    else
                    {
                        code16bit = (ushort)((file[pc] << 8) + file[pc + 1]);
                        instruction16bit = Instructions.GB16bitInstructions[code16bit];
                        pc += instruction16bit.size;
                        sb.AppendLine($"{BitConverter.ToString(new[] { file[pc] })} {BitConverter.ToString(new[] { file[pc + 1] })}\t\t{instruction16bit.optxt}");
                    }
                }
            }
            catch(Exception ex)
            {
                pc = int.MaxValue;
            }
        }

        private Instruction8bit Get8bitInstruction(byte code)
        {
            int size = Instructions.GB8bitInstructions[code].size;
            byte op1;
            byte op2;

            switch(size)
            {
                case 2:
                    if(code == 0xE2 || code == 0xF2 || code == 0x10)
                    {
                        op1 = 0x00;
                        op2 = 0x00;
                    }
                    else
                    {
                        op1 = file[pc + 1];
                        op2 = 0x00;
                    }
                    break;
                case 3:
                    // The Gameboy CPU is little endian, which means the least significant byte comes first
                    op1 = file[pc + 2];
                    op2 = file[pc + 1];
                    break;
                default:
                    op1 = 0x00;
                    op2 = 0x00;
                    break;
            }

            Instruction8bit instruction = Instructions.Get8bitInstruction(code, op1, op2);

            return instruction;
        }
    }
}
