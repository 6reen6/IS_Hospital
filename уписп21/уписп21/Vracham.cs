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
    public partial class Spisok : Form
    {
        private DobavZap dobavZap;
        private DobavLek dobavLek;
        public Spisok()
        {
            InitializeComponent();
        }

        private void pacientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.уП_ИСП21DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.MedCartForPacient". При необходимости она может быть перемещена или удалена.
            this.medCartForPacientTableAdapter.Fill(this.уП_ИСП21DataSet.MedCartForPacient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.lekarctva". При необходимости она может быть перемещена или удалена.
            this.lekarctvaTableAdapter.Fill(this.уП_ИСП21DataSet.lekarctva);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.zapic". При необходимости она может быть перемещена или удалена.
            this.zapicTableAdapter.Fill(this.уП_ИСП21DataSet.zapic);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.med_karta". При необходимости она может быть перемещена или удалена.
            this.med_kartaTableAdapter.Fill(this.уП_ИСП21DataSet.med_karta);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.Pacient". При необходимости она может быть перемещена или удалена.
            this.pacientTableAdapter.Fill(this.уП_ИСП21DataSet.Pacient);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            medCartForPacientBindingSource.Filter = "fam_pacient='" + textBox1.Text + "'";
            medCartForPacientDataGridView.Visible = true;
            medCartForPacientDataGridView1.Visible = true;
            medCartForPacientDataGridView2.Visible = true;
            medCartForPacientDataGridView3.Visible = true;
        }

        private void pacientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void medCartForPacientDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dobavLek = new DobavLek();
            dobavLek.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dobavZap = new DobavZap();
            dobavZap.Visible = true;
        }
    }
}
