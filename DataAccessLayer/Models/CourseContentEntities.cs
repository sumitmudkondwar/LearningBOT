using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class CourseContentEntities
    {
        private string _CourseContentEntityId;
        private string _ModuleId;
        private string _Name;
        private string _Duration;
        private string _Uri;
        private int _Order;
        private int _Style;

        public string CourseContentEntityId
        {
            get
            {
                return _CourseContentEntityId;
            }

            set
            {
                _CourseContentEntityId = value;
            }
        }

        public string ModuleId
        {
            get
            {
                return _ModuleId;
            }

            set
            {
                _ModuleId = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string Duration
        {
            get
            {
                return _Duration;
            }

            set
            {
                _Duration = value;
            }
        }

        public string Uri
        {
            get
            {
                return _Uri;
            }

            set
            {
                _Uri = value;
            }
        }

        public int Order
        {
            get
            {
                return _Order;
            }

            set
            {
                _Order = value;
            }
        }

        public int Style
        {
            get
            {
                return _Style;
            }

            set
            {
                _Style = value;
            }
        }
    }
}
