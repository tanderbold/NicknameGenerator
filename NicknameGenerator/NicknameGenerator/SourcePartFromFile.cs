using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace NicknameGenerator
{
    /// <summary>
    /// Source for reading data from speciefed file
    /// </summary>
    public class SourcePartFromFile : ISourcePart
    {
        private readonly List<string> strings;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filepath">File path to the source data</param>
        public SourcePartFromFile(string filepath)
        {
            if (!File.Exists(filepath))
                throw new FileNotFoundException();
            strings = File.ReadAllLines(filepath).ToList();            
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
