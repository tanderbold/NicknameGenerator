using Microsoft.VisualStudio.TestTools.UnitTesting;
using NicknameGenerator;
using System;
using System.Collections.Generic;

namespace TestNicknameGenerator
{
    [TestClass]
    public class TestGenerator
    {
        [TestMethod]
        public void TestGenerate()
        {
            Dictionary<TypeOfPart, ISourcePart> sources = new Dictionary<TypeOfPart, ISourcePart>()
            {
                { TypeOfPart.Adjective, new SourcePartFromFile("Adjectives.txt") },
                { TypeOfPart.Noun, new SourcePartFromFile("Nouns.txt") },
                { TypeOfPart.Number, new SourcePartNumber(1000) }
            };

            List<Part> parts = new List<Part>()
            {
                new Part() { Type = TypeOfPart.Adjective, Format = FormatDescriptor.FirstUppercase },
                new Part() { Type = TypeOfPart.Noun, Format = FormatDescriptor.FirstUppercase },
                new Part() { Type = TypeOfPart.Number, Format = FormatDescriptor.FirstUppercase }
            };

            IGenerator generator = new Generator(parts, sources);
            var firstnick = generator.Generate();
            var secondnick = generator.Generate();
            var thirdnick = generator.Generate();
        }
    }
}
