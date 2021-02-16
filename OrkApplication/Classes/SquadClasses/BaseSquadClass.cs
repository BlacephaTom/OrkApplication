using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrkApplication.Classes.OrkEventArgs;

using OrkApplication.BaseApplicationClasses;

using System.ComponentModel;

namespace OrkApplication.Classes.SquadClasses
{
    public class BaseSquadClass
    {
        public delegate void TooManySquadMembers(object sender, TooManySquadMembersEventArgs e);
        public TooManySquadMembers delTooManySquadMembers;

        public delegate void TooFewSquadMembers(object sender, TooFewSquadMembersEventArgs e);
        public TooFewSquadMembers delTooFewSquadMembers;

        protected int MaximumSquadMembers { get; set; }
        public int CurrentSquadMembers { get; set; }
        public int MinimumSquadMembers { get; set; }


        // TODO probably move this as doesn't belong here
        public virtual void AddSquadMember(int NumberOfSquadToAdd)
        {
            if (NumberOfSquadToAdd.WillSquadBeTooBig(CurrentSquadMembers, MaximumSquadMembers))
            {
                delTooManySquadMembers?.Invoke(this, new TooManySquadMembersEventArgs($"This squad can only have {MaximumSquadMembers} Orks!"));
            }
        }

        // TODO probably move this as doesn't belong here
        public virtual void RemoveSquadMember(int NumberOfSquadToRemove)
        {
            if(CurrentSquadMembers - NumberOfSquadToRemove < 0)
            {
                delTooFewSquadMembers?.Invoke(this, new TooFewSquadMembersEventArgs($"This squad must have at least {MinimumSquadMembers} Orks in it!"));
            }
        }
    }

    static class ExtensionHelpers
    {
        public static bool WillSquadBeTooBig(this int NumberOfSquadToAdd, int CurrentSquadMembers, int MaximumSquadMembers)
        {
            return (CurrentSquadMembers + NumberOfSquadToAdd) > MaximumSquadMembers;
        }

        public static bool WillSquadBeTooSmall(this int NumberOfSquadToRemove, int CurrentSquadMembers, int MinumumSquadMembers)
        {
            return (CurrentSquadMembers - NumberOfSquadToRemove) > MinumumSquadMembers;
        }
    }
}
