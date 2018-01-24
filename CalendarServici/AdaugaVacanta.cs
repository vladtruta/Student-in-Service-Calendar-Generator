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
    public partial class AdaugaVacanta : Form
    {
        private DataGridView dgv_vacante;
        private VacanteHelper vacanteHelper;

        public AdaugaVacanta(DataGridView dgv)
        {
            dgv_vacante = dgv;
            InitializeComponent();
        }

        private void rb_zi_CheckedChanged(object sender, EventArgs e)
        {
            lb_dataStart.Text = "In data de";
            dtp_end.Visible = false;
            lb_dataEnd.Visible = false;
        }

        private void rb_perioada_CheckedChanged(object sender, EventArgs e)
        {
            lb_dataStart.Text = "De la";
            dtp_end.Visible = true;
            lb_dataEnd.Visible = true;
        }

        private void bt_adauga_vacanta_Click(object sender, EventArgs e)
        {
            char tip = ' ';

            if (rb_perioada.Checked)
            {
                if (dtp_start.Value.Date == dtp_end.Value.Date)
                    MessageBox.Show("Perioada trebuie sa fie de cel putin 2 zile!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    tip = 'P';
                    vacanteHelper.adaugaVacanta(tip, dtp_start.Value.Date, dtp_end.Value.Date, dgv_vacante);
                }
            }
            else if (rb_zi.Checked)
            {
                tip = 'Z';
                vacanteHelper.adaugaVacanta(tip, dtp_start.Value.Date, dtp_start.Value.Date, dgv_vacante);
            }
        }

        private void AdaugaVacanta_Load(object sender, EventArgs e)
        {
            vacanteHelper = VacanteHelper.getInstance();
        }
    }
}
