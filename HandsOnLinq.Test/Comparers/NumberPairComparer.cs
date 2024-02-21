﻿using HandsOnLinq.Objects;

namespace HandsOnLinq.Test.Comparers
{
	class NumberPairComparer : IEqualityComparer<NumberPair>
	{
		public bool Equals(NumberPair? x, NumberPair? y)
		{
			if (x == null && y == null)
				return true;
			if (x == null || y == null)
				return false;
			return x.Item1 == y.Item1 && x.Item2 == y.Item2;
		}

		public int GetHashCode(NumberPair obj)
		{
			return obj.GetHashCode();
		}
	}
}
