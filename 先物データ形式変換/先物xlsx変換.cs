using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 先物データ形式変換
{
	class 先物xlsx変換
	{
		private static List<string> file_name = new List<string>();     //フォルダ内のxlsxファイルの名前リスト



		/// <summary>
		/// 指定したフォルダ内のxlsxファイルを探します。
		/// </summary>
		/// <param name="file_path"></param>
		/// <returns></returns>
		public static int フォルダ内検索(string file_path)
		{
			file_name.Clear();

			//フォルダ内にxlsxファイルがあるかを確認します。
			try
			{
				file_name.AddRange(Directory.GetFiles(file_path, "*.xlsx"));

				foreach (string name in file_name)
				{
					Console.WriteLine(name);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return 0;
			}

			return file_name.Count();
		}

		public static void 変換実行()
		{
			foreach (string name in file_name)
			{
				XlsxRead(name);
			}
			MessageBox.Show("完了");
		}

		private static void XlsxRead(string name)
        {
			System.Data.DataTable dtBefore = new System.Data.DataTable();
			System.Data.DataTable dtAfter = new System.Data.DataTable();
			DataRow dr = null;
			int lastRow = 0;
			int lastColumn = 0;

			try
			{
				using (XLWorkbook workbook = new XLWorkbook(name))
				{
					foreach (IXLWorksheet worksheet in workbook.Worksheets)
					{
						if (worksheet.Name.Equals("15min"))
						{
							//エクセルデータの行数、列数の取得
							lastRow = worksheet.RowsUsed().Count();
							lastColumn = worksheet.ColumnsUsed().Count();

							//行の追加(日と時が分かれた形式から合成)
							dtBefore.Columns.Add("日時");
							for (int columnCount=3; columnCount<=lastColumn; columnCount++)
                            {
								dtBefore.Columns.Add(worksheet.Cell(1,columnCount).Value.ToString());
								//Console.WriteLine(worksheet.Cell(1, columnCount).Value.ToString());
							}

							for(int row=2; row < lastRow - 1; row++)
                            {
								dr = dtBefore.NewRow();

								dr[0] = ConvertDateTime(worksheet.Cell(row, 1).Value.ToString(), worksheet.Cell(row, 2).Value.ToString());
								//Console.WriteLine(dr[0]);
								for (int col=3; col<=lastColumn; col++)
                                {
									dr[col - 3] = worksheet.Cell(row, col).Value;
									//Console.WriteLine(dr[col - 3]);
								}
								dtBefore.Rows.Add(dr);
							}
						}

						dtAfter.Columns.Add("日時");
						dtAfter.Columns.Add("SQ");
						dtAfter.Columns.Add("始値");
						dtAfter.Columns.Add("高値");
						dtAfter.Columns.Add("低値");
						dtAfter.Columns.Add("終値");
						


					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			finally
			{

			}
		}

		private static object ConvertDateTime(string date, string time)
        {
			date = date.Remove(10);	//「yyyy/MM/dd h(h):mm:ss」の形式から10文字目(「 」:スペース）以降を削除
			time = time.Remove(0, 10);  //「yyyy/MM/dd h(h):mm:ss」の形式から9文字目(「 」:スペース）より前を削除

			return date + time;
        }
	}


}
