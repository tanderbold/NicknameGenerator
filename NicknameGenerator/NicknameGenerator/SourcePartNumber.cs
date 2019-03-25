using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace NicknameGenerator
{
    public class SourcePartNumber : ISourcePart
    {
        private int max;
        public SourcePartNumber(int max)
        {
            this.max = max;
        }
        public int Count()
        {
            return max;
        }

        public string Get(int index)
        {
            if (index < 0 || index > max)
                throw new IndexOutOfRangeException();
            return (index + 1).ToString();
        }

        public ReadOnlyCollection<string> List()
        {
            return new ReadOnlyCollection<string>(Enumerable.Range(1, max).Select(el => el.ToString()).ToList());
        }
    }
}
