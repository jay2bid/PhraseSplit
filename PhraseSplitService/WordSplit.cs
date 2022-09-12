using System;
using System.Linq;
namespace PhraseSplitService
{
	public class PhraseSplit
	{
		public string[] pharaseplitconverter(string phrase)

		{
			string[] splitphrase = phrase.Split(" ");
			string[] sortedphrase = splitphrase.OrderBy(splitphrase => splitphrase[splitphrase.Length - 1]).ToArray();

            return sortedphrase;

		}


		public PhraseSplit()
		{
		}
	}
}

