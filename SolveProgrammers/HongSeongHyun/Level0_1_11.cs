using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveProgrammers.HongSeongHyun
{
	internal class Level0_1_11
	{
		public double solution(int[] numbers)
		{

			double length = numbers.Length;
			double sum = 0;
			for (int i = 0; i < numbers.Length; i++)
			{

				sum += numbers[i];
			}
			double result = sum / length;

			return result;
		}
	}
}
