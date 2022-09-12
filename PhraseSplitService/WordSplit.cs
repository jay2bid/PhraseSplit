using System;
namespace PhraseSplitService
{
	public class PhraseSplit
	{
		public string[] pharaseplitconverter(string phrase)

		{
			string[] splitphrase = phrase.Split(" ");
			return splitphrase;

		}


		public PhraseSplit()
		{
		}
	}
}

