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
                // Custom file
                { TypeOfPart.Adjective, new SourcePartFromFile("Adjectives.txt") },
                // Default values
                { TypeOfPart.Noun, new SourcePartDefault(TypeOfPart.Noun) },
                // Numbers
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
