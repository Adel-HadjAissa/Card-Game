using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    //enum for the status of the computer
    public enum Status
    {
        Waiting,
        Playing,
        Lost,
        Won,
    }

    public sealed class Computer : Player
    {
        //property for the status of the computer
        public Status status;

        //constructor for the name of the computer
        public Computer(string NewName) : base(NewName)
        {
        }
            

    }

    
}
