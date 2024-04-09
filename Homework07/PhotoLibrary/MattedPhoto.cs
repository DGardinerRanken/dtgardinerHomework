using System;


namespace PhotoLibrary
{
    public class MattedPhoto : Photo
    {
        //Color Enumerator
      public enum Color
        {
            BLACK = 0,
            RED = 1,
            GREEN = 2,
            BLUE = 4,
            WHITE = 7
        }

        //Instance Variable
        private Color _theColor;

        //Full-arg Constructor
        public MattedPhoto(double width, double height,
                           Color theColor)
                          :base(width, height)
        {
            _theColor = theColor;
        }

        //Getter and Setter
        public Color TheColor
        {
            get
            {
                return _theColor;
            }
            set
            {
                _theColor = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Matted " + _theColor.ToString();
        }
    }
}
