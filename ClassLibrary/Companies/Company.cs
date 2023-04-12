using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Houses;

namespace ClassLibrary.Companies
{
    public abstract class Company
    {
        protected string _name;

        public abstract House BuildHouse(Image img, int square, int cost);
    }
}
