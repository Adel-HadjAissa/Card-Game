using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DLL.Player;

namespace DLL
{
    [Serializable]
    public class Player
    {
        //properties for the playerclass
        public string name { get; private set; } = "";
        public byte avatar { get; private set; } = 0;
        public byte HP { get; set; } = 0;
        public int wins { get; set; }
        public int losses { get; set; }
        public int draws { get; set; }
        public double TotalPoints { get; set; }

     
     

        public Player(string myname = "",byte myavatar = 0)
        {
            //setting the Player constructor
            this.name = myname;
            this.avatar = myavatar;

        }

       
    }
    
}
