using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Houses
{
    public abstract class House
    {
        protected Image _img;
        protected int _square;
        protected int _cost;
        
        public abstract Image View();
    }
}
