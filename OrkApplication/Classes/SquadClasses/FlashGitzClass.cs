using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrkApplication.Classes.OrkEventArgs;

namespace OrkApplication.Classes.SquadClasses
{
    public class FlashGitzClass : BaseSquadClass
    {
        
        public FlashGitzClass(int OriginalSquadNumber)
        {
            CurrentSquadMembers = OriginalSquadNumber;
            MaximumSquadMembers = 5;
        }


        public override void AddSquadMember(int NumberOfSquadToAdd)
        {
            if (CurrentSquadMembers.WillSquadBeTooBig(CurrentSquadMembers, MaximumSquadMembers))
            {
                delTooManySquadMembers?.Invoke(this, new TooManySquadMembersEventArgs($"Flash Gitz can only have {MaximumSquadMembers} Gitz in it!"));
            }
        }

        public override void RemoveSquadMember(int NumberOfSquadToRemove)
        {
            if(CurrentSquadMembers.WillSquadBeTooSmall(CurrentSquadMembers, MinimumSquadMembers))
            {
                delTooFewSquadMembers?.Invoke(this, new TooFewSquadMembersEventArgs($"Slugga Boyz need at least {MinimumSquadMembers} Botz to crump hedz!"));
            }
        }
    }
}
