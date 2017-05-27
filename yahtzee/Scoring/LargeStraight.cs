using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class LargeStraight : Straights
    {
        // fields
        

        // properties
        

        // constructors
        public LargeStraight() 
        {
            Name = "Lg. Straight";
        }


        // methods
        public override bool ValidCheck(Hand hand)
        {
            bool checkConsecutive = IsConsecutive(hand, 5);
            return checkConsecutive;
        }
        public override int CalcScore(Hand hand)
        {
            int score = 40;
            return score;
        }

    }
}
