using MOhammed_hebili.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOhammed_hebili.Class
{
    class ProductClass: IProduct
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Volume { get; set; }

        public string GetCode()
        {
            string firstThreeLetterOfBrand = Brand.Substring(0, 3).ToUpper();
            string firstThreeLetterOfName = Name.Substring(0, 3).ToUpper();
            string replaceUnderscore = Volume.Replace(" ", "_");
            return firstThreeLetterOfBrand + firstThreeLetterOfName + replaceUnderscore;
        }
    }
}
