using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarServici
{
    struct Vacante
    {
        public int id;
        public char tip;
        public DateTime start;
        public DateTime finish;
    };
    
    struct AnScolar
    {
        public DateTime start;
        public DateTime finish;
    }

    class VacanteHelper
    {
        private static VacanteHelper instance;
        private List<Vacante> lista_vacante = new List<Vacante>();
        private AnScolar anScolar;

        private VacanteHelper() { }

        public static VacanteHelper getInstance()
        {
            if (instance == null)
                instance = new VacanteHelper();
            return instance;
        }

        public void adaugaVacanta(char tip, DateTime start, DateTime finish, DataGridView dgv)
        {
            int id = genereazaIDVacanta();
            Vacante temp = new Vacante();
            temp.id = id;
            temp.tip = tip;
            temp.start = start;
            temp.finish = finish;
            lista_vacante.Add(temp);

            //incarca cate o vacanta in DGV, fix dupa adaugare
            incarcaVacanteDGV(id, tip, start, finish, dgv);

            SaveFileHelper.unsavedChanges = true;
        }

        public void incarcaVacanteDGV(int id, char tip, DateTime start, DateTime finish, DataGridView dgv)
        {
            dgv.Rows.Add();
            int x = dgv.Rows.Count - 1;
            dgv.Rows[x].Cells[0].Value = id;
            dgv.Rows[x].Cells[1].Value = tip;
            dgv.Rows[x].Cells[2].Value = start;
            dgv.Rows[x].Cells[3].Value = finish;
        }

        public void incarcaVacanteDGVRuntime(DataGridView dgv)
        {
            int i = 0;
            foreach (Vacante v in lista_vacante)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = v.id;
                dgv.Rows[i].Cells[1].Value = v.tip;
                dgv.Rows[i].Cells[2].Value = v.start;
                dgv.Rows[i].Cells[3].Value = v.finish;
                i++;
            }
        }

        public void stergeToateVacanteleDGV(DataGridView dgv)
        {
            lista_vacante.Clear();
            dgv.Rows.Clear();
        }

        public void stergeVacantaDGV(int id, DataGridView dgv, int rowIndex)
        {
            for (int i = 0; i < lista_vacante.Count; i++)
                if (lista_vacante[i].id == id)
                    lista_vacante.Remove(lista_vacante[i]);
            dgv.Rows.RemoveAt(rowIndex);
        }

        private int genereazaIDVacanta()
        {
            int max = 0;
            for (int i = 0; i < lista_vacante.Count; i++)
                if (lista_vacante[i].id > max)
                    max = lista_vacante[i].id;
            return max + 1;
        }

        public List<Vacante> GetListaVacante { get { return lista_vacante; } }
        public List<Vacante> SetListaVacante { set { lista_vacante = value; } }

        public AnScolar GetAnScolar { get { return anScolar; } }
        public AnScolar SetAnScolar { set { anScolar = value; } }

    }
}
