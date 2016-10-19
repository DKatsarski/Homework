using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWJSON.Contracts
{
    public interface IFileCreator
    {
        void ExtractFile(string url, string fileName);
    }
}
