using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class Die : INotifyPropertyChanged
    {
        // fields
        Random rnd = new Random(Guid.NewGuid().GetHashCode());

        // properties
        // value of dice
        private int pips = 1;
        private bool kept = false;
        public int Pips 
        {
            get { return pips; }
            set
            {
                pips = value;

                PropertyChanged.Raise(this, "Pips");
            }
        }

        // is dice locked
        public bool Kept 
        {
            get { return kept; }
            set
            {
                kept = value;

                PropertyChanged.Raise(this, "Kept");
            }
        }


        // constructors
        public Die() 
        {
            Kept = false;
        }

        // methods
        public void Roll()
        {

            if (!Kept)
            {
                Pips = rnd.Next(1, 7);
            }
        }

        public void Reset()
        {
            Pips = 0;
            Kept = false;
        }
        public override string ToString()
        {
            return Pips.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
