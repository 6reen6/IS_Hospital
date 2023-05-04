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
    public partial class Vrach : Form
    {
        
        private Tabl_vid_vrach tabl_Vid_Vrach;
        public Vrach()
        {
            InitializeComponent();
        }

        private void vrachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vrachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.уП_ИСП21DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.Vrach". При необходимости она может быть перемещена или удалена.
            this.vrachTableAdapter.Fill(this.уП_ИСП21DataSet.Vrach);

        }

        private void date_brich_vrachDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabl_Vid_Vrach = new Tabl_vid_vrach();
            tabl_Vid_Vrach.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vrachBindingSource.AddNew();
        }

        private void Udal_Click(object sender, EventArgs e)
        {
            vrachBindingSource.RemoveCurrent();
        }

        private void Soxran_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vrachBindingSource.EndEdit();
            this . tableAdapterManager.UpdateAll(this.уП_ИСП21DataSet);

        }
    }
}
