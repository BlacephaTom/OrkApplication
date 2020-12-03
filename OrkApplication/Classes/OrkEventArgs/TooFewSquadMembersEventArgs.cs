using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkApplication.Classes.OrkEventArgs
{
    public class TooFewSquadMembersEventArgs : EventArgs
    {
        public string Message { get; set; }

        public TooFewSquadMembersEventArgs(string message)
        {
            Message = message;
        }

    }
}
