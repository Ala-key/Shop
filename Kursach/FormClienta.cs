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
    public partial class FormClienta : Form
    {
        public FormClienta()
        {
            InitializeComponent();
        }

        private void ClentsForm(object sender, EventArgs e)
        {

        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.kursachDataSet.Клиенты);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSotrudnik sot = new FormSotrudnik();

            sot.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormZakaza zak = new FormZakaza();

            zak.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDogovora dog = new FormDogovora();

            dog.Show();

            this.Close();
        }
    }
}
