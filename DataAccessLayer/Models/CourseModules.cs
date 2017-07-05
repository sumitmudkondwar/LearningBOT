using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class CourseModules
    {
        private string _ModuleId;
        private string _ModuleName;
        private string _Description;
        private string _Abstract;
        private string _Details;
        private string _CourseId;
        private int _Level;
        private int _Style;
        private string _Duration;
        private DateTime _LastUpdated;
        private int _Order;

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

        public string ModuleName
        {
            get
            {
                return _ModuleName;
            }

            set
            {
                _ModuleName = value;
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

        public string Details
        {
            get
            {
                return _Details;
            }

            set
            {
                _Details = value;
            }
        }

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

        public DateTime LastUpdated
        {
            get
            {
                return _LastUpdated;
            }

            set
            {
                _LastUpdated = value;
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
    }
}
