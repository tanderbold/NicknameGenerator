using System;
using System.Collections.Generic;
using System.Text;

namespace NicknameGenerator
{
    /// <summary>
    /// Format descriptor of part of nickname
    /// </summary>
    public enum FormatDescriptor
    {
        /// <summary>
        /// Nickname
        /// </summary>
        FirstUppercase = 0,
        /// <summary>
        /// NICKNAME
        /// </summary>
        AllUppercase = 1,
        /// <summary>
        /// nickname
        /// </summary>
        AllLowercase = 2,
        /// <summary>
        /// nICKNAME
        /// </summary>
        FirstLowercase = 3
    }
}
