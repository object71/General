using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee.Scoring
{
    public class TopHalfScoringHands : ScoringHands
    {
        // fields



        // properties
        public int BasePip { get; set; }

        // constructors
        public TopHalfScoringHands(int basePip) : this(basePip, basePip.ToString()) { }

        public TopHalfScoringHands(int basePip, string name)
        {
            BasePip = basePip;

            Name = name;

        }


        // methods
        public override bool ValidCheck(Hand hand)
        {
            bool valid = false;
            valid = hand.Dice.Any(item => item.Pips == BasePip);
            return valid;
        }

        public override int CalcScore(Hand hand)
        {
            int score = 0;

            foreach (Die element in hand.Dice)
            {
                if (element.Pips == BasePip)
                {
                    score += element.Pips;
                }
            }
            return score;
        }
        

    }
}
