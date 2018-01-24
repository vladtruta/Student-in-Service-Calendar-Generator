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
    public partial class AdaugareElev : Form
    {
        private ListBox lb_elevi;
        public AdaugareElev(ListBox lb)
        {
            InitializeComponent();
            lb_elevi = lb;
        }

        private void bt_adauga_Click(object sender, EventArgs e)
        {
            if (tb_nume.Text.Trim() == "")
                MessageBox.Show("Trebuie sa introduceti macar un nume de familie!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                lb_elevi.Items.Add(tb_nume.Text.Trim() + " " + tb_prenume.Text.Trim());
                SaveFileHelper.unsavedChanges = true;
                //this.Close();
            }
        }

        private void tb_nume_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }

        private void AdaugareElev_Load(object sender, EventArgs e)
        {

        }
    }
}
