using HandsOnLinq.Objects;

namespace HandsOnLinq
{
	public static class Tasks
	{
		//The implementation of your tasks should look like this:
		public static string TaskExample(IEnumerable<string> stringList)
		{
			return stringList.Aggregate((x, y) => x + y);
		}

		#region Low

		public static IEnumerable<string> Task1(char c, IEnumerable<string> stringList)
		{
			return stringList.Where(x => x.Length > 1 && x.StartsWith(c) && x.EndsWith(c));
		}

		public static IEnumerable<int> Task2(IEnumerable<string> stringList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<string> Task3(IEnumerable<string> stringList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<string> Task4(int k, IEnumerable<string> stringList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<string> Task5(IEnumerable<int> integerList)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region Middle

		public static IEnumerable<string> Task6(IEnumerable<int> numbers, IEnumerable<string> stringList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<int> Task7(int k, IEnumerable<int> integerList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<int> Task8(int k, int d, IEnumerable<int> integerList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<string> Task9(IEnumerable<string> stringList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<string> Task10(IEnumerable<string> stringList)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region Advance

		public static IEnumerable<YearSchoolStat> Task11(IEnumerable<Entrant> nameList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<NumberPair> Task12(IEnumerable<int> integerList1, IEnumerable<int> integerList2)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<YearSchoolStat> Task13(IEnumerable<Entrant> nameList, IEnumerable<int> yearList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<MaxDiscountOwner> Task14(IEnumerable<Supplier> supplierList,
				IEnumerable<SupplierDiscount> supplierDiscountList)
		{
			throw new NotImplementedException();
		}

		public static IEnumerable<CountryStat> Task15(IEnumerable<Good> goodList,
			IEnumerable<StorePrice> storePriceList)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
