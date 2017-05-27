using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class Yahtzee : Repeats
    {
        // fields


        // properties


        // constructors
        public Yahtzee() 
        {
            Name = "YAHTZEE";
        }

        // methods
        public override bool ValidCheck(Hand hand)
        {
            bool checkRepeat = RepeatCheck(hand, 5);
            return checkRepeat;
        }

        public override int CalcScore(Hand hand)
        {
            int score = 50;
            return score;
        }





    }
}
