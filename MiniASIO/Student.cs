using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniASIO
{
    public class Student
    {
        #region PROPERTIES
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string AsioID { get; set; }
        public string Group { get; set; }

        #endregion
        #region CONSTRUCTORS
        public Student()
        {

        }
        public Student(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        public Student(string firstname, string lastname, string asioid): this(firstname, lastname)
        {
            AsioID = asioid;
        }
        public Student(string firstname, string lastname, string asioid, string group) : this(firstname, lastname, asioid)
        {
            Group = group;
        }

        #endregion
        #region METHODS
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Firstname, Lastname, AsioID, Group);
        }
        #endregion

    }
}
