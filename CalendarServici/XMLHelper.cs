using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CalendarServici
{
    class SaveFileHelper
    {
        //trackuie schimbarile pt meniurile de save
        public static bool unsavedChanges = false;

        private static SaveFileHelper instance;
        private string currentFileName = "";
        private VacanteHelper vacanteHelper;

        private SaveFileHelper()
        {
            vacanteHelper = VacanteHelper.getInstance();
        }

        public static SaveFileHelper getInstance()
        {
            if (instance == null)
                instance = new SaveFileHelper();
            return instance;
        }

        public void deschideDialogSaveXML(Meniu mnInstance, ListBox lb_elevi, ListBox lb_perechi)
        {
            SaveFileDialog dialogSave = new SaveFileDialog();
            dialogSave.Filter = "Fisier XML|*.xml";
            dialogSave.Title = "Salveaza Fisierul XML";
            if (currentFileName != "")
                dialogSave.FileName = currentFileName;
            else
                dialogSave.FileName = "untitled";
                       
            DialogResult result = dialogSave.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(dialogSave.FileName))
                        File.Delete(dialogSave.FileName);
                    if (dialogSave.FileName != "")
                    {
                        mnInstance.stergeElev1DinTB();
                        mnInstance.stergeElev2DinTB();
                        salveazaFisierXML(dialogSave.FileName, lb_elevi, lb_perechi);
                        unsavedChanges = false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void incarcaFisiereXML(ListBox lb_elevi, ListBox lb_perechi, string filePath)
        {
            XDocument doc = XDocument.Load(filePath);

            string date_start = null;
            string date_finish = null;

            try
            {
                date_start = doc.Root.FirstAttribute.Value;
                date_finish = doc.Root.LastAttribute.Value;
            }
            catch { }

            AnScolar asc = new AnScolar();
            asc.start = Convert.ToDateTime(date_start);
            asc.finish = Convert.ToDateTime(date_finish);
            vacanteHelper.SetAnScolar = asc;

            List<Vacante> lista_vacante = vacanteHelper.GetListaVacante;

            var vacante = doc.Descendants("vacanta");
            foreach (var v in vacante)
            {
                Vacante temp = new Vacante();
                temp.id = Convert.ToInt32(v.Attribute("id").Value);
                temp.tip = Convert.ToChar(v.Attribute("tip").Value);
                temp.start = Convert.ToDateTime(v.Attribute("start").Value);
                temp.finish = Convert.ToDateTime(v.Attribute("finish").Value);
                lista_vacante.Add(temp);
            }

            var elevi = doc.Descendants("elev");
            foreach (var e in elevi)
            {
                lb_elevi.Items.Add(e.Value);
            }

            var perechi = doc.Descendants("pereche");
            foreach (var p in perechi)
            {
                lb_perechi.Items.Add(p.Value);
            }
        }

        private void salveazaFisierXML(string nume, ListBox lb_elevi, ListBox lb_perechi)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("\t");

            using (XmlWriter xmlWriter = XmlWriter.Create(nume, settings))
            {

                xmlWriter.WriteStartDocument();

                xmlWriter.WriteStartElement("an");
                if (vacanteHelper.GetAnScolar.start.Year != 0001)
                {
                    xmlWriter.WriteAttributeString("start", vacanteHelper.GetAnScolar.start.ToString());
                    xmlWriter.WriteAttributeString("finish", vacanteHelper.GetAnScolar.finish.ToString());
                }

                xmlWriter.WriteStartElement("vacante");
                foreach (Vacante a in vacanteHelper.GetListaVacante)
                {
                    xmlWriter.WriteStartElement("vacanta");
                    xmlWriter.WriteAttributeString("id", a.id.ToString());
                    xmlWriter.WriteAttributeString("tip", a.tip.ToString());
                    xmlWriter.WriteAttributeString("start", a.start.ToString());
                    xmlWriter.WriteAttributeString("finish", a.finish.ToString());
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("elevi");
                foreach (string e in lb_elevi.Items)
                {
                    xmlWriter.WriteStartElement("elev");
                    xmlWriter.WriteString(e);
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("perechi");
                foreach (string e in lb_perechi.Items)
                {
                    xmlWriter.WriteStartElement("pereche");
                    xmlWriter.WriteString(e);
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
        }

        public string GetCurrentFileName { get { return currentFileName; } }
    }
}