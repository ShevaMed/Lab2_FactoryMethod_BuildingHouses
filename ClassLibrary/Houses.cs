using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class House
    {
        protected Image _img;
        protected int _square;
        protected int _cost;
        
        public abstract Image View();
    }

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

    public class BaroqueHouse : House
    {
        public BaroqueHouse(Image img, int square, int cost)
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

    public class ModernHouse : House
    {
        public ModernHouse(Image img, int square, int cost)
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

    public class Hi_TechHouse : House
    {
        public Hi_TechHouse(Image img, int square, int cost)
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
