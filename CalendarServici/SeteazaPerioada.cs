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
    public partial class SeteazaPerioada : Form
    {
        VacanteHelper vacanteHelper;
        public SeteazaPerioada()
        {
            InitializeComponent();
        }

        private void AnScolar_Load(object sender, EventArgs e)
        {
            vacanteHelper = VacanteHelper.getInstance();
            Console.WriteLine(vacanteHelper.GetAnScolar.start.Year);

            if (vacanteHelper.GetAnScolar.start.Year != 0001)
            {
                AnScolar asc = vacanteHelper.GetAnScolar;
                dtp_start.Value = asc.start;
                dtp_finish.Value = asc.finish;
            }
            else
            {
                dtp_start.Value = DateTime.Now;
                dtp_finish.Value = DateTime.Now;
            }
        }

        private void bt_adauga_Click(object sender, EventArgs e)
        {
            if (dtp_start.Value.Date == dtp_finish.Value.Date)
                MessageBox.Show("Perioada trebuie sa fie de cel putin 2 zile!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                AnScolar asc = new AnScolar();
                asc.start = dtp_start.Value.Date;
                asc.finish = dtp_finish.Value.Date;
                vacanteHelper.SetAnScolar = asc;

                SaveFileHelper.unsavedChanges = true;

                this.Close();
            }
        }
    }
}
