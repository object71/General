using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class FullHouse : Repeats
    {
        // constructors
        public FullHouse()
        {
            Name = "Full House";
        }

        // methods
        public override bool ValidCheck(Hand hand)
        {
            bool valid = false;
            if (RepeatCheck(hand, 3) & !RepeatCheck(hand, 4))
            {
                List<int> allPips = hand.Dice.Select(d => d.Pips).OrderBy(d => d).Distinct().ToList();
                int checkDistinct = allPips.Count;
                valid = (checkDistinct == 2);
            }
            return valid;
        }

        public override int CalcScore(Hand hand)
        {
            int score = 25;
            return score;
        }

    }
}
