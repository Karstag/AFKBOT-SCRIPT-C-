using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Rust
{
    public partial class Form1 : Form
    {
        InputSimulator simulator = new InputSimulator();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                simulator.Mouse.MoveMouseBy(1, 0)
                .Sleep(30000);
            } while (true);
        }
        }
    }
