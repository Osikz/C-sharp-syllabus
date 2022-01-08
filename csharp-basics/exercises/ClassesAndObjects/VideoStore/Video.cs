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
            _checkedOut = true;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _checkedOut = false;
        }

        public void BeingReturned()
        {
            _checkedOut = true;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);

        }

        public double AverageRating()
        {
            return Math.Round(_rating.Average(), 2);
        }

        public bool Available()
        {
            return _checkedOut;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"Title: {Title}     User Rating: {AverageRating()}     Available: {Available()}";
        }
    }
}
