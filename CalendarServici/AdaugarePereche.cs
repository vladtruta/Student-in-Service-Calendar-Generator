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
    public partial class AdaugarePereche : Form
    {
        private ListBox perechi;

        public AdaugarePereche(ListBox lb)
        {
            perechi = lb;
            InitializeComponent();
        }

        private void AdaugarePereche_Load(object sender, EventArgs e)
        {
            rb_1per.Checked = true;
            toggleElevDoi(false);
        }

        private void rb_2per_CheckedChanged(object sender, EventArgs e)
        {
            toggleElevDoi(true);
        }

        private void rb_1per_CheckedChanged(object sender, EventArgs e)
        {
            toggleElevDoi(false);
            tb_nume2.Clear();
            tb_prenume2.Clear();
        }

        private void toggleElevDoi(bool state)
        {
            lb_nume2.Visible = state;
            lb_prenume2.Visible = state;
            tb_nume2.Visible = state;
            tb_prenume2.Visible = state;
        }

        private void clearAll()
        {
            tb_nume1.Clear();
            tb_nume2.Clear();
            tb_prenume1.Clear();
            tb_prenume2.Clear();
        }

        private void bt_adauga_Click(object sender, EventArgs e)
        {
            if (rb_1per.Checked)
            {
                if (tb_nume1.Text.Trim() == "")
                    MessageBox.Show("Trebuie sa introduceti macar un nume de familie!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    perechi.Items.Add(tb_nume1.Text.Trim() + " " + tb_prenume1.Text.Trim());
                    clearAll();
                    SaveFileHelper.unsavedChanges = true;
                    //this.Close();
                }
            }
            else
            {
                if (tb_nume1.Text.Trim() == "" || tb_nume2.Text.Trim() == "")
                    MessageBox.Show("Trebuie sa introduceti macar cate un nume de familie!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    perechi.Items.Add(tb_nume1.Text.Trim() + " " + tb_prenume1.Text.Trim() + ", "
                        + tb_nume2.Text.Trim() + " " + tb_prenume2.Text.Trim());
                    clearAll();
                    // this.Close();
                }
            }
        }

        private void tb_nume1_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }
    }
}
