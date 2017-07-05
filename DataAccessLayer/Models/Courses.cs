using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Courses
    {
        private string _CourseId;
        private string _SubjectId;
        private int _Source;
        private string _CourseName;
        private string _Description;
        private string _Abstract;
        private int _CourseAudience;
        private string _courseDuration;
        private int _Level;
        private int _Rating;
        private int _RatingCount;
        private string _Author;
        private DateTime _CourseDate;

        public string CourseId
        {
            get
            {
                return _CourseId;
            }

            set
            {
                _CourseId = value;
            }
        }

        public string SubjectId
        {
            get
            {
                return _SubjectId;
            }

            set
            {
                _SubjectId = value;
            }
        }

        public int Source
        {
            get
            {
                return _Source;
            }

            set
            {
                _Source = value;
            }
        }

        public string CourseName
        {
            get
            {
                return _CourseName;
            }

            set
            {
                _CourseName = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        public string Abstract
        {
            get
            {
                return _Abstract;
            }

            set
            {
                _Abstract = value;
            }
        }

        public int CourseAudience
        {
            get
            {
                return _CourseAudience;
            }

            set
            {
                _CourseAudience = value;
            }
        }

        public string CourseDuration
        {
            get
            {
                return _courseDuration;
            }

            set
            {
                _courseDuration = value;
            }
        }

        public int Level
        {
            get
            {
                return _Level;
            }

            set
            {
                _Level = value;
            }
        }

        public int Rating
        {
            get
            {
                return _Rating;
            }

            set
            {
                _Rating = value;
            }
        }

        public int RatingCount
        {
            get
            {
                return _RatingCount;
            }

            set
            {
                _RatingCount = value;
            }
        }

        public string Author
        {
            get
            {
                return _Author;
            }

            set
            {
                _Author = value;
            }
        }

        public DateTime CourseDate
        {
            get
            {
                return _CourseDate;
            }

            set
            {
                _CourseDate = value;
            }
        }
    }
}
