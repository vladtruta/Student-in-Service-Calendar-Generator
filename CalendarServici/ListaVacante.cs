using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarServici
{
    public partial class ListaVacante : Form
    {
        private VacanteHelper vacanteHelper;

        public ListaVacante()
        {
            InitializeComponent();
        }

        private void bt_adauga_Click(object sender, EventArgs e)
        {

        }

        private void bt_adauga_Click_1(object sender, EventArgs e)
        {
            AdaugaVacanta av = new AdaugaVacanta(dgv_vacante);
            av.ShowDialog(this);
        }

        private void Vacante_Load(object sender, EventArgs e)
        {
            vacanteHelper = VacanteHelper.getInstance();

            vacanteHelper.incarcaVacanteDGVRuntime(dgv_vacante);
            dgv_vacante.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgv_vacante.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Sunteti sigur ca doriti sa stergeti toate vacantele?", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                vacanteHelper.stergeToateVacanteleDGV(dgv_vacante);

                SaveFileHelper.unsavedChanges = true;
            }
        }

        private void dgv_vacante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_vacante.Columns[4].Index && e.RowIndex >= 0)
            {
                vacanteHelper.stergeVacantaDGV((int)dgv_vacante.Rows[e.RowIndex].Cells["id"].Value, dgv_vacante, e.RowIndex);
            }
        }
    }
}
