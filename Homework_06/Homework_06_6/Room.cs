using System;

namespace Homework_06_6
{
    public class Room
    {
        //Instance Variables
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;

        //Full-arg Constructor
        public Room(string name, int width, int length, int area, int boxes)
        {
            _name = name;
            _width = width;
            _length = length;
            _area = area;
            _boxes = boxes;
        }

        //Getters
        public string GetName()
        {
            return _name;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetLength()
        {
            return _length;
        }

        public int GetArea()
        {
            return _area;
        }

        public int GetBoxes()
        {
            return _boxes;
        }
    }
}
