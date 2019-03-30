﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlatmateFinders.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PricingPage : ContentPage
	{
		public PricingPage ()
		{
			InitializeComponent ();
		}


        // Back to Previous Page Event
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //Navigation.PopModalAsync(true);
            await FFNavigation.PopAsync(Parent, Navigation, TransitionType.SlideFromBottom);
        }
    }
}