using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.IO.Executor
{
    public interface IDirectoryCreator
    {
        void CreateDirectoryInCurrentFolder(string name);
    }
}
