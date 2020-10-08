using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 先物データ形式変換
{
	struct FutureData
	{
		/// <summary>
		/// データの開始時間
		/// </summary>
		private DateTime startTime;

		private Price opnePrice;
		private Price highPrice;
		private Price lowPrice;
		private Price closingPrice;
	}

	class 先物データ変換
	{
		List<FutureData> data = new List<FutureData>();

		/// <summary>
		/// 変換後先物データの時間間隔
		/// </summary>
		private static TimeSpan timeSpan;

		public 先物データ変換()
		{
		}

	}

	class 先物mini_15min : 先物データ変換
	{
		private static TimeSpan span = new TimeSpan(0,15,0);

		public 先物mini_15min(DateTime dateTime)
		{
			
		}
	}


	class Price
	{
		protected int price { get; set; }
	}

}
