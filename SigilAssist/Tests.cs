using System;
using NUnit.Framework;

namespace SigilAssist
{
    [TestFixture]
    public class Tests
    {
        [TestCase("Good morning")]
        public void CompressText(string uncompressedSigil)
        {
            var subject = new SigilBuilder();
            var compressedSigil = subject.GetCompressedText(uncompressedSigil);
            
            Assert.NotNull(compressedSigil);
        }
    }
}