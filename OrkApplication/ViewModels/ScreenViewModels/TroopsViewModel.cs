using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrkApplication.Classes;
using OrkApplication.BaseApplicationClasses;

namespace OrkApplication.ViewModels.ScreenViewModels
{
    public class TroopsViewModel
    {
        public CommandClass AddTroopToArmyICmd => new CommandClass(AddTroopToArmy);


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

        private string A;
        public string SelectedTroop { get; set; }


        public void AddTroopToArmy()
        {


        }
    }
}
