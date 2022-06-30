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
    public partial class FormZakaza : Form
    {
        public FormZakaza()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void FormZakaza_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClienta cl = new FormClienta();

            cl.Show();

          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSotrudnik sot = new FormSotrudnik();

            sot.Show();

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDogovora dogovora = new FormDogovora();

            dogovora.Show();

            

            
        }
    }
}
