using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using yahtzee.Scoring;

namespace yahtzee
{
    public class Hand : INotifyPropertyChanged
    {
        // fields
        static public int NumDie = 5;


        // properties
        
        public Die[] Dice { get; set; }

        public int RollNumber { get; set; }


        // constructors
        public Hand() 
        {
            Dice = new Die[NumDie];

            // construct the Dice
            for (int i = 0; i < NumDie; i++)
            {
                // the die is rolled when instantiated
                Dice[i] = new Die();
                // make each image blank on first load
                Dice[i].Pips = 0;
            }
        }

        // methods
        public void Roll()
        {
            for (int i = 0; i < NumDie; i++)
            {
            // the roll method does not change the value if its kept
            Dice[i].Roll();
            }
            RollNumber++;
        }

        public void Reset()
        {
            // un-keeps all die and rolls them
            foreach (Die d in Dice)
            {
                d.Reset();
            }

            RollNumber = 1;
            
        }

        public void CheckScores(Hand hand, List<ScoringHands> upperScoring, List<ScoringHands> lowerScoring)
        {
            int score = 0;
            foreach (ScoringHands s in upperScoring)
            {
                score = 0;
                if (s.ValidCheck(hand))
                {
                    s.Valid = true;
                    score = s.CalcScore(hand);
                }
                s.Score = score;
            }
            foreach (ScoringHands s in lowerScoring)
            {
                score = 0;
                if (s.ValidCheck(hand))
                {
                    s.Valid = true;
                    score = s.CalcScore(hand);
                }
                s.Score = score;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
