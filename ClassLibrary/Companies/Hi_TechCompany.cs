using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Houses;

namespace ClassLibrary.Companies
{
    public class Hi_TechCompany : Company
    {
        public Hi_TechCompany(string name)
        {
            _name = name;
        }

        public override House BuildHouse(Image img, int square, int cost)
        {
            return new Hi_TechHouse(img, square, cost);
        }
    }
}
