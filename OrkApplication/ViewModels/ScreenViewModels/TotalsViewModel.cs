using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace OrkApplication.ViewModels.ScreenViewModels
{
    public class TotalsViewModel : BaseApplicationClasses.UpdateUIClass
    {

        public ObservableCollection<HQClass> HQColl { get; set; }
        public ObservableCollection<TroopClass> TroopColl { get; set; }

        public TotalsViewModel()
        {
            HQColl = new ObservableCollection<HQClass>() {
                new HQClass("Thrakka", 189),
                new HQClass("Boss", 45)
            };

            TroopColl = new ObservableCollection<TroopClass>() {
                new TroopClass("Slugga Boyz", 150),
                new TroopClass("Shoota Boyz", 130)
            };

        }







    }


    public class TroopClass
    {

        public TroopClass(string troopName, int troopPoints)
        {
            TroopName = troopName;
            TroopPoints = troopPoints;
        }

        public string TroopName { get; set; }
        public int TroopPoints { get; set; }
    }


    public class HQClass
    {
        public HQClass(string hQTitle, int hQPoints)
        {
            HQTitle = hQTitle;
            HQPoints = hQPoints;
        }
        public string HQTitle { get; set; }
        public int HQPoints { get; set; }
    }

}
