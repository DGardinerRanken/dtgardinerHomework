using System;


namespace PhotoLibrary
{
    public class FramedPhoto : Photo
    {
        //Material Enumerator
        public enum Material
        {
            PINE   = 0, 
            OAK    = 1,
            STEEL  = 2,
            SILVER = 3,
            GOLD   = 4         
        }

        //Style Enumerator
        public enum Style
        {
            SIMPLE = 0,
            MODERN = 1,
            ANTIQUE = 2,
            VINTAGE = 3,
            ECLECTIC = 4
        }

        //Instance Variables

        private Material _theMaterial;
        private Style    _theStyle;

        //Full-arg Constructor

        public FramedPhoto(Double width, double height, Material theMaterial, Style theStyle)
                           :base (width, height)
        {
            _theMaterial = theMaterial;
            _theStyle = theStyle;
        }

        //Getters and Setters

        public Material TheMaterial
        {
            get
            {
                return _theMaterial;
            }
            set
            {
                _theMaterial = value;
            }
        }

        public Style TheStyle
        {
            get
            {
                return _theStyle;
            }
            set
            {
                _theStyle = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Framed " + TheMaterial.ToString() + 
                   " " + TheStyle;
        }
    }
}
