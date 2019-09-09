using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GBEmu
{
    public partial class Form1 : Form
    {
        private Disassembler disassembler = new Disassembler();
        private int interval = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            tbLog.Clear();

            using (var dialog = new OpenFileDialog())
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ROM Rom = new ROM(tbLog);
                        if (!Rom.Load(dialog.FileName))
                        {
                            tbLog.AppendText("Failed to load ROM.");
                            return;
                        }
                    }
                    catch(Exception ex)
                    {
                        tbLog.AppendText($"{ex.Message}\n");
                    }
                }
            }
        }

        private void miDisassemble_Click(object sender, EventArgs e)
        {
            tbLog.Clear();

            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] file = File.ReadAllBytes(dialog.FileName);
                        disassembler.file = file;
                        disassembler.pc = 0x100; // On power-up the Gameboy's PC is set to 0x100

						//disassembler.Disassemble();

						Thread thread = new Thread(disassembler.Disassemble);
						
						tbLog.AppendText("Disassembly can take some time.\nPlease wait while this process executes...\n");
						thread.Start();
						thread.Join();
						tbLog.AppendText("done");
						StreamWriter sw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test.txt"));
						sw.Write(disassembler.sb.ToString());
					}
                    catch(Exception ex)
                    {
                        tbLog.AppendText($"{ex.Message}\n");
                    }
                }
            }
        }
    }
}
