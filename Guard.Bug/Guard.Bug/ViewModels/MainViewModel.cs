using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;

namespace Guard.Bug.ViewModels
{
    public class MainViewModel : Screen
    {
        public MainViewModel()
        {
            ActionMessage.EnforceGuardsDuringInvocation = true;
        }

        private int count = 1;
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                NotifyOfPropertyChange(() => Count);
            }
        }

        public void CountUp(int i)
        {
            Count += i;
        }

        public bool CanCountUp(int i)
        {
            if (i > 10)
                return false;

            if (Count < 10)
                return true;
            else
                return false;
        }

    }
}
