using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Guard.Bug.ViewModels;
using Guard.Bug.Views;
using Xamarin.Forms;

namespace Guard.Bug
{
    public class App : FormsApplication
    {
        private readonly SimpleContainer container;

        public App(SimpleContainer container)
        {
            Initialize();

            this.container = container;

            container.PerRequest<MainViewModel>();

            DisplayRootView<MainView>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }
    }
}
