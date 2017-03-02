using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HDF.ViewModels
{
    public class InscriptionPageViewModel : ContentPage
    {
        public InscriptionPageViewModel()
        {
            Title = "Inscription";
            Content = new StackLayout
            {
                Children = {
					new Label {
						Text = "inscription data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
            };
        }
    }
}
