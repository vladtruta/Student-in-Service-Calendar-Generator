using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarServici
{
    struct Perechi
    {
        public string elev1;
        public string elev2;
    };

    class ExcelHelper
    {
        //caz special, daca anul scolar incepe si se termina in aceeasi luna...asa e gandita portiunea asta de cod momentan...
        private int day_end_same_month;

        private static ExcelHelper instance;
        private VacanteHelper vacanteHelper = VacanteHelper.getInstance();      
        private int indexPerechi;
        private bool doarNumeFamilie;

        private ExcelHelper() { }

        public static ExcelHelper getInstance()
        {
            if (instance == null)
                instance = new ExcelHelper();
            return instance;
        }
        
        public void deschideDialogSaveXLS(ListBox lb_perechi, bool doarNumeFamilie)
        {
            SaveFileDialog dialogSave = new SaveFileDialog();
            dialogSave.Filter = "Fisier Excel|*.xlsx";
            dialogSave.Title = "Salveaza Fisierul Excel";
            //se poate scoate afara
            dialogSave.FileName = "untitled";

            DialogResult result = dialogSave.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(dialogSave.FileName))
                        File.Delete(dialogSave.FileName);
                    if (dialogSave.FileName != "")
                        createExcel(lb_perechi, dialogSave.FileName, doarNumeFamilie);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
        }

        private FileInfo createExcel(ListBox lb_perechi, string docname, bool doarNumeFamilie)
        {
            var fileName = /*"Example-CRM-" + DateTime.Now.ToString("yyyy-MM-dd--hh-mm-ss")*/ docname;

            var file = new FileInfo(fileName);

            AnScolar anScolar = vacanteHelper.GetAnScolar;

            List<Perechi> lista_perechi = adaugaPerechiInLista(lb_perechi);

            //reseteaza indexul de perechi
            indexPerechi = 0;
            //seteaza doarNumeFamilie
            this.doarNumeFamilie = doarNumeFamilie;

            createWorkspacesForEachMonth(file, anScolar.start, anScolar.finish, lista_perechi);

            return file;
        }

        private void createWorkspacesForEachMonth(FileInfo file, DateTime start, DateTime end, List<Perechi> lista_perechi)
        {
            int diff = Math.Abs(start.Month - end.Month + 12 * (start.Year - end.Year));

            int j, currentYear, currentDay;
            char status;

            for (int i = start.Month; i <= start.Month + diff; i++)
            {
                currentYear = start.Year;
                if (i > 12)
                {
                    currentYear++;
                    j = i - 12;
                }
                else
                    j = i;

                if (start.Month == end.Month)
                {
                    status = 's';
                    currentDay = start.Day;
                    day_end_same_month = end.Day;
                }
                else if (i == start.Month)
                {
                    status = 'b';
                    currentDay = start.Day;
                }
                else if (i == start.Month + diff)
                {
                    status = 'e';
                    currentDay = end.Day;
                }                
                else
                {
                    status = 'm';
                    currentDay = 1;
                }

                addWorkspace(file, new DateTime(currentYear, j, currentDay), getMonthName(j) + " - " + currentYear, lista_perechi, status);
            }
        }

        private void addWorkspace(FileInfo file, DateTime referenceDate, string currentMonthName,
            List<Perechi> lista_perechi, char status)
        {
            using (var package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(currentMonthName);

                //worksheet.TabColor = Color.Blue;
                worksheet.PrinterSettings.Orientation = eOrientation.Landscape;
                worksheet.DefaultColWidth = 17;
                worksheet.HeaderFooter.FirstHeader.CenteredText = currentMonthName;

                worksheet.Cells[1, 1].Value = "Luni";
                worksheet.Cells[1, 2].Value = "Marti";
                worksheet.Cells[1, 3].Value = "Miercuri";
                worksheet.Cells[1, 4].Value = "Joi";
                worksheet.Cells[1, 5].Value = "Vineri";
                worksheet.Cells[1, 6].Value = "Sambata";
                worksheet.Cells[1, 7].Value = "Duminica";

                for (int i = 1; i <= 7; i++)
                    worksheet.Cells[1, i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                worksheet.Cells[1, 1, 1, 7].Style.Font.Size = 14;
                worksheet.Cells[1, 1, 1, 7].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Cells[1, 6, 1, 7].Style.Font.Color.SetColor(Color.Red);

                //Ok now format the first row of the heade, but only the first two columns;
                using (var range = worksheet.Cells[1, 1, 1, 7])
                {
                    range.Style.Font.Bold = true;
                }

                //generate the days and enter the day number in each cell
                generateDaysSiAdaugaElevi(worksheet, referenceDate, lista_perechi, status);

                // Set some document properties
                package.Workbook.Properties.Title = "Calendar Elevi Serviciu";
                package.Workbook.Properties.Author = "Vlad Truta - www.truta.ro";

                // save our new workbook and we are done!
                package.Save();
            }
        }

        private void generateDaysSiAdaugaElevi(ExcelWorksheet worksheet, DateTime referenceDate, List<Perechi> lista_perechi, char status)
        {
            List<DateTime> dates = DateHelper.getAllDates(referenceDate.Year, referenceDate.Month);
            //data ce va creste odata cu i            
            DateTime currentDate = new DateTime(referenceDate.Year, referenceDate.Month, 1);

            //coloana curenta, randul si inaltimea randurilor cu data din zi (se va adauga 15 la cele pt numem la linia 179)
            int currentColumn = DateHelper.getDayOfWeek(referenceDate.Year, referenceDate.Month, 1);
            int currentRow = 2;
            int currentRowHeight = 16;

            //aparent incepe de la 0...yux
            if (currentColumn == 0)
                currentColumn = 7;            

            //seteaza primele 3 randuri
            worksheet.Row(currentRow).Height = currentRowHeight;
            worksheet.Row(currentRow + 1).Height = worksheet.Row(currentRow + 2).Height = currentRowHeight + 15;

            int i = 1;
            while (i <= currentColumn)
            {
                worksheet.Cells[currentRow, i, currentRow + 2, i].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Hair);
                i++;
            }

            i = 0;
            while (i < dates.Count)
            {
                worksheet.Cells[currentRow, currentColumn].Style.Font.Bold = true;
                worksheet.Cells[currentRow, currentColumn].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Top;
                worksheet.Cells[currentRow, currentColumn].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;

                worksheet.Cells[currentRow, currentColumn, currentRow + 2, currentColumn].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                worksheet.Cells[currentRow + 1, currentColumn, currentRow + 2, currentColumn].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                worksheet.Cells[currentRow + 1, currentColumn, currentRow + 2, currentColumn].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                //adauga ziua
                worksheet.Cells[currentRow, currentColumn].Value = dates[i].Day;
                if (currentColumn == 6 || currentColumn == 7)
                    worksheet.Cells[currentRow, currentColumn].Style.Font.Color.SetColor(Color.Red);
                
                //adauga elevii, pe cazuri
                if (status == 'b')
                    adaugaEleviDeLa(dates, lista_perechi, worksheet, referenceDate, ref currentDate, currentRow, currentColumn, i);
                else if (status == 'e')
                    adaugaEleviPanaLa(dates, lista_perechi, worksheet, referenceDate, ref currentDate, currentRow, currentColumn, i);
                else if (status == 's')
                    adaugaEleviAceeasiLuna(dates, lista_perechi, worksheet, referenceDate, ref currentDate, currentRow, currentColumn, i);
                else
                    adaugaElevi(dates, lista_perechi, worksheet, ref currentDate, currentRow, currentColumn, i);

                if (currentColumn == 7)
                {
                    currentColumn = 1;
                    currentRow += 3;
                    worksheet.Row(currentRow).Height = currentRowHeight;
                    worksheet.Row(currentRow + 1).Height = worksheet.Row(currentRow + 2).Height = currentRowHeight + 15;
                }
                else
                    currentColumn++;

                i++;
                currentDate = currentDate.AddDays(1);
            }

            while (currentColumn <= 7)
            {
                worksheet.Cells[currentRow, currentColumn, currentRow + 2, currentColumn].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Hair);
                currentColumn++;
            }
        }

        private void adaugaEleviAceeasiLuna(List<DateTime> dates, List<Perechi> lista_perechi, ExcelWorksheet worksheet,
            DateTime referenceDate, ref DateTime currentDate, int currentRow, int currentColumn, int i)
        {
            if (dates[i].Day >= referenceDate.Day && dates[i].Day <= day_end_same_month)
                adaugaElevi(dates, lista_perechi, worksheet, ref currentDate, currentRow, currentColumn, i);
        }

        private void adaugaEleviDeLa(List<DateTime> dates, List<Perechi> lista_perechi, ExcelWorksheet worksheet,
            DateTime referenceDate, ref DateTime currentDate, int currentRow, int currentColumn, int i)
        {
            if (dates[i].Day >= referenceDate.Day)
                adaugaElevi(dates, lista_perechi, worksheet, ref currentDate, currentRow, currentColumn, i);
        }

        private void adaugaEleviPanaLa(List<DateTime> dates, List<Perechi> lista_perechi, ExcelWorksheet worksheet,
            DateTime referenceDate, ref DateTime currentDate, int currentRow, int currentColumn, int i)
        {
            if (dates[i].Day <= referenceDate.Day)
                adaugaElevi(dates, lista_perechi, worksheet, ref currentDate, currentRow, currentColumn, i);
        }

        private void adaugaElevi(List<DateTime> dates, List<Perechi> lista_perechi, ExcelWorksheet worksheet,
            ref DateTime currentDate, int currentRow, int currentColumn, int i)
        {
            if (currentColumn != 6 && currentColumn != 7 && !eVacanta(currentDate))
            {
                if (doarNumeFamilie)
                {
                    string[] numefam1 = lista_perechi[indexPerechi].elev1.Split(' ');
                    worksheet.Cells[currentRow + 1, currentColumn].Value = numefam1[0];

                    if (lista_perechi[indexPerechi].elev2 != null)
                    {
                        string[] numefam2 = lista_perechi[indexPerechi].elev2.Split(' ');
                        worksheet.Cells[currentRow + 2, currentColumn].Value = numefam2[0];
                    }                                    
                }
                else
                {
                    worksheet.Cells[currentRow + 1, currentColumn].Value = lista_perechi[indexPerechi].elev1;
                    worksheet.Cells[currentRow + 2, currentColumn].Value = lista_perechi[indexPerechi].elev2;
                }

                indexPerechi++;

                if (indexPerechi == lista_perechi.Count)
                    indexPerechi = 0;
            }
            else if (eVacanta(currentDate))
            {
                worksheet.Cells[currentRow + 1, currentColumn].Style.Border.Diagonal.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                worksheet.Cells[currentRow + 2, currentColumn].Style.Border.Diagonal.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                worksheet.Cells[currentRow + 1, currentColumn].Style.Border.DiagonalDown = true;
                worksheet.Cells[currentRow + 1, currentColumn].Style.Border.DiagonalUp = true;
                worksheet.Cells[currentRow + 2, currentColumn].Style.Border.DiagonalDown = true;
                worksheet.Cells[currentRow + 2, currentColumn].Style.Border.DiagonalUp = true;
            }
        }

        private bool eVacanta(DateTime currentDate)
        {
            List<Vacante> lista_vacante = vacanteHelper.GetListaVacante;

            foreach (Vacante v in lista_vacante)
            {
                for (var i = v.start; i <= v.finish; i = i.AddDays(1))
                    if (currentDate == i)
                        return true;
            }
            return false;
        }

        private string getMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "Ianuarie";
                case 2:
                    return "Februarie";
                case 3:
                    return "Martie";
                case 4:
                    return "Aprilie";
                case 5:
                    return "Mai";
                case 6:
                    return "Iunie";
                case 7:
                    return "Iulie";
                case 8:
                    return "August";
                case 9:
                    return "Septembrie";
                case 10:
                    return "Octombrie";
                case 11:
                    return "Noiembrie";
                case 12:
                    return "Decembrie";
            }
            return "";
        }

        //aicia tre sa ma uit umpic
        private List<Perechi> adaugaPerechiInLista(ListBox lb_perechi)
        {
            List<Perechi> lista_perechi = new List<Perechi>();

            foreach (string e in lb_perechi.Items)
            {
                string[] elevi = e.Split(',');
                Perechi temp = new Perechi();
                temp.elev1 = elevi[0].Trim();
                if (elevi.Length > 1) //nu stiu exact ce va returna
                    temp.elev2 = elevi[1].Trim();
                //al doilea nu va exista deloc, va da object ref error;
                lista_perechi.Add(temp);
            }
            return lista_perechi;
        }
    }
}
