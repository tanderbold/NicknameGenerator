using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NicknameGenerator
{
    /// <summary>
    /// Methods of the data source
    /// </summary>
    public interface ISourcePart
    {
        /// <summary>
        /// Collection of elements of the source
        /// </summary>
        /// <returns>Collection of elements</returns>
        ReadOnlyCollection<string> List();
        /// <summary>
        /// Count of elements of the source
        /// </summary>
        /// <returns>Count of elements</returns>
        int Count();
        /// <summary>
        /// Get element of the source by index
        /// </summary>
        /// <param name="index">Index of element</param>
        /// <returns>Value from source with index</returns>
        string Get(int index);
    }
}
