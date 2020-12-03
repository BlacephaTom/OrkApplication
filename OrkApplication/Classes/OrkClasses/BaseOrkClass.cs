using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkApplication.Classes.OrkClasses
{
    public class BaseOrkClass
    {

        public BaseOrkClass(string orkName)
        {
            OrkName = orkName;
        }
        public string OrkName { get; set; }


        
        public enum Faction
        {
            Goffs,
            Freebooters,
            BadMoons,
            DeathSkulls,
            EvilSunz
        }
    }
}
