using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace NicknameGenerator
{
    /// <summary>
    /// Source for integer numbers
    /// </summary>
    public class SourcePartNumber : ISourcePart
    {
        private int max;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="max">Maximal integer of source</param>
        public SourcePartNumber(int max)
        {
            this.max = max;
        }
        /// <summary>
        /// Count of elements of the source
        /// </summary>
        /// <returns>Count of elements</returns>
        public int Count()
        {
            return max;
        }
        /// <summary>
        /// Get element of the source by index
        /// </summary>
        /// <param name="index">Index of element</param>
        /// <returns>Value from source with index</returns>
        public string Get(int index)
        {
            if (index < 0 || index > max)
                throw new IndexOutOfRangeException();
            return (index + 1).ToString();
        }
        /// <summary>
        /// Collection of elements of the source
        /// </summary>
        /// <returns>Collection of elements</returns>
        public ReadOnlyCollection<string> List()
        {
            return new ReadOnlyCollection<string>(Enumerable.Range(1, max).Select(el => el.ToString()).ToList());
        }
    }
}
