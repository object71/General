using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using yahtzee.Scoring;

namespace yahtzee
{
    public class Player : INotifyPropertyChanged
    {
        // fields
        private string name = "null";
        private int currentScore = 0;

        // properties
        public string Name
        {
            get { return name; }
            set
            {
                name = value;

                PropertyChanged.Raise(this, "Name");
            }
        }

        public int CurrentScore
        {
            get { return currentScore; }
            set
            {
                currentScore = value;

                PropertyChanged.Raise(this, "CurrentScore");
            }
        }

        public Hand CurrentHand { get; set; }

        private bool isActive = false;
        public bool IsActive 
        {
            get { return isActive; }
            set
            {
                if (value)
                {
                    // if this player is active, make all the other players inactive

                    // => indicates LINQ ... look it up
                    if (MainWindow.Singleton.CurrentGame != null) MainWindow.Singleton.CurrentGame.Players.ForEach(p => { if (p != this && p.IsActive) { p.IsActive = false; } });

                //    MainWindow.Singleton.CurrentGame.Players.Any(p => p.IsActive);

                    // give the active player a new hand
                    CurrentHand.Reset();


                }

                isActive = value;
            }
        }

        public List<ScoringHands> LowerScores { get; set; }
        public List<ScoringHands> UpperScores { get; set; }



        // constructors
        public Player() : this("") { }

        public Player(string name)
        {
            Name = name;

            CurrentHand = new Hand();
        }


        // methods
        public Player Next()
        {
            // get the index of the current player
            int index = MainWindow.Singleton.CurrentGame.Players.IndexOf(MainWindow.Singleton.CurrentGame.ActivePlayer);

            // increment this by one to get the next player
            index++;

            // but if this is greater than the number of players, go back to zero
            if (index > MainWindow.Singleton.CurrentGame.NumPlayers - 1) index = 0;

            // return the next player
            return MainWindow.Singleton.CurrentGame.Players[index];
        }

        public void InitializeIntoGame(Game g)
        {
            // create list of all scoring hands in order
            UpperScores = new List<ScoringHands>();
            LowerScores = new List<ScoringHands>();
            
            ScoringHands[] upperHands = {
                                                 new TopHalfScoringHands(1, "Ones"),
                                                 new TopHalfScoringHands(2, "Twos"),
                                                 new TopHalfScoringHands(3, "Threes"),
                                                 new TopHalfScoringHands(4, "Fours"),
                                                 new TopHalfScoringHands(5, "Fives"),
                                                 new TopHalfScoringHands(6, "Sixes"),
                                                 new UpperBonus()
                                             };
            ScoringHands[] lowerHands = {
                                                 new ThreeOfAKind(),
                                                 new FourOfAKind(),
                                                 new FullHouse(),
                                                 new SmallStraight(),
                                                 new LargeStraight(),
                                                 new Yahtzee(),
                                                 new Chance()
                                             };

            UpperScores.AddRange(upperHands);
            LowerScores.AddRange(lowerHands);


            UpperScores.ForEach(score =>
            {
                score.AssociatedPlayer = this;
                score.PropertyChanged += ((sender, args) => {
                    if (args.PropertyName == "LockedScore")
                    {
                        CurrentScore += ((ScoringHands)sender).LockedScore;
                    }
                });
            });
            LowerScores.ForEach(score =>
            {
                score.AssociatedPlayer = this;
                score.PropertyChanged += ((sender, args) => {
                    if (args.PropertyName == "LockedScore")
                    {
                        CurrentScore += ((ScoringHands)sender).LockedScore;
                    }
                });
            });
        }

        public void CheckScores()
        {
            CurrentHand.CheckScores(CurrentHand, UpperScores, LowerScores);
        }

        public void LockScores(List<ScoringHands> upperScoring, List<ScoringHands> lowerScoring)
        {
            foreach (ScoringHands s in upperScoring)
            {
                if (s.Locked)
                    s.LockedScore = s.Score;
            }
            foreach (ScoringHands s in lowerScoring)
            {
                if (s.Locked)
                    s.LockedScore = s.Score;
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
    }
}
