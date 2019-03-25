using System;
using System.Collections.Generic;
using System.Text;

namespace NicknameGenerator
{
    /// <summary>
    /// Main class for generating
    /// </summary>
    public class Generator: IGenerator
    {
        private readonly Dictionary<TypeOfPart, ISourcePart> sources;
        private readonly List<Part> parts;
        private Random random;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parts">Parts of nickname that you want in needed orer</param>
        /// <param name="sources">Sources of data for parts</param>
        public Generator(List<Part> parts, Dictionary<TypeOfPart, ISourcePart> sources)
        {
            this.parts = parts;
            this.sources = sources;
            random = new Random();
        }

        /// <summary>
        /// Method for generating nickname
        /// </summary>
        /// <returns>nickname</returns>
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
