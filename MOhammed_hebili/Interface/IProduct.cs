using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOhammed_hebili.Interface
{
    public interface IProduct
    {
        string Brand { get; set; }
        string Name { get; set; }
        string Volume { get; set; }
        string GetCode();
    }
}
