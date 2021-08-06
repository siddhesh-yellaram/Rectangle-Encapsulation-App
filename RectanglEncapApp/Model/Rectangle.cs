using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglEncapApp.Model
{
    class Rectangle
    {
        private int _height;
        private int _width;
        private BorderStyle _border = BorderStyle.SOLID;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public Rectangle(int width, int height, BorderStyle border)
        {
            _width = width;
            _height = height;
            _border = border;
        }

        public int getHeight()
        {
            return _height;
        }

        public int getWidth()
        {
            return _width;
        }

        public BorderStyle getBorder()
        {
            return _border;
        }

        public void setBorder(BorderStyle border)
        {
            _border = border;
        }

        public int calculateArea()
        {
            return _width * _height;
        }
    }
}
