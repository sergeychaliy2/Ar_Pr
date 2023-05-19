using System;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;       
using System.IO;
using UnityEngine;
using Excel = Microsoft.Office.Interop.Excel;
namespace ExampleAssets.Scripts
{
    class ExcelHelper : IDisposable
    {
        private Application _excel;
        private Workbook _workbook;
        private string _filePatch;
        public ExcelHelper()
        {
            _excel = new Excel.Application();
        }

        internal bool Open(string filepatch)
        {
            try
            {
                if (File.Exists(filepatch))
                {
                    _workbook = _excel.Workbooks.Open(filepatch);
                }
                else
                {
                    _workbook = _excel.Workbooks.Add();
                    _filePatch = filepatch;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        internal void Save()
        {
            if (!string.IsNullOrEmpty(_filePatch))
            {
                _workbook.SaveAs(_filePatch);
                _filePatch = null;
            }
            else
            {
                _workbook.Save();
            }
        }

        internal bool Set(string column, int row, object data)
        {
            try
            {
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column] = data;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public void Dispose()
        {
            try
            {
                _workbook.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}