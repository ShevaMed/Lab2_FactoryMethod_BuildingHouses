using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Houses;

namespace ClassLibrary.Companies
{
    public class ClassicCompany : Company
    {
        public ClassicCompany(string name)
        {
            _name = name;
        }

        public override House BuildHouse(Image img, int square, int cost)
        {
            return new ClassicHouse(img, square, cost);
        }
    }
}
