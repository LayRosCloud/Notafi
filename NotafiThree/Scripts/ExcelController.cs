using NotafiThree.Model.DealData;
using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace NotafiThree.Scripts
{
    internal class ExcelController
    {
        private readonly Excel.Application _app = new Excel.Application();
        private readonly Excel.Workbook _workbook;
        private readonly Excel.Worksheet _worksheet;
        public ExcelController()
        {
            _workbook = _app.Workbooks.Add();
            _worksheet = _workbook.Worksheets.Add();

            Excel.Range range = _worksheet.Range[_worksheet.Cells[1, 1], _worksheet.Cells[1, 4]];
            range.Merge();
            _worksheet.Cells[1, 1] = "Сгенерированный отчет";
            _worksheet.Cells[2, 1] = "Дата отчета: ";
            _worksheet.Cells[2, 2] = DateTime.Now.ToLongDateString();

            _worksheet.Cells[3, 1] = "Время отчета: ";
            _worksheet.Cells[3, 2] = DateTime.Now.ToLongTimeString();
        }

        public void CreateList(IEnumerable<DealResult> deals)
        {
            Result result = new Result();
            var list = result.GetAllRows();

            int rowIndex = 5;

            _worksheet.Cells[rowIndex, 1] = "ФИО Сотрудника";
            _worksheet.Cells[rowIndex, 2] = "ФИО Заказчика";
            _worksheet.Cells[rowIndex, 3] = "Дата сделки";
            _worksheet.Cells[rowIndex, 4] = "Статус сделки";


            for (int i = 0; i < list.Count; i++)
            {
                result = list[i];
                rowIndex++;

                Excel.Range range = _worksheet.Range[_worksheet.Cells[rowIndex, 1], _worksheet.Cells[rowIndex, 4]];
                range.Merge();
                _worksheet.Cells[rowIndex, 1] = result.Name;
                foreach (var item in deals)
                {
                    if(item.Result.Id == result.Id)
                    {
                        rowIndex++;
                        _worksheet.Cells[rowIndex, 1] = item.Deal.Worker.Person.FullName;
                        _worksheet.Cells[rowIndex, 2] = item.Deal.Person.FullName;
                        _worksheet.Cells[rowIndex, 3] = item.Deal.Date.ToLongDateString();
                        _worksheet.Cells[rowIndex, 4] = item.Result.Name;
                    }
                }
            }
        }
        public void SaveAs()
        {
            _worksheet.SaveAs(@"C:\Users\Betrayal\Desktop\app\Notafi\test1.xlsx");
            _app.Quit();
        }
    }
}
