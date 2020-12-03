﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrkApplication.Classes.OrkEventArgs;

namespace OrkApplication.Classes.SquadClasses
{
    public class BaseSquadClass
    {
        public delegate void TooManySquadMembers(object sender, TooManySquadMembersEventArgs e);
        public TooManySquadMembers delTooManySquadMembers;

        public delegate void TooFewSquadMembers(object sender, TooFewSquadMembersEventArgs e);
        public TooFewSquadMembers delTooFewSquadMembers;

        public int MaximumSquadMembers { get; set; }
        public int CurrentSquadMembers { get; set; }
        public int MinimumSquadMembers { get; set; }

        public virtual void AddSquadMember(int NumberOfSquadToAdd)
        {
            if (NumberOfSquadToAdd.WillSquadBeTooBig(CurrentSquadMembers, MaximumSquadMembers))
            {
                delTooManySquadMembers?.Invoke(this, new TooManySquadMembersEventArgs($"This squad can only have {MaximumSquadMembers} Orks!"));
            }
        }

        public virtual void RemoveSquadMember(int NumberOfSquadToRemove)
        {
            if(CurrentSquadMembers - NumberOfSquadToRemove < 0)
            {
                delTooFewSquadMembers?.Invoke(this, new TooFewSquadMembersEventArgs($"This squad must have at least {MinimumSquadMembers} Orks in it!"));
            }
        }


        public enum SquadLeaders
        {
            Nob,
            Mek,
            Captain
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