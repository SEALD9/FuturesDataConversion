using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 先物データ形式変換
{
	class 取引時間
	{
		public static setting_date 開始日 = new setting_date(new DateTime(2016, 7, 19, 0, 0, 0));
		public static setting_date 終了日 = new setting_date(new DateTime(1, 1, 1, 0, 0, 0));

		public static setting_time ザラ場_OP開始       = new setting_time(new DateTime(1, 1, 2, 8, 0, 0));
		public static setting_time ザラ場_OP終了       = new setting_time(new DateTime(1, 1, 2, 8, 45, 0));
		public static setting_time ザラ場_メイン開始   = new setting_time(new DateTime(1, 1, 2, 8, 45, 0));
		public static setting_time ザラ場_メイン終了   = new setting_time(new DateTime(1, 1, 2, 15, 10, 0));
		public static setting_time ザラ場_CL開始       = new setting_time(new DateTime(1, 1, 2, 15, 10, 0));
		public static setting_time ザラ場_CL終了       = new setting_time(new DateTime(1, 1, 2, 15, 5, 0));

		public static setting_time 夕場_OP開始         = new setting_time(new DateTime(1, 1, 2, 16, 15, 0));
		public static setting_time 夕場_OP終了         = new setting_time(new DateTime(1, 1, 2, 16, 30, 0));
		public static setting_time 夕場_メイン開始     = new setting_time(new DateTime(1, 1, 2, 16, 30, 0));
		public static setting_time 夕場_メイン終了     = new setting_time(new DateTime(1, 1, 2, 5, 25, 0));
		public static setting_time 夕場_CL開始         = new setting_time(new DateTime(1, 1, 2, 5, 25, 0));
		public static setting_time 夕場_CL終了         = new setting_time(new DateTime(1, 1, 2, 5, 30, 0));
	}

	/// <summary>
	/// 時間設定クラス
	/// </summary>
	class setting_time
	{
		public DateTime time{ get; }

		public setting_time(DateTime t)
		{
			time = t;
		}
	}

	/// <summary>
	/// 日付設定クラス
	/// </summary>
	class setting_date
	{
		public DateTime date { get; }

		public setting_date(DateTime d)
		{
			date = d;
		}
	}
}
