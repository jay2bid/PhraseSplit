using System;
using FluentAssertions;

namespace PhraseSplitService.Tests
{
	public class WordSplitTests
	{
        private PhraseSplit _phraseSplit;

        [SetUp]
        public void Setup()
        {
            _phraseSplit = new PhraseSplit();
        }

        [Test]
        public void Word_Split_Should_Return_Array_with_3_elements()
        {
            string[] splitphrase = { "how", "are", "you" };
            string phrase = "how are you";
            _phraseSplit.pharaseplitconverter("how are you").Should().BeEquivalentTo(splitphrase);
        }


        
	}
}

