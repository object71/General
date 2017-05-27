using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using yahtzee.Scoring;

namespace yahtzee
{
    public class Game : INotifyPropertyChanged
    {
        // fields

        private List<Player> players = new List<Player>();
        // properties
        public List<Player> Players 
        {
            get { return players; }
            set
            {
                players = value;

                PropertyChanged.Raise(this, "Players");
            }
        }

        public int NumPlayers { get { return Players.Count; } }

        public Player ActivePlayer 
        {
            get { return MainWindow.Singleton.CurrentGame.Players.First(p => p.IsActive); }
            set
            {
                Player p = value;

                PropertyChanged.Raise(this, "ActivePlayer");
            }
        }

        // constructors
        public Game() { }

        public Game(List<Player> players)
        {
            Players = players;

            // make the first player active
            Players[0].IsActive = true;

            

            // initialize players into game
            Players.ForEach(p => p.InitializeIntoGame(this));
        }

        // methods
        public void NewTurn()
        {
            Player next = MainWindow.Singleton.CurrentGame.ActivePlayer.Next();
            // make the next player active
            next.IsActive = true;

            // change active player
            MainWindow.Singleton.CurrentGame.ActivePlayer = next;

            // give a new hand
            MainWindow.Singleton.CurrentGame.ActivePlayer.CurrentHand.Reset();
        }

        // static methods
        static public Game NewDefaultGame()
        {
            List<Player> players = new List<Player>(2) { new Player("Oli"), new Player("Nick") };

            // start a new game with these players
            return new Game(players);
        }

        public Player CheckWinner()
        {
            bool gameIsOver = true;

            foreach(Player player in Players)
            {
                if(player.UpperScores.Any(x => !x.Locked) && player.LowerScores.Any(x => !x.Locked))
                {
                    gameIsOver = false;
                }
            }

            if(gameIsOver)
            {
                return Players.OrderBy(x => x.CurrentScore).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
