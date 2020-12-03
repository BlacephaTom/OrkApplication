using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrkApplication.Classes.OrkEventArgs;

namespace OrkApplication.Classes.SquadClasses
{
    public class SluggaBoyz : BaseSquadClass
    {
        
        public override void AddSquadMember(int NumberOfSquadToAdd)
        {
            if(NumberOfSquadToAdd.WillSquadBeTooBig(CurrentSquadMembers, MaximumSquadMembers))
            {
                delTooManySquadMembers?.Invoke(this, new TooManySquadMembersEventArgs($"Slugga Boyz can only have {MaximumSquadMembers} Boyz, iz that not good enuf for ya!?"));
            }
        }

        public override void RemoveSquadMember(int NumberOfSquadToRemove)
        {
            if(CurrentSquadMembers.WillSquadBeTooSmall(CurrentSquadMembers, MinimumSquadMembers))
            {
                delTooFewSquadMembers?.Invoke(this, new TooFewSquadMembersEventArgs($"You need at least {MinimumSquadMembers} Slugga Boyz to make this mob wurk!"));
            }
        }
    }
}
