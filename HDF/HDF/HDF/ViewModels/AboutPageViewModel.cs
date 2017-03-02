using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HDF.ViewModels
{
    public class AboutPageViewModel : ContentPage
    {
        public AboutPageViewModel()
        {
            Title = "A propos de HDF Page";
            Content = new StackLayout
            {
                Children = {
					new Label {
						Text = "Contacts data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
            };
        }
    }
}
