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
    public partial class Tabl_vid_vrach : Form
    {
        public Tabl_vid_vrach()
        {
            InitializeComponent();
        }

        private void vrachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vrachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.уП_ИСП21DataSet);

        }

        private void tabl_vid_vrach_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.Vrach". При необходимости она может быть перемещена или удалена.
            this.vrachTableAdapter.Fill(this.уП_ИСП21DataSet.Vrach);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vrachBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vrachBindingSource.Filter = "fam_vrach='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vrachDataGridView.ColumnCount - 1; i++) 
            {
                for (int j = 0; j < vrachDataGridView.RowCount - 1; j++) 
                {
                    vrachDataGridView[i, j].Style.BackColor = Color.White;
                    vrachDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < vrachDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < vrachDataGridView.RowCount - 1; j++)
                {
                    if (vrachDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        vrachDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        vrachDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
