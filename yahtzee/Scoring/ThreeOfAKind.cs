using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class ThreeOfAKind : Repeats
    {
        // constructors
        public ThreeOfAKind() 
        {
            Name = "3 of a kind";
        }

        // methods
        public override bool ValidCheck(Hand hand)
        {
            bool checkRepeat = RepeatCheck(hand, 3);
            return checkRepeat;
        }

        public override int CalcScore(Hand hand)
        {
            int score = 0;
            score = hand.Dice.Select(d => d.Pips).Sum();
            return score;
        }









    }
}
