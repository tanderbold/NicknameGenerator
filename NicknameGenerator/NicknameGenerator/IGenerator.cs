﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NicknameGenerator
{
    /// <summary>
    /// Methods of generator
    /// </summary>
    public interface IGenerator
    {
        /// <summary>
        /// Method for generating nickname
        /// </summary>
        /// <returns>nickname</returns>
        string Generate();
    }
}
