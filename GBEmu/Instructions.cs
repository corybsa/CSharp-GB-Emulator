using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBEmu
{
    static class Instructions
    {
        static public Dictionary<byte, Instruction8bit> GB8bitInstructions = new Dictionary<byte, Instruction8bit>();
        static public Dictionary<ushort, Instruction16bit> GB16bitInstructions = new Dictionary<ushort, Instruction16bit>();

        static Instructions()
        {
            /***************************************************************************
                                        8 Bit Instructions
            ***************************************************************************/

            GB8bitInstructions.Add(0x00, new Instruction8bit(0x00, "NOP", 1, 4));
            GB8bitInstructions.Add(0x01, new Instruction8bit(0x01, "LD BC,**", 3, 12));
            GB8bitInstructions.Add(0x02, new Instruction8bit(0x02, "LD (BC),A", 1, 8));
            GB8bitInstructions.Add(0x03, new Instruction8bit(0x03, "INC BC", 1, 8));
            GB8bitInstructions.Add(0x04, new Instruction8bit(0x04, "INC C", 1, 4));
            GB8bitInstructions.Add(0x05, new Instruction8bit(0x05, "DEC B", 1, 4));
            GB8bitInstructions.Add(0x06, new Instruction8bit(0x06, "LD B,*", 2, 8));
            GB8bitInstructions.Add(0x07, new Instruction8bit(0x07, "RLCA", 1, 4));
            GB8bitInstructions.Add(0x08, new Instruction8bit(0x08, "LD (**),SP", 3, 20));
            GB8bitInstructions.Add(0x09, new Instruction8bit(0x09, "ADD HL,BC", 1, 8));
            GB8bitInstructions.Add(0x0A, new Instruction8bit(0x0A, "LD A,(BC)", 1, 8));
            GB8bitInstructions.Add(0x0B, new Instruction8bit(0x0B, "DEC BC", 1, 8));
            GB8bitInstructions.Add(0x0C, new Instruction8bit(0x0C, "INC C", 1, 4));
            GB8bitInstructions.Add(0x0D, new Instruction8bit(0x0D, "DEC C", 1, 4));
            GB8bitInstructions.Add(0x0E, new Instruction8bit(0x0E, "LD C,*", 2, 8));
            GB8bitInstructions.Add(0x0F, new Instruction8bit(0x0F, "RRCA", 1, 4));

            GB8bitInstructions.Add(0x10, new Instruction8bit(0x10, "STOP 0", 2, 4));
            GB8bitInstructions.Add(0x11, new Instruction8bit(0x11, "LD DE,**", 3, 12));
            GB8bitInstructions.Add(0x12, new Instruction8bit(0x12, "LD (DE),A", 1, 8));
            GB8bitInstructions.Add(0x13, new Instruction8bit(0x13, "INC DE", 1, 8));
            GB8bitInstructions.Add(0x14, new Instruction8bit(0x14, "INC D", 1, 4));
            GB8bitInstructions.Add(0x15, new Instruction8bit(0x15, "DEC D", 1, 4));
            GB8bitInstructions.Add(0x16, new Instruction8bit(0x16, "LD D,*", 2, 8));
            GB8bitInstructions.Add(0x17, new Instruction8bit(0x17, "RLA", 1, 4));
            GB8bitInstructions.Add(0x18, new Instruction8bit(0x18, "JR *", 2, 12));
            GB8bitInstructions.Add(0x19, new Instruction8bit(0x19, "ADD HL,DE", 1, 8));
            GB8bitInstructions.Add(0x1A, new Instruction8bit(0x1A, "LD A,(DE)", 1, 8));
            GB8bitInstructions.Add(0x1B, new Instruction8bit(0x1B, "DEC DE", 1, 4));
            GB8bitInstructions.Add(0x1C, new Instruction8bit(0x1C, "INC E", 1, 4));
            GB8bitInstructions.Add(0x1D, new Instruction8bit(0x1D, "DEC E", 1, 4));
            GB8bitInstructions.Add(0x1E, new Instruction8bit(0x1E, "LD E,*", 2, 8));
            GB8bitInstructions.Add(0x1F, new Instruction8bit(0x1F, "RRA", 1, 4));

            GB8bitInstructions.Add(0x20, new Instruction8bit(0x20, "JR NZ,*", 2, 1));
            GB8bitInstructions.Add(0x21, new Instruction8bit(0x21, "LD HL,**", 3, 1));
            GB8bitInstructions.Add(0x22, new Instruction8bit(0x22, "LD (HL+),A", 1, 1));
            GB8bitInstructions.Add(0x23, new Instruction8bit(0x23, "INC HL", 1, 1));
            GB8bitInstructions.Add(0x24, new Instruction8bit(0x24, "INC H", 1, 1));
            GB8bitInstructions.Add(0x25, new Instruction8bit(0x25, "DEC H", 1, 1));
            GB8bitInstructions.Add(0x26, new Instruction8bit(0x26, "LD H,*", 2, 1));
            GB8bitInstructions.Add(0x27, new Instruction8bit(0x27, "DAA", 1, 1));
            GB8bitInstructions.Add(0x28, new Instruction8bit(0x28, "JR Z,*", 2, 1));
            GB8bitInstructions.Add(0x29, new Instruction8bit(0x29, "ADD HL,HL", 1, 1));
            GB8bitInstructions.Add(0x2A, new Instruction8bit(0x2A, "LD A,(HL+)", 1, 1));
            GB8bitInstructions.Add(0x2B, new Instruction8bit(0x2B, "DEC HL", 1, 1));
            GB8bitInstructions.Add(0x2C, new Instruction8bit(0x2C, "INC L", 1, 1));
            GB8bitInstructions.Add(0x2D, new Instruction8bit(0x2D, "DEC L", 1, 1));
            GB8bitInstructions.Add(0x2E, new Instruction8bit(0x2E, "LD L,*", 2, 1));
            GB8bitInstructions.Add(0x2F, new Instruction8bit(0x2F, "CPL", 1, 1));

            GB8bitInstructions.Add(0x30, new Instruction8bit(0x30, "JR NC,*", 2, 1));
            GB8bitInstructions.Add(0x31, new Instruction8bit(0x31, "LD SP,**", 3, 1));
            GB8bitInstructions.Add(0x32, new Instruction8bit(0x32, "LD (HL-),A", 1, 1));
            GB8bitInstructions.Add(0x33, new Instruction8bit(0x33, "INC SP", 1, 1));
            GB8bitInstructions.Add(0x34, new Instruction8bit(0x34, "INC (HL)", 1, 1));
            GB8bitInstructions.Add(0x35, new Instruction8bit(0x35, "DEC (HL)", 1, 1));
            GB8bitInstructions.Add(0x36, new Instruction8bit(0x36, "LD (HL),*", 2, 1));
            GB8bitInstructions.Add(0x37, new Instruction8bit(0x37, "SCF", 1, 1));
            GB8bitInstructions.Add(0x38, new Instruction8bit(0x38, "JR C,*", 2, 1));
            GB8bitInstructions.Add(0x39, new Instruction8bit(0x39, "ADD HL,SP", 1, 1));
            GB8bitInstructions.Add(0x3A, new Instruction8bit(0x3A, "LD A,(HL-)", 1, 1));
            GB8bitInstructions.Add(0x3B, new Instruction8bit(0x3B, "DEC SP", 1, 1));
            GB8bitInstructions.Add(0x3C, new Instruction8bit(0x3C, "INC A", 1, 1));
            GB8bitInstructions.Add(0x3D, new Instruction8bit(0x3D, "DEC A", 1, 1));
            GB8bitInstructions.Add(0x3E, new Instruction8bit(0x3E, "LD A,*", 2, 1));
            GB8bitInstructions.Add(0x3F, new Instruction8bit(0x3F, "CCF", 1, 1));

            GB8bitInstructions.Add(0x40, new Instruction8bit(0x40, "LD B,B", 1, 1));
            GB8bitInstructions.Add(0x41, new Instruction8bit(0x41, "LD B,C", 1, 1));
            GB8bitInstructions.Add(0x42, new Instruction8bit(0x42, "LD B,D", 1, 1));
            GB8bitInstructions.Add(0x43, new Instruction8bit(0x43, "LD B,E", 1, 1));
            GB8bitInstructions.Add(0x44, new Instruction8bit(0x44, "LD B,H", 1, 1));
            GB8bitInstructions.Add(0x45, new Instruction8bit(0x45, "LD B,L", 1, 1));
            GB8bitInstructions.Add(0x46, new Instruction8bit(0x46, "LD B,(HL)", 1, 1));
            GB8bitInstructions.Add(0x47, new Instruction8bit(0x47, "LD B,A", 1, 1));
            GB8bitInstructions.Add(0x48, new Instruction8bit(0x48, "LD C,B", 1, 1));
            GB8bitInstructions.Add(0x49, new Instruction8bit(0x49, "LD C,C", 1, 1));
            GB8bitInstructions.Add(0x4A, new Instruction8bit(0x4A, "LD C,D", 1, 1));
            GB8bitInstructions.Add(0x4B, new Instruction8bit(0x4B, "LD C,E", 1, 1));
            GB8bitInstructions.Add(0x4C, new Instruction8bit(0x4C, "LD C,H", 1, 1));
            GB8bitInstructions.Add(0x4D, new Instruction8bit(0x4D, "LD C,L", 1, 1));
            GB8bitInstructions.Add(0x4E, new Instruction8bit(0x4E, "LD C,(HL)", 1, 1));
            GB8bitInstructions.Add(0x4F, new Instruction8bit(0x4F, "LC C,A", 1, 1));

            GB8bitInstructions.Add(0x50, new Instruction8bit(0x50, "LD D,B", 1, 1));
            GB8bitInstructions.Add(0x51, new Instruction8bit(0x51, "LD D,C", 1, 1));
            GB8bitInstructions.Add(0x52, new Instruction8bit(0x52, "LD D,D", 1, 1));
            GB8bitInstructions.Add(0x53, new Instruction8bit(0x53, "LD D,E", 1, 1));
            GB8bitInstructions.Add(0x54, new Instruction8bit(0x54, "LD D,H", 1, 1));
            GB8bitInstructions.Add(0x55, new Instruction8bit(0x55, "LD D,L", 1, 1));
            GB8bitInstructions.Add(0x56, new Instruction8bit(0x56, "LD D,(HL)", 1, 1));
            GB8bitInstructions.Add(0x57, new Instruction8bit(0x57, "LD D,A", 1, 1));
            GB8bitInstructions.Add(0x58, new Instruction8bit(0x58, "LD E,B", 1, 1));
            GB8bitInstructions.Add(0x59, new Instruction8bit(0x59, "LD E,C", 1, 1));
            GB8bitInstructions.Add(0x5A, new Instruction8bit(0x5A, "LD E,D", 1, 1));
            GB8bitInstructions.Add(0x5B, new Instruction8bit(0x5B, "LD E,E", 1, 1));
            GB8bitInstructions.Add(0x5C, new Instruction8bit(0x5C, "LD E,H", 1, 1));
            GB8bitInstructions.Add(0x5D, new Instruction8bit(0x5D, "LD E,L", 1, 1));
            GB8bitInstructions.Add(0x5E, new Instruction8bit(0x5E, "LD E,(HL)", 1, 1));
            GB8bitInstructions.Add(0x5F, new Instruction8bit(0x5F, "LD E,A", 1, 1));

            GB8bitInstructions.Add(0x60, new Instruction8bit(0x60, "LD H,B", 1, 1));
            GB8bitInstructions.Add(0x61, new Instruction8bit(0x61, "LD H,C", 1, 1));
            GB8bitInstructions.Add(0x62, new Instruction8bit(0x62, "LD H,D", 1, 1));
            GB8bitInstructions.Add(0x63, new Instruction8bit(0x63, "LD H,E", 1, 1));
            GB8bitInstructions.Add(0x64, new Instruction8bit(0x64, "LD H,H", 1, 1));
            GB8bitInstructions.Add(0x65, new Instruction8bit(0x65, "LD H,L", 1, 1));
            GB8bitInstructions.Add(0x66, new Instruction8bit(0x66, "LD H,(HL)", 1, 1));
            GB8bitInstructions.Add(0x67, new Instruction8bit(0x67, "LD H,A", 1, 1));
            GB8bitInstructions.Add(0x68, new Instruction8bit(0x68, "LD L,B", 1, 1));
            GB8bitInstructions.Add(0x69, new Instruction8bit(0x69, "LD L,C", 1, 1));
            GB8bitInstructions.Add(0x6A, new Instruction8bit(0x6A, "LD L,D", 1, 1));
            GB8bitInstructions.Add(0x6B, new Instruction8bit(0x6B, "LD L,E", 1, 1));
            GB8bitInstructions.Add(0x6C, new Instruction8bit(0x6C, "LD L,H", 1, 1));
            GB8bitInstructions.Add(0x6D, new Instruction8bit(0x6D, "LD L,L", 1, 1));
            GB8bitInstructions.Add(0x6E, new Instruction8bit(0x6E, "LD L,(HL)", 1, 1));
            GB8bitInstructions.Add(0x6F, new Instruction8bit(0x6F, "LD L,A", 1, 1));

            GB8bitInstructions.Add(0x70, new Instruction8bit(0x70, "LD (HL),B", 1, 1));
            GB8bitInstructions.Add(0x71, new Instruction8bit(0x71, "LD (HL),C", 1, 1));
            GB8bitInstructions.Add(0x72, new Instruction8bit(0x72, "LD (HL),D", 1, 1));
            GB8bitInstructions.Add(0x73, new Instruction8bit(0x73, "LD (HL),E", 1, 1));
            GB8bitInstructions.Add(0x74, new Instruction8bit(0x74, "LD (HL),H", 1, 1));
            GB8bitInstructions.Add(0x75, new Instruction8bit(0x75, "LD (HL),L", 1, 1));
            GB8bitInstructions.Add(0x76, new Instruction8bit(0x76, "LD (HL),(HL)", 1, 1));
            GB8bitInstructions.Add(0x77, new Instruction8bit(0x77, "LD (HL),A", 1, 1));
            GB8bitInstructions.Add(0x78, new Instruction8bit(0x78, "LD A,B", 1, 1));
            GB8bitInstructions.Add(0x79, new Instruction8bit(0x79, "LD A,C", 1, 1));
            GB8bitInstructions.Add(0x7A, new Instruction8bit(0x7A, "LD A,C", 1, 1));
            GB8bitInstructions.Add(0x7B, new Instruction8bit(0x7B, "LD A,E", 1, 1));
            GB8bitInstructions.Add(0x7C, new Instruction8bit(0x7C, "LD A,H", 1, 1));
            GB8bitInstructions.Add(0x7D, new Instruction8bit(0x7D, "LD A,L", 1, 1));
            GB8bitInstructions.Add(0x7E, new Instruction8bit(0x7E, "LD A,(HL)", 1, 1));
            GB8bitInstructions.Add(0x7F, new Instruction8bit(0x7F, "LD A,A", 1, 1));

            GB8bitInstructions.Add(0x80, new Instruction8bit(0x80, "ADD A,B", 1, 1));
            GB8bitInstructions.Add(0x81, new Instruction8bit(0x81, "ADD A,C", 1, 1));
            GB8bitInstructions.Add(0x82, new Instruction8bit(0x82, "ADD A,D", 1, 1));
            GB8bitInstructions.Add(0x83, new Instruction8bit(0x83, "ADD A,E", 1, 1));
            GB8bitInstructions.Add(0x84, new Instruction8bit(0x84, "ADD A,H", 1, 1));
            GB8bitInstructions.Add(0x85, new Instruction8bit(0x85, "ADD A,L", 1, 1));
            GB8bitInstructions.Add(0x86, new Instruction8bit(0x86, "ADD A,(HL)", 1, 1));
            GB8bitInstructions.Add(0x87, new Instruction8bit(0x87, "ADD A,A", 1, 1));
            GB8bitInstructions.Add(0x88, new Instruction8bit(0x88, "ADC A,B", 1, 1));
            GB8bitInstructions.Add(0x89, new Instruction8bit(0x89, "ADC A,C", 1, 1));
            GB8bitInstructions.Add(0x8A, new Instruction8bit(0x8A, "ADC A,D", 1, 1));
            GB8bitInstructions.Add(0x8B, new Instruction8bit(0x8B, "ADC A,E", 1, 1));
            GB8bitInstructions.Add(0x8C, new Instruction8bit(0x8C, "ADC A,H", 1, 1));
            GB8bitInstructions.Add(0x8D, new Instruction8bit(0x8D, "ADC A,L", 1, 1));
            GB8bitInstructions.Add(0x8E, new Instruction8bit(0x8E, "ADC A,(HL)", 1, 1));
            GB8bitInstructions.Add(0x8F, new Instruction8bit(0x8F, "ADC A,A", 1, 1));

            GB8bitInstructions.Add(0x90, new Instruction8bit(0x90, "SUB B", 1, 1));
            GB8bitInstructions.Add(0x91, new Instruction8bit(0x91, "SUB C", 1, 1));
            GB8bitInstructions.Add(0x92, new Instruction8bit(0x92, "SUB D", 1, 1));
            GB8bitInstructions.Add(0x93, new Instruction8bit(0x93, "SUB E", 1, 1));
            GB8bitInstructions.Add(0x94, new Instruction8bit(0x94, "SUB H", 1, 1));
            GB8bitInstructions.Add(0x95, new Instruction8bit(0x95, "SUB L", 1, 1));
            GB8bitInstructions.Add(0x96, new Instruction8bit(0x96, "SUB (HL)", 1, 1));
            GB8bitInstructions.Add(0x97, new Instruction8bit(0x97, "SUB A", 1, 1));
            GB8bitInstructions.Add(0x98, new Instruction8bit(0x98, "SBC A,B", 1, 1));
            GB8bitInstructions.Add(0x99, new Instruction8bit(0x99, "SBC A,C", 1, 1));
            GB8bitInstructions.Add(0x9A, new Instruction8bit(0x9A, "SBC A,D", 1, 1));
            GB8bitInstructions.Add(0x9B, new Instruction8bit(0x9B, "SBC A,E", 1, 1));
            GB8bitInstructions.Add(0x9C, new Instruction8bit(0x9C, "SBC A,H", 1, 1));
            GB8bitInstructions.Add(0x9D, new Instruction8bit(0x9D, "SBC A,L", 1, 1));
            GB8bitInstructions.Add(0x9E, new Instruction8bit(0x9E, "SBC A,(HL)", 1, 1));
            GB8bitInstructions.Add(0x9F, new Instruction8bit(0x9F, "SBC A,A", 1, 1));

            GB8bitInstructions.Add(0xA0, new Instruction8bit(0xA0, "AND B", 1, 1));
            GB8bitInstructions.Add(0xA1, new Instruction8bit(0xA1, "AND C", 1, 1));
            GB8bitInstructions.Add(0xA2, new Instruction8bit(0xA2, "AND D", 1, 1));
            GB8bitInstructions.Add(0xA3, new Instruction8bit(0xA3, "AND E", 1, 1));
            GB8bitInstructions.Add(0xA4, new Instruction8bit(0xA4, "AND H", 1, 1));
            GB8bitInstructions.Add(0xA5, new Instruction8bit(0xA5, "AND L", 1, 1));
            GB8bitInstructions.Add(0xA6, new Instruction8bit(0xA6, "AND (HL)", 1, 1));
            GB8bitInstructions.Add(0xA7, new Instruction8bit(0xA7, "AND A", 1, 1));
            GB8bitInstructions.Add(0xA8, new Instruction8bit(0xA8, "XOR B", 1, 1));
            GB8bitInstructions.Add(0xA9, new Instruction8bit(0xA9, "XOR C", 1, 1));
            GB8bitInstructions.Add(0xAA, new Instruction8bit(0xAA, "XOR D", 1, 1));
            GB8bitInstructions.Add(0xAB, new Instruction8bit(0xAB, "XOR E", 1, 1));
            GB8bitInstructions.Add(0xAC, new Instruction8bit(0xAC, "XOR H", 1, 1));
            GB8bitInstructions.Add(0xAD, new Instruction8bit(0xAD, "XOR L", 1, 1));
            GB8bitInstructions.Add(0xAE, new Instruction8bit(0xAE, "XOR (HL)", 1, 1));
            GB8bitInstructions.Add(0xAF, new Instruction8bit(0xAF, "XOR A", 1, 1));

            GB8bitInstructions.Add(0xB0, new Instruction8bit(0xB0, "OR B", 1, 1));
            GB8bitInstructions.Add(0xB1, new Instruction8bit(0xB1, "OR C", 1, 1));
            GB8bitInstructions.Add(0xB2, new Instruction8bit(0xB2, "OR D", 1, 1));
            GB8bitInstructions.Add(0xB3, new Instruction8bit(0xB3, "OR E", 1, 1));
            GB8bitInstructions.Add(0xB4, new Instruction8bit(0xB4, "OR H", 1, 1));
            GB8bitInstructions.Add(0xB5, new Instruction8bit(0xB5, "OR L", 1, 1));
            GB8bitInstructions.Add(0xB6, new Instruction8bit(0xB6, "OR (HL)", 1, 1));
            GB8bitInstructions.Add(0xB7, new Instruction8bit(0xB7, "OR A", 1, 1));
            GB8bitInstructions.Add(0xB8, new Instruction8bit(0xB8, "CP B", 1, 1));
            GB8bitInstructions.Add(0xB9, new Instruction8bit(0xB9, "CP C", 1, 1));
            GB8bitInstructions.Add(0xBA, new Instruction8bit(0xBA, "CP D", 1, 1));
            GB8bitInstructions.Add(0xBB, new Instruction8bit(0xBB, "CP E", 1, 1));
            GB8bitInstructions.Add(0xBC, new Instruction8bit(0xBC, "CP H", 1, 1));
            GB8bitInstructions.Add(0xBD, new Instruction8bit(0xBD, "CP L", 1, 1));
            GB8bitInstructions.Add(0xBE, new Instruction8bit(0xBE, "CP (HL)", 1, 1));
            GB8bitInstructions.Add(0xBF, new Instruction8bit(0xBF, "CP A", 1, 1));

            GB8bitInstructions.Add(0xC0, new Instruction8bit(0xC0, "RET NZ", 1, 1));
            GB8bitInstructions.Add(0xC1, new Instruction8bit(0xC1, "POP BC", 1, 1));
            GB8bitInstructions.Add(0xC2, new Instruction8bit(0xC2, "JP NZ,**", 3, 1));
            GB8bitInstructions.Add(0xC3, new Instruction8bit(0xC3, "JP **", 3, 1));
            GB8bitInstructions.Add(0xC4, new Instruction8bit(0xC4, "CALL NZ,**", 3, 1));
            GB8bitInstructions.Add(0xC5, new Instruction8bit(0xC5, "PUSH BC", 1, 1));
            GB8bitInstructions.Add(0xC6, new Instruction8bit(0xC6, "ADD A,*", 2, 1));
            GB8bitInstructions.Add(0xC7, new Instruction8bit(0xC7, "RST 00H", 1, 1));
            GB8bitInstructions.Add(0xC8, new Instruction8bit(0xC8, "RET Z", 1, 1));
            GB8bitInstructions.Add(0xC9, new Instruction8bit(0xC9, "RET", 1, 1));
            GB8bitInstructions.Add(0xCA, new Instruction8bit(0xCA, "JP Z,**", 3, 1));
            GB8bitInstructions.Add(0xCC, new Instruction8bit(0xCC, "CALL Z,**", 3, 1));
            GB8bitInstructions.Add(0xCD, new Instruction8bit(0xCD, "CALL **", 3, 1));
            GB8bitInstructions.Add(0xCE, new Instruction8bit(0xCE, "ADC A,*", 2, 1));
            GB8bitInstructions.Add(0xCF, new Instruction8bit(0xCF, "RST 08H", 1, 1));

            GB8bitInstructions.Add(0xD0, new Instruction8bit(0xD0, "RET NC", 1, 1));
            GB8bitInstructions.Add(0xD1, new Instruction8bit(0xD1, "POP DE", 1, 1));
            GB8bitInstructions.Add(0xD2, new Instruction8bit(0xD2, "JP NC,**", 3, 1));
            GB8bitInstructions.Add(0xD3, new Instruction8bit(0xD3, "NOP", 1, 4));
            GB8bitInstructions.Add(0xD4, new Instruction8bit(0xD4, "CALL NC,**", 3, 1));
            GB8bitInstructions.Add(0xD5, new Instruction8bit(0xD5, "PUSH DE", 1, 1));
            GB8bitInstructions.Add(0xD6, new Instruction8bit(0xD6, "SUB *", 2, 1));
            GB8bitInstructions.Add(0xD7, new Instruction8bit(0xD7, "RST 10H", 1, 1));
            GB8bitInstructions.Add(0xD8, new Instruction8bit(0xD8, "RET C", 1, 1));
            GB8bitInstructions.Add(0xD9, new Instruction8bit(0xD9, "RETI", 1, 1));
            GB8bitInstructions.Add(0xDA, new Instruction8bit(0xDA, "JP C,**", 3, 1));
            GB8bitInstructions.Add(0xDB, new Instruction8bit(0xDB, "NOP", 1, 4));
            GB8bitInstructions.Add(0xDC, new Instruction8bit(0xDC, "CALL C,**", 3, 1));
            GB8bitInstructions.Add(0xDD, new Instruction8bit(0xDD, "NOP", 1, 4));
            GB8bitInstructions.Add(0xDE, new Instruction8bit(0xDE, "SBC A,*", 2, 1));
            GB8bitInstructions.Add(0xDF, new Instruction8bit(0xDF, "RST 18H", 1, 1));

            GB8bitInstructions.Add(0xE0, new Instruction8bit(0xE0, "LDH (*),A", 2, 1));
            GB8bitInstructions.Add(0xE1, new Instruction8bit(0xE1, "POP HL", 1, 1));
            GB8bitInstructions.Add(0xE2, new Instruction8bit(0xE2, "LD (C),A", 2, 1)); // why is this 2 bytes??
            GB8bitInstructions.Add(0xE3, new Instruction8bit(0xE3, "NOP", 1, 4));
            GB8bitInstructions.Add(0xE4, new Instruction8bit(0xE4, "NOP", 1, 4));
            GB8bitInstructions.Add(0xE5, new Instruction8bit(0xE5, "PUSH HL", 1, 1));
            GB8bitInstructions.Add(0xE6, new Instruction8bit(0xE6, "AND *", 2, 1));
            GB8bitInstructions.Add(0xE7, new Instruction8bit(0xE7, "RST 20H", 1, 1));
            GB8bitInstructions.Add(0xE8, new Instruction8bit(0xE8, "ADD SP,*", 2, 1));
            GB8bitInstructions.Add(0xE9, new Instruction8bit(0xE9, "JP (HL)", 1, 1));
            GB8bitInstructions.Add(0xEA, new Instruction8bit(0xEA, "LD (**),A", 3, 1));
            GB8bitInstructions.Add(0xEB, new Instruction8bit(0xEB, "NOP", 1, 4));
            GB8bitInstructions.Add(0xEC, new Instruction8bit(0xEC, "NOP", 1, 4));
            GB8bitInstructions.Add(0xED, new Instruction8bit(0xED, "NOP", 1, 4));
            GB8bitInstructions.Add(0xEE, new Instruction8bit(0xEE, "XOR *", 2, 1));
            GB8bitInstructions.Add(0xEF, new Instruction8bit(0xEF, "RST 28H", 1, 1));

            GB8bitInstructions.Add(0xF0, new Instruction8bit(0xF0, "LDH A,(*)", 2, 1));
            GB8bitInstructions.Add(0xF1, new Instruction8bit(0xF1, "POP AF", 1, 1));
            GB8bitInstructions.Add(0xF2, new Instruction8bit(0xF2, "LD A,(C)", 2, 1)); // why is this 2 bytes??
            GB8bitInstructions.Add(0xF3, new Instruction8bit(0xF3, "DI", 1, 1));
            GB8bitInstructions.Add(0xF4, new Instruction8bit(0xF4, "NOP", 1, 4));
            GB8bitInstructions.Add(0xF5, new Instruction8bit(0xF5, "PUSH AF", 1, 1));
            GB8bitInstructions.Add(0xF6, new Instruction8bit(0xF6, "OR *", 2, 1));
            GB8bitInstructions.Add(0xF7, new Instruction8bit(0xF7, "RST 30H", 1, 1));
            GB8bitInstructions.Add(0xF8, new Instruction8bit(0xF8, "LD HL,SP+*", 2, 1));
            GB8bitInstructions.Add(0xF9, new Instruction8bit(0xF9, "LD SP,HL", 1, 1));
            GB8bitInstructions.Add(0xFA, new Instruction8bit(0xFA, "LD A,(**)", 3, 1));
            GB8bitInstructions.Add(0xFB, new Instruction8bit(0xFB, "EI", 1, 1));
            GB8bitInstructions.Add(0xFC, new Instruction8bit(0xFC, "NOP", 1, 4));
            GB8bitInstructions.Add(0xFD, new Instruction8bit(0xFD, "NOP", 1, 4));
            GB8bitInstructions.Add(0xFE, new Instruction8bit(0xFE, "CP *", 2, 1));
            GB8bitInstructions.Add(0xFF, new Instruction8bit(0xFF, "RST 38H", 1, 1));

            /***************************************************************************
                                    16 Bit Instructions
            ***************************************************************************/

            GB16bitInstructions.Add(0xCB00, new Instruction16bit(0xCB00, "RLC B", 2, 1));
            GB16bitInstructions.Add(0xCB01, new Instruction16bit(0xCB01, "RLC C", 2, 1));
            GB16bitInstructions.Add(0xCB02, new Instruction16bit(0xCB02, "RLC D", 2, 1));
            GB16bitInstructions.Add(0xCB03, new Instruction16bit(0xCB03, "RLC E", 2, 1));
            GB16bitInstructions.Add(0xCB04, new Instruction16bit(0xCB04, "RLC H", 2, 1));
            GB16bitInstructions.Add(0xCB05, new Instruction16bit(0xCB05, "RLC L", 2, 1));
            GB16bitInstructions.Add(0xCB06, new Instruction16bit(0xCB06, "RLC (HL)", 2, 1));
            GB16bitInstructions.Add(0xCB07, new Instruction16bit(0xCB07, "RLC A", 2, 1));
            GB16bitInstructions.Add(0xCB08, new Instruction16bit(0xCB08, "RRC B", 2, 1));
            GB16bitInstructions.Add(0xCB09, new Instruction16bit(0xCB09, "RRC C", 2, 1));
            GB16bitInstructions.Add(0xCB0A, new Instruction16bit(0xCB0A, "RRC D", 2, 1));
            GB16bitInstructions.Add(0xCB0B, new Instruction16bit(0xCB0B, "RRC E", 2, 1));
            GB16bitInstructions.Add(0xCB0C, new Instruction16bit(0xCB0C, "RRC H", 2, 1));
            GB16bitInstructions.Add(0xCB0D, new Instruction16bit(0xCB0D, "RRC L", 2, 1));
            GB16bitInstructions.Add(0xCB0E, new Instruction16bit(0xCB0E, "RRC (HL)", 2, 1));
            GB16bitInstructions.Add(0xCB0F, new Instruction16bit(0xCB0F, "RRC A", 2, 1));

            GB16bitInstructions.Add(0xCB10, new Instruction16bit(0xCB10, "RL B", 2, 1));
            GB16bitInstructions.Add(0xCB11, new Instruction16bit(0xCB11, "RL C", 2, 1));
            GB16bitInstructions.Add(0xCB12, new Instruction16bit(0xCB12, "RL D", 2, 1));
            GB16bitInstructions.Add(0xCB13, new Instruction16bit(0xCB13, "RL E", 2, 1));
            GB16bitInstructions.Add(0xCB14, new Instruction16bit(0xCB14, "RL H", 2, 1));
            GB16bitInstructions.Add(0xCB15, new Instruction16bit(0xCB15, "RL L", 2, 1));
            GB16bitInstructions.Add(0xCB16, new Instruction16bit(0xCB16, "RL (HL)", 2, 1));
            GB16bitInstructions.Add(0xCB17, new Instruction16bit(0xCB17, "RL A", 2, 1));
            GB16bitInstructions.Add(0xCB18, new Instruction16bit(0xCB18, "RR B", 2, 1));
            GB16bitInstructions.Add(0xCB19, new Instruction16bit(0xCB19, "RR C", 2, 1));
            GB16bitInstructions.Add(0xCB1A, new Instruction16bit(0xCB1A, "RR D", 2, 1));
            GB16bitInstructions.Add(0xCB1B, new Instruction16bit(0xCB1B, "RR E", 2, 1));
            GB16bitInstructions.Add(0xCB1C, new Instruction16bit(0xCB1C, "RR H", 2, 1));
            GB16bitInstructions.Add(0xCB1D, new Instruction16bit(0xCB1D, "RR L", 2, 1));
            GB16bitInstructions.Add(0xCB1E, new Instruction16bit(0xCB1E, "RR (HL)", 2, 1));
            GB16bitInstructions.Add(0xCB1F, new Instruction16bit(0xCB1F, "RR A", 2, 1));

            GB16bitInstructions.Add(0xCB20, new Instruction16bit(0xCB20, "SLA B", 2, 1));
            GB16bitInstructions.Add(0xCB21, new Instruction16bit(0xCB21, "SLA C", 2, 1));
            GB16bitInstructions.Add(0xCB22, new Instruction16bit(0xCB22, "SLA D", 2, 1));
            GB16bitInstructions.Add(0xCB23, new Instruction16bit(0xCB23, "SLA E", 2, 1));
            GB16bitInstructions.Add(0xCB24, new Instruction16bit(0xCB24, "SLA H", 2, 1));
            GB16bitInstructions.Add(0xCB25, new Instruction16bit(0xCB25, "SLA L", 2, 1));
            GB16bitInstructions.Add(0xCB26, new Instruction16bit(0xCB26, "SLA (HL)", 2, 1));
            GB16bitInstructions.Add(0xCB27, new Instruction16bit(0xCB27, "SLA A", 2, 1));
            GB16bitInstructions.Add(0xCB28, new Instruction16bit(0xCB28, "SRA B", 2, 1));
            GB16bitInstructions.Add(0xCB29, new Instruction16bit(0xCB29, "SRA C", 2, 1));
            GB16bitInstructions.Add(0xCB2A, new Instruction16bit(0xCB2A, "SRA D", 2, 1));
            GB16bitInstructions.Add(0xCB2B, new Instruction16bit(0xCB2B, "SRA E", 2, 1));
            GB16bitInstructions.Add(0xCB2C, new Instruction16bit(0xCB2C, "SRA H", 2, 1));
            GB16bitInstructions.Add(0xCB2D, new Instruction16bit(0xCB2D, "SRA L", 2, 1));
            GB16bitInstructions.Add(0xCB2E, new Instruction16bit(0xCB2E, "SRA (HL)", 2, 1));
            GB16bitInstructions.Add(0xCB2F, new Instruction16bit(0xCB2F, "SRA A", 2, 1));

            GB16bitInstructions.Add(0xCB30, new Instruction16bit(0xCB30, "SWAP B", 2, 1));
            GB16bitInstructions.Add(0xCB31, new Instruction16bit(0xCB31, "SWAP C", 2, 1));
            GB16bitInstructions.Add(0xCB32, new Instruction16bit(0xCB32, "SWAP D", 2, 1));
            GB16bitInstructions.Add(0xCB33, new Instruction16bit(0xCB33, "SWAP E", 2, 1));
            GB16bitInstructions.Add(0xCB34, new Instruction16bit(0xCB34, "SWAP H", 2, 1));
            GB16bitInstructions.Add(0xCB35, new Instruction16bit(0xCB35, "SWAP L", 2, 1));
            GB16bitInstructions.Add(0xCB36, new Instruction16bit(0xCB36, "SWAP (HL)", 2, 1));
            GB16bitInstructions.Add(0xCB37, new Instruction16bit(0xCB37, "SWAP A", 2, 1));
            GB16bitInstructions.Add(0xCB38, new Instruction16bit(0xCB38, "SRL B", 2, 1));
            GB16bitInstructions.Add(0xCB39, new Instruction16bit(0xCB39, "SRL C", 2, 1));
            GB16bitInstructions.Add(0xCB3A, new Instruction16bit(0xCB3A, "SRL D", 2, 1));
            GB16bitInstructions.Add(0xCB3B, new Instruction16bit(0xCB3B, "SRL E", 2, 1));
            GB16bitInstructions.Add(0xCB3C, new Instruction16bit(0xCB3C, "SRL H", 2, 1));
            GB16bitInstructions.Add(0xCB3D, new Instruction16bit(0xCB3D, "SRL L", 2, 1));
            GB16bitInstructions.Add(0xCB3E, new Instruction16bit(0xCB3E, "SRL (HL)", 2, 1));
            GB16bitInstructions.Add(0xCB3F, new Instruction16bit(0xCB3F, "SRL A", 2, 1));

            GB16bitInstructions.Add(0xCB40, new Instruction16bit(0xCB40, "BIT 0,B", 2, 1));
            GB16bitInstructions.Add(0xCB41, new Instruction16bit(0xCB41, "BIT 0,C", 2, 1));
            GB16bitInstructions.Add(0xCB42, new Instruction16bit(0xCB42, "BIT 0,D", 2, 1));
            GB16bitInstructions.Add(0xCB43, new Instruction16bit(0xCB43, "BIT 0,E", 2, 1));
            GB16bitInstructions.Add(0xCB44, new Instruction16bit(0xCB44, "BIT 0,H", 2, 1));
            GB16bitInstructions.Add(0xCB45, new Instruction16bit(0xCB45, "BIT 0,L", 2, 1));
            GB16bitInstructions.Add(0xCB46, new Instruction16bit(0xCB46, "BIT 0,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB47, new Instruction16bit(0xCB47, "BIT 0,A", 2, 1));
            GB16bitInstructions.Add(0xCB48, new Instruction16bit(0xCB48, "BIT 1,B", 2, 1));
            GB16bitInstructions.Add(0xCB49, new Instruction16bit(0xCB49, "BIT 1,C", 2, 1));
            GB16bitInstructions.Add(0xCB4A, new Instruction16bit(0xCB4A, "BIT 1,D", 2, 1));
            GB16bitInstructions.Add(0xCB4B, new Instruction16bit(0xCB4B, "BIT 1,E", 2, 1));
            GB16bitInstructions.Add(0xCB4C, new Instruction16bit(0xCB4C, "BIT 1,H", 2, 1));
            GB16bitInstructions.Add(0xCB4D, new Instruction16bit(0xCB4D, "BIT 1,L", 2, 1));
            GB16bitInstructions.Add(0xCB4E, new Instruction16bit(0xCB4E, "BIT 1,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB4F, new Instruction16bit(0xCB4F, "BIT 1,A", 2, 1));

            GB16bitInstructions.Add(0xCB50, new Instruction16bit(0xCB50, "BIT 2,B", 2, 1));
            GB16bitInstructions.Add(0xCB51, new Instruction16bit(0xCB51, "BIT 2,C", 2, 1));
            GB16bitInstructions.Add(0xCB52, new Instruction16bit(0xCB52, "BIT 2,D", 2, 1));
            GB16bitInstructions.Add(0xCB53, new Instruction16bit(0xCB53, "BIT 2,E", 2, 1));
            GB16bitInstructions.Add(0xCB54, new Instruction16bit(0xCB54, "BIT 2,H", 2, 1));
            GB16bitInstructions.Add(0xCB55, new Instruction16bit(0xCB55, "BIT 2,L", 2, 1));
            GB16bitInstructions.Add(0xCB56, new Instruction16bit(0xCB56, "BIT 2,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB57, new Instruction16bit(0xCB57, "BIT 2,A", 2, 1));
            GB16bitInstructions.Add(0xCB58, new Instruction16bit(0xCB58, "BIT 3,B", 2, 1));
            GB16bitInstructions.Add(0xCB59, new Instruction16bit(0xCB59, "BIT 3,C", 2, 1));
            GB16bitInstructions.Add(0xCB5A, new Instruction16bit(0xCB5A, "BIT 3,D", 2, 1));
            GB16bitInstructions.Add(0xCB5B, new Instruction16bit(0xCB5B, "BIT 3,E", 2, 1));
            GB16bitInstructions.Add(0xCB5C, new Instruction16bit(0xCB5C, "BIT 3,H", 2, 1));
            GB16bitInstructions.Add(0xCB5D, new Instruction16bit(0xCB5D, "BIT 3,L", 2, 1));
            GB16bitInstructions.Add(0xCB5E, new Instruction16bit(0xCB5E, "BIT 3,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB5F, new Instruction16bit(0xCB5F, "BIT 3,A", 2, 1));

            GB16bitInstructions.Add(0xCB60, new Instruction16bit(0xCB60, "BIT 4,B", 2, 1));
            GB16bitInstructions.Add(0xCB61, new Instruction16bit(0xCB61, "BIT 4,C", 2, 1));
            GB16bitInstructions.Add(0xCB62, new Instruction16bit(0xCB62, "BIT 4,D", 2, 1));
            GB16bitInstructions.Add(0xCB63, new Instruction16bit(0xCB63, "BIT 4,E", 2, 1));
            GB16bitInstructions.Add(0xCB64, new Instruction16bit(0xCB64, "BIT 4,H", 2, 1));
            GB16bitInstructions.Add(0xCB65, new Instruction16bit(0xCB65, "BIT 4,L", 2, 1));
            GB16bitInstructions.Add(0xCB66, new Instruction16bit(0xCB66, "BIT 4,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB67, new Instruction16bit(0xCB67, "BIT 4,A", 2, 1));
            GB16bitInstructions.Add(0xCB68, new Instruction16bit(0xCB68, "BIT 5,B", 2, 1));
            GB16bitInstructions.Add(0xCB69, new Instruction16bit(0xCB69, "BIT 5,C", 2, 1));
            GB16bitInstructions.Add(0xCB6A, new Instruction16bit(0xCB6A, "BIT 5,D", 2, 1));
            GB16bitInstructions.Add(0xCB6B, new Instruction16bit(0xCB6B, "BIT 5,E", 2, 1));
            GB16bitInstructions.Add(0xCB6C, new Instruction16bit(0xCB6C, "BIT 5,H", 2, 1));
            GB16bitInstructions.Add(0xCB6D, new Instruction16bit(0xCB6D, "BIT 5,L", 2, 1));
            GB16bitInstructions.Add(0xCB6E, new Instruction16bit(0xCB6E, "BIT 5,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB6F, new Instruction16bit(0xCB6F, "BIT 5,A", 2, 1));

            GB16bitInstructions.Add(0xCB70, new Instruction16bit(0xCB70, "BIT 6,B", 2, 1));
            GB16bitInstructions.Add(0xCB71, new Instruction16bit(0xCB71, "BIT 6,C", 2, 1));
            GB16bitInstructions.Add(0xCB72, new Instruction16bit(0xCB72, "BIT 6,D", 2, 1));
            GB16bitInstructions.Add(0xCB73, new Instruction16bit(0xCB73, "BIT 6,E", 2, 1));
            GB16bitInstructions.Add(0xCB74, new Instruction16bit(0xCB74, "BIT 6,H", 2, 1));
            GB16bitInstructions.Add(0xCB75, new Instruction16bit(0xCB75, "BIT 6,L", 2, 1));
            GB16bitInstructions.Add(0xCB76, new Instruction16bit(0xCB76, "BIT 6,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB77, new Instruction16bit(0xCB77, "BIT 6,A", 2, 1));
            GB16bitInstructions.Add(0xCB78, new Instruction16bit(0xCB78, "BIT 7,B", 2, 1));
            GB16bitInstructions.Add(0xCB79, new Instruction16bit(0xCB79, "BIT 7,C", 2, 1));
            GB16bitInstructions.Add(0xCB7A, new Instruction16bit(0xCB7A, "BIT 7,D", 2, 1));
            GB16bitInstructions.Add(0xCB7B, new Instruction16bit(0xCB7B, "BIT 7,E", 2, 1));
            GB16bitInstructions.Add(0xCB7C, new Instruction16bit(0xCB7C, "BIT 7,H", 2, 1));
            GB16bitInstructions.Add(0xCB7D, new Instruction16bit(0xCB7D, "BIT 7,L", 2, 1));
            GB16bitInstructions.Add(0xCB7E, new Instruction16bit(0xCB7E, "BIT 7,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB7F, new Instruction16bit(0xCB7F, "BIT 7,A", 2, 1));

            GB16bitInstructions.Add(0xCB80, new Instruction16bit(0xCB80, "RES 0,B", 2, 1));
            GB16bitInstructions.Add(0xCB81, new Instruction16bit(0xCB81, "RES 0,C", 2, 1));
            GB16bitInstructions.Add(0xCB82, new Instruction16bit(0xCB82, "RES 0,D", 2, 1));
            GB16bitInstructions.Add(0xCB83, new Instruction16bit(0xCB83, "RES 0,E", 2, 1));
            GB16bitInstructions.Add(0xCB84, new Instruction16bit(0xCB84, "RES 0,H", 2, 1));
            GB16bitInstructions.Add(0xCB85, new Instruction16bit(0xCB85, "RES 0,L", 2, 1));
            GB16bitInstructions.Add(0xCB86, new Instruction16bit(0xCB86, "RES 0,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB87, new Instruction16bit(0xCB87, "RES 0,A", 2, 1));
            GB16bitInstructions.Add(0xCB88, new Instruction16bit(0xCB88, "RES 1,B", 2, 1));
            GB16bitInstructions.Add(0xCB89, new Instruction16bit(0xCB89, "RES 1,C", 2, 1));
            GB16bitInstructions.Add(0xCB8A, new Instruction16bit(0xCB8A, "RES 1,D", 2, 1));
            GB16bitInstructions.Add(0xCB8B, new Instruction16bit(0xCB8B, "RES 1,E", 2, 1));
            GB16bitInstructions.Add(0xCB8C, new Instruction16bit(0xCB8C, "RES 1,H", 2, 1));
            GB16bitInstructions.Add(0xCB8D, new Instruction16bit(0xCB8D, "RES 1,L", 2, 1));
            GB16bitInstructions.Add(0xCB8E, new Instruction16bit(0xCB8E, "RES 1,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB8F, new Instruction16bit(0xCB8F, "RES 1,A", 2, 1));

            GB16bitInstructions.Add(0xCB90, new Instruction16bit(0xCB90, "RES 2,B", 2, 1));
            GB16bitInstructions.Add(0xCB91, new Instruction16bit(0xCB91, "RES 2,C", 2, 1));
            GB16bitInstructions.Add(0xCB92, new Instruction16bit(0xCB92, "RES 2,D", 2, 1));
            GB16bitInstructions.Add(0xCB93, new Instruction16bit(0xCB93, "RES 2,E", 2, 1));
            GB16bitInstructions.Add(0xCB94, new Instruction16bit(0xCB94, "RES 2,H", 2, 1));
            GB16bitInstructions.Add(0xCB95, new Instruction16bit(0xCB95, "RES 2,L", 2, 1));
            GB16bitInstructions.Add(0xCB96, new Instruction16bit(0xCB96, "RES 2,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB97, new Instruction16bit(0xCB97, "RES 2,A", 2, 1));
            GB16bitInstructions.Add(0xCB98, new Instruction16bit(0xCB98, "RES 3,B", 2, 1));
            GB16bitInstructions.Add(0xCB99, new Instruction16bit(0xCB99, "RES 3,C", 2, 1));
            GB16bitInstructions.Add(0xCB9A, new Instruction16bit(0xCB9A, "RES 3,D", 2, 1));
            GB16bitInstructions.Add(0xCB9B, new Instruction16bit(0xCB9B, "RES 3,E", 2, 1));
            GB16bitInstructions.Add(0xCB9C, new Instruction16bit(0xCB9C, "RES 3,H", 2, 1));
            GB16bitInstructions.Add(0xCB9D, new Instruction16bit(0xCB9D, "RES 3,L", 2, 1));
            GB16bitInstructions.Add(0xCB9E, new Instruction16bit(0xCB9E, "RES 3,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCB9F, new Instruction16bit(0xCB9F, "RES 3,A", 2, 1));

            GB16bitInstructions.Add(0xCBA0, new Instruction16bit(0xCBA0, "RES 4,B", 2, 1));
            GB16bitInstructions.Add(0xCBA1, new Instruction16bit(0xCBA1, "RES 4,C", 2, 1));
            GB16bitInstructions.Add(0xCBA2, new Instruction16bit(0xCBA2, "RES 4,D", 2, 1));
            GB16bitInstructions.Add(0xCBA3, new Instruction16bit(0xCBA3, "RES 4,E", 2, 1));
            GB16bitInstructions.Add(0xCBA4, new Instruction16bit(0xCBA4, "RES 4,H", 2, 1));
            GB16bitInstructions.Add(0xCBA5, new Instruction16bit(0xCBA5, "RES 4,L", 2, 1));
            GB16bitInstructions.Add(0xCBA6, new Instruction16bit(0xCBA6, "RES 4,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBA7, new Instruction16bit(0xCBA7, "RES 4,A", 2, 1));
            GB16bitInstructions.Add(0xCBA8, new Instruction16bit(0xCBA8, "RES 5,B", 2, 1));
            GB16bitInstructions.Add(0xCBA9, new Instruction16bit(0xCBA9, "RES 5,C", 2, 1));
            GB16bitInstructions.Add(0xCBAA, new Instruction16bit(0xCBAA, "RES 5,D", 2, 1));
            GB16bitInstructions.Add(0xCBAB, new Instruction16bit(0xCBAB, "RES 5,E", 2, 1));
            GB16bitInstructions.Add(0xCBAC, new Instruction16bit(0xCBAC, "RES 5,H", 2, 1));
            GB16bitInstructions.Add(0xCBAD, new Instruction16bit(0xCBAD, "RES 5,L", 2, 1));
            GB16bitInstructions.Add(0xCBAE, new Instruction16bit(0xCBAE, "RES 5,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBAF, new Instruction16bit(0xCBAF, "RES 5,A", 2, 1));

            GB16bitInstructions.Add(0xCBB0, new Instruction16bit(0xCBB0, "RES 6,B", 2, 1));
            GB16bitInstructions.Add(0xCBB1, new Instruction16bit(0xCBB1, "RES 6,C", 2, 1));
            GB16bitInstructions.Add(0xCBB2, new Instruction16bit(0xCBB2, "RES 6,D", 2, 1));
            GB16bitInstructions.Add(0xCBB3, new Instruction16bit(0xCBB3, "RES 6,E", 2, 1));
            GB16bitInstructions.Add(0xCBB4, new Instruction16bit(0xCBB4, "RES 6,H", 2, 1));
            GB16bitInstructions.Add(0xCBB5, new Instruction16bit(0xCBB5, "RES 6,L", 2, 1));
            GB16bitInstructions.Add(0xCBB6, new Instruction16bit(0xCBB6, "RES 6,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBB7, new Instruction16bit(0xCBB7, "RES 6,A", 2, 1));
            GB16bitInstructions.Add(0xCBB8, new Instruction16bit(0xCBB8, "RES 7,B", 2, 1));
            GB16bitInstructions.Add(0xCBB9, new Instruction16bit(0xCBB9, "RES 7,C", 2, 1));
            GB16bitInstructions.Add(0xCBBA, new Instruction16bit(0xCBBA, "RES 7,D", 2, 1));
            GB16bitInstructions.Add(0xCBBB, new Instruction16bit(0xCBBB, "RES 7,E", 2, 1));
            GB16bitInstructions.Add(0xCBBC, new Instruction16bit(0xCBBC, "RES 7,H", 2, 1));
            GB16bitInstructions.Add(0xCBBD, new Instruction16bit(0xCBBD, "RES 7,L", 2, 1));
            GB16bitInstructions.Add(0xCBBE, new Instruction16bit(0xCBBE, "RES 7,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBBF, new Instruction16bit(0xCBBF, "RES 7,A", 2, 1));

            GB16bitInstructions.Add(0xCBC0, new Instruction16bit(0xCBC0, "SET 0,B", 2, 1));
            GB16bitInstructions.Add(0xCBC1, new Instruction16bit(0xCBC1, "SET 0,C", 2, 1));
            GB16bitInstructions.Add(0xCBC2, new Instruction16bit(0xCBC2, "SET 0,D", 2, 1));
            GB16bitInstructions.Add(0xCBC3, new Instruction16bit(0xCBC3, "SET 0,E", 2, 1));
            GB16bitInstructions.Add(0xCBC4, new Instruction16bit(0xCBC4, "SET 0,H", 2, 1));
            GB16bitInstructions.Add(0xCBC5, new Instruction16bit(0xCBC5, "SET 0,L", 2, 1));
            GB16bitInstructions.Add(0xCBC6, new Instruction16bit(0xCBC6, "SET 0,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBC7, new Instruction16bit(0xCBC7, "SET 0,A", 2, 1));
            GB16bitInstructions.Add(0xCBC8, new Instruction16bit(0xCBC8, "SET 1,B", 2, 1));
            GB16bitInstructions.Add(0xCBC9, new Instruction16bit(0xCBC9, "SET 1,C", 2, 1));
            GB16bitInstructions.Add(0xCBCA, new Instruction16bit(0xCBCA, "SET 1,D", 2, 1));
            GB16bitInstructions.Add(0xCBCB, new Instruction16bit(0xCBCB, "SET 1,E", 2, 1));
            GB16bitInstructions.Add(0xCBCC, new Instruction16bit(0xCBCC, "SET 1,H", 2, 1));
            GB16bitInstructions.Add(0xCBCD, new Instruction16bit(0xCBCD, "SET 1,L", 2, 1));
            GB16bitInstructions.Add(0xCBCE, new Instruction16bit(0xCBCE, "SET 1,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBCF, new Instruction16bit(0xCBCF, "SET 1,A", 2, 1));

            GB16bitInstructions.Add(0xCBD0, new Instruction16bit(0xCBD0, "SET 2,B", 2, 1));
            GB16bitInstructions.Add(0xCBD1, new Instruction16bit(0xCBD1, "SET 2,C", 2, 1));
            GB16bitInstructions.Add(0xCBD2, new Instruction16bit(0xCBD2, "SET 2,D", 2, 1));
            GB16bitInstructions.Add(0xCBD3, new Instruction16bit(0xCBD3, "SET 2,E", 2, 1));
            GB16bitInstructions.Add(0xCBD4, new Instruction16bit(0xCBD4, "SET 2,H", 2, 1));
            GB16bitInstructions.Add(0xCBD5, new Instruction16bit(0xCBD5, "SET 2,L", 2, 1));
            GB16bitInstructions.Add(0xCBD6, new Instruction16bit(0xCBD6, "SET 2,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBD7, new Instruction16bit(0xCBD7, "SET 2,A", 2, 1));
            GB16bitInstructions.Add(0xCBD8, new Instruction16bit(0xCBD8, "SET 3,B", 2, 1));
            GB16bitInstructions.Add(0xCBD9, new Instruction16bit(0xCBD9, "SET 3,C", 2, 1));
            GB16bitInstructions.Add(0xCBDA, new Instruction16bit(0xCBDA, "SET 3,D", 2, 1));
            GB16bitInstructions.Add(0xCBDB, new Instruction16bit(0xCBDB, "SET 3,E", 2, 1));
            GB16bitInstructions.Add(0xCBDC, new Instruction16bit(0xCBDC, "SET 3,H", 2, 1));
            GB16bitInstructions.Add(0xCBDD, new Instruction16bit(0xCBDD, "SET 3,L", 2, 1));
            GB16bitInstructions.Add(0xCBDE, new Instruction16bit(0xCBDE, "SET 3,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBDF, new Instruction16bit(0xCBDF, "SET 3,A", 2, 1));

            GB16bitInstructions.Add(0xCBE0, new Instruction16bit(0xCBE0, "SET 4,B", 2, 1));
            GB16bitInstructions.Add(0xCBE1, new Instruction16bit(0xCBE1, "SET 4,C", 2, 1));
            GB16bitInstructions.Add(0xCBE2, new Instruction16bit(0xCBE2, "SET 4,D", 2, 1));
            GB16bitInstructions.Add(0xCBE3, new Instruction16bit(0xCBE3, "SET 4,E", 2, 1));
            GB16bitInstructions.Add(0xCBE4, new Instruction16bit(0xCBE4, "SET 4,H", 2, 1));
            GB16bitInstructions.Add(0xCBE5, new Instruction16bit(0xCBE5, "SET 4,L", 2, 1));
            GB16bitInstructions.Add(0xCBE6, new Instruction16bit(0xCBE6, "SET 4,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBE7, new Instruction16bit(0xCBE7, "SET 4,A", 2, 1));
            GB16bitInstructions.Add(0xCBE8, new Instruction16bit(0xCBE8, "SET 5,B", 2, 1));
            GB16bitInstructions.Add(0xCBE9, new Instruction16bit(0xCBE9, "SET 5,C", 2, 1));
            GB16bitInstructions.Add(0xCBEA, new Instruction16bit(0xCBEA, "SET 5,D", 2, 1));
            GB16bitInstructions.Add(0xCBEB, new Instruction16bit(0xCBEB, "SET 5,E", 2, 1));
            GB16bitInstructions.Add(0xCBEC, new Instruction16bit(0xCBEC, "SET 5,H", 2, 1));
            GB16bitInstructions.Add(0xCBED, new Instruction16bit(0xCBED, "SET 5,L", 2, 1));
            GB16bitInstructions.Add(0xCBEE, new Instruction16bit(0xCBEE, "SET 5,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBEF, new Instruction16bit(0xCBEF, "SET 5,A", 2, 1));

            GB16bitInstructions.Add(0xCBF0, new Instruction16bit(0xCBF0, "SET 6,B", 2, 1));
            GB16bitInstructions.Add(0xCBF1, new Instruction16bit(0xCBF1, "SET 6,C", 2, 1));
            GB16bitInstructions.Add(0xCBF2, new Instruction16bit(0xCBF2, "SET 6,D", 2, 1));
            GB16bitInstructions.Add(0xCBF3, new Instruction16bit(0xCBF3, "SET 6,E", 2, 1));
            GB16bitInstructions.Add(0xCBF4, new Instruction16bit(0xCBF4, "SET 6,H", 2, 1));
            GB16bitInstructions.Add(0xCBF5, new Instruction16bit(0xCBF5, "SET 6,L", 2, 1));
            GB16bitInstructions.Add(0xCBF6, new Instruction16bit(0xCBF6, "SET 6,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBF7, new Instruction16bit(0xCBF7, "SET 6,A", 2, 1));
            GB16bitInstructions.Add(0xCBF8, new Instruction16bit(0xCBF8, "SET 7,B", 2, 1));
            GB16bitInstructions.Add(0xCBF9, new Instruction16bit(0xCBF9, "SET 7,C", 2, 1));
            GB16bitInstructions.Add(0xCBFA, new Instruction16bit(0xCBFA, "SET 7,D", 2, 1));
            GB16bitInstructions.Add(0xCBFB, new Instruction16bit(0xCBFB, "SET 7,E", 2, 1));
            GB16bitInstructions.Add(0xCBFC, new Instruction16bit(0xCBFC, "SET 7,H", 2, 1));
            GB16bitInstructions.Add(0xCBFD, new Instruction16bit(0xCBFD, "SET 7,L", 2, 1));
            GB16bitInstructions.Add(0xCBFE, new Instruction16bit(0xCBFE, "SET 7,(HL)", 2, 1));
            GB16bitInstructions.Add(0xCBFF, new Instruction16bit(0xCBFF, "SET 7,A", 2, 1));
        }

        static public Instruction8bit Get8bitInstruction(byte code, byte op1, byte op2)
        {
            Instruction8bit instruction = GB8bitInstructions[code];
            string operation = instruction.GetOperation();
            int index;

            try
            {
                if(op1 > 0x00)
                {
                    index = operation.IndexOf("*");
                    operation = operation.Remove(index, 1);
                    operation = operation.Insert(index, BitConverter.ToString(new byte[] { op1 }));
                    instruction = new Instruction8bit(code, operation, GB8bitInstructions[code].size, GB8bitInstructions[code].cycles);
                }

                // if op2 is not null or empty
                if(op2 > 0x00)
                {
                    index = operation.IndexOf("*");
                    operation = operation.Remove(index, 1);
                    operation = operation.Insert(index, BitConverter.ToString(new byte[] { op2 }));
                    instruction = new Instruction8bit(code, operation, GB8bitInstructions[code].size, GB8bitInstructions[code].cycles);
                }
            }
            catch(Exception ex)
            {
                instruction = new Instruction8bit(code, $"Opcode not found", int.MaxValue, 0);
            }

            return instruction;
        }

        static public Instruction16bit Get16bitInstruction(byte code, byte op1, byte op2)
        {
            return new Instruction16bit(0x00, "nothing", int.MaxValue, 0);
        }
    }
}
