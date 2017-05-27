using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using yahtzee.Scoring;

namespace yahtzee.UserControls
{
    /// <summary>
    /// Interaction logic for ScoringHandView.xaml
    /// </summary>
    public partial class ScoringHandView : UserControl
    {
        public ScoringHandView()
        {
            InitializeComponent();
        }

        private void lockClick_Click(object sender, RoutedEventArgs e)
        {
            ScoringHands hand = DataContext as ScoringHands;

            if (hand != null)
            {
                hand.Locked = true;

                hand.LockedScore = hand.Score;
            }
        }
    }
}
