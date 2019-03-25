using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NicknameGenerator
{
    public interface ISourcePart
    {
        ReadOnlyCollection<string> List();
        int Count();
        string Get(int index);
    }
}
