using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employment_center_v2._0
{
    public partial class genform : Form
    {
        public genform()
        {
            InitializeComponent();
        }


        private void genform_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobDatabaseDataSet.vacantiondb". При необходимости она может быть перемещена или удалена.
            this.vacantiondbTableAdapter.Fill(this.jobDatabaseDataSet.vacantiondb);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobDatabaseDataSet.vacantiondb". При необходимости она может быть перемещена или удалена.
            this.vacantiondbTableAdapter.Fill(this.jobDatabaseDataSet.vacantiondb);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
         //   profile = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
         //dataGridView1.

        }
    }
}
