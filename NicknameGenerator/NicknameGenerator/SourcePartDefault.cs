using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicknameGenerator
{
    /// <summary>
    /// Default Source for part (Adjectives and Nouns accepted)
    /// </summary>
    public class SourcePartDefault : ISourcePart
    {
        private readonly List<string> strings;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type">Type of part that you need</param>
        public SourcePartDefault(TypeOfPart type)
        {
            if(type == TypeOfPart.Adjective)
                strings = Resources.Adjectives.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)?.ToList();
            else if (type == TypeOfPart.Noun)
                strings = Resources.Nouns.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)?.ToList();
        }
        /// <summary>
        /// Count of elements of the source
        /// </summary>
        /// <returns>Count of elements</returns>
        public int Count()
        {
            return strings.Count;
        }
        /// <summary>
        /// Get element of the source by index
        /// </summary>
        /// <param name="index">Index of element</param>
        /// <returns>Value from source with index</returns>
        public string Get(int index)
        {
            if (index < 0 || index >= strings.Count)
                throw new IndexOutOfRangeException();
            return strings[index];
        }
        /// <summary>
        /// Collection of elements of the source
        /// </summary>
        /// <returns>Collection of elements</returns>
        public ReadOnlyCollection<string> List()
        {
            return new ReadOnlyCollection<string>(strings);
        }
    }
}
