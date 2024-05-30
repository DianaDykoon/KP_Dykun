using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace OfficeLab
{
    public class ExcelDoc : IDisposable
    {
        Excel.Application? application = null;
        Excel.Sheets? sheets = null;
        public Excel.Worksheet? sheet = null;
        Excel.Workbook? workbook = null;

        public ExcelDoc()
        {
            application = new Excel.Application();
            workbook = application.Workbooks.Add();
            sheets = workbook.Sheets;
            sheet = sheets[1];
        }
        public ExcelDoc(string fileName)
        {
            application = new Excel.Application();
            workbook = application.Workbooks.Open(fileName);
            sheets = workbook.Sheets;
            sheet = sheets[1];
        }

        public void SaveAs(string fileName)
        {
            workbook?.SaveAs(fileName);
        }

        public void Dispose()
        {
            workbook?.Close();
            application?.Quit();
            Release(sheet);
            sheet = null;
            Release(sheets);
            sheets = null;
            Release(workbook);
            workbook = null;
            Release(application);
            application = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void createSheet()
        {
            workbook!.Sheets.Add();
            sheets = workbook!.Sheets;
            sheet = sheets[2];
        }

        public string? this[string cellName]
        {
            get => sheet?.Range[cellName].Value2.ToString();
            set
            {
                if (sheet != null)
                    sheet.Range[cellName].Value2 = value;
            }
        }

        public string? this[int row, int column]
        {
            get => sheet?.Cells[row, column].ToString();
            set
            {
                if (sheet != null)
                    sheet.Cells[row, column] = value;
            }
        }

        public void Release(object? obj)
        {
            if (application != null)
            {
#pragma warning disable CA1416 // Проверка совместимости платформы
                _ = Marshal.FinalReleaseComObject(obj!);
#pragma warning restore CA1416 // Проверка совместимости платформы
            }
        }
    }
}
