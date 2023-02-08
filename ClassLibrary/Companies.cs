using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Company
    {
        protected string _name;

        public abstract House BuildHouse(Image img, int square, int cost);
    }

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

    public class BaroqueCompany : Company
    {
        public BaroqueCompany(string name)
        {
            _name = name;
        }

        public override House BuildHouse(Image img, int square, int cost)
        {
            return new BaroqueHouse(img, square, cost);
        }
    }

    public class ModernCompany : Company
    {
        public ModernCompany(string name)
        {
            _name = name;
        }

        public override House BuildHouse(Image img, int square, int cost)
        {
            return new ModernHouse(img, square, cost);
        }
    }

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
