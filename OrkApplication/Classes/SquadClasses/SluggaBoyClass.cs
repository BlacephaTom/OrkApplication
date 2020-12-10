using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrkApplication.Classes.OrkEventArgs;

using System.Collections;

namespace OrkApplication.Classes.SquadClasses
{
    public class SluggaBoyClass : IComparable, IComparable<SluggaBoyClass>
    {
        protected int BaseTenNumber;

        public string Name { get; set; }





        public int CompareTo(object obj)
        {

            // negative if instance is less than passed in value
            // 0 if equal
            // positive if greater than value
            SluggaBoyClass sluggaBoyClass = obj as SluggaBoyClass;
            if (sluggaBoyClass != null)
                return this.BaseTenNumber.CompareTo(sluggaBoyClass.BaseTenNumber);
            else
                throw new ArgumentException("Object passed through was not a Sluggs Boy");
        }

        public int CompareTo(SluggaBoyClass sluggaBoyClass)
        {
            // Compare this class with that of one passed in
            return this.CompareTo(sluggaBoyClass);
        }

    }
}
