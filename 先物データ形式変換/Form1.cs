using System;
using System.Reflection;
using System.Windows.Forms;

namespace 先物データ形式変換
{
    public partial class Form1 : Form
    {
		取引時間 now_time = new 取引時間();

		public Form1()
		{
			InitializeComponent();
			TxtBox_フォルダ選択.Text = GetExeFolder() + "\\先物データ\\先物mini";
		}

        /// <summary>
        /// 生成されたexeファイルの置かれているフォルダパスを取得します。
        /// </summary>
        /// <returns></returns>
		private string GetExeFolder()
        {
            int num;
            string pass;
            
            num = Assembly.GetEntryAssembly().Location.LastIndexOf("\\");
            pass = Assembly.GetEntryAssembly().Location.Remove(num);

            return pass;
        }

		private void Btn_フォルダ選択_Click(object sender, EventArgs e)
		{
			#region フォルダブラウザダイアログの初期設定
			FBD_先物データフォルダ.Description = "フォルダを選択してください。";
			FBD_先物データフォルダ.RootFolder = Environment.SpecialFolder.Desktop;
			FBD_先物データフォルダ.SelectedPath = TxtBox_フォルダ選択.Text;
			FBD_先物データフォルダ.ShowNewFolderButton = true;
			#endregion
			if (FBD_先物データフォルダ.ShowDialog(this) == DialogResult.OK)
			{
				this.TxtBox_フォルダ選択.Text = FBD_先物データフォルダ.SelectedPath;
			}
		}

		private void Btn_変換実行_Click(object sender, EventArgs e)
		{
			//指定のフォルダにxlsxファイルがなかった時にエラーを表示
			if (先物xlsx変換.フォルダ内検索(TxtBox_フォルダ選択.Text) == 0)
			{
				MessageBox.Show("指定のフォルダにxlsxファイルが見つかりません",
								"エラー",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}

			先物xlsx変換.変換実行();
		}
    }
}
