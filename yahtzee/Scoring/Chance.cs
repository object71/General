using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class Chance : ScoringHands
    {
        public Chance()
        {
            Name = "Chance";
        }
        public override bool ValidCheck(Hand hand)
        {
            return true;
        }
        public override int CalcScore(Hand hand)
        {
            int score = 0;
            score = hand.Dice.Select(d => d.Pips).Sum();
            return score;
        }








    }
}
