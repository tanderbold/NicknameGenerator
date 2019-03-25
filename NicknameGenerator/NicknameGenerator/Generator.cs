using System;
using System.Collections.Generic;
using System.Text;

namespace NicknameGenerator
{
    public class Generator: IGenerator
    {
        private readonly Dictionary<TypeOfPart, ISourcePart> sources;
        private readonly List<Part> parts;
        private Random random;

        public Generator(List<Part> parts, Dictionary<TypeOfPart, ISourcePart> sources)
        {
            this.parts = parts;
            this.sources = sources;
            random = new Random();
        }

        public string Generate()
        {
            StringBuilder nickname = new StringBuilder();
            foreach(var part in parts)
            {
                var source = sources[part.Type];
                nickname.Append(Formatter.Format(source.Get(random.Next(source.Count())), part.Format));
            }
            return nickname.ToString();
        }
    }
}
