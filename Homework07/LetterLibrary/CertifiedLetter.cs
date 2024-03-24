using System;


namespace LetterLibrary
{
    public class CertifiedLetter : Letter
    {
        //Instance Variables

        string _trackingNumber;

        //Full-arg Constructor 

        public CertifiedLetter(string recipient, DateTime sentDate, string trackingNumber)
                                : base(recipient, sentDate)
        {
            _trackingNumber = trackingNumber;
        }

        //Getter
        public string TrackingNumber
        {
            get
            {
                return _trackingNumber;
            }
        }

        public override double Price
        {
            get
            {
                return 0.65;
            }
        }

        public override string ToString()
        {
            return SentDate.ToString("ddMMMyyyy") + ", " + 
                                    Recipient + ", " + 
                                    Price.ToString("c") + ", " +
                                    TrackingNumber;
        }
    }
}
