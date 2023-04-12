using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Houses
{
    public class ClassicHouse : House
    {
        public ClassicHouse(Image img, int square, int cost)
        {
            _img = img;
            _square = square;
            _cost = cost;
        }

        public override Image View()
        {
            return _img;
        }
    }
}
