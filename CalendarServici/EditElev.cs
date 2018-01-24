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
    public partial class EditElev : Form
    {
        private string nume, prenume;
        private ListBox lb_elevi;
        private int idLB;

        public EditElev(string nume, string prenume, ListBox lb_elevi, int idLB)
        {            
            InitializeComponent();
            this.nume = nume;
            this.prenume = prenume;
            this.lb_elevi = lb_elevi;
            this.idLB = idLB;
        }

        private void bt_actualiz_Click(object sender, EventArgs e)
        {
            if (tb_nume.Text.Trim() == "")
                MessageBox.Show("Trebuie sa introduceti macar un nume de familie!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                lb_elevi.Items[idLB] = tb_nume.Text.Trim() + " " + tb_prenume.Text.Trim();

                SaveFileHelper.unsavedChanges = true;

                this.Close();
            }
        }
        private void tb_nume_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }

        private void EditElev_Load(object sender, EventArgs e)
        {
            tb_nume.Text = nume;
            tb_prenume.Text = prenume;
        }
    }
}
