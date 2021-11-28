using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using WeAreDevs_API;
using System.Windows.Forms;
using System.Threading;

namespace Example
{
    public partial class Form1 : Form
    {
        readonly ExploitAPI api = new ExploitAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (api.isAPIAttached())
            {

            }
            else
            {
                if (File.Exists("Files\\exploit-main.dll"))
                {
                    File.Delete("Files\\exploit-main.dll");
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (api.isAPIAttached())
            {
                string input = inputscript.Text;
                api.SendLuaScript(input);

            }
            else
            {
                MessageBox.Show("The Exploit is already Not Injected !");
            }
            
        }
           


        private void button3_Click(object sender, EventArgs e)
        {
            inputscript.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (api.isAPIAttached())
            {
                MessageBox.Show("The exploit is already injected !");

            }
            else
            {
                api.LaunchExploit();

                FileInfo gg = new FileInfo("exploit-main.dll");
                gg.CopyTo("Files\\exploit-main.dll");
                Thread.Sleep(100);
                Thread.Sleep(200);
                System.Diagnostics.Process fd = new System.Diagnostics.Process();
                fd.StartInfo.FileName = "Files\\Injector.exe";
                Thread.Sleep(100);
                fd.Start();

            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            api.DoBTools();
        }
    }
}
