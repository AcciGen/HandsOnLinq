namespace HandsOnLinq.Objects
{
	public class CountryStat
	{
		public string Country { get; set; } = default!;
		public int StoresNumber { get; set; }
		public decimal MinPrice { get; set; }
	}
}
