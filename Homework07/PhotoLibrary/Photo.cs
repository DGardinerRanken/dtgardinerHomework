using System;


namespace PhotoLibrary
{
    public class Photo
    {
        //Instance Variables
        private double _width;
        private double _height;

        //Full-arg Constructor
        public Photo(double width, double height)
        {
            _width = width;
            _height = height;
        }

        //Getters and Setters

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public override string ToString()
        {
            return (Width + " x " + Height);
        }
    }
};
