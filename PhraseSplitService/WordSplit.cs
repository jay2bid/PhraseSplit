using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PhraseSplitService
{
	public class PhraseSplit
	{
		public string[] pharaseplitconverter(string phrase)

		{
			string[] splitphrase = phrase.Split(" ");
			string[] sortedphrase = splitphrase.OrderBy(splitword => splitword[splitword.Length - 1]).ToArray();

            return sortedphrase;

		}


		public PhraseSplit()
		{
		}
	}
}

