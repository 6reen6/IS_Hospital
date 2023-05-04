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
    public partial class DobavLek : Form
    {
        public DobavLek()
        {
            InitializeComponent();
        }

        private void lekarctvaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lekarctvaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.уП_ИСП21DataSet);

        }

        private void DobavLek_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ИСП21DataSet.lekarctva". При необходимости она может быть перемещена или удалена.
            this.lekarctvaTableAdapter.Fill(this.уП_ИСП21DataSet.lekarctva);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lekarctvaBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lekarctvaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.уП_ИСП21DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lekarctvaBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
