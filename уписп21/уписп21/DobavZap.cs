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
    public partial class DobavZap : Form
    {
        public DobavZap()
        {
            InitializeComponent();
        }

        private void med_kartaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.med_kartaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.уП_ИСП21DataSet);

        }

        private void DobavZap_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.zapic". При необходимости она может быть перемещена или удалена.
            this.zapicTableAdapter.Fill(this.уП_ИСП21DataSet.zapic);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.Vrach". При необходимости она может быть перемещена или удалена.
            this.vrachTableAdapter.Fill(this.уП_ИСП21DataSet.Vrach);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.lekarctva". При необходимости она может быть перемещена или удалена.
            this.lekarctvaTableAdapter.Fill(this.уП_ИСП21DataSet.lekarctva);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.Pacient". При необходимости она может быть перемещена или удалена.
            this.pacientTableAdapter.Fill(this.уП_ИСП21DataSet.Pacient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.med_karta". При необходимости она может быть перемещена или удалена.
            this.med_kartaTableAdapter.Fill(this.уП_ИСП21DataSet.med_karta);

        }

        private void anamnesLabel_Click(object sender, EventArgs e)
        {

        }

        private void iD_med_kartaLabel_Click(object sender, EventArgs e)
        {

        }

        private void plan_leheniaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            med_kartaBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.med_kartaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.уП_ИСП21DataSet);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            med_kartaBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
