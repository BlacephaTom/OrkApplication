using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrkApplication.Classes.SquadClasses;
using OrkApplication.Classes.SquadClasses.Troops;
using OrkApplication.BaseApplicationClasses;
using OrkApplication.Interfaces;

using MoreLinq;

namespace OrkApplication.ViewModels.ScreenViewModels
{
    public class TroopsViewModel : UpdateUIClass
    {
        public CommandClass AddTroopToArmyICmd => new CommandClass(AddTroopToArmy);

       //public List<SquadMembers<Structs.SluggaBoy>> EachMember = new List<SquadMembers<Structs.SluggaBoy>>();

        public List<Structs.SluggaBoy> SquadMembers = new List<Structs.SluggaBoy>();
       //public int TotalOfEachSquadToAdd { get; set; }
        public int SquadNumbersToAdd { get; set; }


        public TroopsViewModel()
        {




        }




        private void AddTroopToArmy()
        {
            for(int i = 1; i <= SquadNumbersToAdd; i ++)
            {
                SquadMembers.Add(new Structs.SluggaBoy());
            }
        }

        public int ReturnTotalTroopPoints
        {
            get
            {
                System.Windows.MessageBox.Show($"worth {SquadMembers.Sum(x => x.PointsPerModel)} points");
                if (SquadMembers.Any())
                    return SquadMembers.Sum(x => x.PointsPerModel); //SquadMembers.Count() * (int)SquadMembers.Select(x => x.PointsPerModel).FirstOrDefault();
                else
                    return 0;
            }
        }

        







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

       
    }
}
