using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class FormDogovora : Form
    {
        public FormDogovora()
        {
            InitializeComponent();
        }

        private void договораBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договораBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void FormDogovora_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Договора". При необходимости она может быть перемещена или удалена.
            this.договораTableAdapter.Fill(this.kursachDataSet.Договора);

        }

        private void zakaz_click(object sender, EventArgs e)
        {
            FormZakaza zak = new FormZakaza();

            zak.Show();

            this.Close();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            FormClienta cl = new FormClienta();

            cl.Show();

            this.Close();
        }

        private void sotrudnic_Click(object sender, EventArgs e)
        {
            FormSotrudnik sot = new FormSotrudnik();

            sot.Show();
            this.Close();

        }
    }
}
