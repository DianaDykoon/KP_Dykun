using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace OfficeLab
{
    public class WordDoc : IDisposable
    {
        Word.Application? application = null;
        Word.Paragraph? paragraph = null;
        Word.Document? document = null;
        Word.Table? table = null;

        object objMiss = System.Reflection.Missing.Value;
        object objEndOfDocFlag = "\\endofdoc";

        public WordDoc()
        {
            application = new Word.Application();
            document = application.Documents.Add();
            paragraph = document.Paragraphs.Add();
        }

        public WordDoc(string fileName)
        {
            application = new Word.Application();
            document = application.Documents.Open(fileName);
            paragraph = document.Paragraphs.Add();
        }

        public void SaveAs(string fileName)
        {
            document?.SaveAs(fileName);
        }

        public void CreateTable(int row, int column, string title)
        {
            
            Word.Range objWordRng = document!.Bookmarks.get_Item
                        (ref objEndOfDocFlag).Range;
            objWordRng.InsertParagraphAfter();
            
            objWordRng.InsertAfter(title);
            objWordRng = document.Bookmarks.get_Item
                       (ref objEndOfDocFlag).Range;
            table = document.Tables.Add(objWordRng, row, column,
                        ref objMiss, ref objMiss);

            table.Borders.Enable = 1;
        }

        public void Dispose()
        {
            document?.Close();
            application?.Quit();
            Release(paragraph);
            paragraph = null;
            Release(table);
            table = null;
            Release(document);
            document = null;
            Release(application);
            application = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public string? this[int row]
        {
            get => document?.Paragraphs[row].Range.Text.ToString();
            set
            {
                if (document != null)
                {
                    document.Paragraphs[row].Range.Text = value;
                    document.Paragraphs[row].Range.Font.Name = "Times New Roman";
                    document.Paragraphs[row].Range.Font.Size = 14;
                    document.Paragraphs.Add();
                }
            }
        }

        public string? this[int row, int column]
        {
            get => table!.Cell(row, column).Range.Text.ToString();
            set
            {
                if (table != null)
                {
                    table.Cell(row, column).Range.Font.Name = "Times New Roman";
                    table.Cell(row, column).Range.Font.Size = 12;
                    table.Cell(row, column).Range.Text = value;
                }
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