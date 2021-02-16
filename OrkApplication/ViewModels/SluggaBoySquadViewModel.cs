using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.CompilerServices;

using OrkApplication.Classes.OrkClasses;
using OrkApplication.Classes.SquadClasses;
using OrkApplication.BaseApplicationClasses;

using System.Collections;

namespace OrkApplication.ViewModels
{
    public class SluggaBoySquadViewModel : BaseSquadClass
    {
        
        public SluggaBoySquadViewModel()
        {
            MaximumSquadMembers = 30;
            MinimumSquadMembers = 10;

            // check list of Orks
            CurrentSquadMembers = 0;
        }

        //private List<SluggaBoyzClass> _SluggaBoySquad;
        //public List<SluggaBoyzClass> SluggaBoySquad
        //{
        //    get { return _SluggaBoySquad; }
        //    set
        //    {
        //        _SluggaBoySquad = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public SluggaBoyzClass this[string Name]
        //{
        //    get { return SluggaBoySquad.Where(Ork => Ork.Name == Name).FirstOrDefault(); }
        //    set { /* set the specified index to value here */ }
        //}
    }
}
