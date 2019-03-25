using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace NicknameGenerator
{
    public class SourcePartFromFile : ISourcePart
    {
        private readonly List<string> strings;

        public SourcePartFromFile(string filepath)
        {
            if (!File.Exists(filepath))
                throw new FileNotFoundException();
            strings = File.ReadAllLines(filepath).ToList();            
        }

        public int Count()
        {
            return strings.Count;
        }

        public string Get(int index)
        {
            if (index < 0 || index >= strings.Count)
                throw new IndexOutOfRangeException();
            return strings[index];
        }

        public ReadOnlyCollection<string> List()
        {
            return new ReadOnlyCollection<string>(strings);
        }
    }
}
