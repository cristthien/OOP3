using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Table
{
    public class Table
    {
        private int _height, _width;

        public Table(int height, int width) {
            this._width = width;
            this._height = height;
        }
        public int Height { get { return _height; } set { _height = value; } }
        public int Width { get { return _width; } set { _width = value; } }
        public void ShowData() {

            Console.WriteLine("The table's height {0} and width {1}", _height,_width);
        }
    }
}
