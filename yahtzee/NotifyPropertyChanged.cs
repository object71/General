using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace yahtzee
{
    public static class NotifyPropertyChanged
    {
        public static void Raise(this PropertyChangedEventHandler @obj, INotifyPropertyChanged sender, string propertyName)
        {
            if (@obj != null)
                @obj(sender, new PropertyChangedEventArgs(propertyName));
        }

    }
}
