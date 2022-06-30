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
    public partial class FormSotrudnik : Form
    {
        public FormSotrudnik()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void FormSotrudnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.kursachDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClienta cl = new FormClienta();

            cl.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormZakaza zak = new FormZakaza();

            zak.Show();

            this.Close();
        }

        private void Dogovor_Click(object sender, EventArgs e)
        {
            FormDogovora form = new FormDogovora();

            form.Show();
        }
    }
}
