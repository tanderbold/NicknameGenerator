using System;
using System.Collections.Generic;
using System.Text;

namespace NicknameGenerator
{
    /// <summary>
    /// Description of part of your nickname
    /// </summary>
    public class Part
    {
        /// <summary>
        /// Type of part (adjective, noun, number)
        /// </summary>
        public TypeOfPart Type { get; set; }
        /// <summary>
        /// Format of part (uppercase, lowercase)
        /// </summary>
        public FormatDescriptor Format { get; set; }
    }
}
