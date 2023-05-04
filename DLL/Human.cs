using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
   interface IHuman
    {
        byte NumberOfLives { get;}

        void LoseOneLife();
        bool CheckHumanAlive();
    }

    
    public sealed class Human : Player, IHuman
    {
        //setting the property for the numbers of humans live
        public byte NumberOfLives { get; set; }
        
        //setting constructor for the name and number of lives of the human
        public Human(string newName, byte newNumberOfLives) : base(newName)
        {
            this.NumberOfLives = newNumberOfLives;
        }

        public void LoseOneLife()
        {
            NumberOfLives -= 1;
        }

        //method check if the human is still alive
         public bool CheckHumanAlive()
        {
            if (NumberOfLives > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
