using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrkApplication.Classes.SquadClasses;
using OrkApplication.Classes.SquadClasses.Troops;
using OrkApplication.BaseApplicationClasses;
using OrkApplication.Interfaces;

namespace OrkApplication.ViewModels.ScreenViewModels
{
    public class TroopsViewModel : BaseSquadClass
    {
        public CommandClass AddTroopToArmyICmd => new CommandClass(AddTroopToArmy);
        private SluggaBoyzClass _SluggaboyzClass = new SluggaBoyzClass();

        public Dictionary<string, string> TroopHierarchyDict = new Dictionary<string, string>()
        {
            // TODO Get values from Slugga boy class
            { "Slugga Boyz", "Slugga Boy Nob" },
            { "Burna Boyz", "Mek" }
        };

        //public List<Type> TroopClasses = new List<Type>()
        //{
        //    SluggaBoyzClass,
        //    new ShootaBoyClass()
        //};

        public List<string> ListOfTroops
        {
            get
            {
                return TroopHierarchyDict.Keys.ToList();
            }
        }

        public List<string> ListOfTroopLeaders
        {
            get
            {
                return TroopHierarchyDict.Values.ToList();
            }
        }

        private string _SelectedTroop;
        public string SelectedTroop
        {
            get
            {
                return _SelectedTroop;
            }
            set
            {
                if (_SelectedTroop != value)
                {
                    _SelectedTroop = value;
                    if (TroopHierarchyDict.ContainsKey(_SelectedTroop))
                        TroopLeaderType = TroopHierarchyDict[_SelectedTroop];

                    OnPropertyChanged();
                }
            }
        }

        private string _TroopLeaderType;
        public string TroopLeaderType
        {
            get
            {
                return _TroopLeaderType;
            }
            set
            {
                _TroopLeaderType = value;
                OnPropertyChanged();
            }
        }


        public int SquadNumbersToAdd { get; set; }


        public void AddTroopToArmy()
        {
            _SluggaboyzClass.AddNewSquadMember(SquadNumbersToAdd);
        }
    }
}
