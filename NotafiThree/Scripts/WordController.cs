using NotafiThree.Model.DealData;
using System.Collections.Generic;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;

namespace NotafiThree.Scripts
{
	internal class WordController
	{
		private readonly Word.Application _application;
		private readonly Word.Document _document;
		
		public WordController()
		{
			_application = new Word.Application();
			_document = _application.Documents.Add();
		}

		public void AddParagraph(string text, string style = "Обычный")
		{
			var paragraph = _document.Paragraphs.Add();
			var range = paragraph.Range;
			range.Text = text;
			range.set_Style(style);
			range.InsertParagraphAfter();
		}

		public void CreateTable(List<DealService> services)
		{
			var paragraph = _document.Paragraphs.Add();
			var range = paragraph.Range;
			var table = _document.Tables.Add(range, services.Count + 1, 5);
			table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
			table.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

			Word.Range cellRange;
			cellRange = table.Cell(1, 1).Range;
			cellRange.Text = "Наименование";

			cellRange = table.Cell(1, 2).Range;
			cellRange.Text = "Количество";

			cellRange = table.Cell(1, 3).Range;
			cellRange.Text = "Скидка";

			cellRange = table.Cell(1, 4).Range;
			cellRange.Text = "Цена";

			cellRange = table.Cell(1, 5).Range;
			cellRange.Text = "Итого";

			table.Rows[1].Range.Bold = 1;
			table.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

			for(int i = 0; i < services.Count(); i++)
			{
				var service = services[i];
				cellRange = table.Cell(i + 2, 1).Range;
				cellRange.Text = service.Service.Title;

				cellRange = table.Cell(i + 2, 2).Range;
				cellRange.Text = service.Number.ToString();

				cellRange = table.Cell(i + 2, 3).Range;
				cellRange.Text = service.Service.Discount.Number.ToString();

				cellRange = table.Cell(i + 2, 4).Range;
				cellRange.Text = service.Service.Price.Number.ToString();

				cellRange = table.Cell(i + 2, 5).Range;
				cellRange.Text = $"{service.Service.PriceWithDiscount * service.Number}";
			}
		}

		public void SaveAsFile(string fullPath, bool isVisible = true)
		{
			_application.Visible = isVisible;
			_document.SaveAs2(fullPath);
		}
	}
}
