using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public abstract class Straights : ScoringHands
    {
        // methods
        public bool IsConsecutive(Hand hand, int numDistinct)
        {
            bool valid = false;
            List<int> allPips = hand.Dice.Select(d => d.Pips).OrderBy(d => d).Distinct().ToList();
            int checkDistinct = allPips.Count;
            bool sequenceCheck = allPips.SequenceEqual(Enumerable.Range(allPips[0], allPips.Count));
            if (checkDistinct >= numDistinct & sequenceCheck)
                valid = true;
            return valid;

        }

    }
}
