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
        public void Phrase_Split_Should_Return_Array_with_3_elements()
        {
            string[] splitphrase = { "how", "are", "you" };
            _phraseSplit.pharaseplitconverter("how are you").Should().BeEquivalentTo(splitphrase);
        }
        [Test]
        public void Phrase_Split_Should_Return_A_Split_Phrase()
        {
            string[] splitphrase = { "how", "are", "you"};
            _phraseSplit.pharaseplitconverter("how are you").Should().BeEquivalentTo(splitphrase);
        }
        [Test]
        public void Phrase_Split_Should_Return_A_Split_Phrase_In_Last_Letter_Order()
        {
            string[] splitphrase = { "are", "you", "how" };
            _phraseSplit.pharaseplitconverter("how are you").Should().ContainInOrder(splitphrase);
        }




    }
}

