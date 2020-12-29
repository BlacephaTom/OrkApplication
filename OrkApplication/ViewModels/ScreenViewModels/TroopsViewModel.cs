using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrkApplication.Classes.SquadClasses;
using OrkApplication.BaseApplicationClasses;
using OrkApplication.Interfaces;

namespace OrkApplication.ViewModels.ScreenViewModels
{
    public class TroopsViewModel
    {
        public CommandClass AddTroopToArmyICmd => new CommandClass(AddTroopToArmy);
        private SluggaBoyzClass _SluggaboyzClass = new SluggaBoyzClass();

        public List<string> ListOfTroops
        {
            get
            {
                return new List<string>()
                {
                    { "Slugga Boyz" },
                    { "Shoota Boyz" }
                };
            }
        }

        public string SelectedTroop { get; set; }
        public int SquadNumbersToAdd { get; set; }


        public void AddTroopToArmy()
        {
            _SluggaboyzClass.AddNewSquadMember(SquadNumbersToAdd);
        }
    }
}
