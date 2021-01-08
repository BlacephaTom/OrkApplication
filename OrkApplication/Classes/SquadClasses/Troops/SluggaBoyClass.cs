using System;
using System.Collections.ObjectModel;
using OrkApplication.Structs;
using System.Linq;

using OrkApplication.Interfaces;

namespace OrkApplication.Classes.SquadClasses.Troops
{
    public class SluggaBoyzClass : BaseSquadClass, IComparable, IComparable<SluggaBoyzClass>, ISquadManagement
    {
        protected int BaseTenNumber;

        public string SquadLeaderType = "Slugga Boy Nob";
        public string SquadName = "Slugga Boyz";

        public ObservableCollection<SluggaBoy> SquadMembers = new ObservableCollection<SluggaBoy>();


        public SluggaBoyzClass()
        {
            delTooFewSquadMembers += (object sender, OrkEventArgs.TooFewSquadMembersEventArgs e) =>
            {
                MessageBoxWindow MsgBoxWindow = new MessageBoxWindow(OrkApplication.App.Current.MainWindow, e.Message);
            };
        }

        public int TotalSquadPoints
        {
            get
            {
                return SquadMembers.Sum(x => x.PointCost);
            }
        }


        public void AddNewSquadMember(int NumberOfSquadToAdd)
        {
            for (int i = 1; i <= NumberOfSquadToAdd; i++)
            {
                SquadMembers.Add(new SluggaBoy());
            }
        }


        


        //Compare to higher points cost troops
        public int CompareTo(object obj)
        {

            // negative if instance is less than passed in value
            // 0 if equal
            // positive if greater than value
            SluggaBoyzClass sluggaBoyClass = obj as SluggaBoyzClass;
            if (sluggaBoyClass != null)
                return this.BaseTenNumber.CompareTo(sluggaBoyClass.BaseTenNumber);
            else
                throw new ArgumentException("Object passed through was not a Sluggs Boy");
        }

        public int CompareTo(SluggaBoyzClass sluggaBoyClass)
        {
            // Compare this class with that of one passed in
            return this.CompareTo(sluggaBoyClass);
        } 
    }
}
