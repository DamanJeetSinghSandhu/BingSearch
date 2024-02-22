using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Service
{
    public interface ICSVStreamer 
    {
        List<string[]> GetCsvFromFile();
    }
}
