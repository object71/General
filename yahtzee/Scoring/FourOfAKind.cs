using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class FourOfAKind : Repeats
    {
        // constructors
        public FourOfAKind() 
        {
            Name = "4 of a kind";
            
        }

        // methods
        public override bool ValidCheck(Hand hand)
        {
            bool checkRepeat = RepeatCheck(hand, 4);
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
