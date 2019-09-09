using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBEmu
{
	class CPU
	{
		// registers
		public byte a;
		public byte b;
		public byte c;
		public byte d;
		public byte e;
		public byte h;
		public byte l;
		public ushort af;
		public ushort bc;
		public ushort de;
		public ushort hl;
		public ushort pc;
		public ushort sp;

		// flag
		private byte f;
	}
}
