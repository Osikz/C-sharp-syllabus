using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _checkedOut;
        private List<double> _rating;

        public Video(string title)
        {
            _title = title;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        { 
            _checkedOut = true;
        }

        public void BeingReturned()
        {
            _checkedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);

        }

        public double AverageRating()
        {
            return _rating.Any() ? _rating.Average() : _rating.FirstOrDefault();
        }

        public bool Available()
        {
            return _checkedOut;
        }

        public string Title => "";

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
