using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarServici
{
    public partial class Meniu : Form
    {
        private SaveFileHelper saveFileHelper;
        private ExcelHelper excelHelper;
        private VacanteHelper vacanteHelper;

        public Meniu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb_pereche1.Visible = rb_pereche2.Visible = false;
            saveFileHelper = SaveFileHelper.getInstance();
            excelHelper = ExcelHelper.getInstance();
            vacanteHelper = VacanteHelper.getInstance();
        }

        private void cb_gen_automat_CheckedChanged(object sender, EventArgs e)
        {
            panel_perechi.Enabled = !cb_gen_automat.Checked;
            rb_pereche1.Visible = cb_gen_automat.Checked;
            rb_pereche2.Visible = cb_gen_automat.Checked;
        }

        private void bt_sterge_toti_elevi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur doriti sa stergeti toti elevii din lista?", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lb_elevi.Items.Clear();
                SaveFileHelper.unsavedChanges = true;
            }
        }

        private void bt_sterge_toti_perechi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigur doriti sa stergeti toate perechile de elevi din lista?", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < lb_perechi.Items.Count; i++)
                    mutaInapoiInLBElevi(i);
                lb_perechi.Items.Clear();
                SaveFileHelper.unsavedChanges = true;
            }
        }

        private void mutaInapoiInLBElevi(int index)
        {
            if (lb_perechi.Items[index].ToString().IndexOf(',') > -1)
            {
                string[] perechi = lb_perechi.Items[index].ToString().Split(',');
                for (int i = 0; i < perechi.Length; i++)
                {
                    perechi[i] = perechi[i].Trim();
                    lb_elevi.Items.Add(perechi[i]);
                }
            }
            else
                lb_elevi.Items.Add(lb_perechi.Items[index]);
        }

        private void bt_adauga1_Click(object sender, EventArgs e)
        {
            if (lb_elevi.SelectedItem != null)
            {
                tb_elev1.Text = lb_elevi.SelectedItem.ToString();
                lb_elevi.Items.Remove(lb_elevi.SelectedItem);
                bt_adauga1.Enabled = false;

                SaveFileHelper.unsavedChanges = true;
            }
        }

        private void bt_adauga2_Click(object sender, EventArgs e)
        {
            if (lb_elevi.SelectedItem != null)
            {
                tb_elev2.Text = lb_elevi.SelectedItem.ToString();
                lb_elevi.Items.Remove(lb_elevi.SelectedItem);
                bt_adauga2.Enabled = false;

                SaveFileHelper.unsavedChanges = true;
            }
        }

        private void bt_sterge1_Click(object sender, EventArgs e)
        {
            stergeElev1DinTB();
        }

        private void bt_sterge2_Click(object sender, EventArgs e)
        {
            stergeElev2DinTB();
        }

        private void bt_sterge12_Click(object sender, EventArgs e)
        {
            stergeElev1DinTB();
            stergeElev2DinTB();

            bt_adauga1.Enabled = true;
            bt_adauga2.Enabled = true;
        }

        public void stergeElev1DinTB()
        {
            if (tb_elev1.Text != "")
            {
                lb_elevi.Items.Add(tb_elev1.Text);
                tb_elev1.Clear();
                bt_adauga1.Enabled = true;

                SaveFileHelper.unsavedChanges = true;
            }
        }

        public void stergeElev2DinTB()
        {
            if (tb_elev2.Text != "")
            {
                lb_elevi.Items.Add(tb_elev2.Text);
                tb_elev2.Clear();
                bt_adauga2.Enabled = true;

                SaveFileHelper.unsavedChanges = true;
            }
        }

        private void bt_confirma_Click(object sender, EventArgs e)
        {
            if (!cb_gen_automat.Checked)
            {
                if (tb_elev1.Text == "" && tb_elev2.Text == "")
                    MessageBox.Show("Trebuie sa selectati cel putin un elev!", "Nici un elev selectat", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (tb_elev1.Text != "" && tb_elev2.Text != "")
                    {
                        lb_perechi.Items.Add(tb_elev1.Text + ", " + tb_elev2.Text);
                        tb_elev1.Clear();
                        tb_elev2.Clear();
                        SaveFileHelper.unsavedChanges = true;
                    }
                    else if (tb_elev1.Text != "" && tb_elev2.Text == "")
                    {
                        lb_perechi.Items.Add(tb_elev1.Text);
                        tb_elev1.Clear();
                        SaveFileHelper.unsavedChanges = true;
                    }
                    else
                    {
                        lb_perechi.Items.Add(tb_elev2.Text);
                        tb_elev2.Clear();
                        SaveFileHelper.unsavedChanges = true;
                    }
                }
                bt_adauga1.Enabled = true;
                bt_adauga2.Enabled = true;
            }
            else
            {
                if (rb_pereche1.Checked)
                {
                    while (lb_elevi.Items.Count > 0)
                    {
                        Random rand = new Random();
                        int index = rand.Next(0, lb_elevi.Items.Count);
                        lb_perechi.Items.Add(lb_elevi.Items[index]);
                        lb_elevi.Items.RemoveAt(index);
                    }
                }
                else
                {
                    while (lb_elevi.Items.Count > 1)
                    {
                        Random rand = new Random();
                        int index1 = rand.Next(0, lb_elevi.Items.Count);
                        int index2 = rand.Next(0, lb_elevi.Items.Count);
                        while(index2 == index1)
                            index2 = rand.Next(0, lb_elevi.Items.Count);
                        lb_perechi.Items.Add(lb_elevi.Items[index1] + ", " + lb_elevi.Items[index2]);

                        lb_elevi.Items[index1] = "";
                        lb_elevi.Items[index2] = "";
                        for (int i = 0; i < lb_elevi.Items.Count; i++)
                            if (lb_elevi.Items[i].Equals(""))
                            {
                                lb_elevi.Items.RemoveAt(i);
                                i--;
                            }
                    }
                }
            }
        }
        private void bt_adauga_elev_Click(object sender, EventArgs e)
        {
            AdaugareElev ae = new AdaugareElev(lb_elevi);
            ae.ShowDialog(this);
        }

        private void bt_inc_fisier_elevi_Click(object sender, EventArgs e)
        {
            OpenFileDialog fisierElevi = new OpenFileDialog();
            fisierElevi.Title = "Deschide Un Fisier Text Cu Elevi";
            fisierElevi.Filter = "Fisiere Text|*.txt";

            if (fisierElevi.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (fisierElevi.CheckFileExists)
                    {
                        DialogResult result = MessageBox.Show("Doriti sa pastrati elevii ce au fost deja introdusi?", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                            lb_elevi.Items.Clear();
                        string[] lines = File.ReadAllLines(fisierElevi.FileName);
                        foreach (string line in lines)
                            lb_elevi.Items.Add(line.Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu s-a putut citi fisierul!\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_inc_fisier_perechi_Click(object sender, EventArgs e)
        {
            OpenFileDialog fisierPerechi = new OpenFileDialog();
            fisierPerechi.Title = "Deschide Un Fisier Text Cu Perechi";
            fisierPerechi.Filter = "Fisiere Text|*.txt";

            if (fisierPerechi.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (fisierPerechi.CheckFileExists)
                    {
                        DialogResult result = MessageBox.Show("Doriti sa pastrati perechile de elevi ce au fost deja introduse?", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                            lb_perechi.Items.Clear();
                        string[] lines = File.ReadAllLines(fisierPerechi.FileName);
                        foreach (string line in lines)
                            lb_perechi.Items.Add(line.Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu s-a putut citi fisierul!\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<string> sorteazaListaElevi()
        {
            List<string> elevi = new List<string>();
            foreach (string i in lb_elevi.Items)
                elevi.Add(i);
            elevi.Sort();

            return elevi;
        }

        private void bt_cresc_elevi_Click(object sender, EventArgs e)
        {
            List<string> elevi = sorteazaListaElevi();
            lb_elevi.Items.Clear();
            foreach (string i in elevi)
                lb_elevi.Items.Add(i);
            SaveFileHelper.unsavedChanges = true;
        }
        private void bt_desc_elevi_Click(object sender, EventArgs e)
        {
            List<string> elevi = sorteazaListaElevi();
            lb_elevi.Items.Clear();
            for (int i = elevi.Count - 1; i >= 0; i--)
                lb_elevi.Items.Add(elevi[i]);
            SaveFileHelper.unsavedChanges = true;
        }

        private void bt_adauga_pereche_Click(object sender, EventArgs e)
        {
            AdaugarePereche ap = new AdaugarePereche(lb_perechi);
            ap.ShowDialog(this);
        }

        private void el_dubl_elevi_Click(object sender, EventArgs e)
        {
            List<string> elevi = eliminaDubluriElevi();
                       
            lb_elevi.Items.Clear();
            foreach (string i in elevi)
                lb_elevi.Items.Add(i);
            SaveFileHelper.unsavedChanges = true;
        }

        private List<string> eliminaDubluriElevi()
        {
            int i, j;
            List<string> elevi = new List<string>();

            foreach (string s in lb_elevi.Items)
                elevi.Add(s);
            for (i = 0; i < elevi.Count; i++)
                for (j = i + 1; j < elevi.Count; j++)
                    if (elevi[i].Equals(elevi[j]))
                    {
                        elevi.RemoveAt(j);
                        j--;
                    }
            return elevi;
        }

        private void bt_moveDown_Click(object sender, EventArgs e)
        {
            if (lb_perechi.SelectedItem != null)
            {
                if (lb_perechi.SelectedIndex < lb_perechi.Items.Count - 1)
                {
                    string aux = lb_perechi.Items[lb_perechi.SelectedIndex].ToString();
                    lb_perechi.Items[lb_perechi.SelectedIndex] = lb_perechi.Items[lb_perechi.SelectedIndex + 1];
                    lb_perechi.Items[lb_perechi.SelectedIndex + 1] = aux;
                    lb_perechi.SelectedIndex++;

                    SaveFileHelper.unsavedChanges = true;
                }
            }
        }

        private void bt_moveUp_Click(object sender, EventArgs e)
        {
            if (lb_perechi.SelectedItem != null)
            {
                if (lb_perechi.SelectedIndex > 0)
                {
                    string aux = lb_perechi.Items[lb_perechi.SelectedIndex].ToString();
                    lb_perechi.Items[lb_perechi.SelectedIndex] = lb_perechi.Items[lb_perechi.SelectedIndex - 1];
                    lb_perechi.Items[lb_perechi.SelectedIndex - 1] = aux;
                    lb_perechi.SelectedIndex--;

                    SaveFileHelper.unsavedChanges = true;
                }
            }
        }

        private void bt_an_scolar_Click(object sender, EventArgs e)
        {
            SeteazaPerioada asc = new SeteazaPerioada();
            asc.ShowDialog(this);
        }

        private void bt_seteaza_vacante_Click(object sender, EventArgs e)
        {
            ListaVacante vc = new ListaVacante();
            vc.ShowDialog(this);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileHelper.deschideDialogSaveXML(this, lb_elevi, lb_perechi);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Deschide Un Fisier Text Cu Elevi";
            openFile.Filter = "Fisier XML|*.xml";

            if (SaveFileHelper.unsavedChanges == true)
            {
                if (promptSaveBefore())
                    deschideMeniuOpenFile(openFile);
            }
            else
                deschideMeniuOpenFile(openFile);
        }

        private void deschideMeniuOpenFile(OpenFileDialog openFile)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFile.CheckFileExists)
                    {
                        reseteazaAplicatie();
                        saveFileHelper.incarcaFisiereXML(lb_elevi, lb_perechi, openFile.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu s-a putut citi fisierul!\n" + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool promptSaveBefore()
        {
            DialogResult result = MessageBox.Show("Doriti sa salvati proiectul inainte?\nAvertisment: In caz contrar, se vor pierde toate datele!", "Avertisment", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                saveFileHelper.deschideDialogSaveXML(this, lb_elevi, lb_perechi);
                return true;
            }
            else if (result == DialogResult.No)
                return true;
            return false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileHelper.unsavedChanges == true)
            {
                if (promptSaveBefore())
                    reseteazaAplicatie();
            }
            else
                reseteazaAplicatie();
        }

        private void Meniu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveFileHelper.unsavedChanges == true)
            {
                if (!promptSaveBefore())
                    e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_generare_Click(object sender, EventArgs e)
        {
            AnScolar anScolar = vacanteHelper.GetAnScolar;
            if (anScolar.start.Year == 1)
                MessageBox.Show("Nu ati setat perioada!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (lb_perechi.Items.Count == 0)
                MessageBox.Show("Nu ati adaugat perechi!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (rb_nume_fam.Checked)
                    excelHelper.deschideDialogSaveXLS(lb_perechi, true);
                else if (rb_nume_complet.Checked)
                    excelHelper.deschideDialogSaveXLS(lb_perechi, false);
            }
        }

        private void lb_elevi_MouseUp(object sender, MouseEventArgs e)
        {
            if (lb_elevi.SelectedItem == null)
                meniuElevi.Close();
        }

        private void lb_perechi_MouseUp(object sender, MouseEventArgs e)
        {
            if (lb_perechi.SelectedItem == null)
                meniuPerechi.Close();
        }

        private void sterge_elevi_toolstrip_Click(object sender, EventArgs e)
        {
            lb_elevi.Items.Remove(lb_elevi.Items[lb_elevi.SelectedIndex]);
            SaveFileHelper.unsavedChanges = true;
        }

        private void sterge_perechi_toolstrip_Click(object sender, EventArgs e)
        {
            mutaInapoiInLBElevi(lb_perechi.SelectedIndex);
            lb_perechi.Items.Remove(lb_perechi.Items[lb_perechi.SelectedIndex]);
            SaveFileHelper.unsavedChanges = true;
        }

        private void lb_elevi_MouseDown(object sender, MouseEventArgs e)
        {
            lb_elevi.SelectedIndex = lb_elevi.IndexFromPoint(e.X, e.Y);
        }

        private void lb_perechi_MouseDown(object sender, MouseEventArgs e)
        {
            lb_perechi.SelectedIndex = lb_perechi.IndexFromPoint(e.X, e.Y);
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditElev ee;

            string[] nume = lb_elevi.Items[lb_elevi.SelectedIndex].ToString().Split(' ');
            if (nume.Length > 1)
                ee = new EditElev(nume[0], nume[1], lb_elevi, lb_elevi.SelectedIndex);
            else
                ee = new EditElev(nume[0], null, lb_elevi, lb_elevi.SelectedIndex);
            ee.ShowDialog(this);
        }

        private void reseteazaAplicatie()
        {
            lb_elevi.Items.Clear();
            lb_perechi.Items.Clear();
            vacanteHelper.GetListaVacante.Clear();
            AnScolar asc = new AnScolar();
            asc.start = new DateTime(1, 1, 1);
            asc.finish = new DateTime(1, 1, 1);
            vacanteHelper.SetAnScolar = asc;            
            tb_elev1.Clear();
            tb_elev2.Clear();
            cb_gen_automat.Checked = false;
            bt_adauga1.Enabled = true;
            bt_adauga2.Enabled = true;
            rb_pereche2.Checked = true;
            rb_nume_complet.Checked = true;

            //reseteaza unsaved changes            
            SaveFileHelper.unsavedChanges = false;
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranAbout ea = new EcranAbout();
            ea.ShowDialog(this);
        }
    }
}
