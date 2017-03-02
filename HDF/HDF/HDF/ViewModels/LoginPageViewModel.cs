using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HDF.ViewModels
{
    public class LoginPageViewModel : ContentPage
    {
        public LoginPageViewModel()
        {
            Title = "login";
            Content = new StackLayout
            {
                Children = {
					new Label {
						Text = "login data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
            };
        }
    }
}
