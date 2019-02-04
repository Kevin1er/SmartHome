using Autofac;
using SmartHome.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHome.Views
{
	public partial class ConnectionPage : ContentPage
	{
		public ConnectionPage ()
		{
			InitializeComponent ();
            this.BindingContext = (Application.Current as App).Container.Resolve<ConnectionViewModel>();
		}
    }
}