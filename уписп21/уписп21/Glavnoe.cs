using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace уписп21
{
    public partial class Glavnay : Form
    {
        private Vrach vrach;
        private Pacient pacient;
        private Spisok spisok;
        public Glavnay()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            vrach = new Vrach();
            vrach.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pacient = new Pacient();
            pacient.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spisok = new Spisok();
            spisok.Visible = true;
        }
    }
}
